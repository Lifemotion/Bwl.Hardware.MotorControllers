/*
 * motors.h
 *
 * Created: 02.03.2018 9:41:09
 *  Author: Nikcolay Gusev
 */ 


#ifndef MOTORS_H_
#define MOTORS_H_

#define G2_DIR     A,3
#define G2_PWM     A,5
//#define G2_SLEEP   A,5

#define STEP_RESET C,1
#define STEP_CLK   B,5 
#define STEP_DIR   B,7

#define SERVO_PWM  C,1

void motor_servo_pmw(char pwm_width);
void motor_dc_set_power(int speed);
void motor_step(char dir);

void var_delay_ms(int ms);
#endif 