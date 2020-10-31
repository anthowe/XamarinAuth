using System;
using System.Threading.Tasks;
using Firebase.Auth;
using Foundation;
using XamarinAuth.System;

namespace XamarinAuth.iOS.System
{
    public class FirebaseAuthentication : IFirebaseAuthentication

    {
        public FirebaseAuthentication()
        {
        }
        public bool IsSignIn()
        {
            var user = Auth.DefaultInstance.CurrentUser;
            return user != null;
        }

        public async Task<string> LoginWithEmailAndPassword(string email, string password)
        {
            var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
            return await user.User.GetIdTokenAsync();
        }

        public bool SignOut()
        {
            try
            {
                _ = Auth.DefaultInstance.SignOut(out NSError error);
                return error == null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
