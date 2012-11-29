using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;

namespace UITableViewCellCustomization
{
	public partial class DialogViewControllerForElementCustomDerived 
		: 
		DialogViewController
	{
		public DialogViewControllerForElementCustomDerived () : base (UITableViewStyle.Plain, null)
		{

			ElementCustomDerived sie = new ElementCustomDerived();


			Root = new RootElement("MTD") 
			{
				new Section ("First Section"){
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section")
				{
				  new ElementCustomDerived()
				, sie
				},
				// WTF??? no error? check comma in the line above
			};
		}
	}
}
