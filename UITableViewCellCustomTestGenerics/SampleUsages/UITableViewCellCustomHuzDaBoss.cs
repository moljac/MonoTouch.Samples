
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITableViewCellCustomTestGenerics.SampleUsages
{
	public partial class UITableViewCellCustomHuzDaBoss : UITableViewCellCustomGeneric<string>
	{  

		public UITableViewCellCustomHuzDaBoss () : base()
		{
		}
		
		public UITableViewCellCustomHuzDaBoss (IntPtr handle) : base(handle)
		{
		}


		public override void DataBind(string text)
		{
			this.lblDate.Text = "Moki's da boss" + DateTime.Now;
			this.lblDate.Text = "Moki's da boss" + text;
			btnDelete.SetTitle("title set" + "Moki's da boss", UIControlState.Normal);

			return;
		}
	}
}

