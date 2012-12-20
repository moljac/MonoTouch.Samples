using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;
using MonoTouch.ObjCRuntime;

namespace CustomCell
{
	public class ListSource : UITableViewSource
	{
		private List<string> tableData = new List<string> ();
		
		public ListSource ()
		{
			//ADDING DATA TO List OF STRINGS
			tableData.Add ("Technology");
			tableData.Add ("Biology");
			tableData.Add ("Science");
			tableData.Add ("Teleportation");
			tableData.Add ("Multiverse");
			tableData.Add ("Peace");   
		}
		
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			// Reuse a cell if one exists
			CustomListCell cell = tableView.DequeueReusableCell ("CustomCellIdentifier") as CustomListCell;
			
			if (cell == null) {   
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("CustomListCell", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as CustomListCell;
			}
			
			// This cell has been used before, so we need to update it's data
			cell.UpdateWithData (tableData [indexPath.Row]); 
			cell.CellStyle();

			return cell;
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableData.Count;
		}
	}
}

