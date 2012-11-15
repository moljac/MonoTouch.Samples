
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;


using Xsample.iFly;

namespace TEST
{
	public partial class MTD : DialogViewController
	{
		public MTD () : base (UITableViewStyle.Plain, null)
		{

			CustomElement<SectionalInformation, CustomListCell> sie;
			sie = new CustomElement<SectionalInformation, CustomListCell> ();

			List<CustomElement<SectionalInformation, CustomListCell>> data_ui;
			data_ui = new List<CustomElement<SectionalInformation, CustomListCell>>();

			List<SectionalInformation> data_sectional_info = Data.SectionalInformation ();

			foreach (SectionalInformation si in data_sectional_info) 
			{

				CustomElement<SectionalInformation, CustomListCell> ce;
				ce = new CustomElement<SectionalInformation, CustomListCell>();

				ce.BusinessObject = si;
				ce.PresentationObjectCell = null; // if null will be extracted from xib hahahahahahaha
				ce.ParentTableView = this.TableView;
				CustomListCell clc = ce.PresentationObjectCell as CustomListCell;
				clc.UpdateData(si.Name, si.Elapsed.ToString(), si.Delete);
				//ce.UpdateData += delegate(UITableViewCell c)
				//{
				//};

				data_ui.Add(ce);
			}


			Root = new RootElement ("MTD") 
			{
				new Section ("First Section"){
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section: Custom cell from XIB")
				{
					data_ui.ToArray()
				},
				new Section ("Second Section: Custom cell from XIB")
				{
				}
			};
		}

		void ce_UpdateData(UITableViewCell cell)
		{
		}
	}
}
