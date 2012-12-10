
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.Dialog;
using MonoMobile.Dialog;

using UITableViewCellCustomTestGenerics.SampleUsages;

namespace UITableViewCellCustomTestVersionInitial
{
	public partial class DialogViewControllerDemoListViewCustomCell : DialogViewController
	{
		public DialogViewControllerDemoListViewCustomCell () : base (UITableViewStyle.Plain, null)
		{
			// Defining some element based on Custom Cell and some Business (Domain) object
			ElementDerivedCustom<UITableViewCellPerson, Person> edc1;
			edc1 = new ElementDerivedCustom<UITableViewCellPerson, Person>();
			
			ElementDerivedCustom<UITableViewCellPerson, Person> edc2;
			edc2 = new ElementDerivedCustom<UITableViewCellPerson, Person>()
			{
				CellCustom = new UITableViewCellCustom<Person>()
				{
					// intializers only for fields or properties
					// Binder += BindThisCellAndObject
				}
			};
			edc2.CellCustom.DataBindMethod += BindCustomCellAndObject;
			
			ElementDerivedCustom<UITableViewCellPerson, Person> edc3;
			edc3 = new ElementDerivedCustom<UITableViewCellPerson, Person>();
			
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
				  new ElementDerivedCustom<UITableViewCellPerson, Person>()
				  {
				    BusinessObject = new Person()
				    		{
				    		  NameLast = "Mokeee"
				    		, NameFirst = "Mel"
				    		, DateOfBirth = DateTime.Now
				    		}
				  }
				, edc1
				, new ElementDerivedCustom<UITableViewCellPerson, Person>()
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
		void BindCustomCellAndObject (UITableViewCellCustom<Person> tcp, Person p)
		{
		    
			return;
		}
	}
}
