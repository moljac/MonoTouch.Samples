using System;
using MonoTouch.UIKit;


using System.Collections.Generic;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;


using UITabBarWithTabBarOnTopWithDialogViewControllers.SampleUsages;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers 
{
	public partial class UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers
	{
		Section SectionGenericSampleFactory ()
		{
			ElementCustomGeneric<UITableViewCellCustomCar, Car> ec1;
			ec1 = new ElementCustomGeneric<UITableViewCellCustomCar, Car>();

			// Following Cell is loaded from XIB
			ElementCustomGeneric<UITableViewCellCustomPerson, Person> ec2;
			ec2 = new ElementCustomGeneric<UITableViewCellCustomPerson, Person>();
			ec2.FileNameXIB = "UITableViewCellCustomPerson";
			ec2.CellReuseIdentifier = "UITableViewCellCustomPerson";

			// TODO: API brainstorming!
			// ElementCustomGeneric<UITableViewCellCustomPerson, Person> ec3;
			// ec3 = new ElementCustomGeneric<UITableViewCellCustomPerson, Person>();
			// ec3.CellCustom.DataBindMethod += new DataBindDelegate<Person>(CellCustom_DataBindMethod);

			Section s = new Section("Custom Element Generic") 
			{
			  ec1
			, ec2
			};

			return s;
		}
		
	}




	/// <summary>
	/// TODO: Iki can You make manual UI here?
	/// </summary>
	public partial class UITableViewCellCustomCar 
		: MonoMobile.Dialog.UITableViewCellCustomGeneric<Car>
	{
		UILabel labelNameFirst = null;
		UILabel labelNameSecond = null;

		public override void DataBind(Car p)
		{

			return;
		}
	}
}


