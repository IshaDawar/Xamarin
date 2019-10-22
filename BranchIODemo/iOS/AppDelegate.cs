using System;
using System.Collections.Generic;
using System.Linq;
using BranchXamarinSDK;
using Foundation;
using UIKit;

namespace BranchIOsSample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IBranchSessionInterface
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			BranchIOS.Debug = true;
            BranchIOS.Init("iOs_Live_key", options, this);
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		public void InitSessionComplete(Dictionary<string, object> data)
		{

		}

		public void SessionRequestError(BranchError error)
		{
			if (error == null)
			{
				// params are the deep linked params associated with the link that the user clicked -> was re-directed to this app
				// params will be empty if no data found
				// ... insert custom logic here ...
			}
			else
			{
				Console.WriteLine("MyApp :{0}", error.ErrorMessage);
			}
		}
		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			return BranchIOS.getInstance().OpenUrl(url);
		}

		public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler)
		{
			return BranchIOS.getInstance().ContinueUserActivity(userActivity);
		}

		public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
		{
			BranchIOS.getInstance().HandlePushNotification(userInfo);
		}
	}
}
