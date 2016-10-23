#define F_CPU 8000000UL
#define BAUD 9600
#define DEV_NAME "BwlMtrCntTwo-1.0"
#include "libs/bwl_uart.h"
#include "libs/bwl_simplserial.h"

#include <avr/io.h>
#include <avr/wdt.h>
#include <util/delay.h>
#include <util/setbaud.h>
#include <stdlib.h>
#include <string.h>

#define getbit(port, bit)		((port) &   (1 << (bit)))
#define setbit(port,bit,val)	{if ((val)) {(port)|= (1 << (bit));} else {(port) &= ~(1 << (bit));}}

#include "pwm.h"

void var_delay_ms(int ms)
{
	for (int i=0; i<ms; i++)_delay_ms(1.0);
}

void sserial_send_start(unsigned char portindex)
{
	if (portindex==0)
	{
		setbit(DDRC,7,1);
		setbit(PORTC,7,1);
	}else
	{
		setbit(DDRD,4,1);
		setbit(PORTD,4,1);		
	}
}

void sserial_send_end(unsigned char portindex)
{
	if (portindex==0)
	{
		setbit(DDRC,7,1);
		setbit(PORTC,7,0);
	}else
	{
		setbit(DDRD,4,1);
		setbit(PORTD,4,0);
	}	
}

void sserial_process_request(unsigned char portindex)
{
	if (sserial_request.command==77)
	{
		for (byte i=0; i<sserial_request.datalength-1; i+=3)
		{
			byte type=sserial_request.data[i];
			byte channel=sserial_request.data[i+1];
			byte value=sserial_request.data[i+2];
			if (type==10){pwm_set(channel,value);}
			if (type==20){servo_set(channel,value);}
		}
	}
}

void servo_set_out(byte channel, byte state)
{
	DDRB=255;
	switch (channel)
	{
		case 0:	setbit (PORTB,0,state);break;
		case 1:	setbit (PORTB,1,state);break;
		case 2:	setbit (PORTB,2,state);break;
		case 3:	setbit (PORTB,3,state);break;
		case 4:	setbit (PORTB,4,state);break;
		case 5:	setbit (PORTB,5,state);break;
		case 6:	setbit (PORTB,6,state);break;
		case 7:	setbit (PORTB,7,state);break;
	}
}


void pwm_set_out(byte channel, byte state)
{
	setbit(DDRD,5,1);setbit(PORTD,5,1);
	setbit(DDRD,6,1);
	setbit(DDRD,7,1);
	switch (channel)
	{
		case 0:	setbit (PORTD,7,state);break;		//DIR
		case 1:	setbit (PORTD,6,state);break;		//PWM
	}
}


int main(void)
{
	wdt_enable(WDTO_8S);
	sserial_find_bootloader();
	sserial_set_devname(DEV_NAME);
	sserial_append_devname(15,12,__DATE__);
	sserial_append_devname(27,8,__TIME__);
	
	uart_init_withdivider(0,UBRR_VALUE);
	uart_init_withdivider(1,UBRR_VALUE);
	
	//servo_set(0,100);
	
    while (1) 
    {
		pwm();
		servo();
		sserial_poll_uart(0);
		wdt_reset();
	//	sserial_poll_uart(1);
    }
}

