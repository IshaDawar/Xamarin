using System;
using Xamarin.Forms;

namespace FirebaseAuthentication
{
    public partial class FirebaseAuthenticationPage : ContentPage
    {
        public FirebaseAuthenticationPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (CheckValidatiions())
            {
                var token = await DependencyService.Get<IFirebaseAuthenticator>().RegsiterWithEmailPassword(txtEmail.Text, txtPassword.Text);
            }

        }
        
        async void Login_Cicked(object sender, System.EventArgs e)
        {
            if (CheckValidatiions())
            {
                var token = await DependencyService.Get<IFirebaseAuthenticator>().LoginWithEmailPassword(txtEmail.Text, txtPassword.Text);
            }

        }
        private bool CheckValidatiions()
        {
            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                DisplayAlert("Alert", "Enter email", "ok");
                return false;
            }
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
             
                DisplayAlert("Alert", "Enter password", "ok");
                return false;
            }
            return true;
        }
    }
}
