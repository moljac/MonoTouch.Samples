using System;


using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace FileSystem
{
	public class DataManagement
	{
		static string  mydocuments = null;
		static string  personal = null;
		static string  program_files = null;
		static string  programs = null;
		static string  common_program_files = null;
		static string  common_application_data = null;

		static string  application_data = null;
		static string  cookies = null;
		static string  desktop = null;
		static string  desktop_directory = null;
		static string  favorites = null;
		static string  history = null;
		static string  internet_cache = null;
		static string  loacal_application_data = null;
		static string  mycomputer = null;
		static string  mymusic = null;
		static string  mypictures = null;
		static string  myvideos = null;
		static string  recent = null;
		static string  sendto = null;
		static string  start_menu = null;
		static string  startup = null;
		static string  system = null;
		static string  templates = null;



		static DataManagement ()
		{
			application_data = Environment.GetFolderPath (Environment.SpecialFolder.Cookies);
			cookies = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			desktop = Environment.GetFolderPath (Environment.SpecialFolder.DesktopDirectory);
			desktop_directory = Environment.GetFolderPath (Environment.SpecialFolder.Favorites);
			favorites = Environment.GetFolderPath (Environment.SpecialFolder.History);
			history = Environment.GetFolderPath (Environment.SpecialFolder.InternetCache);
			internet_cache = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData);
			loacal_application_data = Environment.GetFolderPath (Environment.SpecialFolder.MyComputer);
			mymusic = Environment.GetFolderPath (Environment.SpecialFolder.MyMusic);
			mypictures = Environment.GetFolderPath (Environment.SpecialFolder.MyPictures);
			myvideos = Environment.GetFolderPath (Environment.SpecialFolder.MyVideos);
			recent = Environment.GetFolderPath (Environment.SpecialFolder.Recent);
			sendto = Environment.GetFolderPath (Environment.SpecialFolder.SendTo);
			start_menu = Environment.GetFolderPath (Environment.SpecialFolder.StartMenu);
			startup = Environment.GetFolderPath (Environment.SpecialFolder.Startup);
			system = Environment.GetFolderPath (Environment.SpecialFolder.System);
			templates = Environment.GetFolderPath (Environment.SpecialFolder.Templates);

			mydocuments = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			personal = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			program_files = Environment.GetFolderPath (Environment.SpecialFolder.ProgramFiles);
			programs = Environment.GetFolderPath (Environment.SpecialFolder.Programs);
			common_program_files = Environment.GetFolderPath (Environment.SpecialFolder.CommonProgramFiles);
			common_application_data = Environment.GetFolderPath (Environment.SpecialFolder.CommonApplicationData);

			///$HOME/Library/Application Support/iPhone Simulator/6.0/Applications/{GUID}/Documents
			Debug.WriteLine("mydocuments             = {0}", mydocuments, "");
			Debug.WriteLine("personal                = {0}", personal, "");

			// Simulator MacOSX:	/Applications
			Debug.WriteLine("program_files           = {0}", program_files, "");
			// Simulator MacOSX:	
			Debug.WriteLine("programs                = {0}", programs, "");
			// Simulator MacOSX:	
			Debug.WriteLine("common_program_files    = {0}", common_program_files, "");
			// Simulator MacOSX:	/usr/share
			Debug.WriteLine("common_application_data = {0}", common_application_data, "");

			Debug.WriteLine("application_data = {0}", application_data, "");
			Debug.WriteLine("cookies = {0}", cookies, "");
			Debug.WriteLine("desktop = {0}", desktop, "");
			Debug.WriteLine("desktop_directory = {0}", desktop_directory, "");
			Debug.WriteLine("favorites = {0}", favorites, "");
			Debug.WriteLine("history = {0}", history, "");
			Debug.WriteLine("internet_cache = {0}", internet_cache, "");
			Debug.WriteLine("loacal_application_data = {0}", loacal_application_data, "");
			Debug.WriteLine("mymusic = {0}", mymusic, "");
			Debug.WriteLine("mypictures = {0}", mypictures, "");
			Debug.WriteLine("myvideos = {0}", myvideos, "");
			Debug.WriteLine("recent = {0}", recent, "");
			Debug.WriteLine("sendto = {0}", sendto, "");
			Debug.WriteLine("start_menu = {0}", start_menu, "");
			Debug.WriteLine("startup = {0}", startup, "");
			Debug.WriteLine("system = {0}", system, "");
			Debug.WriteLine("startup = {0}", startup, "");
			Debug.WriteLine("templates = {0}", templates, "");

		}
	
		public static void Settings(string settings_file)
		{
			string text = File.ReadAllText("DataManagement.txt");

			Console.WriteLine(text);

			string documents1 =
				Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var filename = Path.Combine (documents1, "Write.txt");
			File.WriteAllText(filename, "Write this text into a file");





			string documents2 =
				Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents2, "NewDirectory");
			Directory.CreateDirectory(directoryname);


			return;
		}
		public static bool Copy (string source, string target)
		{
			bool copied = true;
			
			return copied;
		}

		/// <summary>
		/// Copies with forcing overwrite
		/// </summary>
		/// <returns>
		/// <c>true</c>, if forced was copyed, <c>false</c> otherwise.
		/// </returns>
		/// <param name='source'>
		/// Source.
		/// </param>
		/// <param name='target'>
		/// Target.
		/// </param>
		public static bool CopyForced (string source, string target)
		{
			bool copied = true;

			return copied;
		}

		public static bool Move(string source, string target)
		{
			bool moved = true;

			IEnumerable<string> directories = Directory.EnumerateDirectories("./");
			foreach (var directory in directories) 
			{
				Console.WriteLine(directory);
			}
	
			return moved;
		}
	}


}
	