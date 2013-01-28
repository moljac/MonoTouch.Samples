
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace CustomCell
{
	public partial class MTDElementsTesting : DialogViewController
	{
		public MTDElementsTesting () : base (UITableViewStyle.Grouped, null)
		{
			SliderElement sliderElement = new SliderElement();

			StringElement sliderValues = new StringElement("");

//			sliderElement.slider.ValueChanged += (object sender, EventArgs e) => 
//			{
//				sliderValues.Caption = sliderElement.slider.Value.ToString();
//			};

			Root = new RootElement ("MTDElementsTesting") 
			{
				new Section ("First Section")
				{
					sliderElement,
					sliderValues
				},
				new Section ("Second Section")
				{
				},
			};
		}
	}
}
