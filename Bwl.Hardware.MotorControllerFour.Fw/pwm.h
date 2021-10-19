#ifndef PWM_H_
#define PWM_H_

#define PWM_CHANNELS 4
#define PWM_TOP 50

#define SERVO_CHANNELS 4
#define SERVO_TOP	 400

#define SERVO_START	 SERVO_TOP*0.050
#define SERVO_END	 SERVO_TOP*0.100

typedef unsigned char byte;

//must be defined
void servo_set_out(byte channel, byte state);
void pwm_set_out(byte channel, byte state);

//can net used
void pwm_set(byte channel, byte value);
void servo_set(byte channel, byte value);
void servo_disable(byte channel);
void pwm();
void servo();

#endif /* PWM_H_ */