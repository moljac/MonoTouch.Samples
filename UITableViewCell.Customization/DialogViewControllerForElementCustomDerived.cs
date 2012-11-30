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
			UIView v = this.View;
			// Load Views from XIB
			NSArray views = NSBundle.MainBundle.LoadNib ("UITableViewControllerForList", v, null);
			
			// Extract cell drawn/defined in XIB with Interface Builder 
			// it is one and only UIView thus index 0
			UITableViewCellCustom cell = 
					MonoTouch.ObjCRuntime.Runtime.GetNSObject (views.ValueAt (0))
				 	as UITableViewCellCustom;
			
			ElementCustomDerived ecd1 = 
				new ElementCustomDerived("UITableViewControllerForList")
				{
				CellCustom = cell
				};

			ElementCustomDerived  ecd2 = new ElementCustomDerived(cell);
			
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
					new ElementCustomDerived("UITableViewControllerForList")
				, ecd1
				, ecd2
				},
				// WTF??? no error? check comma in the line above
			};
		}
	}
}
