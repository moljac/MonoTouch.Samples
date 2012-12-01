
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoMobile.Dialog
{
	public partial class UITableViewCellCustomForList : UITableViewCellCustom
	{  

		public UITableViewCellCustomForList () : base()
		{
		}

		public UITableViewCellCustomForList(IntPtr handle)
			: base(handle)
		{
		}

		// TODO: refactor to be more generic
		public void UpdateWithData (string name, DateTime time)
		{  
			lblDate.Text = time.ToString();
			lblName.Text = name;
			btnDelete.Hidden = false;
		}


	}
}

