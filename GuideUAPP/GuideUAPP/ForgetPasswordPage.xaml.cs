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
	public partial class ForgetPasswordPage : ContentPage
	{
		public ForgetPasswordPage ()
		{
			InitializeComponent ();
		}

        private async void SendCode_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPasswordPage());
        }
    }
}