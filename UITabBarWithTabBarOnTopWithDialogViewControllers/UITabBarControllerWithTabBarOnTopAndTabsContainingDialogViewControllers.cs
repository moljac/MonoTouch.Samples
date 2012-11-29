using System;
using MonoTouch.UIKit;


using MonoTouch.Dialog;
using System.Collections.Generic;

namespace TabBarOnTopDVC 
{
	public class UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers : UITabBarController 
	{
		//CUSTOM TAB BAR
		static readonly float TAB_BAR_HEIGHT = 44;
		System.Drawing.RectangleF rect;

		DialogViewController tab1;
		DialogViewController tab2;
		DialogViewController tab3;
		DialogViewController tab4;
		DialogViewController tab5;
		DialogViewController tab6;
		DialogViewController tab7;
		DialogViewController tab8;

		RootElement re1 = new RootElement("re1");
		RootElement re2 = new RootElement("re2");
		RootElement re3 = new RootElement("re3");
		RootElement re4 = new RootElement("re4");
		RootElement re5 = new RootElement("re5");
		RootElement re6 = new RootElement("re6");
		RootElement re7 = new RootElement("re7");
		RootElement re8 = new RootElement("re8");

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
			
			tab1 = new DialogViewController(re1);
			tab1.Title = "Sectionals";

			tab2 = new DialogViewController(re2);
			tab2.Title = "Sectionals AK";

			tab3 = new DialogViewController(re3);
			tab3.Title = "Plates";

			tab4 = new DialogViewController(re4);
			tab4.Title = "Apt Diagrams";

			tab5 = new DialogViewController(re5);
			tab5.Title = "Low Enroute";

			tab6 = new DialogViewController(re6);
			tab6.Title = "TAC";

			tab7 = new DialogViewController(re7);
			tab7.Title = "WAC";

			tab8 = new DialogViewController(re8);
			tab8.Title = "Databases";


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
			, tab5
			, tab6
			, tab7
			, tab8
			};
			
			ViewControllers = tabs;
			
			SelectedViewController = tab3; // normally you would default to the left-most tab (ie. tab1)
		}
	}
}


