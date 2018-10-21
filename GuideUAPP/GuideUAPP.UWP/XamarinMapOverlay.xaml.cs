using GuideUAPP;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace GuideUAPP.UWP
{
    public sealed partial class XamarinMapOverlay : UserControl
    {
        CustomPin customPin;


        public XamarinMapOverlay(CustomPin pin)
        {
            this.InitializeComponent();
            customPin = pin;
            SetupData();

        }

        void SetupData()
        {
            Label.Text = customPin.Label;
            Address.Text = customPin.Address;
        }
    }
}
