#ifndef PWM_H_
#define PWM_H_

#define PWM_CHANNELS 2
#define PWM_TOP 50

#define SERVO_CHANNELS 8
#define SERVO_TOP	 1000

#define SERVO_START	 SERVO_TOP*0.050
#define SERVO_END	 SERVO_TOP*0.100

uint8_t pwm_counter=PWM_TOP;
uint8_t pwm_values[PWM_CHANNELS]={0};
uint8_t pwm_next_values[PWM_CHANNELS]={0};

uint16_t servo_counter=SERVO_TOP;
uint16_t servo_values[SERVO_CHANNELS]={0};
uint16_t servo_next_values[SERVO_CHANNELS]={0};

void servo_set_out(byte channel, byte state);

void pwm_set_out(byte channel, byte state);


void pwm_set(byte channel, byte value)
{
	float val=(float) value/100.0 * (float)(PWM_TOP+1);
	if (channel<PWM_CHANNELS) {pwm_next_values[channel]=(byte)val;}
}

void servo_set(byte channel, byte value)
{
	float val=(float) value/100.0 * (float)(SERVO_END-SERVO_START)+SERVO_START;
	if (channel<PWM_CHANNELS) {servo_next_values[channel]=(uint16_t)val;}
}

void pwm()
{
	if (pwm_counter>=PWM_TOP)
	{
		pwm_counter=0;
		for (byte i=0; i<PWM_CHANNELS; i++)
		{
			pwm_values[i]=pwm_next_values[i];
			if (pwm_values[i]>0)
			{
				pwm_set_out(i,1);
			}else
			{
				pwm_set_out(i,0);
			}
		}
	}
	
	for (byte i=0; i<PWM_CHANNELS; i++)
	{
		if (pwm_values[i]==pwm_counter)		pwm_set_out(i,0);
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
			servo_set_out(i,1);
		}
	}
	
	for (byte i=0; i<SERVO_CHANNELS; i++)
	{
		if (servo_values[i]==servo_counter)		servo_set_out(i,0);
	}
	servo_counter++;
}



#endif /* PWM_H_ */