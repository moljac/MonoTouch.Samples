// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace CustomCell
{
	[Register ("CustomListCell")]
	partial class CustomListCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblTotalQToBeAnswered { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblQCurrentlyAnswered { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblOverallRankScore { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblCategoryName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTotalQToBeAnswered != null) {
				lblTotalQToBeAnswered.Dispose ();
				lblTotalQToBeAnswered = null;
			}

			if (lblQCurrentlyAnswered != null) {
				lblQCurrentlyAnswered.Dispose ();
				lblQCurrentlyAnswered = null;
			}

			if (lblOverallRankScore != null) {
				lblOverallRankScore.Dispose ();
				lblOverallRankScore = null;
			}

			if (lblCategoryName != null) {
				lblCategoryName.Dispose ();
				lblCategoryName = null;
			}
		}
	}
}
