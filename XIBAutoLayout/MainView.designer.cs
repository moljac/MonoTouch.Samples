// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace XSample.AutoLayout
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnAutoLayout { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnNoAutoLayout { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnAutoLayout != null) {
				btnAutoLayout.Dispose ();
				btnAutoLayout = null;
			}

			if (btnNoAutoLayout != null) {
				btnNoAutoLayout.Dispose ();
				btnNoAutoLayout = null;
			}
		}
	}
}
