
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XSample.AutoLayout
{
	public partial class MainView : UIViewController
	{
		public MainView () : base ("MainView", null)
		{
			this.NavigationItem.Title = "AUTOSIZING";
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

			//AutoLayout View
			btnAutoLayout.TouchUpInside += (object sender, EventArgs e) => 
			{
				AutoLayout al = new AutoLayout();
				this.NavigationController.PushViewController(al,true);
			};

			//NoAutoLayout View
			btnNoAutoLayout.TouchUpInside += (object sender, EventArgs e) => 
			{
				NoAutoLayout nal = new NoAutoLayout();
				this.NavigationController.PushViewController(nal,true);
			};

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

