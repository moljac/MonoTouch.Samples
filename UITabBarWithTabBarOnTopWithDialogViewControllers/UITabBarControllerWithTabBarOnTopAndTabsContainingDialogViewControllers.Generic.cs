using System;
using MonoTouch.UIKit;


using System.Collections.Generic;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;
using System.Drawing;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers 
{
	public partial class UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers
	{
		Section SectionGenericSampleFactory ()
		{
			ElementCustom ec1 = new ElementCustom () {
				CellReuseIdentifier = "UITableViewCellCustomPerson",
				FileNameXIB = "UITableViewCellCustomPerson"
			};
			ElementCustom ec2 = new ElementCustom ("UITableViewCellCustomPerson", "UITableViewCellCustomPerson");
			ec2.CellReuseIdentifier = "UITableViewCellCustomPerson";
			ec1.CellContentFactory += CellContentFactoryImplementationForPerson;
			Section s = new Section ("Custom Element Non Generic") {
				ec1,
				ec2
			};
			return s;
		}
		
	}
}


