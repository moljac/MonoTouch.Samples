// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ElementsTesting
{
	[Register ("PickerView")]
	partial class PickerView
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIScrollView scrollView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel MessageLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DragLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtLabel != null) {
				txtLabel.Dispose ();
				txtLabel = null;
			}

			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}

			if (MessageLabel != null) {
				MessageLabel.Dispose ();
				MessageLabel = null;
			}

			if (DragLabel != null) {
				DragLabel.Dispose ();
				DragLabel = null;
			}
		}
	}
}
