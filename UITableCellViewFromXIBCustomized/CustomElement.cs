using System;

using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace TEST
{
	public partial class CustomElement<BusinessLogicType, PresentationType> : Element
		where 
			PresentationType 
			: 
			  // UIView OK but need more strict
			  UITableViewCell
	{
		//---------------------------------------------------------------------
		// RefactorStep=01
		// new variables lower in class hierarchy
		public UIView   UIViewCustom = null;
		public NSArray  UIViewsFromXIB = null;
		public NSObject UIViewFromXIB = null;
		//---------------------------------------------------------------------
		// RefactorStep=02
		// make CustomElement generic BusinessLogic + Presentation
		public BusinessLogicType BusinessObject;
		// public UITableViewCell PresentationObjectCell;
		//---------------------------------------------------------------------
		// RefactorStep=03
		// make PresentationObjectCell property
		public UITableViewCell presentation_object_cell;
		public UITableViewCell PresentationObjectCell {
			get 
			{
				if (null == presentation_object_cell)
				{
					// Allocate a cell
					NSArray views = NSBundle.MainBundle.LoadNib (XIBNIBName, ParentTableView, null);
					// TODO: remove XIB stuff
					PresentationObjectCell = Runtime.GetNSObject (views.ValueAt (0)) as UITableViewCell;
				}

				return presentation_object_cell;
			}
			set 
			{
				presentation_object_cell = value;
			}
		}
		public string 			XIBNIBName = "CustomListCell";
		public UITableView	ParentTableView;
		CustomListCell cell;
		//---------------------------------------------------------------------

		public CustomElement () : base (null)
		{
		}


		public delegate void UpdateDataDelegate(UITableViewCell cell);
		public event UpdateDataDelegate UpdateData;

		public override UITableViewCell GetCell (UITableView tv)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute

			ParentTableView = tv;
			// Reuse a cell if one exists
			cell  = ParentTableView.DequeueReusableCell ("CustomListCell") as CustomListCell;
			PresentationObjectCell = ParentTableView.DequeueReusableCell ("CustomListCell");

			if (cell == null) 
			{   
				cell = this.PresentationObjectCell as CustomListCell;

				// Allocate a cell
				// NSArray views = NSBundle.MainBundle.LoadNib ("CustomListCell", tableView, null);
				// cell = Runtime.GetNSObject (views.ValueAt (0)) as CustomListCell;
			}

			// this.SomeDelegateForMapping += ////
			//(this.PresentationObjectCell as CustomListCell).UpdateWithData();

			//			UIViewFromXIB = cell;    // OK NSObject from Runtime.GetNSObject is UIView!
//			if (PresentationObjectCell == null) 
//			{
//				PresentationObjectCell = this.PresentationObjectCell;
//			}
			// PresentationObjectCell = cell;   // OK


			// This cell has been used before, so we need to update it's data
			//cell.UpdateWithData (_testData [indexPath.Row]);   
			
			return 
				// cell					// OK too strongly typed
				PresentationObjectCell	// UITableViewCell
				;
		}
	}
}

