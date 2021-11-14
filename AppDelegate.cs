using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using UIKit;

namespace MtouchDllmapIssue
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // create a new window instance based on the screen size
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.RootViewController = new UIViewController();

            Window.BackgroundColor = UIColor.SystemGreenColor;

            // make the window visible
            Window.MakeKeyAndVisible();
            
            var alert = UIAlertController.Create("From native library", $"The number is: {GetNumber()}", UIAlertControllerStyle.Alert);

            Debug.Assert(Window.RootViewController != null);
            
            Window.RootViewController.PresentViewController(alert, true, null);

            return true;
        }

        [DllImport("mtouch-issue-library")]
        public static extern int GetNumber();
    }
}


