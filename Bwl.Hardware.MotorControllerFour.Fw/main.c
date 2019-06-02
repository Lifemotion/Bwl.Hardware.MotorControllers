#define F_CPU 12000000UL
#define BAUD 9600
#define DEV_NAME "BwlMtrCntFour-1.0"
#include "libs/bwl_adc.h"
#include "libs/bwl_uart.h"
#include "libs/bwl_simplserial.h"
#include "pwm.h"
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

ISR(TIMER1_COMPA_vect)
{
	if (time_to_stop>0)
	{
		time_to_stop--;
		servo();
		pwm();
	}
}

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
}

void servo_set_out(byte channel, byte state)
{
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
	switch (channel)
	{
		case 1:	setbit (PORTB,0,1);break;
		case 2:	setbit (PORTB,1,1);break;
		case 3:	setbit (PORTB,2,1);break;
		case 4:	setbit (PORTB,3,1);break;
		case 5:	setbit (PORTC,6,1);break;
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
	select_pwm_driver(255);
	timer1_set(20000,12.0,1);
	sei();
    while (1) 
    {
		sserial_poll_uart(0);
		sserial_poll_uart(1);
		wdt_reset();
    }
}

