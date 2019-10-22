using Xamarin.Forms;

namespace AnalyticsManager
{
	public partial class AnalyticsManagerPage : ContentPage
	{
		public AnalyticsManagerPage()
		{
			InitializeComponent();
			var analyticsManager = DependencyService.Get<IAnalyticsManager>();
            analyticsManager.InitWithId("Tracking_ID");
			analyticsManager.TrackScreen(ScreenName.Main);
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			int i = 10;
			i = i / 0;
			
		}
	}
}
