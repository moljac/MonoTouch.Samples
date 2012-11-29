
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ElementsTesting
{
	public partial class PickerView : UIViewController
	{

		UIView pickerDismissalView;
		private PointF _originalPosition;

		public PickerView () : base ("PickerView", null)
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

			//Setup the picker and model
			PickerModel model = new PickerModel (this.View);
			model.PickerChanged += (sender, e) => 
			{
				this.txtLabel.Text = e.SelectedValue;
				
			};

			//UIPickerView
			UIPickerView picker = new UIPickerView ();
			picker.ShowSelectionIndicator = true;
			picker.Model = model;

			//TAP GESTURE
			var tap = new UITapGestureRecognizer();
		
			
			//Tell the textbox to use the picker for input
			this.txtLabel.InputView = picker;

			pickerDismissalView = new UIView ();
			pickerDismissalView.Frame = new System.Drawing.RectangleF (0, 0, this.View.Bounds.Width, this.View.Bounds.Height - picker.Frame.Height);
			pickerDismissalView.Alpha = 1.0f;
			pickerDismissalView.BackgroundColor = UIColor.FromWhiteAlpha(0.2f,0.2f);


			//Display the transparent view over the pickers
			this.txtLabel.InputAccessoryView = pickerDismissalView;

			//add gestures for removal
			tap.AddTarget(() => {this.txtLabel.ResignFirstResponder();});
			pickerDismissalView.AddGestureRecognizer(tap);

			//--------------------------------------------------------------------------
			//Scroll across the picture
			var iv = new UIImageView (UIImage.FromFile ("desktop.png"));
			
			scrollView.AddSubview (iv);
			scrollView.ContentSize = iv.Frame.Size;
			scrollView.MinimumZoomScale = 1.0f;
			scrollView.MaximumZoomScale = 3.0f;
			scrollView.MultipleTouchEnabled = true;
//			scrollView.ViewForZoomingInScrollView = delegate(UIScrollView scrollView) {
//				return iv;
//			};      
			scrollView.ViewForZoomingInScrollView = delegate {
				return iv;
			};
		
			//---------------------------------------------------------------------------				

			//---------GESTURES----------------------------------------------------------
			DragLabel.Layer.MasksToBounds = false;
			DragLabel.Layer.BorderColor = UIColor.White.CGColor;
			DragLabel.Layer.CornerRadius = 5.0f;
			DragLabel.Layer.ShadowOffset = SizeF.Empty;
			DragLabel.Layer.ShadowRadius = 4.0f;
			DragLabel.Layer.ShadowOpacity = 0.75f;
			DragLabel.Layer.ShadowPath = UIBezierPath.FromRoundedRect(DragLabel.Bounds, 5.0f).CGPath;
			DragLabel.Layer.ShouldRasterize = true;
			DragLabel.BackgroundColor = UIColor.White;
			DragLabel.UserInteractionEnabled = true;
			
			SetupGestureRecognisers();
			

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

		private void SetupGestureRecognisers()
		{
			var tapRecogniser = new UITapGestureRecognizer(this, new MonoTouch.ObjCRuntime.Selector("ViewTapSelector"));
			View.AddGestureRecognizer(tapRecogniser);
			
			var doubleTapRecogniser = new UITapGestureRecognizer(this, new MonoTouch.ObjCRuntime.Selector("ViewDoubleTapSelector"));
			doubleTapRecogniser.NumberOfTapsRequired = 3;
			View.AddGestureRecognizer(doubleTapRecogniser);
			
			var longPressRecogniser = new UILongPressGestureRecognizer(this, new MonoTouch.ObjCRuntime.Selector("LongPressSelector"));
			View.AddGestureRecognizer(longPressRecogniser);
			
			var panRecogniser = new UIPanGestureRecognizer(this, new MonoTouch.ObjCRuntime.Selector("LabelPanSelector"));
			DragLabel.AddGestureRecognizer(panRecogniser);
		}
		
		[Export("ViewTapSelector")]
		protected void OnViewTapped(UIGestureRecognizer sender)
		{
			MessageLabel.Text = "View Tapped";
		}
		
		[Export("ViewDoubleTapSelector")]
		protected void OnViewDoubleTapped(UIGestureRecognizer sender)
		{
			MessageLabel.Text = "View Triple Tapped";
		}
		
		[Export("LongPressSelector")]
		protected void OnLongPress(UIGestureRecognizer sender)
		{
			MessageLabel.Text = "View Long Pressed";
		}
		
		[Export("LabelPanSelector")]
		protected void OnLabelPan(UIGestureRecognizer sender)
		{
			var panRecogniser = sender as UIPanGestureRecognizer;
			
			if (panRecogniser == null)
				return;
			
			switch (panRecogniser.State)
			{
			case UIGestureRecognizerState.Began:
				_originalPosition = DragLabel.Frame.Location;
				break;
				
			case UIGestureRecognizerState.Cancelled:
			case UIGestureRecognizerState.Failed:
				DragLabel.Frame = new RectangleF(_originalPosition, DragLabel.Frame.Size);
				break;
				
			case UIGestureRecognizerState.Changed:
				var movement = panRecogniser.TranslationInView(View);
				var newPosition = new PointF(movement.X + _originalPosition.X, movement.Y + _originalPosition.Y);
				DragLabel.Frame = new RectangleF(newPosition, DragLabel.Frame.Size);
				break;
			}
		}
	}
}

