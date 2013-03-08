
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using System.Drawing;

namespace HideKeyboard
{
	public partial class MainView : DialogViewController
	{
		//For notification
		NSObject observer1, observer2;

		public MainView () : base (UITableViewStyle.Grouped, null,true)
		{
			string footer = "After the keyboard is loaded, red transparent UIView will be loaded on top of the keyboard. Click on that view to dismiss keyboard.";

			EntryElement entryElement = new EntryElement ("HTTP","www.holisticware.net",string.Empty);
			EntryElement entryElement1 = new EntryElement ("CEO","Miljenko Cvjetko",string.Empty);
			EntryElement entryElement2 = new EntryElement ("DEV","Ivan Dikic",string.Empty);
			StringElement stringElement3 = new StringElement ("ALERT");

			stringElement3.Alignment = UITextAlignment.Center;


			stringElement3.Tapped += () => 
			{
				new UIAlertView("HIDE KEYBOARD","WWW.HOLSITICWARE.NET",null,"CANCEL",null).Show();
			};


			Root = new RootElement ("HolisticWare") 
			{
				new Section ("Hide Keyboard Sample")
				{
					entryElement,
					entryElement1,
					entryElement2,
					stringElement3,
				},
				new Section("",footer)
				{

				}
			};


			//Observing Keyboard notifications------------------------------------------------------------------------------------------------
			float keyboardHeight;
			UIView dismissalView = null;

			//WillShow
			observer1 = NSNotificationCenter
				.DefaultCenter
					.AddObserver
					(
						UIKeyboard.WillShowNotification
						,delegate(NSNotification notification) 
						{
							RectangleF frame;
							if(notification != null)
							{
								RectangleF kbdRect = UIKeyboard.FrameEndFromNotification(notification);
								//double animationDuration = UIKeyboard.AnimationDurationFromNotification(notification);
								
								if(notification.Name == UIKeyboard.WillShowNotification || notification.Name == UIKeyboard.DidShowNotification)
								{
						
									//UIView firstResponder = UIApplication.SharedApplication.KeyWindow;

									foreach (UIWindow keyboardWindow in UIApplication.SharedApplication.Windows) 
									{
										foreach(UIView keyboard in keyboardWindow.Subviews)
										{
											if(keyboard.Description.Contains("UILayoutContainerView"))
											{
												dismissalView = new UIView();
												dismissalView.Frame = new RectangleF(0, 0, keyboard.Frame.Size.Width, keyboard.Frame.Size.Height - kbdRect.Height);
												
												
												dismissalView.BackgroundColor = UIColor.Red;
												dismissalView.Alpha = 0.5f;
												
												//Gesture recognizer for handling EndEditing of Elements
												var tap = new UITapGestureRecognizer ();
												tap.AddTarget (() =>{ this.TableView.EndEditing(true); });
												
												dismissalView.AddGestureRecognizer (tap);
												
												keyboard.AddSubview(dismissalView);
												
												System.Console.WriteLine(keyboard.Description);
											}
											
										}
									}

								} 
								
							} 
						}
					);

			//WillHide
			observer2 = NSNotificationCenter
				.DefaultCenter
					.AddObserver
					(
						UIKeyboard.WillHideNotification
						,delegate(NSNotification notification) 
						{
							RectangleF frame;
							if(notification != null)
							{
								RectangleF kbdRect = UIKeyboard.FrameEndFromNotification(notification);
								//double animationDuration = UIKeyboard.AnimationDurationFromNotification(notification);
								
								if(notification.Name == UIKeyboard.WillHideNotification)
								{
									foreach (UIWindow keyboardWindow in UIApplication.SharedApplication.Windows) 
									{
										foreach(UIView keyboard in keyboardWindow.Subviews)
										{
											if(keyboard.Description.Contains("UIPeripheralHostView"))
											{
												if(dismissalView != null)
												{
													dismissalView.RemoveFromSuperview();
													dismissalView = null;
													
												}
												
												System.Console.WriteLine(keyboard.Description);
											}

										}
									}
									
								} 
							} 
						}
					);
	
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();

			//Unregistering observers - not sure if this is needed anymore
			NSNotificationCenter.DefaultCenter.RemoveObserver(observer1);
			NSNotificationCenter.DefaultCenter.RemoveObserver(observer1);
		}
	}
}


/* 
 * 	//Solutions bellow are the ones that I found on the internet, so credit goes to the original
 * 	//creators. If You happen to be one of them, contact me so that I can give credit to You!
 *  
 *  //Solution 1
 	public override UIView InputAccessoryView 
	{
		get 
		{
			UIView dismiss = new UIView(new RectangleF(0,0,320,27));
			dismiss.BackgroundColor = UIColor.FromPatternImage(new UIImage("Images/accessoryBG.png"));          
			UIButton dismissBtn = new UIButton(new RectangleF(255, 2, 58, 23));
			dismissBtn.SetBackgroundImage(new UIImage("Images/dismissKeyboard.png"), UIControlState.Normal);        
			dismissBtn.TouchDown += delegate 
			{
				subjectField.ResignFirstResponder();
			};
			
			dismiss.AddSubview(dismissBtn);

			return dismiss;
		}
	}
	
 *	//Solution 2
	this.TableView.DraggingStarted += (object sender, EventArgs e) => 
	{
		stringElement.ResignFirstResponder(true);

	};

 * 	//Solution 3
  	stringElement.ReturnKeyType = UIReturnKeyType.Done;
	stringElement.ShouldReturn += () =>
	{
 		stringElement.ResignFirstResponder(true);
 		return true;
	};
 * 
 * 	//Solution 4 - by Miguel DeIcaza
 	var tap = new UITapGestureRecognizer ();
	tap.AddTarget (() =>{ this.TableView.EndEditing(true); });
	
	dismissalView.AddGestureRecognizer (tap);
 *	 
 * 
 * 
 * 	//Problems: 
 * 	//
 * 	//SOLUTION 4:
 * 	//UITapGestureRecognizer will block all other taps, so you cant have UIAlertView
 * 	//or picker element.
 *	// 
 *	//SOLUTION 2:
 *	//DraggingStarted also blocks tap input gesture 
 * 
 * 
 * 
 * 
 * 
 */ 


