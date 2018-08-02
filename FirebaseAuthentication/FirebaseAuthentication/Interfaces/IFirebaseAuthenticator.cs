using System;
using System.Threading.Tasks;

namespace FirebaseAuthentication
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string email, string password);
        Task<string> RegsiterWithEmailPassword(string email, string password);
      

    }
}
