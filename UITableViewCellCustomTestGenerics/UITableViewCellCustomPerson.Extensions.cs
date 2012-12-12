using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MonoMobile.Dialog;
using UITableViewCellCustomTestGenerics.SampleUsages;

namespace UITableViewCellCustomTestGenerics
{
	public static class UITableViewCellCustomPersonExtensions
	{
		public static void DataBind(this UITableViewCellCustom<Person> tcp, Person p)
		{
			return;
		}

		public static void DataBind(this UITableViewCellCustomPerson tcp, Person p)
		{
			//  MonoTouch + MonoDevelop generate non-public fields Outlets (Controls)
			// in *.designer.cs file, so without modification we cannot access fields.
			// Abandoned!

			// tcp.labelNameLast.Text = p.NameFirst;
			// tcp.labelNameLast.Text = p.NameLast;

			return;
		}
	}
}
