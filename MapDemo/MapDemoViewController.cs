
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;

namespace MapDemo
{
	public partial class MapDemoViewController : UIViewController
	{

		public MapDemoViewController () : base ("MapDemoViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			//change map type and show user location
			//mapView.MapType = MonoTouch.MapKit.MKMapType.Hybrid;
			mapView.ShowsUserLocation = true;

			//set map center and region
			double lat = 45.8149;
			double lon = 15.9785;
			var mapCenter = new CLLocationCoordinate2D (lat,lon);
			var mapRegion = MKCoordinateRegion.FromDistance (mapCenter, 2000, 2000);
			mapView.CenterCoordinate = mapCenter;
			mapView.Region = mapRegion;


			//set the map delegate -> callback
			//mapView will call this when something needs to be done (extras ...)
			MapViewDelegate mvd = new MapViewDelegate();
			mapView.Delegate = mvd;

			//It's important that the map delegate is created before annotations!!
			//add an annotation MKPointAnnotation -> basic class
			mapView.AddAnnotation (new MKPointAnnotation (){Title="MyAnnotation",Coordinate = new CLLocationCoordinate2D(45.8100,15.9760)});
			//add an annotation MyCustomAnnotation -> custom class
			mapView.AddAnnotation (new MyCustomAnnotation("HolisticWare","www.holisticware.com",new CLLocationCoordinate2D(45.8090,15.9710)));

			//add an overlay
			var circleOverlay = MKCircle.Circle (mapCenter, 1000);
			mapView.AddOverlay (circleOverlay);

		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}

	public class MapViewDelegate : MKMapViewDelegate
	{
		//strings for dequeueing (DequeueReusableAnnotation)
		string pinID = "MyCustomAnnotation";
		string pinGeneric = "PinAnnotation";

		public MapViewDelegate ():base()
		{
		}

		public override MKAnnotationView GetViewForAnnotation (MKMapView mapView, NSObject annotation)
		{
			MKAnnotationView anView;

			if (annotation is MKUserLocation)
				return null;

			//modifications for MyCustomAnnotations
			if (annotation is MyCustomAnnotation) 
			{
				anView = (MKPinAnnotationView)mapView.DequeueReusableAnnotation (pinID);
				
				if(anView == null)
					anView = new MKPinAnnotationView (annotation,pinID);
				
				anView.CanShowCallout = true;
				anView.Draggable = true;
				((MKPinAnnotationView)anView).PinColor = MKPinAnnotationColor.Red;

				anView.RightCalloutAccessoryView = UIButton.FromType (UIButtonType.DetailDisclosure);

			}
			//modifications for MKPointAnnotation
			else 
			{
				anView = (MKPinAnnotationView)mapView.DequeueReusableAnnotation (pinGeneric);

				if(anView == null)
					anView = new MKPinAnnotationView (annotation,pinGeneric);

				anView.CanShowCallout = true;
				((MKPinAnnotationView)anView).PinColor = MKPinAnnotationColor.Green;

			}

			return anView;
		}
		//annotation callout accessory
		public override void CalloutAccessoryControlTapped (MKMapView mapView, MKAnnotationView view, UIControl control)
		{
			var myCustomAnnotation = view.Annotation as MyCustomAnnotation;

			if (myCustomAnnotation != null) 
			{
				var alert = new UIAlertView ("My Custom Annotation",myCustomAnnotation.Title,null,"OK");
				alert.Show();
			}
		}

		public override MKOverlayView GetViewForOverlay (MKMapView mapView, NSObject overlay)
		{
			var circleOverlay = overlay as MKCircle;
			var circleView = new MKCircleView(circleOverlay);

			circleView.FillColor = UIColor.Red;
			circleView.Alpha = 0.4f;

			return circleView;
		}

	}
}

























































































