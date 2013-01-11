// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace AnimationTesting
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnCrossDissolve { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnCurlDown { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnCurlUp { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnFlipFromBottom { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnFlipFromLeft { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnCoreAnimation { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnFadeInView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnTest { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnCrossDissolve != null) {
				btnCrossDissolve.Dispose ();
				btnCrossDissolve = null;
			}

			if (btnCurlDown != null) {
				btnCurlDown.Dispose ();
				btnCurlDown = null;
			}

			if (btnCurlUp != null) {
				btnCurlUp.Dispose ();
				btnCurlUp = null;
			}

			if (btnFlipFromBottom != null) {
				btnFlipFromBottom.Dispose ();
				btnFlipFromBottom = null;
			}

			if (btnFlipFromLeft != null) {
				btnFlipFromLeft.Dispose ();
				btnFlipFromLeft = null;
			}

			if (btnCoreAnimation != null) {
				btnCoreAnimation.Dispose ();
				btnCoreAnimation = null;
			}

			if (btnFadeInView != null) {
				btnFadeInView.Dispose ();
				btnFadeInView = null;
			}

			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
			}
		}
	}
}
