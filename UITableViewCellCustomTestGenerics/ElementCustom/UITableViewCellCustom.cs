using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoMobile.Dialog
{
	public delegate void DataBindDelegate<BusinessObjectType>(BusinessObjectType bot);


	public partial class UITableViewCellCustom<BusinessObjectType>
		: 
		MonoTouch.UIKit.UITableViewCell
	{
		public UITableViewCellCustom () : base()
		{
		}
		
		public UITableViewCellCustom (IntPtr handle) : base(handle)
		{

		}

		public event DataBindDelegate<BusinessObjectType> Binder;

		public void DataBind(BusinessObjectType bot)
		{
			if (Binder != null)
			{
				Binder(bot);
			}
		}
	}




}
/*
	new cell
 * 
 *  this.Binder += new CellDrawGenric()
 *  
*/
