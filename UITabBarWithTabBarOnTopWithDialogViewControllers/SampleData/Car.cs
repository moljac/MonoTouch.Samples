
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.Dialog;
using MonoMobile.Dialog;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers.SampleUsages
{
	public partial class Car
	{
		string manufacturer;
		public string Manufacturer {
			get {
				return manufacturer;
			}
			set {
				manufacturer = value;
			}
		}
		
		string model;
		public string Model {
			get {
				return model;
			}
			set {
				model = value;
			}
		}
		
		
		int assembly_year;
		public int AssemblyYear {
			get {
				return assembly_year;
			}
			set {
				assembly_year = value;
			}
		}
	}

}
