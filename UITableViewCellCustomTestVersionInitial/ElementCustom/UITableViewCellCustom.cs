using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoMobile.Dialog
{
	public class UITableViewCellCustom : MonoTouch.UIKit.UITableViewCell
	{
		public UITableViewCellCustom () : base()
		{
		}
		
		public UITableViewCellCustom (IntPtr handle) : base(handle)
		{
		}
		
		public virtual void UpdateWithData(string name, DateTime time)
		{

		}
	}
}
