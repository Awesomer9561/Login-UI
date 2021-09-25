using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs.Pages.Flow3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginorSignupPage : ContentPage
    {
        bool onlogin = true;
        public LoginorSignupPage()
        {
            InitializeComponent();
        }

        private void rightClicked(object sender, EventArgs e)
        {
            if (onlogin)
            {
                onlogin = false;
                rightSide.IsEnabled = false;
                Option.TranslateTo(142, 0, 100, Easing.SinInOut);
                leftSide.IsEnabled = true;
            }
            else
            {
                //DisplayAlert("Signup", "Signup clicked", "Ok");
                Navigation.PushAsync(new SignUpPage());
            }
        }

        private void leftClicked(object sender, EventArgs e)
        {
            if (!onlogin)
            {
                onlogin = true;
                leftSide.IsEnabled = false;
                Option.TranslateTo(0, 0, 100, Easing.SinInOut);
                rightSide.IsEnabled = true;
            }
            else
            {
                //DisplayAlert("Login", "login clicked", "Ok");
                Navigation.PushAsync(new LoginPage());
            }
        }
    }
}