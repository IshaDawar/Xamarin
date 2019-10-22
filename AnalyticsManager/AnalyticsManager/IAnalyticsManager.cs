using System;
namespace AnalyticsManager
{
	
		public enum ScreenName { Login, Main }

		public interface IAnalyticsManager
		{
			IAnalyticsManager InitWithId(string analyticsId);
			void TrackScreen(ScreenName screen);
		}

}
