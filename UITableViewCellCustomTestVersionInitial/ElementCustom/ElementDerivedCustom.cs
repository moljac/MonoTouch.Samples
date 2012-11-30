using System;

using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace TEST
{
	public class ElementDerivedCustom : Element
	{
		public ElementDerivedCustom () : base (null)
		{
		}

		public override UITableViewCell GetCell (UITableView tableView)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			
			// Reuse a cell if one exists
			CustomListCell cell = tableView.DequeueReusableCell ("TabsCell") as CustomListCell;
			
			if (cell == null) 
			{   
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("CustomListCell", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as CustomListCell;
			}

			// This cell has been used before, so we need to update it's data
			cell.UpdateWithData
				(
					"name" + DateTime.Now.Millisecond.ToString()
					, DateTime.Now 
				);   
			
			return cell;
			
		}
	}
}

