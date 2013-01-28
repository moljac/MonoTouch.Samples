#include <iostream>
#include <algorithm>

#include "String.h"

using namespace std;

int main (int argc, char *argv[])
{
	string msg="Hello world!";
	
	string msg_reversed = msg;

	std::reverse(msg_reversed.begin(), msg_reversed.end());
	
	cout << msg << endl;
	cout << msg_reversed << endl;
	
	return 0;
}

