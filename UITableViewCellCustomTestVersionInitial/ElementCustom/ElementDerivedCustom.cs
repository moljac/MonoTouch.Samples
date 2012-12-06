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

		public ElementDerivedCustom (string fnx) : base (null)
		{		
			file_name_xib = fnx;
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
			cell_custom = tv.DequeueReusableCell ("UITableViewCellCustom") as UITableViewCellCustom;

			if (CellCustom == null) 
			{   
				if ("" == file_name_xib || null == file_name_xib ) 
				{
					CellCustom = this.CellFromXib ("UITableViewCellCustomForList", tv)
										as UITableViewCellCustom;
				} 
				else 
				{			
					CellCustom = this.CellFromXib (file_name_xib, tv)
										as UITableViewCellCustom;
				}
			}

			// This cell has been used before, so we need to update it's data
			// TODO: genricize
			// 		this is not "generic enough"
			// 		needed: 
			//			delegate + event
			//			generc for BusinessObject-Type and UITableViewCell-Type
			// further implementation in UITableViewCellCustomTestVersionInitial
			CellCustom.UpdateWithData
				(
					"name" + DateTime.Now.Millisecond.ToString()
					, DateTime.Now 
				);   
			
			return CellCustom;
			
		}

		public UITableViewCell CellFromXib (string file_name_xib, UITableView tv)
		{
			// allocate/load a cell from XIB
			NSArray views = NSBundle.MainBundle.LoadNib (file_name_xib, tv, null);
			UITableViewCell cc;
			cc = Runtime.GetNSObject(views.ValueAt(0)) as UITableViewCell;
			
			return cc;
		}
	}
}

