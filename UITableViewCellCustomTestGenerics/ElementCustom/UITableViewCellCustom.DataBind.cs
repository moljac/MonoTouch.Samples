using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using MonoTouch.UIKit;

namespace MonoMobile.Dialog
{
	public delegate void DataBindDelegate<BusinessObjectType>
			(
			  UITableViewCellCustom<BusinessObjectType> cell
			, BusinessObjectType bot
			);

	public partial class UITableViewCellCustom<BusinessObjectType>
	{
		public event DataBindDelegate<BusinessObjectType> DataBindMethod;

		public void DataBind (UITableViewCellCustom<BusinessObjectType> cell, BusinessObjectType bot)
		{
			if (DataBindMethod != null) 
			{
				cell.DataBindMethod (cell, bot);
			} else 
			{
				Debug.WriteLine("No DataBinding method assigned!");
			}
		}
	}
}
