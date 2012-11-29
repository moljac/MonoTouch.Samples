using System;


using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MonoMobile.Dialog
{
	public class UITableViewSourceForListOfSamples : UITableViewSource
	{
		private List<string> _testData = new List<string> ();

		public UITableViewSourceForListOfSamples ()
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
			UITableViewCellCustom cell = tableView.DequeueReusableCell ("ColorCell") as UITableViewCellCustom;
			
			if (cell == null) {   
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("UITableViewCellCustom", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as UITableViewCellCustom;
			}
			
			// This cell has been used before, so we need to update it's data
			cell.UpdateWithData (_testData [indexPath.Row]);   
			
			return cell;
		
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			return _testData.Count;
		}
	}
}

