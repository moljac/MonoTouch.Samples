using System;
using MonoTouch.UIKit;


using MonoTouch.Dialog;
using System.Collections.Generic;

namespace TabBarOnTopDVC 
{
	public class TabBarController : UITabBarController 
	{
		//CUSTOM TAB BAR
		static readonly float TAB_BAR_HEIGHT = 44;
		System.Drawing.RectangleF rect;

		DVC tabSectionals, tabSectionalsAK, tabPlates, tabAptDiagrams, tabLowEnroute, tabTAC, tabWAC, tabDatabases;
	
		
		
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
			
			tabSectionals = new DVC();
			tabSectionals.Title = "Sectionals";

			tabSectionalsAK = new DVC();
			tabSectionalsAK.Title = "Sectionals AK";

			tabPlates = new DVC();
			tabPlates.Title = "Plates";

			tabAptDiagrams = new DVC();
			tabAptDiagrams.Title = "Apt Diagrams";

			tabLowEnroute = new DVC();
			tabLowEnroute.Title = "Low Enroute";

			tabTAC = new DVC();
			tabTAC.Title = "TAC";

			tabWAC = new DVC();
			tabWAC.Title = "WAC";

			tabDatabases = new DVC();
			tabDatabases.Title = "Databases";


			#region Additional Info
			//			tab1.TabBarItem = new UITabBarItem (UITabBarSystemItem.History, 0); // sets image AND text
			//			tab2.TabBarItem = new UITabBarItem ("Orange", UIImage.FromFile("Images/first.png"), 1);
			//			tab3.TabBarItem = new UITabBarItem ();
			//			tab3.TabBarItem.Image = UIImage.FromFile("Images/second.png");
			//			tab3.TabBarItem.Title = "Rouge"; // this overrides tab3.Title set above
			//			tab3.TabBarItem.BadgeValue = "4";
			//			tab3.TabBarItem.Enabled = false;
			#endregion
			
			var tabs = new DialogViewController[] 
			{
				tabSectionals, tabSectionalsAK, tabPlates, tabAptDiagrams, tabLowEnroute, tabTAC, tabWAC, tabDatabases
			};
			
			ViewControllers = tabs;
			
			SelectedViewController = tabSectionals; // normally you would default to the left-most tab (ie. tab1)
		}
	}
}


