
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using SampleData;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;

namespace UITableViewCellCustomizationFromXIB
{
	public partial class DataLoadingDialogViewController : DialogViewController
	{
		public DataLoadingDialogViewController()
			: base(UITableViewStyle.Plain, null)
		{

			ElementCustomDerivedGeneric<object, UITableViewCell> ecdg1;
			ecdg1 = new ElementCustomDerivedGeneric<object, UITableViewCell> ();

			List<ElementCustomDerivedGeneric<object, UITableViewCell>> data_ui;
			data_ui = new List<ElementCustomDerivedGeneric<object, UITableViewCell>>();

			List<SectionalInformation> data_sectional_info;
			data_sectional_info = SectionalInformationDataFactory.SectionalInformation ();

			foreach (SectionalInformation si in data_sectional_info) 
			{

				ElementCustomDerivedGeneric<object, UITableViewCell> ecdg2;
				ecdg2 = new ElementCustomDerivedGeneric<object, UITableViewCell>();

				ecdg2.BusinessObject = si;
				// Trick: 
				// if null will be extracted from xib hahahahahahaha
				ecdg2.PresentationObjectCell = null; 
				ecdg2.ParentTableView = this.TableView;

				//UITableViewCellCustom clc = ce.PresentationObjectCell as UITableViewCellCustom;
				// clc.UpdateData(si.Name, si.Elapsed.ToString(), si.Delete);

				UITableViewCellCustomListXIBless clcxl = new UITableViewCellCustomListXIBless();

				ecdg2.UpdateData += delegate(UITableViewCell c)
				{
				};

				data_ui.Add(ecdg2);
			}


			Root = new RootElement ("MTD") 
			{
				new Section ("First Section: Custom cell from XIB")
				{
					data_ui.ToArray()
				},
				new Section ("Second Section: Custom cell from XIB")
				{
				}
			};
		}

		void ce_UpdateData(MonoTouch.UIKit.UITableViewCell cell)
		{
		}
	}
}
