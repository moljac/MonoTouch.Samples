using System;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace CustomCell
{
	public class SliderElement : Element 
	{
		static NSString key = new NSString ("CustomCellIdentifier");
		public UISlider slider;

		public SliderElement () : base (null)
		{

		}
		
		public override UITableViewCell GetCell (UITableView tableView)
		{
			// Reuse a cell if one exists
			SliderCell cell = tableView.DequeueReusableCell (key) as SliderCell;

			if (cell == null) 
			{   
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("SliderCell", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as SliderCell;
			}

			slider = cell.GetSlider as UISlider;

			return cell;
		}
	}
}

