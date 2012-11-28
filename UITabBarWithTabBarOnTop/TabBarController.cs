using System;
using MonoTouch.UIKit;



namespace TabBar 
{
	public class TabBarController : UITabBarController 
	{
		//CUSTOM TAB BAR
		static readonly float TAB_BAR_HEIGHT = 44;
		System.Drawing.RectangleF rect;

		UIViewController tab1, tab2, tab3;


		public TabBarController ()
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

			tab1 = new UIViewController();
			tab1.Title = "Green";
			tab1.View.BackgroundColor = UIColor.Green;

			tab2 = new UIViewController();
			tab2.Title = "Orange";
			tab2.View.BackgroundColor = UIColor.Orange;

			tab3 = new UIViewController();
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

			var tabs = new UIViewController[] {
				tab1, tab2, tab3
			};

			ViewControllers = tabs;

			SelectedViewController = tab2; // normally you would default to the left-most tab (ie. tab1)
		}
	}
}

