using System;

using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;


namespace MonoMobile.Dialog
{
	public partial class 
		ElementDerivedCustom<UITableViewCellType, BusinessObjectType> 
		:
		MonoTouch.Dialog.Element
		//MonoMobile.Dialog.Element
		where 
			UITableViewCellType 
			: 
			// UIView OK but need more strict
			// MonoTouch.UIKit.UITableViewCell
			// event stricter - use our custom cell which has Update Function
			MonoMobile.Dialog.UITableViewCellCustom<BusinessObjectType>
			// TODO: investigate if UIView could be instead of UITableViewCell
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

		UITableViewCellCustom<BusinessObjectType> cell_custom;
		public UITableViewCellCustom<BusinessObjectType> CellCustom
		{
			get {
				return cell_custom;
			}
			set {
				cell_custom = value;
			}
		}
		
		
		/// <summary>
		/// The business_object_type.
		///  BO logic type = Tag in WindowsFoms or similar! "Kinda databinding"
		/// </summary>
		BusinessObjectType business_object_type;
		public BusinessObjectType BusinessObject
		{
			get {
				return business_object_type;
			}
			set {
				business_object_type = value;
			}
		}
		
		public override UITableViewCell GetCell (UITableView tv)
		{
			// TODO: Implement - see: http://go-mono.com/docs/index.aspx?link=T%3aMonoTouch.Foundation.ModelAttribute
			
			// Reuse a cell if one exists
			// 
			// <string key="IBUIReuseIdentifier">UITableViewCellCustom</string>
			NSString memory_identifier = new NSString("UITableViewCellCustom");
			cell_custom = tv.DequeueReusableCell(memory_identifier) as UITableViewCellType;

			if (CellCustom == null) 
			{   
				if ("" == file_name_xib || null == file_name_xib ) 
				{
					CellCustom = this.CellFromXib ("UITableViewCellPerson", tv)
										as UITableViewCellType;
				} 
				else 
				{			
					CellCustom = this.CellFromXib (file_name_xib, tv)
										as UITableViewCellType;
				}
			}

			// This cell has been used before, so we need to update it's data
			CellCustom.DataBind(business_object_type);
			
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

