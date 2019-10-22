using System;
using Android.Gms.Analytics;
using Xamarin.Forms;

[assembly: Dependency(typeof(AnalyticsManager.Droid.AnalyticsManager))]
namespace AnalyticsManager.Droid
{
	public class AnalyticsManager: IAnalyticsManager
	{
		private static GoogleAnalytics gaInstance;
		private static Tracker tracker;

		public IAnalyticsManager InitWithId(string analyiticsId)
		{
			gaInstance = GoogleAnalytics.GetInstance(Android.App.Application.Context);
			gaInstance.SetLocalDispatchPeriod(10);
			tracker = gaInstance.NewTracker(analyiticsId);
			tracker.EnableExceptionReporting(true);
			tracker.EnableAutoActivityTracking(true);
			return this;
		}
		public void TrackScreen(ScreenName screen)
		{
			tracker.SetScreenName(screen.ToString());
			var builder = new HitBuilders.ScreenViewBuilder();
			tracker.Send(builder.Build());
			gaInstance.DispatchLocalHits();
		}
	}
}