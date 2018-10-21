using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace GuideUAPP
{
	public partial class App : Application
	{
        public static double ScreenHeight;
        public static double ScreenWidth;

        public App ()
		{
			InitializeComponent();

            //MainPage = new MapPage();
            MainPage = new NavigationPage(new SigninPage());
            //MainPage = navigationPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
