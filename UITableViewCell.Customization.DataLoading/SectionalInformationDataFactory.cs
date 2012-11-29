using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UITabBarControllerWithTabContainingDialogViewController
{
	public partial class SectionalInformationDataFactory
	{
		public static List<string> Sample = new List<string>()
		{
			"Albuquerque", 
			"Atlanta",
			"Billings",
			"Brownsville",
			"Charlotte",
			"Cheyenne",
			"Chicago",
			"Cincinnati",
			"Dallas-Ft_Worth",
			"Denver",
			"Detroit",
			"El_Paso",
			"Great_Falls",
			"Green_Bay",
			"Halifax",
			"Houston",
			"Jacksonville",
			"Kansas_City",
			"Klamath_Falls",
			"Lake_Huron",
			"Las_Vegas",
			"Los_Angeles",
			"Memphis",
			"Miami",
			"Montreal",
			"New_Orleans",
			"New_York",
			"Omaha",
			"Phoenix",
			"Salt_Lake_City",
			"San_Antonio",
			"San_Francisco",
			"Seattle",
			"St_Louis",
			"Twin_Cities",
			"Washington",
			"Wichita"
		};

		public static List<SectionalInformation> SectionalInformation()
		{
			List<SectionalInformation> si =
					(
					from d in Sample
					select
						new SectionalInformation()
						{
						  Name = d
						, Delete = true
						, Elapsed = new TimeSpan(23,54,22)
						}
					).ToList();

			return si;
		}
	}
}
