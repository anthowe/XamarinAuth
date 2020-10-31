using System;
using System.Threading.Tasks;

namespace XamarinAuth.System
{
    public interface IFirebaseAuthentication
    {
        Task<string> LoginWithEmailAndPassword(string email, string password);
        bool SignOut();
        bool IsSignIn();
    }
}
