using System;

using System.Runtime.InteropServices;

namespace BindingNativeLibrariesMonoConsoleAppToTestCompiledLibraryForPInvoke
{
	
	class MainClass
	{
		[DllImport("libiFlyiPadNativeDebug")]
		public static extern void 
			BlendPerPixelAlpha565(
				[In, Out] short* destPointer, [In] short* srcPointer, [In] byte[,] alphaPointer, int destDataStride, int srcDataStride,
				int destWidth, int destHeight, int srcWidth, int srcHeight, int destStartX, int destStartY, int masterAlpha);

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			BlendPerPixelAlpha565(0, 0, null, 0,0,0,0,0,0,0,0,0);
		}
	}
}
