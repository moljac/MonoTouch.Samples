
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;

using SampleData;

namespace UITableViewCellCustomizationFromXIB
{
	public partial class DataLoadingDialogViewController : DialogViewController
	{
		public DataLoadingDialogViewController()
			: base(UITableViewStyle.Plain, null)
		{

			ElementCustom ecdg1 = new ElementCustom();

			List<ElementCustom> data_ui = new List<ElementCustom>();

			List<SectionalInformation> data_sectional_info;
			data_sectional_info = SectionalInformationDataFactory.SectionalInformation ();

			foreach (SectionalInformation si in data_sectional_info) 
			{

				ElementCustom ecdg2 = new ElementCustom();

				//UITableViewCellCustom clc = ce.PresentationObjectCell as UITableViewCellCustom;
				// clc.UpdateData(si.Name, si.Elapsed.ToString(), si.Delete);


//				ecdg2.UpdateData += delegate(UITableViewCell c)
//				{
//				};

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
