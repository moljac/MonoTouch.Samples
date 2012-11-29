using System;


using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoMobile.Dialog;

namespace UITableViewCellCustomizationFromXIB
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

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
		
			// Reuse a cell if one exists
			UITableViewCellCustomAlternative cell;
			cell = tableView.DequeueReusableCell ("ColorCell") as UITableViewCellCustomAlternative;
			
			if (cell == null) 
			{   
				// need to allocate a cell
				NSArray views = NSBundle.MainBundle.LoadNib ("UITableViewCellCustom", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as UITableViewCellCustomAlternative;
			}
			
			// This cell has been used before, so we need to update it's data
			// cell.UpdateWithData (_testData [indexPath.Row]);   

			return cell;
		
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			return _testData.Count;
		}
	}
}

