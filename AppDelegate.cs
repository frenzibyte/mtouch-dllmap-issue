using System;
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
            
            return true;
        }
    }
}


