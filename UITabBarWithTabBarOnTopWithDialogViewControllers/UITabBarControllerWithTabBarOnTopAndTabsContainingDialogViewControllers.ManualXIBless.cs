using System;
using MonoTouch.UIKit;


using System.Collections.Generic;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;
using System.Drawing;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers 
{
	public partial class UITabBarControllerWithTabBarOnTopAndTabsContainingDialogViewControllers
	{
	
		Section SectionManualXIBlessSampleFactory ()
		{
			ElementCustom ec1 = new ElementCustom();
			ec1.CellContentFactory += CellContentFactoryImplementationForPerson1;
			// ec1.CellContentFactory += new SomeClass().SomeMethodThatReturnsUITableViewCell();

			ElementCustom ec2 = new ElementCustom();
			ec2.CellContentFactory += CellContentFactoryImplementationForPerson2;

			Section s = new Section("Custom Element Non Generic") 
			{
			  ec1
			, ec2
			};
			
			return s;
		}

		/// <summary>
		/// Creation of the UITableViewCell which is basic building block oft he
		/// MonoTouch.Dialog. 
		/// This Cell Contains UIView as Subview (UIView is manually generated or from XIB)
		/// </summary>
		/// <returns>
		/// The content factory implementation for person.
		/// </returns>
		public static 
			UITableViewCell CellContentFactoryImplementationForPerson1 ()
		{
			UITableViewCell cc = new UITableViewCell();
			UIView content_view = UIViewFactory();		// wrap UIView
			cc.Bounds = content_view.Bounds;
			cc.AddSubview(content_view);
			
			return cc;			
		}
		
		/// <summary>
		/// Manual UIView creation. This UIView i inserted into UITableViewCell as Subview
		/// </summary>
		/// <returns>
		/// The view factory.
		/// </returns>
		public static 
			UIView UIViewFactory()
		{
			UIView uiview_xibless = new UIView();
			uiview_xibless.Frame = new RectangleF(0, 0, 750, 44);
			
			UIButton btnDelete;
			UILabel lblName;
			UILabel lblDate;
			
			btnDelete = UIButton.FromType(UIButtonType.Custom);
			btnDelete.Frame = new RectangleF(30, 8, 100, 27);
			lblName = new UILabel(new RectangleF(150, 8 + 3, 350, 21));
			lblDate = new UILabel(new RectangleF(500, 8 + 3, 150, 21));
			
			//UIControlState = Normal -> default system state for iOS element
			//UIControlState = Highlighted -> Highlighted state of a control. 
			//								A control enters this state when a touch enters and exits 
			//								during tracking and when there is a touch up event.
			btnDelete.SetTitleColor(UIColor.Blue, UIControlState.Normal);
			btnDelete.SetTitleColor(UIColor.Red, UIControlState.Highlighted);
			
			btnDelete.SetTitle("Delete", UIControlState.Normal);
			btnDelete.TouchUpInside += (object sender, EventArgs e) =>
			{
				
			};
			
			lblName.Text = "Name";
			lblDate.Text = DateTime.Now.ToString();
			
			UIView[] views = 
			{
				btnDelete,
				lblName,
				lblDate
			};
			
			uiview_xibless.AddSubviews(views);
			
			return uiview_xibless;
		}



		public static
			UITableViewCell CellContentFactoryImplementationForPerson2()
		{
			UITableViewCell cc = new UITableViewCell();


			UIView uiview_xibless = new UIView();
			uiview_xibless.Frame = new RectangleF(0, 0, 750, 44);

			UIButton btnDelete;
			UILabel lblName;
			UILabel lblDate;

			btnDelete = UIButton.FromType(UIButtonType.Custom);
			btnDelete.Frame = new RectangleF(30, 8, 100, 27);
			lblName = new UILabel(new RectangleF(150, 8 + 3, 350, 21));
			lblDate = new UILabel(new RectangleF(500, 8 + 3, 150, 21));

			//UIControlState = Normal -> default system state for iOS element
			//UIControlState = Highlighted -> Highlighted state of a control. 
			//								A control enters this state when a touch enters and exits 
			//								during tracking and when there is a touch up event.
			btnDelete.SetTitleColor(UIColor.Green, UIControlState.Normal);
			btnDelete.SetTitleColor(UIColor.Orange, UIControlState.Highlighted);

			btnDelete.SetTitle("Delete", UIControlState.Normal);
			btnDelete.TouchUpInside += (object sender, EventArgs e) =>
			{

			};

			lblName.Text = "Name";
			lblDate.Text = DateTime.Now.ToString();

			UIView[] views = 
			{
				btnDelete,
				lblName,
				lblDate
			};

			uiview_xibless.AddSubviews(views);

			UIView content_view = uiview_xibless;		// wrap UIView
			cc.Bounds = content_view.Bounds;
			cc.AddSubview(content_view);

			return cc;
		}

	}
}


