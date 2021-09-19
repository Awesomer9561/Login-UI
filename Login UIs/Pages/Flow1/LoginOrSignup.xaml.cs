using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs.Pages.Flow1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOrSignup : ContentPage
    {
        public LoginOrSignup()
        {
            InitializeComponent();
        }

        private void Signup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Flow1.SignupPage());
        }

        private void Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Flow1.LoginPage());
        }
    }
}