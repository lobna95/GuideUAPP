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
	public partial class TGProfile : ContentPage
	{
		public TGProfile ()
		{
			InitializeComponent ();
            ImgControl.Source = ImageSource.FromResource("GuideUAPP.Assets.tg.png");
        }
	}
}