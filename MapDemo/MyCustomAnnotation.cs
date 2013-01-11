
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;

namespace MapDemo
{
	//Basic map annotation with annotation update ability
	public class MyCustomAnnotation : MKAnnotation
	{
		string title,subtitle;
		CLLocationCoordinate2D coord;
		
		public MyCustomAnnotation (string title,string subtitle,CLLocationCoordinate2D coord)
		{
			this.title = title;
			this.subtitle = subtitle;
			this.coord = coord;
		}
		
		public override string Title 
		{
			get 
			{
				return title;
			}
		}
		
		public override string Subtitle 
		{
			get 
			{
				return subtitle;
			}
		}
		
		
		public override  CLLocationCoordinate2D Coordinate 
		{
			get 
			{
				return coord;
			}
			set 
			{

				//annotation update ability based on KVO (key-value observing)
				//http://forums.xamarin.com/discussion/64/updating-mapview-annotations
				
				WillChangeValue ("coordinate");
				coord = value;
				DidChangeValue ("coordinate");
			}
		}
	}
}

