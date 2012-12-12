
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XIBfullSingleController
{
	public partial class DetailViewController_iPhone 
		: 
			UIView
			//UIViewController
	{
		public DetailViewController_iPhone () :
			base()
			// base ("DetailViewController_iPhone", null)
		{
		}

		// No overrideable method
		// public override void DidReceiveMemoryWarning ()
		public void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			// base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		// No overrideable method
		// public override void ViewDidLoad ()
		public  void ViewDidLoad ()
		{
			// base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		// No overrideable method
		// public override void ViewDidUnload ()
		public void ViewDidUnload ()
		{
			// base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		// No overrideable method
		// public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		public bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

