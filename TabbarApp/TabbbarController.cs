using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TabbarApp
{
	public partial class TabbbarController : UITabBarController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}



		public TabbbarController ()
			: base ()
		{

			ViewController viewController1 = new ViewController ();
			ViewController viewController2 = new ViewController ();
			ViewController viewController3 = new ViewController ();

			viewController1.View.BackgroundColor = UIColor.Gray;
			viewController2.View.BackgroundColor = UIColor.Red;
			viewController3.View.BackgroundColor = UIColor.Purple;

			viewController1.Title = "A";
			viewController2.Title = "B";
			viewController3.Title = "C";

			ViewControllers = new UIViewController[] {
				viewController1, viewController2, viewController3
			};

			SelectedViewController = viewController1;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

