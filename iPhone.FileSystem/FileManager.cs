using System;
using System.IO;
using System.Diagnostics;

namespace iPhone.FileSystem
{
	public partial class FileManager
	{
		string Content = @"";
		string DirectorySource = string.Empty;
		string DirectoryDestination = string.Empty;
		
		public FileManager ()
		{
			// iTunes shared folder
			DirectorySource = 
				Path.Combine
					(
					  Environment.GetFolderPath(Environment.SpecialFolder.Personal)
					);
			// destination in Documents folder iTunes shred just below!					
			DirectoryDestination = 
				Path.Combine
					(
					  Environment.GetFolderPath(Environment.SpecialFolder.Personal)
					, "SDMMCDisk"
					);
				// Path.Combine  // OK
				//(
				//  ".."
				//, "Documents"
				//, "SDMMCDisk"
				//);
			
			if (! Directory.Exists (DirectoryDestination))
			{
				Directory.CreateDirectory(DirectoryDestination);
			}

			return;
		}

		public void Deploy ()
		{
			try
			{
				string filename = "SDMMCDisk_structure.txt";
				using (StreamReader sr = new StreamReader(filename))
				{
					Content = sr.ReadToEnd ();
					Debug.WriteLine (Content);
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine ("The file could not be read:");
				Debug.WriteLine (e.Message);
			}

			string[] content_lines = Content.Split
													(
				 									  new string[]
														{
														  System.Environment.NewLine
														}
													, StringSplitOptions.RemoveEmptyEntries
			);



			string directory_current = string.Empty;
			string file_destination = string.Empty;
			string file_source = string.Empty;

			
			foreach (string s in content_lines)
			{
				string s_trimmed = s.TrimEnd(new char[]{' ', '\t'});

				Debug.WriteLine("Deploying: {0}", s_trimmed);
				if(s_trimmed.StartsWith("\t"))
				{
					//File
					s_trimmed = s_trimmed.Replace("\t","");
					s_trimmed = s_trimmed.Replace("\r","");

					file_source = Path.Combine
														(
														  DirectorySource
														, s_trimmed
														);
					file_destination = Path.Combine
														(
														  directory_current
														, s_trimmed
														);

					if (! File.Exists(file_source))
					{
						Debug.WriteLine("Deployment File Copy no source: {0}", file_source);
					}
					else
					{
						Debug.WriteLine("Deployment File Copy: {0} => {1}", file_source, file_destination);
						File.Copy(file_source, file_destination, true);
					}
				}
				else if (s_trimmed.EndsWith("\\\r"))
				{
					// Directory/Folder
					s_trimmed = s_trimmed.Replace(@"\",Path.DirectorySeparatorChar.ToString());
					s_trimmed = s_trimmed.Replace(@"/",Path.DirectorySeparatorChar.ToString());
					s_trimmed = s_trimmed.Replace(Environment.NewLine, "");

					directory_current = 
								Path.Combine
											(
											  DirectoryDestination
											, s_trimmed.Replace("\r","")
											);

					if ( ! Directory.Exists(directory_current))
					{
						Debug.WriteLine("Deployment CreateDirectory: {0}", directory_current);
						Directory.CreateDirectory(directory_current);
					}
				}
				else
				{
					Debug.WriteLine("Deployment error: {0}", s_trimmed);
				}
			}
			return;
		}

	}
}
