using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoMobile.Dialog
{
	public abstract class UITableViewCellCustom
		: 
		MonoTouch.UIKit.UITableViewCell
	{
		public UITableViewCellCustom () : base()
		{
		}
		
		public UITableViewCellCustom (IntPtr handle) : base(handle)
		{
		}
		
		public abstract void UpdateWithData<BusinessObjectType>(BusinessObjectType bo_object);

	}
}
