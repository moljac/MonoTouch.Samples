
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace TabBar
{
	public partial class GenericDVC : DialogViewController
	{
		public GenericDVC () : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement (string.Empty) 
			{
				new Section ("First Section")
				{
					//new StringElement(),
				},
				new Section ("Second Section")
				{
				},
			};
		}
	}
}
