#define DEV_NAME "1.0"

/*BODLEVEL = 2V7
OCDEN = [X]
JTAGEN = [X]
SPIEN = [X]
WDTON = [ ]
EESAVE = [X]
BOOTSZ = 2048W_3800
BOOTRST = [ ]
CKDIV8 = [ ]
CKOUT = [ ]
SUT_CKSEL = FSOSC_258CK_65MS_CRES_SLOWPWR

EXTENDED = 0xFD (valid)
HIGH = 0x11 (valid)
LOW = 0xD6 (valid)
*/

#include "board/board.h"
#include "refs-avr/winstar1602.h"
#include "refs-avr/bwl_strings.h"
#include "refs-avr/pwm.h"
#include "motors.h"
int  state    = 0;
int  dc_speed = 0;
long time_to_stop = 0;
unsigned char servo_state = 50;
int  button_counter = 0;
byte autostep=0;

void button_process()
{
	if(get_button_4())
	{
		pwm_set(0, 0);
		state = 0;
		dc_speed = 0;
		servo_state=50;
	}
	switch(state){
		case 0:
		if(get_button_1())state = 1;
		if(get_button_2())state = 2;
		if(get_button_3())state = 3;
		break;

		case 1:
		if(get_button_2() && dc_speed < 100)dc_speed+=10;
		if(get_button_1() && dc_speed > -100)dc_speed -=10;
		if(dc_speed>0){pwm_set(0, dc_speed); pin_high(G2_DIR); }else{pwm_set(0, (-1)*dc_speed); pin_low(G2_DIR);}
		break;

		case 2:
		if(get_button_2())motor_step(1);
		if(get_button_1())motor_step(0);
		if(get_button_3())
		{
			if (autostep==0){autostep=110;}
			autostep-=10;
		}
		break;

		case 3:
		if(get_button_2() && servo_state<100)servo_state+=5;
		if(get_button_1() && servo_state>0)servo_state-=5;
		servo_set(0, servo_state);
		break;
	}
}

void button_process_filtered()
{
	if(get_button_1()==0 && get_button_2()==0 && get_button_3()==0 && get_button_4()==0)
	{
		button_counter = 0;
	}else
	{
		button_counter++;
	}
	if(button_counter>1000)
	{
		button_counter = 0;
		button_process();
	}
}

void timer1_set(double timerMksec, double freqMHz, byte enable_interrupt)
{
	unsigned int divider=(unsigned int)(1000000.0*freqMHz/timerMksec);
	TCCR1A=(0<<COM1A1)|(0<<COM1A0)|(0<<COM1B1)|(0<<COM1B0)|(0<<WGM11)|(0<<WGM10);
	TCCR1B=(0<<WGM13)|(1<<WGM12)|(0<<CS12)|(0<<CS11)|(1<<CS10);
	OCR1AH=divider>>8;
	OCR1AL=divider&255;
	if (enable_interrupt)
	{
		TIMSK1=(1<<OCIE1A);
	}
}

byte counter=0;
ISR(TIMER1_COMPA_vect)
{
	//button_process();
	servo();
	pwm();
	counter++;
	if ((autostep>0)&&((counter%autostep)==0))
	{
		pin_toggle_out(STEP_CLK);
	}
	//wdt_reset();
}

void show_state()
{
	if(state == 0){
		string_clear();
		string_add_string("1DC 2STP");
		lcd_stringbuffer_to_linebuffer(1);

		string_clear();
		string_add_string("3SERVO");
		lcd_stringbuffer_to_linebuffer(2);
		if(get_button_1())state = 1;
		if(get_button_2())state = 2;

	}
	if(state==1){
		string_clear();
		string_add_string("1-UP 2-DN");
		lcd_stringbuffer_to_linebuffer(1);
		string_clear();
		string_add_int(dc_speed);
		lcd_stringbuffer_to_linebuffer(2);
	}

	if(state == 2){
		string_clear();
		string_add_string("1-FW 2-BW");
		lcd_stringbuffer_to_linebuffer(1);

		string_clear();
		string_add_string("STEP ");
		string_add_int(autostep);
		lcd_stringbuffer_to_linebuffer(2);
	}

	if(state == 3){
		string_clear();
		string_add_string("1-FW 2-BW");
		lcd_stringbuffer_to_linebuffer(1);

		string_clear();
		string_add_int(servo_state);
		lcd_stringbuffer_to_linebuffer(2);

	}
	lcd_writebuffer();
}

void board_init()
{
	power_internal(0);
	var_delay_ms(500);
	power_internal(1);
	get_button_1();
	get_button_2();
	get_button_3();
	get_button_4();
}

int main(void)
{
	cli();
	wdt_enable(WDTO_8S);
	board_init();
	lcd_init();
	show_state();
	timer1_set(20000,12.0,1);
	sei();
	pin_low(SERVO_PWM);
	while(1)
	{
		button_process();
		show_state();
		_delay_ms(100);
		wdt_reset();
	}
}