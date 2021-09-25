using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_UIs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);

            //MainPage = new NavigationPage(new MainPage());

            MainPage = new NavigationPage(new Pages.Flow4.LoginorSignupPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
