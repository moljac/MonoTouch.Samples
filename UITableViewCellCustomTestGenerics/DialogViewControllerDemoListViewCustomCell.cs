
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

//using MonoTouch.Dialog;
using MonoMobile.Dialog;

using UITableViewCellCustomTestGenerics.SampleUsages;

namespace UITableViewCellCustomTestGenerics
{
	public partial class DialogViewControllerDemoListViewCustomCell 
		: 
		//MonoTouch.Dialog.DialogViewController
		MonoMobile.Dialog.DialogViewController
	{
		public DialogViewControllerDemoListViewCustomCell () : base (UITableViewStyle.Plain, null)
		{
			// Assume all elements of the same type are loaded from the same XIB file
			ElementCustomGeneric<UITableViewCellCustomPerson, Person>
				.DefaultCellReuseIdentifier = "UITableViewCellPerson";
			ElementCustomGeneric<UITableViewCellCustomPerson, Person>
				.DefaultFileNameXIB = "UITableViewCellPerson";
			
			// Defining some element based on Custom Cell and some Business (Domain) object
			ElementCustomGeneric<UITableViewCellCustomPerson, Person> edc1;
			edc1 = new ElementCustomGeneric<UITableViewCellCustomPerson, Person>();
			
			ElementCustomGeneric<UITableViewCellCustomPerson, Person> edc2;
			edc2 = new ElementCustomGeneric<UITableViewCellCustomPerson, Person>()
			{
				// Generic Version of the custom UITableViewCellCustom is made abstract to
				// instruct user to inherit and implement required methods (for databinding)
				//
				// CellCustom = new UITableViewCellCustom<Person>()
				// {
				// 	// intializers only for fields or properties
				// 	// Binder += BindThisCellAndObject
				// }

				CellCustom = new UITableViewCellCustomPerson()
			};
			edc2.CellCustom.DataBindMethod += BindCustomCellAndObject;
			
			ElementCustomGeneric<UITableViewCellCustomPerson, Person> edc3;
			edc3 = new ElementCustomGeneric<UITableViewCellCustomPerson, Person>();
			
			// Define UI
			Root = new RootElement ("MTD") 
			{
				new Section ("First Section"){
					new StringElement 
					(
					  "Hello"
					, () => 
						{
							new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue")
							.Show (); 
						}
					),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section")
				{
					new ElementCustomGeneric<UITableViewCellCustomPerson, Person>()
				  {
				    BusinessObject = new Person()
				    		{
				    		  NameLast = "Mokeee"
				    		, NameFirst = "Mel"
				    		, DateOfBirth = DateTime.Now
				    		}
				  }
				, edc1
						, new ElementCustomGeneric<UITableViewCellCustomPerson, Person>()
					{
						BusinessObject = new Person()
						{
							NameLast = "Ikeeee"
							, NameFirst = "Guru"
							, DateOfBirth = DateTime.Now.Subtract(new TimeSpan(4000,0,0,0,0))
						}
					}
				, edc2
				, edc3

				},
			};
		}
		
		
		// Drawback: custom cell should have controls publicly exposed
		// Abandoned!
		void BindCustomCellAndObject (UITableViewCellCustomGeneric<Person> tcp, Person p)
		{
		    
			return;
		}

	}
}
