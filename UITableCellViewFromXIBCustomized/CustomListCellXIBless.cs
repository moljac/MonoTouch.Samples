using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace TEST
{
	public partial class CustomListCellXIBless : UITableViewCell
	{  
		UIButton btnDelete;
		UILabel lblName; 
		UILabel lblDate;

		public CustomListCellXIBless () : base()
		{
			DrawCell();
		}
		
		public CustomListCellXIBless (IntPtr handle) : base(handle)
		{
			DrawCell();
		}
		
		// TODO: delegate
		public void UpdateData(string name, string timespan, bool delete)
		{
			lblName.Text = name;
			lblDate.Text = timespan;
			btnDelete.Hidden = false;	// (Mapping["delte"] == "true") ? true : false;
			
			// make View dirty
			this.SetNeedsDisplay();

		}

		//CUSTOM CELL
		public void DrawCell()
		{
			ContentView.Frame = new RectangleF(0,0,768,44);

			btnDelete = new UIButton(new RectangleF(7,8,103,27));
			lblName = new UILabel(new RectangleF(140,11,489,21));
			lblDate = new UILabel(new RectangleF(648,11,100,21));

			UIView [] views = 
			{
				btnDelete,
				lblName,
				lblDate
			};

			
			ContentView.AddSubviews(views);

		}

		
		
	}
}

