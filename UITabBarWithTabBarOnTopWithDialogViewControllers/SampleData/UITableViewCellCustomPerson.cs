
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoMobile.Dialog;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers.SampleUsages
{
	public partial class UITableViewCellCustomPerson 
			: 
			// UITableViewCell  					// OK
			//UITableViewCellCustom					// OK
			UITableViewCellCustomGeneric<Person>	// OK
	{  

		public UITableViewCellCustomPerson () : base()
		{
			//this.DataBindMethod += BindPerson;
		}
		
		public UITableViewCellCustomPerson (IntPtr handle) : base(handle)
		{
		}

		public void DataBind(object bo_object)
		{
			return;
		}
		
		/// <summary>
		/// Binding method
		/// </summary>
		/// <param name='bo_object'>
		/// Bo_object.
		/// </param>
		public override void DataBind(Person bo_object)
		{
			this.labelNameFirst.Text = bo_object.NameFirst;
			this.labelNameLast.Text = bo_object.NameLast;
			this.labelDateOfBirth.Text = bo_object.DateOfBirth.ToShortDateString();
			
			return;
		}
	}
}

