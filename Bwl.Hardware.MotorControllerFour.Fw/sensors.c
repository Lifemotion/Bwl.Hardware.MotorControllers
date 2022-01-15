#include "sensors.h"

#define AUX1 A,0
#define AUX2 A,1
#define AUX3 A,2
#define AUX4 A,3

#define AUX5 A,4
#define AUX6 A,5
#define AUX7 C,7

#include "libs/bwl_pins.h"


	
void ds18b20_pin_set(char index, char isOutput, char isHigh)
{
	switch (index)
	{
		case 1:		pin_set_dir(AUX1,isOutput);	pin_set_out(AUX1,isHigh);		break;
		case 2:		pin_set_dir(AUX2,isOutput);	pin_set_out(AUX2,isHigh);		break;
		case 3:		pin_set_dir(AUX3,isOutput);	pin_set_out(AUX3,isHigh);		break;
		case 4:		pin_set_dir(AUX4,isOutput);	pin_set_out(AUX4,isHigh);		break;
		case 5:		pin_set_dir(AUX5,isOutput);	pin_set_out(AUX5,isHigh);		break;
	}
}

char ds18b20_pin_read(char index)
{
	switch (index)
	{
		case 1:			return pin_get_in(AUX1);		break;
		case 2:			return pin_get_in(AUX2);		break;
		case 3:			return pin_get_in(AUX3);		break;
		case 4:			return pin_get_in(AUX4);		break;
		case 5:			return pin_get_in(AUX5);		break;
	}
	return 0;
}

void dht22_pin_set(char index, char isOutput, char isHigh)
{
	ds18b20_pin_set (index,isOutput,isHigh);
}

char dht22_pin_read(char index)
{
	return ds18b20_pin_read(index);
}


