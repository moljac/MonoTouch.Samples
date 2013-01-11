using System;
using MonoTouch.UIKit;

namespace AnimationTesting
{
	public static class ExtensionMethodUIViewController
	{

		//Allows a UINavigationController to push using a custom animation transition
		public static void PushControllerWithTransition(this UINavigationController 
		                                                target, UIViewController controllerToPush, 
		                                                UIViewAnimationOptions transition)
		{
			UIView.Transition(target.View, 0.75d, transition, delegate() {
				target.PushViewController(controllerToPush, false);
			}, null);
		}
		
		//Allows a UINavigationController to pop a using a custom animation 
		public static void PopControllerWithTransition(this UINavigationController 
		                                               target, UIViewAnimationOptions transition)
		{
			UIView.Transition(target.View, 0.75d, transition, delegate() {
				target.PopViewControllerAnimated(false);
			}, null);         
		}
	}
}

