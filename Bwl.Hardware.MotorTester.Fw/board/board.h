#ifndef BOARD_H
#define BOARD_H


#define F_CPU 12000000UL
#define BAUD 9600

#define UART_USB 0
#define UART_EXT 0

#include "../refs-avr/bwl_pins.h"

#include <avr/io.h>
#include <util/delay.h>
#include <avr/wdt.h>
#include <stdlib.h>
#include <string.h>
#include <util/setbaud.h>
#include <avr/interrupt.h>

#define BUTTON_1 D,7
#define BUTTON_2 A,6
#define BUTTON_3 D,5
#define BUTTON_4 D,6

#define KEY_INTERNAL A,7
#define KEY_1 A,0
#define KEY_2 A,1

#define RS485_DIR D,4

#define EXTIO1 A,2
#define EXTIO2 A,3
#define EXTIO3 A,4
#define EXTIO4 A,5
#define EXTIO5 B,4
#define EXTIO6 B,5
#define EXTIO7 B,6
#define EXTIO8 B,7

#define SCL C,0
#define SDA C,1

typedef unsigned char byte;

void rs485_dir(unsigned char state);
void var_delay_ms(int ms);
void var_delay_us(int us);
byte get_button_1();
byte get_button_2();
byte get_button_3();
byte get_button_4();
void power_key_1(unsigned char state);
void power_key_2(unsigned char state);
void power_internal(unsigned char state);

#endif /* BOARD_H_ */