/*
 * motors.c
 *
 * Created: 02.03.2018 9:38:55
 *  Author: Nikcolay Gusev
 */ 
#include "board/board.h"
#include "motors.h"
#include "refs-avr/bwl_pins.h"
#include "refs-avr/pwm.h"

void motor_step(char dir)
{
	pin_high(STEP_RESET);
	if(dir){
		pin_high(STEP_DIR);
	}else{
		pin_low(STEP_DIR);
	}
	for(int i=0;i<10;i++){
		pin_high(STEP_CLK);
		var_delay_ms(1);
		pin_low(STEP_CLK);
		var_delay_ms(1);
	}
}

void servo_set_out(byte channel, byte state)
{
	//pin_set_dir(SERVO_PWM, 1);
	switch(channel)
	{
		case 0:	 pin_set_out(SERVO_PWM, state); break;																																																																																																						
	}
}

void pwm_set_out(byte channel, byte state)
{
	switch (channel)
	{
		case 0:	pin_set_out(G2_PWM, state); break;		//PWM
	}
}

