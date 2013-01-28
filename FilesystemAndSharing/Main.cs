
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FileSystem
{
	/// <summary>Kick everything off</summary>
	public class Application
	{
		static void Main (string[] args)
		{
			// MONO_LOG_LEVEL="debug"
			string environment_variable_name = "MONO_LOG_LEVEL";
			string environment_variable_value = "debug";
			//EnvironmentVariable.Set (environment_variable_name, environment_variable_value);
			
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}

