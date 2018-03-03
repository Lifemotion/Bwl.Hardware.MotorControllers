#include "board.h"

void rs485_dir(unsigned char state)
{
	pin_set_dir(RS485_DIR,1); pin_set_out(RS485_DIR,state);
}

void var_delay_ms(int ms)
{
	for (int i=0; i<ms; i++)_delay_ms(1.0);
}

void var_delay_us(int us)
{
	for (int i=0; i<(us/50); i++)_delay_us(50);
}

byte get_button_1()
{
	pin_input_pullup(BUTTON_1);
	return pin_get_in(BUTTON_1)==0;
}

byte get_button_2()
{
	pin_input_pullup(BUTTON_2);
	return pin_get_in(BUTTON_2)==0;
}

byte get_button_3()
{
	pin_input_pullup(BUTTON_3);
	return pin_get_in(BUTTON_3)==0;
}

byte get_button_4()
{
	pin_input_pullup(BUTTON_4);
	return pin_get_in(BUTTON_4)==0;
}

void power_key_1(unsigned char state)
{
	pin_set_dir(KEY_1,1); pin_set_out(KEY_1,state);
}

void power_key_2(unsigned char state)
{
	pin_set_dir(KEY_2,1); pin_set_out(KEY_2,state);
}

void power_internal(unsigned char state)
{
	pin_set_dir(KEY_INTERNAL,1); pin_set_out(KEY_INTERNAL,state);
	if (state==0)
	{
		DDRA=0; DDRB=0; DDRC=0; DDRD=0;
		PORTA=0; PORTB=0; PORTC=0; PORTD=0;
	}
}

