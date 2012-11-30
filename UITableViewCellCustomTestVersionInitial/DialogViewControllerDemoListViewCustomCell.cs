
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace TEST
{
	public partial class DialogViewControllerDemoListViewCustomCell : DialogViewController
	{
		public DialogViewControllerDemoListViewCustomCell () : base (UITableViewStyle.Plain, null)
		{

			ElementDerivedCustom edc1 = new ElementDerivedCustom();


			Root = new RootElement ("MTD") 
			{
				new Section ("First Section"){
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section")
				{
				  new ElementDerivedCustom()
				, edc1
				},
			};
		}
	}
}
