using System;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(FirebaseAuthentication.iOS.FirebaseAuthenticator))]
namespace FirebaseAuthentication.iOS
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator 
    {
       public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            var user = await Firebase.Auth.Auth.DefaultInstance.SignInAsync(email, password);
            return await user.GetIdTokenAsync();
        }

       public async Task<string> RegsiterWithEmailPassword(string email, string password)
        {
            var user = await Firebase.Auth.Auth.DefaultInstance.CreateUserAsync(email, password);
            return await user.GetIdTokenAsync();
        }
    }
}
