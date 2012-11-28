
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace TabBarOnTopDVC
{
	public partial class DVC : DialogViewController
	{
		public DVC () : base (UITableViewStyle.Plain, null)
		{
		

			Root = new RootElement ("DVC") 
			{
				new Section ("First Section")
				{
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
			};
		}
	}
}
