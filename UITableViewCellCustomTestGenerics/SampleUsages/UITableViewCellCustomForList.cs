
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITableViewCellCustomTestGenerics.SampleUsages
{
	public partial class UITableViewCellCustomForList : UITableViewCellCustom<string>
	{  

		public UITableViewCellCustomForList () : base()
		{
		}

		public UITableViewCellCustomForList(IntPtr handle)
			: base(handle)
		{
		}

	}
}

