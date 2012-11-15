
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace TEST
{
	public partial class CustomListCell : UITableViewCell
	{  
		public CustomListCell () : base()
		{
		}
		
		public CustomListCell (IntPtr handle) : base(handle)
		{
		}

		public delegate void UpdateWithData<BusinessobjecType>(BusinessobjecType bo);
		//private event UpdateWithData UpdateWithDataDelegate;

		public static Dictionary<string, string> Mapping;

		// TODO: delegate
		public void UpdateWithData()
		{  
			lblDate.Text = "Date"; 		// Mapping["Elapsed"];
			lblName.Text = "name";  	// Mapping["TimeStamp"];
			btnDelete.Hidden = true;	// (Mapping["delte"] == "true") ? true : false;
		}


	}
}

