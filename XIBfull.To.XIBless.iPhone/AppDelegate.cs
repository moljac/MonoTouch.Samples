using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XIBfull.To.XIBless.iPhone
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		UIViewController ui_view_controller;
		MainViewCotroller main_view_controller;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// If you have defined a view, add it here:
			// window.AddSubview (navigationController.View);

			window.Bounds = UIScreen.MainScreen.Bounds;
			window.BackgroundColor = UIColor.White;

			if (null == main_view_controller) 
			{
				main_view_controller =  new MainViewCotroller();

				//
				main_view_controller.View.BackgroundColor = new UIColor(30f,30f,30f, 20f);
			}
			window.AddSubview(main_view_controller.View);


			UILabel purpleLabel = new UILabel();
			purpleLabel.BackgroundColor = UIColor.Purple;
			purpleLabel.Text = "Hello none IB World";
			purpleLabel.Frame = window.Frame;
			window.AddSubview(purpleLabel);

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

