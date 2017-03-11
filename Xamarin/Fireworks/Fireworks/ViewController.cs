using System;

using UIKit;

namespace Fireworks
{
	public partial class ViewController : UIViewController
	{


		partial void sliderValueChanged(UISlider sender)
		{
			//throw new NotImplementedException();
			labelResult.Text = sliderControl.Value.ToString();
		}

		partial void switchValueChanged(UISwitch sender)
		{
			//throw new NotImplementedException();
			if (switchControl.On)
			{
				this.View.BackgroundColor = UIColor.FromRGB(25, 25, 112);
			}
			else
			{
				this.View.BackgroundColor = UIColor.White;

			}
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			buttonControl.TouchUpInside += (sender, e) =>
			{
				labelResult.Text = "button clicked";
			};

			buttonAbout.TouchUpInside += (sender, e) =>
			{
				var storyboard = this.Storyboard;
				var aboutViewController = (AboutViewController)
					storyboard.InstantiateViewController("AboutViewController");
				this.PresentViewController(aboutViewController, true, null);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
