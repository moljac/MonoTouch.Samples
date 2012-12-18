using System;
using MonoTouch.UIKit;


using System.Collections.Generic;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;
using System.Drawing;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers 
{
	public partial class UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers : UITabBarController 
	{
		//CUSTOM TAB BAR
		static readonly float TAB_BAR_HEIGHT = 44;
		System.Drawing.RectangleF rect;

		DialogViewController tab1;
		DialogViewController tab2;
		DialogViewController tab3;
		DialogViewController tab4;
		
		RootElement re1 = new RootElement("re1");
		RootElement re2 = new RootElement("re2");
		RootElement re3 = new RootElement("re3");
		RootElement re4 = new RootElement("re4");
		
		public UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers()
		{
			//-----------------------CUSTOM TAB BAR-------------------------------------------------
			rect = new System.Drawing.RectangleF(0,0,this.View.Bounds.Size.Width,TAB_BAR_HEIGHT);
			this.TabBar.Frame = rect;
			this.TabBar.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			
			rect = new System.Drawing.RectangleF();
			rect.Location.Y = TAB_BAR_HEIGHT;
			rect.Size.Height = this.View.Bounds.Size.Height - TAB_BAR_HEIGHT;
			
			this.View.Frame = rect;
			this.View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
			//----------------------------------------------------------------------------------------
			
			tab1 = DialogViewControllerWithCustomElementNonGeneric(re1);
			tab1.Title = "Element Custom Non Generic";

			tab2 = DialogViewControllerWithCustomElementGeneric(re2);
			tab2.Title = "Element Custom Generic";

			tab3 = DialogViewControllerWithCustomElementFromXIB(re3);
			tab3.Title = "Element Custom Variations";

			tab4 = DialogViewControllerWithCustomElementManual(re4);
			tab4.Title = "Element Custom Variations";

			#region Additional Info
			//			tab1.TabBarItem = new UITabBarItem (UITabBarSystemItem.History, 0); // sets image AND text
			//			tab2.TabBarItem = new UITabBarItem ("Orange", UIImage.FromFile("Images/first.png"), 1);
			//			tab3.TabBarItem = new UITabBarItem ();
			//			tab3.TabBarItem.Image = UIImage.FromFile("Images/second.png");
			//			tab3.TabBarItem.Title = "Rouge"; // this overrides tab3.Title set above
			//			tab3.TabBarItem.BadgeValue = "4";
			//			tab3.TabBarItem.Enabled = false;
			#endregion

			DialogViewController[] tabs = new DialogViewController[] 
			{
			  tab1
			, tab2
			, tab3
			, tab4
			};
			
			ViewControllers = tabs;
			
			SelectedViewController = tab3; // normally you would default to the left-most tab (ie. tab1)
		}


		DialogViewController DialogViewControllerWithCustomElementNonGeneric (RootElement re)
		{
			Section s = SectionGenericSampleFactory ();
			re.Add(s);
			DialogViewController dvc;
			dvc = new DialogViewController(UITableViewStyle.Grouped, re, false);
			
			return dvc;
		}


		DialogViewController DialogViewControllerWithCustomElementGeneric (RootElement re)
		{
			Section s = SectionNonGenericSampleFactory ();
			re.Add(s);
			DialogViewController dvc;
			dvc = new DialogViewController(UITableViewStyle.Grouped, re, false);
			
			return dvc;
		}
		
		DialogViewController DialogViewControllerWithCustomElementFromXIB (RootElement re)
		{
			Section s = SectionFromXIBSampleFactory ();
			re.Add(s);
			DialogViewController dvc;
			dvc = new DialogViewController(UITableViewStyle.Grouped, re, false);
			
			return dvc;
		}
		
		DialogViewController DialogViewControllerWithCustomElementManual (RootElement re)
		{
			Section s = SectionManualXIBlessSampleFactory ();
			re.Add(s);
			DialogViewController dvc;
			dvc = new DialogViewController(UITableViewStyle.Grouped, re, false);
			
			return dvc;
		}
	}
}


