/*
* Bwl SimplSerial Lib
*
* Author: Igor Koshelev
* Licensed: open-source Apache license
*
* Version: 25.10.2018 V1.7.1
*/

#include "bwl_simplserial.h"
#include <avr/io.h>
#include <avr/boot.h>
#include <avr/pgmspace.h>
#include <avr/interrupt.h>

#define CATUART_ADDITIONAL 8
#define SSERIAL_BUFFER_SIZE CATUART_MAX_PACKET_LENGTH+CATUART_ADDITIONAL
unsigned char sserial_buffer[CATUART_MAX_PACKET_LENGTH+CATUART_ADDITIONAL];
unsigned int sserial_buffer_pointer;
unsigned char sserial_buffer_overflow;
uint16_t sserial_crc16;
byte sserial_bootloader_present=0;
byte sserial_portindex=0;

long sserial_last_two_bytes_devguid()
{
	long shortid=(long)(sserial_devguid[14])*256+(long)(sserial_devguid[15]);
	return shortid;
}

void sserial_append_devname(byte startIndex, byte length, char* newname)
{
	for (int i=0; i<length; i++)
	{
		if (sserial_devname[i]<30){sserial_devname[i]=' ';}
		sserial_devname[i+startIndex]=newname[i];
	}
}


#ifdef __AVR_ATmega2560__
#define PGM_READ_BYTE pgm_read_byte_far
#else
#define PGM_READ_BYTE pgm_read_byte_near
#endif

#ifndef IS_BOOTLOADER
void sserial_find_bootloader()
{
	byte found=0;
	uint32_t pos=FLASHEND-32;
	do
	{
		pos--;
		found=1;
		for (uint32_t i=0; i<7; i++)
		{
			uint32_t p=pos+i;
			if (PGM_READ_BYTE(p)!="BwlBoot"[i]){found=0;i=8;}
		}
	} while ((found==0)&&(pos>FLASHEND-4096));
	
	if (found==1)
	{
		for (byte i=0; i<16; i++)
		{
			sserial_devname[i]=PGM_READ_BYTE(pos+16+i);
			sserial_devguid[i]=PGM_READ_BYTE(pos+32+i);
		}
		for (byte i=0; i<16; i++)
		{
			sserial_bootname[i]=PGM_READ_BYTE(pos+i);
		}
	}
	sserial_bootloader_present=found;
}
#endif

void sserial_set_devname(const char* devname)
{
	for (int i=0; i<32; i++)
	{
		if (sserial_devname[i]<30){sserial_devname[i]=' ';}
		sserial_devname[i]=devname[i];
	}
}

void sserial_sendbyte(byte bt)
{
	uart_send(sserial_portindex,bt);sserial_crc16=_crc16_update(sserial_crc16,bt);
	if (bt==0x98)
	{
		uart_send(sserial_portindex,0);
	}
}

void sserial_send_response ()
{
	sserial_send_start(sserial_portindex);
	uart_send(sserial_portindex,0);
	uart_send(sserial_portindex,0);
	uart_send(sserial_portindex,0x98);
	uart_send(sserial_portindex,0x03);
	sserial_crc16=0xFFFF;
	sserial_sendbyte(sserial_address>>8);
	sserial_sendbyte(sserial_address&255);
	sserial_sendbyte(sserial_response.result);
	for (unsigned int i=0; i< sserial_response.datalength; i++)
	{
		sserial_sendbyte(sserial_response.data[i]);
	}
	uint16_t crc=sserial_crc16;
	sserial_sendbyte(crc>>8);
	sserial_sendbyte(crc&255);
	uart_send(sserial_portindex,0x98);
	uart_send(sserial_portindex,0x04);
	uart_send(sserial_portindex,0);
	uart_send(sserial_portindex,0);
	uart_send(sserial_portindex,0);
	sserial_send_end(sserial_portindex);
}

byte mask(byte current, byte newval ,byte mask)
{
	byte result=current&(~mask);
	result|=(newval&mask);
	return result;
}

char sserial_process_internal()
{
	sserial_response.result=0;
	sserial_response.datalength=0;
	
	//random based find
	if (sserial_request.command==255)
	{
		byte byte1=sserial_request.data[1];
		byte byte2=sserial_request.data[2];
		byte byte3=sserial_request.data[3];
		byte byte4=sserial_request.data[4];
		byte delay1=byte1;
		byte delay2=byte2;
		for (byte i=0; i<16; i++)
		{
			delay1^=sserial_devguid[i];
			delay2^=sserial_devguid[i];
			delay1+=byte3;
			delay2+=byte4;
			sserial_response.data[i]=sserial_devguid[i];
		}
		int total=(((int)delay1)<<4)+(int)delay2;
		var_delay_ms(total>>1);
		sserial_response.result=170;
		sserial_response.datalength=16;
		sserial_send_response();
		return 1;
	}
	//device info
	if (sserial_request.command==254)
	{
		for (byte i=0; i<16; i++)
		{
			sserial_response.data[i]=sserial_devguid[i];
			sserial_response.data[16+i]=sserial_devname[i];
			sserial_response.data[32+i]=sserial_devname[16+i];
		}
		sserial_response.data[48]=__DATE__[4];
		sserial_response.data[48+1]=__DATE__[5];
		sserial_response.data[48+2]=__DATE__[0];
		sserial_response.data[48+3]=__DATE__[2];
		sserial_response.data[48+4]=__DATE__[9];
		sserial_response.data[48+5]=__DATE__[10];
		for (byte i=0; i<16; i++)
		{
			sserial_response.data[54+i]=sserial_bootname[i];
		}
		for (byte i=0; i<6; i++)
		{
			sserial_response.data[70+i]=SSERIAL_VERSION[i];
		}
		
		sserial_response.data[80]=boot_signature_byte_get(0);
		sserial_response.data[81]=boot_signature_byte_get(2);
		sserial_response.data[82]=boot_signature_byte_get(4);
		
		sserial_response.data[83]=boot_lock_fuse_bits_get(0); //low
		sserial_response.data[84]=boot_lock_fuse_bits_get(1); //  lock
		sserial_response.data[85]=boot_lock_fuse_bits_get(2); //ext
		sserial_response.data[86]=boot_lock_fuse_bits_get(3); //high
		
		//read serial
		for (byte i=0; i<8; i++)
		{
			sserial_response.data[87+i]=boot_signature_byte_get(i+0x0E); //serial
		}
		
		sserial_response.datalength=95;
		sserial_send_response();
		return 1;
	}
	//set working address
	if (sserial_request.command==253)
	{
		byte guid_match=1;
		uint16_t new_address=(sserial_request.data[16]<<8)+sserial_request.data[17];
		for (byte i=0; i<16; i++)
		{
			if(sserial_request.data[i]!=sserial_devguid[i]){guid_match=0;}
		}
		
		//if no match, check for 0xAA prefix
		if (guid_match==0)
		{
			guid_match=1;
			for (byte i=0; i<8; i++)
			{
				if(sserial_request.data[i]!=0xAA){guid_match=0;}
			}
			//0xAA prefix found, compare address with hw-sn
			if (guid_match==1)
			{
				for (byte i=0; i<8; i++)
				{
					if(sserial_request.data[i+8]!=boot_signature_byte_get(i+0x0E)){guid_match=0;}
				}
			}
		}
		
		if (guid_match==1)
		{
			sserial_address=new_address;
			sserial_send_response();
		}else
		{
			if (new_address==sserial_address){sserial_address=0;}
		}
		return 1;
	}
	//loopback
	if ((sserial_request.command==252)&&(sserial_request.datalength>0)	)
	{
		sserial_response.datalength=sserial_request.datalength-1;
		sserial_response.result=sserial_request.data[0];
		for (unsigned int i=0; i<sserial_response.datalength; i++)
		{
			sserial_response.data[i]=sserial_request.data[i+1]-1;
		}
		sserial_send_response();
		return 1;
	}
	//goto boot/main or hang
	if ((sserial_request.command==251))
	{
		#if defined(GOTO_PROG) || defined(GOTO_BOOT)
		{
			sserial_send_response();
		}
		#endif
		#ifdef GOTO_PROG
		if (sserial_request.data[0]==1)	{GOTO_PROG}
		#endif
		#ifdef GOTO_BOOT
		#ifndef IS_BOOTLOADER
		if (sserial_request.data[0]==2)	{cli(); GOTO_BOOT}
		#endif
		#endif
		
		if (sserial_request.data[0]==255){cli(); wdt_enable(WDTO_500MS); while(1);}
	}
	//in-out control
	if (sserial_request.command==250)
	{
		if (sserial_request.data[0]==1)
		{
			DDRB=	mask (DDRB ,sserial_request.data[4],sserial_request.data[6]);
			PORTB=	mask (PORTB,sserial_request.data[5],sserial_request.data[6]);
			
			#ifdef DDRC
			DDRC=	mask (DDRC ,sserial_request.data[7],sserial_request.data[9]);
			PORTC=	mask (PORTC,sserial_request.data[8],sserial_request.data[9]);
			#endif
			
			#ifdef DDRD
			DDRD=	mask (DDRD ,sserial_request.data[10],sserial_request.data[12]);
			PORTD=	mask (PORTD ,sserial_request.data[11],sserial_request.data[12]);
			#endif
			
			/*DDRB=	sserial_request.data[4];
			PORTB=	sserial_request.data[5];
			
			DDRC=	sserial_request.data[7];
			PORTC=	sserial_request.data[8];

			DDRD=	sserial_request.data[10];
			PORTD=	sserial_request.data[11];		*/
		}
		if (sserial_request.data[0]==2)
		{
			sserial_response.data[4]=DDRB;
			sserial_response.data[5]=PORTB;
			sserial_response.data[6]=PINB;
			
			#ifdef DDRC
			sserial_response.data[7]=DDRC;
			sserial_response.data[8]=PORTC;
			sserial_response.data[9]=PINC;
			#endif
			
			#ifdef DDRD
			sserial_response.data[10]=DDRD;
			sserial_response.data[11]=PORTD;
			sserial_response.data[12]=PIND;
			#endif
		}
		sserial_response.datalength=16;
		sserial_send_response();
		return 1;
	}
	return 0;
}

char sserial_send_request_wait_response(unsigned char portindex, int wait_ms )
{
	//send request
	//cli();
	sserial_send_start(portindex);
	uart_send(portindex,0);
	uart_send(portindex,0);
	uart_send(portindex,0);
	uart_send(portindex,0x98);
	uart_send(portindex,0x01);
	sserial_crc16=0xFFFF;
	sserial_sendbyte(sserial_request.address_to>>8);
	sserial_sendbyte(sserial_request.address_to&255);
	sserial_sendbyte(sserial_request.command);
	for (unsigned int i=0; i< sserial_request.datalength; i++)
	{
		sserial_sendbyte(sserial_request.data[i]);
	}
	uint16_t crc=sserial_crc16;
	sserial_sendbyte(crc>>8);
	sserial_sendbyte(crc&255);
	uart_send(portindex,0x98);
	uart_send(portindex,0x02);
	uart_send(portindex,0);
	uart_send(portindex,0);
	uart_send(portindex,0);
	sserial_send_end(portindex);
	//wait response
	volatile unsigned long limit=wait_ms*100;
	volatile unsigned long counter=0;

	byte lastbyte=0;
	while ((counter++)<limit)
	{
		if (uart_received(portindex))
		{
			byte currbyte=uart_get(portindex);
			
			if (sserial_buffer_pointer>=SSERIAL_BUFFER_SIZE){sserial_buffer_pointer=SSERIAL_BUFFER_SIZE-1;sserial_buffer_overflow=1;}
			
			if (lastbyte==0x98)
			{
				switch (currbyte)
				{
					case 0x00:
					sserial_buffer[sserial_buffer_pointer++]=0x98;
					break;
					case 0x03:
					sserial_buffer_pointer=0;
					sserial_buffer_overflow=0;
					break;
					case 0x04:
					if ((sserial_buffer_overflow==0)&&(sserial_buffer_pointer>4))
					{
						uint16_t real_crc16=0xFFFF;
						for (unsigned int i=0; i<sserial_buffer_pointer-2; i++)
						{real_crc16=_crc16_update(real_crc16,sserial_buffer[i]);}
						uint16_t recv_crc16=(sserial_buffer[sserial_buffer_pointer-2]<<8)+sserial_buffer[sserial_buffer_pointer-1];
						if (recv_crc16==real_crc16)
						{
							//uint16_t addr=(sserial_buffer[0]<<8)+(sserial_buffer[1]);
							//sserial_response.address_to=addr;
							sserial_response.result=sserial_buffer[2];
							sserial_response.datalength=sserial_buffer_pointer-5;
							for (unsigned int i=3; i<sserial_buffer_pointer-2; i++)
							{
								sserial_response.data[i-3]=sserial_buffer[i];
							}
							//sei();
							return 1;
						}
					}
				}
			}else
			{
				if (currbyte!=0x98)
				sserial_buffer[sserial_buffer_pointer++]=currbyte;
			}
			lastbyte=currbyte;
		}
	}
	//sei();
	return 0;
}

void sserial_poll_uart(unsigned char portindex)
{
	sserial_portindex=portindex;
	sserial_send_end(portindex);
	if (uart_received(sserial_portindex))
	{
		static byte lastbyte;
		byte currbyte=uart_get(sserial_portindex);
		
		if (sserial_buffer_pointer>=SSERIAL_BUFFER_SIZE){sserial_buffer_pointer=SSERIAL_BUFFER_SIZE-1;sserial_buffer_overflow=1;}
		
		if (lastbyte==0x98)
		{
			switch (currbyte)
			{
				case 0x00:
				sserial_buffer[sserial_buffer_pointer++]=0x98;
				break;
				case 0x01:
				sserial_buffer_pointer=0;
				sserial_buffer_overflow=0;
				break;
				
				case 0x02:
				if ((sserial_buffer_overflow==0)&&(sserial_buffer_pointer>4))
				{
					uint16_t real_crc16=0xFFFF;
					for (unsigned int i=0; i<sserial_buffer_pointer-2; i++)
					{real_crc16=_crc16_update(real_crc16,sserial_buffer[i]);}
					
					uint16_t recv_crc16=(sserial_buffer[sserial_buffer_pointer-2]<<8)+sserial_buffer[sserial_buffer_pointer-1];
					if (recv_crc16==real_crc16)
					{
						uint16_t addr=(sserial_buffer[0]<<8)+(sserial_buffer[1]);
						if ((addr==0 )||(addr==sserial_address))
						{
							sserial_request.address_to=addr;
							sserial_request.command=sserial_buffer[2];
							sserial_request.datalength=sserial_buffer_pointer-5;
							for (unsigned int i=3; i<sserial_buffer_pointer-2; i++)
							{
								sserial_request.data[i-3]=sserial_buffer[i];
							}
							if (sserial_process_internal()==0){	sserial_process_request(portindex);}
						}
					}
				}
				
			}
		}else
		{
			if (currbyte!=0x98)
			sserial_buffer[sserial_buffer_pointer++]=currbyte;
		}
		lastbyte=currbyte;
	}
	
}

unsigned char int_to_byte(int val)
{
	if (val>127) {val=127;}
	if (val<-128) {val=-128;}
	val+=128;
	return val;
}

unsigned char int_to_low_byte(int val)
{
	//if (val>32767){val=32767;}
	//if (val<-32768){val=-32768;}
	uint16_t uval=(uint16_t)(val + 32768);
	return (uval&0xFF);
}

unsigned char int_to_high_byte(int val)
{
	//if (val>32767){val=32767;}
	//if (val<-32768){val=-32768;}	
	uint16_t uval=(uint16_t)(val + 32768);
	return (uval>>8);
}
