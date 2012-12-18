
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITableViewCellCustomTestGenerics.SampleUsages
{
	public partial class UITableViewCellCustomForList : UITableViewCellCustomGeneric<string>
	{  

		public UITableViewCellCustomForList () : base()
		{
		}

		public UITableViewCellCustomForList(IntPtr handle)
			: base(handle)
		{
		}

		public override void DataBind(string text)
		{
			this.lblDate.Text = text + DateTime.Now;
			this.lblDate.Text = text;
			btnDelete.SetTitle("title set" + text, UIControlState.Normal);

			return;
		}
	}
}

