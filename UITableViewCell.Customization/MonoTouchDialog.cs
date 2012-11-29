
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace TEST
{
	public partial class SectionalInformationDialogViewController : DialogViewController
	{
		public SectionalInformationDialogViewController () : base (UITableViewStyle.Plain, null)
		{

			SectionalInformationElement sie = new SectionalInformationElement();


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
					new SectionalInformationElement()
				},
			};
		}
	}
}
