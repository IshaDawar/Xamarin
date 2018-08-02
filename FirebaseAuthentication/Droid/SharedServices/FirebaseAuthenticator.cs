using System;
using System.Threading.Tasks;
using Android.Gms.Tasks;
using Java.Lang;
using Xamarin.Forms;

[assembly: Dependency(typeof(FirebaseAuthentication.Droid.FirebaseAuthenticator))]
namespace FirebaseAuthentication.Droid
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
       public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            var user = await Firebase.Auth.FirebaseAuth.Instance.
                            SignInWithEmailAndPasswordAsync(email, password);
            var token = await user.User.GetTokenAsync(false);
            return token.Token;
        }     

        public async Task<string> RegsiterWithEmailPassword(string email, string password)
        {
            var user = await Firebase.Auth.FirebaseAuth.Instance.
                                                CreateUserWithEmailAndPasswordAsync(email, password);
            var token = await user.User.GetTokenAsync(false);
            return token.Token;
        }
     
    }
}
