// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace UIViewModalPresentationWithDVC
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnLoad { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnRemove { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnModalPresentation { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnLoad != null) {
				btnLoad.Dispose ();
				btnLoad = null;
			}

			if (btnRemove != null) {
				btnRemove.Dispose ();
				btnRemove = null;
			}

			if (btnModalPresentation != null) {
				btnModalPresentation.Dispose ();
				btnModalPresentation = null;
			}
		}
	}
}
