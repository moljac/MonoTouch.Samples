#include "String.h"

// Add function definitions here


using namespace std;

// Add function prototypes here

string String::Reverse(const string& msg) const
{
	string retval = msg;
	std::reverse(retval.begin(), retval.end());
	
	return retval;
};
