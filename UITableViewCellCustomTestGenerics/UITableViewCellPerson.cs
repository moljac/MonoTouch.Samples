
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using UITableViewCellCustomTestVersionInitial;

namespace MonoMobile.Dialog
{
	public partial class UITableViewCellPerson : UITableViewCellCustom<Person>
	{  

		public UITableViewCellPerson () : base()
		{
			this.Binder += BindPerson;
		}
		
		public UITableViewCellPerson (IntPtr handle) : base(handle)
		{
		}

		// TODO: refactor to be more generic
		public void BindPerson(Person bo_object)
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

