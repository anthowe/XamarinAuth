using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinAuth.System;

namespace XamarinAuth.Views
{
    public partial class MainPage : ContentPage
    {
        IFirebaseAuthentication auth;

        public MainPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthentication>();
        }

        private void SignOutButton_Clicked(object sender, EventArgs e)
        {
            var signedOut = auth.SignOut();
            if (signedOut)
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}
