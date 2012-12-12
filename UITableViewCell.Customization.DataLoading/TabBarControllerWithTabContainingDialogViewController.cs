using System;
using MonoTouch.UIKit;

using System.Collections.Generic;
using System.Drawing;

using MonoTouch.Dialog;
using UITabBarControllerWithTabContainingDialogViewController.SampleData;

namespace UITabBarControllerWithTabContainingDialogViewController
{
	public class UITabBarControllerWithTabContainingDialogViewController : UITabBarController
	{

		UIViewController tab1, tab2, tab3;

		public UITabBarControllerWithTabContainingDialogViewController ()
		{
			tab1 = new UIViewController ();
			tab1.Title = "Green";
			tab1.View.BackgroundColor = UIColor.Green;

			tab2 = new UIViewController ();
			tab2.Title = "Orange";
			tab2.View.BackgroundColor = UIColor.Orange;

			tab3 = new UIViewController ();
			tab3.Title = "Red";
			tab3.View.BackgroundColor = UIColor.Red;
			
			#region Additional Info
//			tab1.TabBarItem = new UITabBarItem (UITabBarSystemItem.History, 0); // sets image AND text
//			tab2.TabBarItem = new UITabBarItem ("Orange", UIImage.FromFile("Images/first.png"), 1);
//			tab3.TabBarItem = new UITabBarItem ();
//			tab3.TabBarItem.Image = UIImage.FromFile("Images/second.png");
//			tab3.TabBarItem.Title = "Rouge"; // this overrides tab3.Title set above
//			tab3.TabBarItem.BadgeValue = "4";
//			tab3.TabBarItem.Enabled = false;
			#endregion


			RootElement re4 = new RootElement ("");
			re4.UnevenRows = true;

			Section re4_sec = new Section("");
			re4.Add(re4_sec);
			DialogViewController tab4 = new DialogViewController (UITableViewStyle.Plain, re4);
			tab4.Title = "DialogViewController";

			// Sample Data
			List<SectionalInformation> list_si;
			list_si = SectionalInformationDataFactory.SectionalInformation (); 

			foreach (SectionalInformation si  in list_si)
			{
				StyledStringElement sse = new StyledStringElement(si.Name, si.Elapsed.ToString());

				re4_sec.Add(sse);
			}

			var tabs = new UIViewController[] {
				tab4, tab1, tab2, tab3
			};

			ViewControllers = tabs;

			SelectedViewController = tab4; // normally you would default to the left-most tab (ie. tab1)
		}
	}
}

