using GuideUAPP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigninPage : ContentPage
    {
        Connection conn = new Connection();
        
        public SigninPage()
        {
            InitializeComponent();
            fbImg.Source = ImageSource.FromResource("GuideUAPP.Assets.fbicon.png");
            googleImg.Source = ImageSource.FromResource("GuideUAPP.Assets.googleicon.png");
            logo.Source = ImageSource.FromResource("GuideUAPP.Assets.logo.png");


            TapGestureRecognizer forgetPasswordTap = new TapGestureRecognizer();
            TapGestureRecognizer signupLabelTap = new TapGestureRecognizer();


            forgetPasswordTap.Tapped += ForgetPasswordTap_Tapped;
            signupLabelTap.Tapped += SignupLabelTap_Tapped;


            ForgetPassword.GestureRecognizers.Add(forgetPasswordTap);
            SignupLabel.GestureRecognizers.Add(signupLabelTap);
        }
        
        private async void SignupLabelTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void ForgetPasswordTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPasswordPage());
        }

        private async void SigninBtn_Clicked(object sender, EventArgs e)
        {
            var Query = conn.db.Table<User>();
            Boolean flage = false;

            foreach (var data in Query)
            {
                if ((UsernameText.Text == data.UserName || UsernameText.Text == data.Email) && PasswordText.Text == data.Password)
                {
                    var view = new NavigationPage(new MainServicePage(UsernameText.Text));
                    Application.Current.MainPage = view;
                    flage = true;
                }
            }
            if (!flage)
            {
                await DisplayAlert("Error!!", "You entered wrong username or password", "OK");
            }
        }
    }
}