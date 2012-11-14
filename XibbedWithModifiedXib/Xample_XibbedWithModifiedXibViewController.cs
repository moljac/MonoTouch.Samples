using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Xample.XibbedWithModifiedXib
{
	public partial class Xample_XibbedWithModifiedXibViewController 
		: 
			UIView
			//UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public Xample_XibbedWithModifiedXibViewController ()
			: 
				base()
				// UIView cannot load xibs
				//base (UserInterfaceIdiomIsPhone ? "Xample_XibbedWithModifiedXibViewController_iPhone" : "Xample_XibbedWithModifiedXibViewController_iPad", null)
		{
		}
		
		//public override void DidReceiveMemoryWarning ()
		public void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			//base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		//public override void ViewDidLoad ()
		public void ViewDidLoad ()
		{
			//base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		//public override void ViewDidUnload ()
		public void ViewDidUnload ()
		{
			//base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		//public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		public bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone) {
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else {
				return true;
			}
		}
	}
}

