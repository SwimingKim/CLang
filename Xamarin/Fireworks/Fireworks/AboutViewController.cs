using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.buttonClose.TouchUpInside += (sender, e) => {
				this.DismissViewController(true, null);
			};
		}
    }
}