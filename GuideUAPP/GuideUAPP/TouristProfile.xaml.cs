using GuideUAPP.Database;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TouristProfile : ContentPage
	{
        Connection conn = new Connection();

        string name;

        public TouristProfile (String name)
		{
			InitializeComponent ();

            ImgControl.Source = ImageSource.FromResource("GuideUAPP.Assets.profile.png");

            this.name = name;

            var Query = conn.db.Table<User>();

            foreach (var data in Query)
            {
                if (name == data.UserName || name == data.Email)
                {
                    fullName.Text = data.FirstName + " " + data.LastName;
                    number.Text = data.PhoneNum;
                    email.Text = data.Email;
                }

            }

        }
        private void ChangePassword_Clicked(object sender, EventArgs e)
        {
            if (changePasswordpopup.IsVisible == false)
                changePasswordpopup.IsVisible = true;

        }

        private void EditProfile_Clicked(object sender, EventArgs e)
        {
            if (editProfilepopup.IsVisible == false)
                editProfilepopup.IsVisible = true;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (PasswordText.Text == ConfirmPasswordText.Text)
                {
                    var Query = conn.db.Table<User>();

                    foreach (var data in Query)
                    {
                        if (data.UserName == name || data.Email == name)
                        {

                            conn.db.Update(new User()
                            {
                                id = data.id,
                                FirstName = data.FirstName,
                                LastName = data.LastName,
                                UserName = data.UserName,
                                Password = PasswordText.Text,
                                DOB = data.DOB,
                                Country = data.Country,
                                City = data.City,
                                PhoneNum = PhoneNumberText.Text,
                                Email = EmailText.Text
                            });
                        }
                    }
                    await DisplayAlert("Message", "Password changed successfully", "OK");
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

        private void ClosePopoUpTap_Tapped(object sender, EventArgs e)
        {
            if (changePasswordpopup.IsVisible == true)
            {
                changePasswordpopup.IsVisible = false;
            }

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