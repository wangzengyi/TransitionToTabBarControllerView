using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TabbarApp
{
	public partial class RootViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		LoginViewController loginViewController;
		DeviceViewController deviceViewController;
		TabbbarController tabbarController;

		public RootViewController ()
			: base ()
		{
			loginViewController = new LoginViewController ();
			deviceViewController = new DeviceViewController ();
			tabbarController = new TabbbarController ();

			loginViewController.loginButtonPressed += (object sender, EventArgs e) => {
				DismissViewController(true, delegate() {
					PresentViewController(deviceViewController, true, null);
				});
			};

			deviceViewController.deviceButtonPressed += (object sender, EventArgs e) => {
				DismissViewController(true, delegate() {
					PresentViewController(tabbarController, true, null);
				});
			};
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
			NSTimer.CreateScheduledTimer (0.1, delegate {
				PresentViewController (loginViewController, true, null);
			});


		}
	}
}

