#include "board.h"
#include "../libs/bwl_simplserial.h"

void adc_init()
{
	ADMUXA = 0x00;
	ADMUXB = 0;
	ADCSRA |= (1<<ADEN)|(1<<ADPS1);
}

unsigned int adc_get()
{
	ADCSRA |= 1<<ADSC;
	while(ADCSRA&(1<<ADSC));
	return ADCL + ADCH*256;
}

void gpio_init()
{
	DDRA &= ~((1<<DDRA1)|(1<<DDRA2)|(1<<DDRA4));//Sensor
	PUEA |= ((1<<PORTA1)|(1<<PORTA2));
	DDRA |= ((1<<DDRA5)|(1<<DDRA6));
}

void motor_set_state(unsigned char state)
{
	PORTA &= ~((1<<PORTA5)|(1<<PORTA6)); 
	if(state <  128) PORTA |= (1<<PORTA5); 
	if(state >  128) PORTA |= (1<<PORTA6);
}

unsigned char get_motor_state()
{
	if((PORTA & ((1<<PORTA5)|(1<<PORTA6))) == 0) return 128;
	if((PORTA & ((1<<PORTA5))) == 0) return 100;
	return 200;
}

void sserial_send_end()
{
	DDRA|=(1<<DDRA3); PORTA&= ~(1<<PORTA3);
}

void var_delay_ms(int ms)
{
	for (int i=0; i<ms; i++)_delay_ms(1.0);
}

void sserial_send_start()
{
	DDRA|=(1<<DDRA3); PORTA|=(1<<PORTA3);
}

unsigned char get_sesnor_state(unsigned char sw)
{
	if(sw == LIMIT_SWITCH_ONE) return PINA & (1<<PINA1);
	if(sw == LIMIT_SWITCH_TWO) return PINA & (1<<PINA2);
	if(sw == MOTOR_FAULT) return PINA & (1<<PINA3);
	return 0;
}
void board_init()
{
	wdt_enable(WDTO_8S);
	uart_init_withdivider(0, UBRR_VALUE);
	sserial_set_devname(DEVNAME);
	REMAP |= (1<<U0MAP);
	adc_init();
	gpio_init();
	motor_set_state(128);
}

