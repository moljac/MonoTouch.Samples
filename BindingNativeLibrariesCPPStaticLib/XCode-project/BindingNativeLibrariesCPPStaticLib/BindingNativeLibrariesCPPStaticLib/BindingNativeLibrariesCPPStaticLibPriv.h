/*
 *  BindingNativeLibrariesCPPStaticLibPriv.h
 *  BindingNativeLibrariesCPPStaticLib
 *
 *  Created by Miljenko Cvjetko on 12/26/12.
 *  Copyright (c) 2012 Miljenko Cvjetko. All rights reserved.
 *
 */

/* The classes below are not exported */
#pragma GCC visibility push(hidden)

class BindingNativeLibrariesCPPStaticLibPriv
{
	public:
		void HelloWorldPriv(const char *);
};

#pragma GCC visibility pop
