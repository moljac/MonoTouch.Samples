// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MapDemo
{
	[Register ("MapDemoViewController")]
	partial class MapDemoViewController
	{
		[Outlet]
		MonoTouch.MapKit.MKMapView mapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}
		}
	}
}
