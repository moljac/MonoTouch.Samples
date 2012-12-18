
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.Dialog;
using MonoMobile.Dialog;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers.SampleUsages
{
	public partial class Person
	{
	
		string name_last;
		public string NameLast {
			get {
				return name_last;
			}
			set {
				name_last = value;
			}
		}
		
		string name_first;
		public string NameFirst {
			get {
				return name_first;
			}
			set {
				name_first = value;
			}
		}
		
		DateTime date_of_birth;
		public DateTime DateOfBirth {
			get {
				return date_of_birth;
			}
			set {
				date_of_birth = value;
			}
		}
	}

}
