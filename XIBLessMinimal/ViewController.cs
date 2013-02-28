using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace XIBless
{
	public class ViewController : UIViewController
	{
		public ViewController () : base()
		{
		}

		public override void LoadView()
		{
			RectangleF frame = UIScreen.MainScreen.Bounds;

			View view = new XIBless.View (frame);

			this.View = view;

		}

	}
}

