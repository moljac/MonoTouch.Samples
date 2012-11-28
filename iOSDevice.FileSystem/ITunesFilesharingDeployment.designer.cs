// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace iPhone.FileSystem
{
	[Register ("ITunesFilesharingDeployment")]
	partial class ITunesFilesharingDeployment
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonDeploy { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonDeploy != null) {
				buttonDeploy.Dispose ();
				buttonDeploy = null;
			}
		}
	}
}
