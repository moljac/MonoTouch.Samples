
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace AnimationTesting
{
	public partial class MainView : UIViewController
	{
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
	
			AnimateView animateView = new AnimateView();

			//TODO: more info at: http://www.youtube.com/watch?v=6JePwHjVj6U

			//MODAL PRESENTATION OF UIVIEW CONTROLLER--------------------------------------------------
			//PRESENTATION STLYE IS FORM SHEET
			btnTest.TouchUpInside += (object sender, EventArgs e) => 
			{
				AnimateModalViewController animateModalViewController = new AnimateModalViewController()
				{
					ModalTransitionStyle = UIModalTransitionStyle.CoverVertical,
					ModalPresentationStyle = UIModalPresentationStyle.FormSheet,
				};
				this.NavigationController.PresentViewController(animateModalViewController,true,null);
			};
			//-----------------------------------------------------------------------------------------

			//UIViewAnimation-----------------------------------------------------------------------------
			//RECTANGLE ANIMATION (GO LEFT AND RETURN TO STARTING POINT 
			PointF p0;
			UIView view = new UIView();
			view.Frame = new RectangleF(20,20,200,200);
			view.BackgroundColor = UIColor.Green;

			this.View.Add(view);
			btnCoreAnimation.TouchUpInside += (object sender, EventArgs e) => 
			{
				p0 = view.Center;

				UIView.Animate(2,0,
				               UIViewAnimationOptions.CurveEaseInOut | UIViewAnimationOptions.Autoreverse,
				               () => 
				               {
									view.Center = 
												new PointF(
															UIScreen.MainScreen.Bounds.Right - view.Frame.Width /2,
															view.Center.Y
															);
							   },
							   () => { view.Center = p0;}
								);

			};

			//UIView ANIMATION (FADE IN FROM THE CENTER OF THE SCREEN)---------------------------------------------
			PointF p1;
			UIView view1 = new UIView();
			view1.Frame = new RectangleF(this.View.Center.X,this.View.Center.Y,0,0);
			view1.BackgroundColor = UIColor.Gray;

			//DISMISS BUTTON FOR VIEW1
			UIButton btnDismissView1 = new UIButton(UIButtonType.RoundedRect);
			btnDismissView1.Frame = new RectangleF(318,687,133,44);
			btnDismissView1.Title(UIControlState.Normal);
			btnDismissView1.SetTitle("Dismiss View1",UIControlState.Normal);

			//DISMISS VIEW1
			btnDismissView1.TouchUpInside += (object sender, EventArgs e) => 
			{
				UIView.Animate(2,0,UIViewAnimationOptions.BeginFromCurrentState | UIViewAnimationOptions.CurveEaseIn,
				               () => 
				               {
									btnDismissView1.RemoveFromSuperview();
									view1.Frame = new RectangleF(this.View.Center.X,this.View.Center.Y,0,0);
								},
				() =>{view1.RemoveFromSuperview();}
				);

			};

			//ADD VIEW1 AS SUBVIEW TO this.View
			btnFadeInView.TouchUpInside += (object sender, EventArgs e) => 
			{
			
				this.View.Add(view1);

				p1 = view1.Center;

				UIView.Animate(2,0,UIViewAnimationOptions.BeginFromCurrentState | UIViewAnimationOptions.CurveEaseIn,
				               () => 
				               {
									view1.Frame = new RectangleF(0,0,768,960);
								},
								() => {view1.Add(btnDismissView1);}	//EMPTY, COULD BE USED FOR ACTION UPON COMPLETITION OF ANIMATION
								);
			};
			//---------------------------------------------------------------------------------------------


			//iOS built-in animations----------------------------------------------------------------------
			btnCrossDissolve.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushControllerWithTransition(animateView, 
				                                                       UIViewAnimationOptions.TransitionCrossDissolve);
			};

			btnCurlDown.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushControllerWithTransition(animateView, 
				                                                       UIViewAnimationOptions.TransitionCurlDown);
			};

			btnCurlUp.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushControllerWithTransition(animateView, 
				                                                       UIViewAnimationOptions.TransitionCurlUp);
			};

			btnFlipFromBottom.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushControllerWithTransition(animateView, 
				                                                       UIViewAnimationOptions.TransitionFlipFromBottom);
			};

			btnFlipFromLeft.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushControllerWithTransition(animateView, 
				                                                       UIViewAnimationOptions.TransitionFlipFromLeft);
			};
			//------------------------------------------------------------------------------------------------


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

