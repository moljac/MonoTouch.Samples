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
			ElementCustom ec1 = new ElementCustom();
			ElementCustom ec2 = new ElementCustom("UITableViewCellCustomPerson");
			ElementCustom ec3 = new ElementCustom
												(
												  "CustomUITableViewCell"	// XIBname
												, "CustomUITableViewCell"	// cell reuse index
												);

			List<ElementCustom> ecs = new List<ElementCustom>();
			ElementCustom.DefaultFileNameXIB = "UITableViewCellCustomPerson";
			ElementCustom.DefaultCellReuseIdentifier = "UITableViewCellCustomPerson";

			for (int i = 1; i <= 20; i++)
			{
				ElementCustom ec = new ElementCustom();
				if (i == 7)
				{
					ec.FileNameXIB = "CustomUITableViewCell";
					ec.CellReuseIdentifier = "CustomUITableViewCell";
				}
				ecs.Add(ec);
			}

			Section s = new Section("Custom Element from XIB") 
			{
			  ec1
			, ec2
			, ec3
			, ecs.ToArray()
			};

			return s;
		}
		
	}
}


