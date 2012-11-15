
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

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

		public void UpdateWithData (string name, DateTime time)
		{  
			lblDate.Text = time.ToString();
			lblName.Text = name;
			btnDelete.Hidden = false;
		}


	}
}

