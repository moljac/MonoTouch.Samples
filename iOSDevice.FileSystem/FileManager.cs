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
					, "SampleSubFolder"
					);
				// Path.Combine  // OK
				//(
				//  ".."
				//, "Documents"
				//, "SampleSubFolder"
				//);
			
			if (! Directory.Exists (DirectoryDestination))
			{
				Directory.CreateDirectory(DirectoryDestination);
			}

			return;
		}

		/// <summary>
		/// Textual file defining deploying location of files located flat in iTunes folder
		/// 
		/// To load definition file from iTunse folder (together with content files)
		///		../Documents/filename.txt would load form iTunes folder
		///	To load from package bundle (root in this case):
		///		./SampleSubFolder-ContentStructureFromBundlePackage.txt
		/// </summary>
		/// <param name="content_structure_file"></param>
		public void DeployFromiTunesSharedLibrary(string content_structure_file)
		{
			try
			{
				using (StreamReader sr = new StreamReader(content_structure_file))
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
