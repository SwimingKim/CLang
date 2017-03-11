// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Fireworks
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonAbout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sliderControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchControl { get; set; }

        [Action ("sliderValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sliderValueChanged (UIKit.UISlider sender);

        [Action ("switchValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void switchValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (buttonAbout != null) {
                buttonAbout.Dispose ();
                buttonAbout = null;
            }

            if (buttonControl != null) {
                buttonControl.Dispose ();
                buttonControl = null;
            }

            if (labelResult != null) {
                labelResult.Dispose ();
                labelResult = null;
            }

            if (sliderControl != null) {
                sliderControl.Dispose ();
                sliderControl = null;
            }

            if (switchControl != null) {
                switchControl.Dispose ();
                switchControl = null;
            }
        }
    }
}