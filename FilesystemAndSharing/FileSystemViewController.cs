using System;
using System.Drawing;
using System.Linq;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace FileSystem
{
	/// <summary>
	/// View containing Buttons and TextView to show off the samples
	/// </summary>
	public class FileSystemViewController : UIViewController
	{
		UIButton btnFiles, btnDirectories, btnXml, btnAll, btnWrite, btnDirectory;
		UITextView txtView;

		UIButton btnDirectoryPath;
		UITextField txtFieldPath;
	
		public override void ViewDidLoad ()
		{	
			base.ViewDidLoad ();
			
			// Create the buttons and TextView to run the sample code
			btnFiles = UIButton.FromType(UIButtonType.RoundedRect);
			btnFiles.Frame = new RectangleF(10,10,145,50);
			btnFiles.SetTitle("Open 'ReadMe.txt'", UIControlState.Normal);

			btnDirectories = UIButton.FromType(UIButtonType.RoundedRect);
			btnDirectories.Frame = new RectangleF(10,70,145,50);
			btnDirectories.SetTitle("List Directories", UIControlState.Normal);
			
			btnXml = UIButton.FromType(UIButtonType.RoundedRect);
			btnXml.Frame = new RectangleF(165,10,145,50);
			btnXml.SetTitle("Open 'Test.xml'", UIControlState.Normal);

			btnAll = UIButton.FromType(UIButtonType.RoundedRect);
			btnAll.Frame = new RectangleF(165,70,145,50);
			btnAll.SetTitle("List All", UIControlState.Normal);
			
			btnWrite = UIButton.FromType(UIButtonType.RoundedRect);
			btnWrite.Frame = new RectangleF(10,130,145,50);
			btnWrite.SetTitle("Write File", UIControlState.Normal);

			btnDirectory = UIButton.FromType(UIButtonType.RoundedRect);
			btnDirectory.Frame = new RectangleF(165,130,145,50);
			btnDirectory.SetTitle("Create Directory", UIControlState.Normal);

			btnDirectoryPath = UIButton.FromType(UIButtonType.RoundedRect);
			btnDirectoryPath.Frame = new RectangleF(10,190,145,50);
			btnDirectoryPath.SetTitle("Create DirectoryPath:", UIControlState.Normal);

			txtFieldPath = new UITextField(new RectangleF(165, 190, 290, 50))
			{
			  Hidden = false
			, Placeholder = @"Folder 1[\/]Folder 2[\/]..."
			, BorderStyle = UITextBorderStyle.RoundedRect
			};
			txtFieldPath.Hidden = false;

			txtView = new UITextView(new RectangleF(10, 250, 300, 250));
			txtView.Editable = false;
			txtView.ScrollEnabled = true;
			
			// Wire up the buttons to the SamplCode class methods
			btnFiles.TouchUpInside += (sender, e) => {
				SampleCode.ReadText(txtView);
			};

			btnDirectories.TouchUpInside += (sender, e) => {
				SampleCode.ReadDirectories(txtView);
			};
			
			btnAll.TouchUpInside += (sender, e) => {
				SampleCode.ReadAll(txtView);
			};

			btnXml.TouchUpInside += (sender, e) => {
				SampleCode.ReadXml(txtView);
			};
			
			btnWrite.TouchUpInside += (sender, e) => {
				SampleCode.WriteFile(txtView);
			};

			btnDirectory.TouchUpInside += (sender, e) => {
				SampleCode.CreateDirectory(txtView);
			};
			
			// Add the controls to the view
			this.Add(btnFiles);
			this.Add(btnDirectories);
			this.Add(btnXml);
			this.Add(btnAll);
			this.Add(btnWrite);
			this.Add(btnDirectory);			
			this.Add(btnDirectoryPath);			
			this.Add(txtFieldPath);
			this.Add(txtView);
			
			// Write out this special folder, just for curiousity's sake
			Console.WriteLine("MyDocuments:"+Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));


			DataManagement.Copy("","");

			return;
		}
	}
}