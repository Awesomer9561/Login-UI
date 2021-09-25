using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs.Pages.Flow4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginorSignupPage : ContentPage
    {
        public LoginorSignupPage()
        {
            InitializeComponent();
        }

        private void EntryFocused(object sender, FocusEventArgs e)
        {
            EntryFrame.Border.Color = Color.Blue;
        }

        private void NextBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OTPPage());
        }

        private void EntryUnfocused(object sender, FocusEventArgs e)
        {
            EntryFrame.Border.Color = Color.FromHex("#d0d9f2");
        }

        private void NextBtnActivate(object sender, CheckedChangedEventArgs e)
        {
            if (checkBox.IsChecked && !string.IsNullOrEmpty(PhoneEntry.Text))
            {
                NextButton.BackgroundColor = Color.Blue;
            }
            else if (!checkBox.IsChecked)
            {
                NextButton.BackgroundColor = Color.FromHex("#d0d9f2");
            }
        }
    }
}