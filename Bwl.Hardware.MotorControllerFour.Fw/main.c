#define F_CPU 12000000UL
#define BAUD 9600
#define DEV_NAME "BwlMtrCntFour-1.2"
#include "libs/bwl_adc.h"
#include "libs/bwl_pins.h"
#include "libs/bwl_uart.h"
#include "libs/bwl_simplserial.h"
#include "libs/bwl_dht22.h"
#include "libs/bwl_ds18b20.h"
#include "pwm.h"
#include "sensors.h"
#define ADC_DEFAULTS ADC_ADJUST_RIGHT, ADC_REFS_INTERNAL_2_56, ADC_PRESCALER_128

#include <avr/io.h>
#include <avr/wdt.h>
#include <util/delay.h>
#include <util/setbaud.h>
#include <stdlib.h>
#include <string.h>
#include <avr/interrupt.h>

#define getbit(port, bit)		((port) &   (1 << (bit)))
#define setbit(port,bit,val)	{if ((val)) {(port)|= (1 << (bit));} else {(port) &= ~(1 << (bit));}}
	
long time_to_stop=0;
#define TIME_TO_STOP 1

void servo_disable1(char sensorchannel)
{
	switch (sensorchannel)
	{
		case 1:			servo_disable(0);		break;
		case 2:			servo_disable(1);		break;
		case 3:			servo_disable(2);		break;
		case 4:			servo_disable(3);		break;
	}
}

void timer1_set(double timerMksec, double freqMHz, byte enable_interrupt)
{
	unsigned int divider=(unsigned int)(1000000.0*freqMHz/timerMksec);
	TCCR1A=(0<<COM1A1)|(0<<COM1A0)|(0<<COM1B1)|(0<<COM1B0)|(0<<WGM11)|(0<<WGM10);
	TCCR1B=(0<<WGM13)|(1<<WGM12)|(0<<CS12)|(0<<CS11)|(1<<CS10);
	OCR1AH=divider>>8;
	OCR1AL=divider&255;
	if (enable_interrupt)	
	{
		TIMSK1=(1<<OCIE1A);
	}
}

byte timer_state=0;

ISR(TIMER1_COMPA_vect)
{
	if ((timer_state++) == 2) {timer_state=0;}
	if (timer_state==0)
	{
		servo();
	}
	pwm();
	
	if (time_to_stop>0)
	{
		time_to_stop--;
		
		/*if (time_to_stop==0)
		{
				for (byte i=0; i<255; i++)
				{
					pwm_set_out(i,0);
					servo_set_out(i,0);
					pwm_set(i,0);
					servo_set(i,0);
				}
		}*/
	}
}

void ds18b20_delay_2us()	{_delay_us(2);}
void ds18b20_delay_60us()	{_delay_us(60);}
void ds18b20_delay_750ms()	{_delay_ms(750);}

void dht22_delay_2us()		{_delay_us(2);}
void dht22_delay_1100us()	{_delay_us(1100);}
	
void var_delay_ms(int ms)
{
	for (int i=0; i<ms; i++)_delay_ms(1.0);
}

void sserial_send_start(unsigned char portindex){}

void sserial_send_end(unsigned char portindex){}
	
void select_pwm_driver(byte channel);

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
			if (type==30){select_pwm_driver(channel);}
		}
		time_to_stop=TIME_TO_STOP*20000;
	}
	if (sserial_request.command==88)
	{
		adc_init(ADC_MUX_ADC7,ADC_DEFAULTS);
		int voltage_adc=adc_read_average(4)*27.1;
		adc_init(ADC_MUX_ADC6,ADC_DEFAULTS);
		int current_adc=adc_read_average(32)*2.4;
		sserial_response.result=sserial_request.command+128;
		sserial_response.data[0]=voltage_adc>>8;
		sserial_response.data[1]=voltage_adc&0xFF;
		sserial_response.data[2]=current_adc>>8;
		sserial_response.data[3]=current_adc&0xFF;		
		sserial_response.datalength=4;
		sserial_send_response();
	}
	if (sserial_request.command==99)
	{
		byte adc_chan=sserial_request.data[0];
		byte adc_avg=sserial_request.data[1];
		adc_init(adc_chan,ADC_DEFAULTS);
		int val=adc_read_average(adc_avg)*2.4;
		sserial_response.result=sserial_request.command+128;
		sserial_response.data[0]=val>>8;
		sserial_response.data[1]=val&0xFF;
		sserial_response.datalength=2;
		sserial_send_response();
	}
	if (sserial_request.command==111)
	{
		byte sensortype=sserial_request.data[0];
		byte sensorchannel=sserial_request.data[1];
		int val1=0;
		int val2=0;
		servo_disable1(sensorchannel);
		cli();
		if (sensortype==1) {val1=ds18b20_get_temperature_fixed_async(sensorchannel);}
		if (sensortype==2) {dht22_read_fixed(sensorchannel,&val1,&val2);}
		sei();
		sserial_response.result=sserial_request.command+128;
		sserial_response.data[1]=val1>>8;
		sserial_response.data[0]=val1&0xFF;
		sserial_response.data[3]=val2>>8;
		sserial_response.data[2]=val2&0xFF;
		sserial_response.datalength=4;
		sserial_send_response();
	}
}

void servo_set_out(byte channel, byte state)
{
	return;
	setbit(DDRA,0,1);
	setbit(DDRA,1,1);
	setbit(DDRA,2,1);
	setbit(DDRA,3,1);
	switch (channel)
	{
		case 0:	setbit (PORTA,0,state);break;
		case 1:	setbit (PORTA,1,state);break;
		case 2:	setbit (PORTA,2,state);break;
		case 3:	setbit (PORTA,3,state);break;
	}
}

void pwm_set_out(byte channel, byte state)
{
	setbit(DDRD,4,1);
	setbit(DDRD,5,1);
	setbit(DDRD,6,1);
	setbit(DDRD,7,1);
	switch (channel)
	{
		case 0:	setbit (PORTD,4,state);break;		
		case 1:	setbit (PORTD,5,state);break;
		case 2:	setbit (PORTD,6,state);break;
		case 3:	setbit (PORTD,7,state);break;	
	}
}

void select_pwm_driver(byte channel)
{
	setbit(DDRB,0,1);
	setbit(DDRB,1,1);
	setbit(DDRB,2,1);
	setbit(DDRB,3,1);
	setbit(DDRC,6,1);
	
	setbit(PORTB,0,0);
	setbit(PORTB,1,0);
	setbit(PORTB,2,0);
	setbit(PORTB,3,0);
	setbit(PORTC,6,0);	
	
	if (channel & 1)  {setbit (PORTB,0,1);}
	if (channel & 2)  {setbit (PORTB,1,1);}
	if (channel & 4)  {setbit (PORTB,2,1);}
	if (channel & 8)  {setbit (PORTB,3,1);}
	if (channel & 16) {setbit (PORTC,6,1);}
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
	select_pwm_driver(0);
	timer1_set(10000,12.0,1);
	sei();
    while (1) 
    {
		sserial_poll_uart(0);
		sserial_poll_uart(1);
		wdt_reset();
    }
}

