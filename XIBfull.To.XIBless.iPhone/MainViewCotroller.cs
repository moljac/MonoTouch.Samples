
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XIBfull.To.XIBless.iPhone
{
	public partial class MainViewCotroller : UIViewController
	{


		public MainViewCotroller () 
			: 
				base()
				//base ("MainViewCotroller", null)
		{
			/*
			 * Does not affect
			UIView ui_view = new UIView( new RectangleF(10, 10, 200, 200))
			{
				BackgroundColor = new UIColor(20f,20f,20f,20f)
			};

			this.View = ui_view;
			*/

		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			UIView ui_view = new UIView(new RectangleF(10, 10, 200, 200))
			{
				BackgroundColor = new UIColor(20f,20f,20f,20f)
			};

			//this.View = ui_view;     // No use
			//this.View.Add(ui_view); // No use

			UIButton ui_button = new UIButton(new RectangleF(10, 250, 100, 50));
			ui_button.SetTitle("Title", UIControlState.Normal);

			this.View = ui_button;  // No use
			//this.View.AddSubview(ui_button);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

