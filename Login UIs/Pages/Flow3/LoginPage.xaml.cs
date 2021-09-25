using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs.Pages.Flow3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void gotoSignUpPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}