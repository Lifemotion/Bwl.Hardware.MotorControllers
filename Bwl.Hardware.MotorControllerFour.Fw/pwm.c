#include "pwm.h"

#include <avr/io.h>
#include <stdint.h>

uint8_t pwm_counter=PWM_TOP;
uint8_t pwm_values[PWM_CHANNELS]={0};
uint8_t pwm_next_values[PWM_CHANNELS]={0};

uint16_t servo_counter=SERVO_TOP;
uint16_t servo_values[SERVO_CHANNELS]={0};
uint16_t servo_next_values[SERVO_CHANNELS]={0};

void pwm_set(byte channel, byte value)
{
	float val=(float) value/100.0 * (float)(PWM_TOP+1);
	if (channel<PWM_CHANNELS) {pwm_next_values[channel]=(byte)val;}
}

void servo_set(byte channel, byte value)
{
	float val=(float) value/100.0 * (float)(SERVO_END-SERVO_START)+SERVO_START;
	if (channel<SERVO_CHANNELS) 
	{
		servo_next_values[channel]=(uint16_t)val;
		if (value==255) servo_next_values[channel]=0;
	}
}

void servo_disable(byte channel)
{
	if (channel<SERVO_CHANNELS)
	{
		servo_next_values[channel]=0;
	}
}

void pwm()
{
	if (pwm_counter>=PWM_TOP)
	{
		pwm_counter=0;
		for (byte i=0; i<PWM_CHANNELS; i++)
		{
			pwm_values[i]=pwm_next_values[i];
			if (pwm_values[i]>0)			pwm_set_out(i,1);
		}
	}
	
	for (byte i=0; i<PWM_CHANNELS; i++)
	{
		if ((pwm_values[i]==pwm_counter)&&(pwm_values[i]>0))		pwm_set_out(i,0);
	}
	pwm_counter++;
}

void servo()
{
	if (servo_counter>=SERVO_TOP)
	{
		servo_counter=0;
		for (byte i=0; i<SERVO_CHANNELS; i++)
		{
			servo_values[i]=servo_next_values[i];
			if (servo_values[i]>0)				servo_set_out(i,1);
		}
	}
	
	for (byte i=0; i<SERVO_CHANNELS; i++)
	{
		if ((servo_values[i]==servo_counter)&&(servo_values[i]>0))		servo_set_out(i,0);
	}
	servo_counter++;
}
