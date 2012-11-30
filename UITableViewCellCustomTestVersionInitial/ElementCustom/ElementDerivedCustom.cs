using System;

using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using TEST.ElementCustom;

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

		UITableViewCellCustom cell_custom;
		public UITableViewCellCustom CellCustom
		{
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
			cell_custom = tv.DequeueReusableCell("UITableViewCellCustomHuzDaBoss") as UITableViewCellCustom;
			
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

		public UITableViewCellCustom CellFromXib (string file_name_xib, UITableView tv)
		{
			// allocate/load a cell from XIB
			NSArray views = NSBundle.MainBundle.LoadNib ("UITableViewCellCustomHuzDaBoss", tv, null);
			UITableViewCellCustom cc;
			cc = Runtime.GetNSObject(views.ValueAt(0)) as UITableViewCellCustom;
			
			return cc;
		}
	}
}

