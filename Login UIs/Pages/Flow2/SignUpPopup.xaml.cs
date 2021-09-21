using Rg.Plugins.Popup.Pages;
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
    public partial class SignUpPopup : PopupPage
    {
        public SignUpPopup()
        {
            InitializeComponent();
        }

        private void Signin(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
            PopupNavigation .PushAsync(new LoginPopup());
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
            PopupNavigation.PopAsync();
        }
    }
}