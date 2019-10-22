
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BranchXamarinSDK;

namespace BranchIOsSample.Droid
{
	[Activity(Theme = "@style/NoActionBar", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true, Label = "Splash Screen")]

	[IntentFilter(new[] { "android.intent.action.VIEW" },
		Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
		DataScheme = "<ApplicationLink>",
		DataHost = "open")]


	[IntentFilter(new[] { "android.intent.action.VIEW" },
	Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
	DataScheme = "https",
	DataHost = "app_url")]

	public class SplashActivity : Activity, IBranchBUOSessionInterface
	{
		RelativeLayout splashLAyout;
		private static int SPLASH_TIME_OUT = 1000;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SplashScreen);
			splashLAyout = FindViewById<RelativeLayout>(Resource.Id.SplashLayout);
			BranchAndroid.Init(this, "Android_Live_Key", this);
			Handler handler = new Handler();
			handler.PostDelayed(CallMainActivity, SPLASH_TIME_OUT);
		}
		public void CallMainActivity()
		{
			StartActivity(typeof(MainActivity));
		}
		protected override void OnStart()
		{
			base.OnStart();

			BranchAndroid.GetAutoInstance(this);
			Branch branch = Branch.GetInstance();
			branch.InitSession(this);
		}

		public void InitSessionComplete(BranchUniversalObject buo, BranchLinkProperties blp)
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
		protected override void OnNewIntent(Intent intent)
		{
			base.OnNewIntent(intent);
			this.Intent = intent;
		}
	}

}



