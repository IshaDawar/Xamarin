using System;
using Google.Analytics;
using Xamarin.Forms;

[assembly: Dependency(typeof(AnalyticsManager.iOS.AnalyticsManager))]
namespace AnalyticsManager.iOS
{
	public class AnalyticsManager: IAnalyticsManager
	{

		private static Gai gaInstance;
		private static ITracker tracker;

		public IAnalyticsManager InitWithId(string analyiticsId)
		{
			gaInstance = Gai.SharedInstance;
			gaInstance.DispatchInterval = 10;
			gaInstance.TrackUncaughtExceptions = true;
			tracker = gaInstance.GetTracker(analyiticsId);
			return this;
		}

		public void TrackScreen(ScreenName screen)
		{
			tracker.Set(GaiConstants.ScreenName, screen.ToString());
			tracker.Send(DictionaryBuilder.CreateScreenView().Build());
			gaInstance.Dispatch();
		}
	}
}