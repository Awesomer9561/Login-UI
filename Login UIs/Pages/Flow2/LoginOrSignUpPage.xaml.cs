using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs.Pages.Flow2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOrSignUpPage : ContentPage
    {
        public LoginOrSignUpPage()
        {
            InitializeComponent();
        }

        private async void openPopup(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new SignUpPopup());
        }
    }
}