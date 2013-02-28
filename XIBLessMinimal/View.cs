using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace XIBless
{
	public class View : UIView
	{
		public View (RectangleF frame) : base()
		{
			Frame = frame;

			this.BackgroundColor = UIColor.Blue;
		}
	}
}

