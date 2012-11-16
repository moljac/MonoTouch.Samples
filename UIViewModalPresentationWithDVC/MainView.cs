
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UIViewModalPresentationWithDVC
{
	public partial class MainView : UIViewController
	{
		//UIViews
		UIView _view;
		DVC dialogViewController;

		public MainView () : base ("MainView", null)
		{
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
			this.View.BackgroundColor = UIColor.Blue;


			btnLoad.TouchUpInside += (object sender, EventArgs e) => 
			{
				if(_view == null)
				{
					//ADD UIVIEW ON (x,y) @ THIS VIEW
					_view = new UIView();
					_view.Frame = new RectangleF(192,20,384,502);
					_view.BackgroundColor = UIColor.Black;
				}
					this.View.AddSubview(_view);

				if(dialogViewController == null)
				{
					dialogViewController = new DVC();
				}
				_view.Add(dialogViewController.View);

				//DISABLE ALL COMMANDS ON MAIN VIEW COULD BE USED FOR MODAL PRESENTATION
//				_view.BecomeFirstResponder();
					
			};
			btnRemove.TouchUpInside += (object sender, EventArgs e) => 
			{
				this._view.RemoveFromSuperview();
				//this.View.WillRemoveSubview(_view);
			};


			//AFTER EVERY PRESS, ALSO PRESS REMOVE BUTTON !!!
			btnModalPresentation.TouchUpInside += (object sender, EventArgs e) => 
			{

				UIView.Animate
					(0.90f,0f,UIViewAnimationOptions.CurveEaseIn,
					 	delegate 
				               {
									
									//ADD UIVIEW ON (x,y) @ THIS VIEW
									_view = new UIView();
									_view.Frame = new RectangleF(192,20,384,502);
									_view.BackgroundColor = UIColor.Black;

									this.View.AddSubview(_view);
					
									
								dialogViewController = new DVC();
								_view.Add(dialogViewController.View);

//								UIView.SetAnimationTransition(UIViewAnimationTransition.CurlUp,_view, false);

								}
					,null);
	

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
			return true;
		}
	}
}

