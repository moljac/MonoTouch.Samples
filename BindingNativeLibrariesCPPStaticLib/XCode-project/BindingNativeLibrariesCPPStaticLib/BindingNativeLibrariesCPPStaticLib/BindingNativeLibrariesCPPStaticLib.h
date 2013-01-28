/*
 *  BindingNativeLibrariesCPPStaticLib.h
 *  BindingNativeLibrariesCPPStaticLib
 *
 *  Created by Miljenko Cvjetko on 12/26/12.
 *  Copyright (c) 2012 Miljenko Cvjetko. All rights reserved.
 *
 */

#ifndef BindingNativeLibrariesCPPStaticLib_
#define BindingNativeLibrariesCPPStaticLib_

/* The classes below are exported */
#pragma GCC visibility push(default)

class BindingNativeLibrariesCPPStaticLib
{
	public:
		void HelloWorld(const char *);
};

#pragma GCC visibility pop
#endif
