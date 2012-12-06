
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoMobile.Dialog
{
	public partial class UITableViewCellPerson : UITableViewCellCustom
	{  

		public UITableViewCellPerson () : base()
		{
		}
		
		public UITableViewCellPerson (IntPtr handle) : base(handle)
		{
		}

		// TODO: refactor to be more generic
		public override void UpdateWithData<Person>(Person bo_object)
		{
		  this.labelNameLast.Text = bo_object.NameFirst;
			this.labelNameLast.Text = bo_object.NameLast;
		}
		
		public virtual void UpdateWithData(UITableViewCellCustomTestVersionInitial.Person bo_object)
		{
			this.labelNameLast.Text = bo_object.NameFirst;
			this.labelNameLast.Text = bo_object.NameLast;
		}
		

	}
}

