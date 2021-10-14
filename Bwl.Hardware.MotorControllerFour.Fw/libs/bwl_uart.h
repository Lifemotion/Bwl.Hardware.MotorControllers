/*
 * Bwl UART lib for AVR: mega48/88/168/328
 *
 * Author: Igor Koshelev and others
 * Licensed: open-source Apache license
 *
 * Version: 25.10.2017
 */ 

#ifndef BWL_UART_H_
#define BWL_UART_H_

void uart_init_withdivider_x2(unsigned char port, unsigned int ubrr);
void uart_init_withdivider(unsigned char port,unsigned int ubrr);
void uart_send(const unsigned char port, const unsigned char byte );
unsigned char uart_get(const unsigned char port );
unsigned char uart_received(const unsigned char port );
void uart_send_string(unsigned char port,char *string);
void uart_send_value(unsigned char port,char* caption, int parameter);
void uart_disable(unsigned char port);

void uart_send_line(unsigned char port,char *string);
void uart_send_int(unsigned char port,int val);
void uart_send_float(unsigned char port,float val, char precision);

#define GET_UBRR(fcpu, baudrate)		(((fcpu) + 8UL * (baudrate)) / (16UL * (baudrate)) -1UL)
#define GET_UBRR_X2(fcpu, baudrate)		(((fcpu) + 4UL * (baudrate)) / (8UL * (baudrate)) -1UL)

/*
//Example:

#define F_CPU           8000000
#define RS485_PORT 0

#include <avr/io.h>
#include "bwl_uart.h"

void main()
{
	uart_init_withdivider_x2(RS485_PORT, GET_UBRR_X2(F_CPU,38400));
	uart_send_line(RS485_PORT,"Hello world");
}

*/

#endif /* BWL_UART_H_ */
