/*
 *  BindingNativeLibrariesCPPStaticLib.cp
 *  BindingNativeLibrariesCPPStaticLib
 *
 *  Created by Miljenko Cvjetko on 12/26/12.
 *  Copyright (c) 2012 Miljenko Cvjetko. All rights reserved.
 *
 */

#include <iostream>
#include "BindingNativeLibrariesCPPStaticLib.h"
#include "BindingNativeLibrariesCPPStaticLibPriv.h"

void BindingNativeLibrariesCPPStaticLib::HelloWorld(const char * s)
{
	 BindingNativeLibrariesCPPStaticLibPriv *theObj = new BindingNativeLibrariesCPPStaticLibPriv;
	 theObj->HelloWorldPriv(s);
	 delete theObj;
};

void BindingNativeLibrariesCPPStaticLibPriv::HelloWorldPriv(const char * s) 
{
	std::cout << s << std::endl;
};

