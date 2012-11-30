using System;

using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MonoMobile.Dialog
{
	public class ElementDerivedCustom : Element
	{
		public ElementDerivedCustom () : base (null)
		{
		}

		public ElementDerivedCustom (string filename_xib) : base (null)
		{
		
		
		}

		string file_name_xib;
		public string FileNameXib {
			get {
				return file_name_xib;
			}
			set {
				file_name_xib = value;
			}
		}
		
		UITableViewCellCustomForList cell_custom;
		public UITableViewCellCustomForList CellCustom {
			get {
				return cell_custom;
			}
			set {
				cell_custom = value;
			}
		}
		
		public override UITableViewCell GetCell (UITableView tv)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			
			// Reuse a cell if one exists
			cell_custom = tv.DequeueReusableCell ("UITableViewCellCustomForList") as UITableViewCellCustomForList;
			
			this.CellFromXib(file_name_xib, tv);
			if (CellCustom == null) 
			{   
				CellCustom = this.CellFromXib(file_name_xib, tv);
			}

			// This cell has been used before, so we need to update it's data
			CellCustom.UpdateWithData
				(
					"name" + DateTime.Now.Millisecond.ToString()
					, DateTime.Now 
				);   
			
			return CellCustom;
			
		}

		public UITableViewCellCustomForList CellFromXib (string file_name_xib, UITableView tv)
		{
			// allocate/load a cell from XIB
			NSArray views = NSBundle.MainBundle.LoadNib ("UITableViewCellCustomForList", tv, null);
			UITableViewCellCustomForList cc;
			cc = Runtime.GetNSObject (views.ValueAt (0)) as UITableViewCellCustomForList;
			
			return cc;
		}
	}
}

