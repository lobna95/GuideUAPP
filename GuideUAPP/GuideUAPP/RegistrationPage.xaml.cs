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
    public partial class RegistrationPage : ContentPage
    {
        Connection conn = new Connection();

        public RegistrationPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("GuideUAPP.Assets.logo.png");
        }

         private async void ResgisterationBtn_ClickedAsync(object sender, EventArgs e)
         {
             try
             {
                 var GENDER = gender.Items[gender.SelectedIndex];

                 bool flag = true;

                 if (PasswordText.Text == ConfirmPasswordText.Text)
                 {
                    var Query = conn.db.Table<User>();

                    foreach (var data in Query)
                    {
                        if (UsernameText.Text == data.UserName)
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        
                        var x = conn.db.Insert(new User()
                        {
                            FirstName = FName.Text,
                            LastName = LName.Text,
                            UserName = UsernameText.Text,
                            Email = EmailText.Text,
                            PhoneNum = PhoneNumberText.Text,
                            Password = PasswordText.Text,
                            DOB = DOBText.Date,
                            Gender = GENDER,
                            Country = CountryText.Text,
                            City = CityText.Text
                        });
                        var view = new NavigationPage(new MainServicePage(UsernameText.Text));
                        Application.Current.MainPage = view;

                    }
                    else
                    {
                        await DisplayAlert("Error!!", "Username already exists", "OK");

                    }
                }
                else
                 {
                     await DisplayAlert("Error!!", "Password doesn't match", "OK");
                 }
             }
             catch
             {
                 await DisplayAlert("Error!!", "Please enter all the fields", "OK");
             }

         }
    }
}