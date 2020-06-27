//Modify this file to change what commands output to your statusbar, and recompile using the make command.
static const Block blocks[] = {
	/*Icon*/	/*Command*/		/*Update Interval*/	/*Update Signal*/
	{" ", "ap",						0,		0},

	{" ", "na",						5,		0},

	{" ", "nett",						5,		0},

	{" ", "vol",						0,		10},

	{" ", "bat",						5,		0},

	{" ", "cloc",						60,		0},

};

//sets delimeter between status commands. NULL character ('\0') means no delimeter.
static char delim = ' ';
