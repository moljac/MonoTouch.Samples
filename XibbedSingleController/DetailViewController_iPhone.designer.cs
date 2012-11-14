// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Xample.XibbedSingleController
{
	[Register ("DetailViewController_iPhone")]
	partial class DetailViewController_iPhone
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonTest { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonTest != null) {
				buttonTest.Dispose ();
				buttonTest = null;
			}
		}
	}
}
