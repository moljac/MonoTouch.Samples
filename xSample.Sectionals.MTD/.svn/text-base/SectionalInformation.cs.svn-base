using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xsample.iFly
{
	public partial class SectionalInformation
	{
		//-------------------------------------------------------------------------
		# region Property bool Delete w Event post (DeleteChanged)
		/// <summary>
		/// Delete
		/// </summary>
		public
		  bool
		  Delete
		{
			get
			{
				return delete;
			} // Delete.get
			set
			{
				//if (delete != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(delete) // MultiThread safe				
					{
						delete = value;
						if (null != DeleteChanged)
						{
							DeleteChanged(this, new EventArgs());
						}
					}
				}
			} // Delete.set
		} // Delete

		/// <summary>
		/// private member field for holding Delete data
		/// </summary>
		private
			bool
			delete
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// DeleteChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			DeleteChanged
			;
		# endregion Property bool Delete w Event post (DeleteChanged)
		//-------------------------------------------------------------------------
	
		//-------------------------------------------------------------------------
		# region Property string Name w Event post (NameChanged)
		/// <summary>
		/// Name
		/// </summary>
		public
		  string
		  Name
		{
			get
			{
				return name;
			} // Name.get
			set
			{
				//if (name != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(name) // MultiThread safe				
					{
						name = value;
						if (null != NameChanged)
						{
							NameChanged(this, new EventArgs());
						}
					}
				}
			} // Name.set
		} // Name

		/// <summary>
		/// private member field for holding Name data
		/// </summary>
		private
			string
			name
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// NameChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			NameChanged
			;
		# endregion Property string Name w Event post (NameChanged)
		//-------------------------------------------------------------------------

		//-------------------------------------------------------------------------
		# region Property TimeSpan Elapsed w Event post (ElapsedChanged)
		/// <summary>
		/// Elapsed
		/// </summary>
		public
		  TimeSpan
		  Elapsed
		{
			get
			{
				return elapsed;
			} // Elapsed.get
			set
			{
				//if (elapsed != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(elapsed) // MultiThread safe				
					{
						elapsed = value;
						if (null != ElapsedChanged)
						{
							ElapsedChanged(this, new EventArgs());
						}
					}
				}
			} // Elapsed.set
		} // Elapsed

		/// <summary>
		/// private member field for holding Elapsed data
		/// </summary>
		private
			TimeSpan
			elapsed
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// ElapsedChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			ElapsedChanged
			;
		# endregion Property TimeSpan Elapsed w Event post (ElapsedChanged)
		//-------------------------------------------------------------------------	
	
	}
}
