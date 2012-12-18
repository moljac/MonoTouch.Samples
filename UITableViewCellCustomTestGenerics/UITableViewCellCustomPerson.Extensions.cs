using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MonoTouch.UIKit;
using System.Drawing;

using MonoMobile.Dialog;
using UITableViewCellCustomTestGenerics.SampleUsages;


namespace UITableViewCellCustomTestGenerics
{
	public static class UITableViewCellCustomPersonExtensions
	{
		public static void DataBind(this UITableViewCellCustomGeneric<Person> tcp, Person p)
		{
			return;
		}

		public static void DataBind(this UITableViewCellCustomPerson tcp, Person p)
		{
			//  MonoTouch + MonoDevelop generate non-public fields Outlets (Controls)
			// in *.designer.cs file, so without modification we cannot access fields.
			// Abandoned!

			// tcp.labelNameLast.Text = p.NameFirst;
			// tcp.labelNameLast.Text = p.NameLast;

			return;
		}
		
		
		//CUSTOM CELL
		public static UIView UIViewFactory()
		{
			UIView uiview_xibless = new UIView();
			uiview_xibless.Frame = new RectangleF(0,0,768,44);
			
			UIButton btnDelete;
			UILabel lblName;
			UILabel lblDate;
			
			btnDelete = UIButton.FromType(UIButtonType.Custom);
			btnDelete.Frame = new RectangleF(7,8,103,27);
			
			//UIControlState = Normal -> default system state for iOS element
			//UIControlState = Highlighted -> Highlighted state of a control. 
			//								A control enters this state when a touch enters and exits 
			//								during tracking and when there is a touch up event.
			btnDelete.SetTitleColor(UIColor.Blue,UIControlState.Normal);
			btnDelete.SetTitleColor(UIColor.Red,UIControlState.Highlighted);
			
			btnDelete.SetTitle("Delete", UIControlState.Normal);
			btnDelete.TouchUpInside += (object sender, EventArgs e) => 
			{
				
			};
			lblName = new UILabel(new RectangleF(140,11,489,21));
			lblDate = new UILabel(new RectangleF(583,11,165,21));
			
			lblName.Text = "Name";
			lblDate.Text = DateTime.Now.ToString();
			
			UIView [] views = 
			{
				btnDelete,
				lblName,
				lblDate
			};
			
			uiview_xibless.AddSubviews(views);
			
			return uiview_xibless;
		}
	}
}
