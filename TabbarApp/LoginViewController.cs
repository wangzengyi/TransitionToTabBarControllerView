using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TabbarApp
{
	public partial class LoginViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		UIButton button;
		public event EventHandler loginButtonPressed;

		public LoginViewController ()
			: base ()
		{
			View.BackgroundColor = UIColor.Yellow;

			button = new UIButton (UIButtonType.System);
			button.SetTitle ("Login", UIControlState.Normal);
			button.Frame = new RectangleF (100, 100, 100, 40);

			button.TouchUpInside += delegate(object sender, EventArgs e) {
				var handler = loginButtonPressed;
				if (handler != null)
					handler (this, EventArgs.Empty);
			};



			View.Add (button);
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

