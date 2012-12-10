
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITableViewCellCustomTestGenerics.SampleUsages
{
	public partial class UITableViewCellPerson : UITableViewCellCustom<Person>
	{  

		public UITableViewCellPerson () : base()
		{
			//this.DataBindMethod += BindPerson;
		}
		
		public UITableViewCellPerson (IntPtr handle) : base(handle)
		{
		}

		// TODO: refactor to be more generic
		public void BindPerson(UITableViewCellPerson cell, Person bo_object)
		{
		  this.labelNameLast.Text = bo_object.NameFirst;
			this.labelNameLast.Text = bo_object.NameLast;
		}
		
		public virtual void UpdateWithData(Person bo_object)
		{
			this.labelNameLast.Text = bo_object.NameFirst;
			this.labelNameLast.Text = bo_object.NameLast;
		}
		

	}
}

