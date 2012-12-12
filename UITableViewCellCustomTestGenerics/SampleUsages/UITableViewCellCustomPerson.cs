
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITableViewCellCustomTestGenerics.SampleUsages
{
	public partial class UITableViewCellCustomPerson : UITableViewCellCustom<Person>
	{  

		public UITableViewCellCustomPerson () : base()
		{
			//this.DataBindMethod += BindPerson;
		}
		
		public UITableViewCellCustomPerson (IntPtr handle) : base(handle)
		{
		}

		public override void DataBind(Person bo_object)
		{
			return;
		}
	}
}

