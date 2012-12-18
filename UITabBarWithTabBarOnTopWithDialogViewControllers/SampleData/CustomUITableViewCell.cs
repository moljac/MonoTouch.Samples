
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers
{
	/// <summary>
	/// Custom user interface table view cell.
	/// Steps:
	/// 		1. Add UIViewConotrller (XIB)
	///			2. Change inherotance from UIViewController to UITableViewCell
	///			3. Remove functions for UIViewController
	///				1. public override void DidReceiveMemoryWarning ()
	///				2. public override void ViewDidLoad ()
	///				3. public override void ViewDidUnload ()
	/// 			4. public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
	///			4. Constructor default
	///					modify - not to load XIB base(string), but calls base()
	///			5. Constructor add (IntPtr)
	///			6. Interface Builder
	///				1. remove UIView default one (click on IB and press delete) raster appears
	///				2. add UITableViewCell
	///				3. Identity Inspector +/ for selected cell 
	///							+/ Custom class = Name of class (CustomUITableViewCell)
	///							class can be generic
	///				4. Attribute Inspector
	///						Style = Custom
	///						identity = Some string (Class name is OK) 
	///									(this is used for memory mngmnt - cell reuse)
	///				3. Objects and Placeholders +/ File's Owner = UITableView  
	/// </summary>
	public partial class CustomUITableViewCell 
			: 
			//UIViewController //not needed
			UITableViewCell
	{
		public CustomUITableViewCell () : base ()//("CustomUITableViewCell", null)
		{
		}

		// Added
		public CustomUITableViewCell (IntPtr handle) : base (handle)
		{
		}
		/*		
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
			return true;
		}
		*/
	}
}

