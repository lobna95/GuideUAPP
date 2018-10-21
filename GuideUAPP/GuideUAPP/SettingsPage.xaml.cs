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
    public partial class SettingsPage : ContentPage
    {
        Connection conn = new Connection();

        string name;

        public SettingsPage(String name)
        {
            InitializeComponent();

            this.name = name;

            TapGestureRecognizer editProfileTap = new TapGestureRecognizer();
            editProfileTap.Tapped += EditProfileTap_Tapped;

            EditProfile.GestureRecognizers.Add(editProfileTap);
        }
        private void EditProfileTap_Tapped(object sender, EventArgs e)
        {
            if (editProfilepopup.IsVisible == false)
                editProfilepopup.IsVisible = true;
        }

        private void ClosePopoUp1Tap_Tapped(object sender, EventArgs e)
        {
            if (editProfilepopup.IsVisible == true)
            {
                editProfilepopup.IsVisible = false;
            }

        }

        private async void editProfile_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var Query = conn.db.Table<User>();
                //conn.db.DropTable<User>();

                foreach (var data in Query)
                {
                    if (data.UserName == name || data.Email == name)
                    {

                        conn.db.Update(new User()
                        {
                            id = data.id,
                            FirstName = FName.Text,
                            LastName = LName.Text,
                            UserName = data.UserName,
                            Password = data.Password,
                            DOB = data.DOB,
                            Country = data.Country,
                            City = data.City,
                            PhoneNum = PhoneNumberText.Text,
                            Email = EmailText.Text
                        });
                    }
                }
                await DisplayAlert("Message", "Data changed successfully", "OK");

            }
            catch
            {
                await DisplayAlert("Error!!", "Please enter all the fields", "OK");
            }
        }
    }
    }
