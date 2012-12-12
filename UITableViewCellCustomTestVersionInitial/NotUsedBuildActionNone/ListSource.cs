using System;


using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace UITableViewCellCustomTestVersionInitial
{
	public class ListSource : UITableViewSource
	{
		private List<string> _testData = new List<string> ();

		public ListSource ()
		{

			_testData.Add ("Green");
			_testData.Add ("Red");
			_testData.Add ("Blue");
			_testData.Add ("Yellow");
			_testData.Add ("Purple");
			_testData.Add ("Orange");   

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
		
			// Reuse a cell if one exists
			UITableViewCellCustomForList cell = tableView.DequeueReusableCell ("ColorCell") as UITableViewCellCustomForList;
			
			if (cell == null) {   
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("CustomListCell", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as UITableViewCellCustomForList;
			}
			
			// This cell has been used before, so we need to update it's data
			cell.UpdateWithData
					(
					  "name" + DateTime.Now.Millisecond.ToString()
					 , DateTime.Now 
					);   
			
			return cell;
		
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			return _testData.Count;
		}
	}
}

