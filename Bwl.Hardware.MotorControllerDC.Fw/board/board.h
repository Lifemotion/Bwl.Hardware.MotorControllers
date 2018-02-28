#ifndef BOARD_H_
#define BOARD_H_

#define F_CPU 16000000
#define BAUD  38400

#include <avr/io.h>
#include <avr/wdt.h>
#include <util/setbaud.h>
#include <util/delay.h>
#include "../libs/bwl_uart.h"

#define LIMIT_SWITCH_ONE 1
#define LIMIT_SWITCH_TWO 2
#define MOTOR_FAULT      3

#define DEVNAME "MotorController.DC v1.0     "

void          board_init();
void		  motor_set_state(unsigned char state);
unsigned char get_motor_state();
unsigned int  adc_get();
unsigned char get_sesnor_state(unsigned char sw);


#endif /* BOARD_H_ */