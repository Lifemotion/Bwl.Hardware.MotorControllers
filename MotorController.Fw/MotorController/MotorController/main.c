/*
 * MotorController.c
 *
 * Created: 04.09.2016 16:37:19
 * Author : gus10
 */ 
#define F_CPU 8000000UL
#define BAUD 9600
#include "libs/bwl_uart.h"


#include <avr/io.h>
#include <util/delay.h>
#include <util/setbaud.h>

#define SERVO_PORT PORTB
#define SERVO_DDR DDRB

void port_init()
{
	SERVO_DDR = 0xFF;
	SERVO_PORT = 0x00;

	DDRC |= 0b10000000;

	DDRD |= 0b00010000;
}

void test()
{
    
	char i = 0;
	SERVO_PORT = 0x01;
	_delay_ms(300);
	for(i=0; i<8;i++){
		SERVO_PORT = SERVO_PORT * 2;
		_delay_ms(300);
	}
}

void test_rs485_0(){
	
	if (uart_received(0))
	{
		char ch = uart_get(0);
		if(ch == '1'){
			PORTC &= ~ 0b10000000;
			uart_send(0, 0xFA);
			PORTC |= 0b10000000;
		}else{
			test();
		}
	}	
}

void test_rs485_1(){
	
	if (uart_received(1))
	{
		char ch = uart_get(1);
		if(ch == '1'){
					PORTD &= ~ 0b00010000;
					uart_send(1, 0xFA);
					PORTD |= 0b00010000;
					
		}else{
			test();
		}
	}
}

int main(void)
{
  
	DDRD |= 0b11100000;
	PORTD |= 0b00100000;

	PORTD |= 0b01000000;
    while (1) 
    {
	    int i = 0;
		PORTD |= 0b10000000;
		_delay_ms(3000);
		for(i=0; i<10;i++){
			PORTD ^= 0b01000000;
			_delay_ms(1000);
		}
		PORTD &= ~0b10000000;
		for(i=0; i<10;i++){
			PORTD ^= 0b01000000;
			_delay_ms(1000);
		}
    }
}

