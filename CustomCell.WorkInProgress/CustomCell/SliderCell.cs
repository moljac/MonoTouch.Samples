
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomCell
{
	public partial class SliderCell : UITableViewCell
	{ 
		public SliderCell () : base()
		{
		}
		
		public SliderCell (IntPtr handle) : base(handle)
		{
		}

		public object GetSlider 
		{

			get 
			{
				return this.slider;
			}
		
			set
			{

			}
		}
	}
}

