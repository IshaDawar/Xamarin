using Android.App;
using Android.Content.PM;
using Android.OS;

namespace FirebaseAuthentication.Droid
{
    [Activity(Label = "FirebaseAuthentication.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Firebase.FirebaseApp.InitializeApp(Application.Context);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            Firebase.FirebaseApp.InitializeApp(this);
            LoadApplication(new App());
        }
    }
}
