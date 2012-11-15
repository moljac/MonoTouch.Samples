
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace TEST
{
	public partial class CustomListCell 
		: UITableViewCell
	{  
		public CustomListCell () : base()
		{
		}
		
		public CustomListCell (IntPtr handle) : base(handle)
		{
		}

		// TODO: delegate
		public void UpdateData(string name, string timespan, bool delete)
		{
			lblDate.Text = name;
			lblName.Text = timespan;
			btnDelete.Hidden = delete;	// (Mapping["delte"] == "true") ? true : false;
		}


	}
}

