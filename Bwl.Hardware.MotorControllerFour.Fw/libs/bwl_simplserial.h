/*
* Bwl SimplSerial Lib
*
* Author: Igor Koshelev
* Licensed: open-source Apache license
*
* Version: 25.10.2018 V1.7.1
*/

#ifndef BWL_GAPUART_H_
#define BWL_GAPUART_H_

#include <util/crc16.h>
#include <avr/wdt.h>

typedef unsigned char byte;

byte sserial_devguid[16];
byte sserial_devname[32];
byte sserial_bootname[16];
byte sserial_bootloader_present;
byte sserial_portindex;
uint16_t sserial_address;

#define CATUART_MAX_PACKET_LENGTH 96
#define SSERIAL_VERSION "V1.7.1"

struct
{
	uint16_t		 address_to;
	unsigned	char command;
	unsigned	char data[CATUART_MAX_PACKET_LENGTH];
	unsigned	int datalength;	
} sserial_request;

struct
{
	unsigned	char result;
	unsigned	char data[CATUART_MAX_PACKET_LENGTH];
	unsigned	int datalength;
} sserial_response;

//������ ���� �����������
extern void sserial_send_start(unsigned char portindex);
extern void sserial_send_end(unsigned char portindex);
extern void sserial_process_request(unsigned char portindex);
void uart_send(unsigned char, unsigned char);
unsigned char uart_get( unsigned char );
unsigned char uart_received( unsigned char );
void var_delay_ms(int ms);

//��������
void sserial_poll_uart(unsigned char portindex);
void sserial_send_response();
void sserial_find_bootloader();
void sserial_append_devname(byte startIndex, byte length, char* newname);
void sserial_set_devname(const char* devname);
char sserial_send_request_wait_response(unsigned char portindex, int wait_ms );
long sserial_last_two_bytes_devguid();

unsigned char int_to_byte(int val);
unsigned char int_to_low_byte(int val);
unsigned char int_to_high_byte(int val);


#endif /* BWL_GAPUART_H_ */

#include "bwl_simplserial_ext.h"

