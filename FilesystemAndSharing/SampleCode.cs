using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using MonoTouch.UIKit;
using System.Diagnostics;

namespace FileSystem
{
	/// <summary>
	/// This class contains the code shown in the article "Working with the File System"
	/// </summary>
	public class SampleCode
	{
		public static void ReadText(UITextView display)
		{
			display.Text = "";

			// Sample code from the article
			var text = System.IO.File.ReadAllText("TestData/ReadMe.txt");
			Console.WriteLine(text);
			
			// Output to app UITextView
			display.Text = text;
		}
		
		public static void ReadDirectories(UITextView display)
		{
			display.Text = "";

			// Sample code from the article
			var directories = Directory.EnumerateDirectories("./");
			foreach (var directory in directories) {
				Console.WriteLine(directory);
			}
			
			// Output to app UITextView
			foreach (var directory in directories) {
				display.Text += directory + Environment.NewLine;
			}
		}

		public static void ReadAll(UITextView display)
		{
			display.Text = "";

			// Sample code from the article
			var fileOrDirectory = Directory.EnumerateFileSystemEntries("./");
			foreach (var entry in fileOrDirectory) {
				Console.WriteLine(entry);
			}
			
			// Output to app UITextView
			foreach (var entry in fileOrDirectory) {
				display.Text += entry + Environment.NewLine;
			}
		}

		public static void ReadXml(UITextView display)
		{
			display.Text = "";

			// Sample code from the article (doesn't output any values)
			using (TextReader reader = new StreamReader("TestData/test.xml")) {
				XmlSerializer serializer = new XmlSerializer(typeof(TestXml));
				var xml = (TestXml)serializer.Deserialize(reader);
			}

			// Output to app UITextView
			using (TextReader reader = new StreamReader("TestData/test.xml")) {
				XmlSerializer serializer = new XmlSerializer(typeof(TestXml));
				var xml = (TestXml)serializer.Deserialize(reader);

				display.Text = "XML was deserialized." + Environment.NewLine
						+ "-----------------" + Environment.NewLine
						+ "Title: " + xml.Title + Environment.NewLine
						+ "Description: " + xml.Description;
			}
		}

		public static void WriteFile(UITextView display)
		{
			string[] paths =  new string[]
			{
			  Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments)
			, "./"
			, "../"			// 
			, "../../"		// OK simlator not on device
			, "../../.."
			, "/" 			// 
			};

			// Sample code from the article
			var documents =
				Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);

			foreach(string p in paths)
			{
				string directory = Path.Combine ("DemoDir");
				string filename = Path.Combine (p,"Write.txt");
				string filename_in_directory = Path.Combine (p, directory, "Write.txt");

				string msg = "";

				try
				{
					File.WriteAllText(filename, "Write this text into a file!");
					msg += 
						"File write OK  = " + filename + Environment.NewLine
							+ "-----------------" + Environment.NewLine
							+ System.IO.File.ReadAllText(filename)
							;
				}
				catch(Exception exc)
				{
					msg += "File write !OK = " + filename;

				}

				Debug.WriteLine(msg);
				display.Text += msg;

				msg = "";
				try
				{
					Directory.CreateDirectory(directory);
					File.WriteAllText(filename_in_directory, "Write this text into a file!");
					msg += 
						"File write OK  = " + filename_in_directory + Environment.NewLine
							+ "-----------------" + Environment.NewLine
							+ System.IO.File.ReadAllText(filename)
							;
				}
				catch(Exception exc)
				{
					msg += "File write !OK = " + filename_in_directory;
					
				}

				Debug.WriteLine(msg);
				display.Text += msg;
			}


			
			// Output to app UITextView
		}

		public static void CreateDirectory(UITextView display)
		{
			// Sample code from the article
			var documents =
				Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
			var directoryname = Path.Combine (documents, "NewDirectory");
			Directory.CreateDirectory(directoryname);

			// Output to app UITextView
			display.Text = "A directory was created." + Environment.NewLine
						+ "-----------------" + Environment.NewLine
						+ directoryname;
		}
	}
}