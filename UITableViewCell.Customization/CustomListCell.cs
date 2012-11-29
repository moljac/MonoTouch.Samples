
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoMobile.Dialog
{
	public partial class CustomListCell : UITableViewCell
	{  
		public CustomListCell () : base()
		{
		}
		
		public CustomListCell (IntPtr handle) : base(handle)
		{
		}

		public void UpdateWithData (string text)
		{  
			UIColor textColor = UIColor.Black;
			
			switch (text.ToLower ()) 
			{
			case "green": 
				textColor = UIColor.Green;
				break;
			case "red":
				textColor = UIColor.Red;
				break;
			case "blue": 
				textColor = UIColor.Blue;
				break;
			case "yellow": 
				textColor = UIColor.Yellow;
				break;
			case "purple": 
				textColor = UIColor.Purple;
				break;
			case "orange": 
				textColor = UIColor.Orange;
				break;
			}
			
			testButton.SetTitleColor (textColor, UIControlState.Normal);
		}
		
	}
}

