// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace AnimationTesting
{
	[Register ("AnimateModalViewController")]
	partial class AnimateModalViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnDismissModal { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnDismissModal != null) {
				btnDismissModal.Dispose ();
				btnDismissModal = null;
			}
		}
	}
}
