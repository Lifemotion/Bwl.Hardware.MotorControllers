/*
 * Bwl.Hardware.MotorControllerDC.Fw
 *
 * Created: 28.02.2018
 * Author : Nickolay Gusev
 */ 

#include "board/board.h"
#include "libs/bwl_simplserial.h"
#include "libs/bwl_uart.h"

void sserial_process_request()
{
	if (sserial_request.command==1)
	{
		unsigned int adc = adc_get();
		sserial_response.data[0] = adc >> 8;
		sserial_response.data[1] = adc & 0xFF;
		sserial_response.data[3] = get_motor_state();
		sserial_response.data[4] = get_sesnor_state(LIMIT_SWITCH_ONE);
		sserial_response.data[5] = get_sesnor_state(LIMIT_SWITCH_TWO);
		sserial_response.data[6] = get_sesnor_state(MOTOR_FAULT);
		sserial_response.datalength = 7;
		sserial_send_response();
	}

	if (sserial_request.command==2)
	{
		motor_set_state(sserial_request.data[0]);
		sserial_response.datalength = 0;
		sserial_send_response();
	}
}


int main(void)
{	
	board_init();
    while (1) 
    {
		sserial_poll_uart(0);
		wdt_reset();
    }
}

