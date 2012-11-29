
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

			ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative> sie;
			sie = new ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative> ();

			List<ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative>> data_ui;
			data_ui = new List<ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative>>();

			List<SectionalInformation> data_sectional_info;
			data_sectional_info = SectionalInformationDataFactory.SectionalInformation ();

			foreach (SectionalInformation si in data_sectional_info) 
			{

				ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative> ce;
				ce = new ElementCustomGeneric<SectionalInformation, UITableViewCellCustomAlternative>();

				ce.BusinessObject = si;
				ce.PresentationObjectCell = null; // if null will be extracted from xib hahahahahahaha
				ce.ParentTableView = this.TableView;

				//UITableViewCellCustom clc = ce.PresentationObjectCell as UITableViewCellCustom;
				// clc.UpdateData(si.Name, si.Elapsed.ToString(), si.Delete);

				UITableViewCellCustomListXIBless clcxl = new UITableViewCellCustomListXIBless();

				ce.UpdateData += delegate(UITableViewCell c)
				{
				};

				data_ui.Add(ce);
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
