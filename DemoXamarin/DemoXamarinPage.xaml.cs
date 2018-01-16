using Xamarin.Forms;

namespace DemoXamarin
{
    public partial class DemoXamarinPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Message", "You have tapped the Button!", "OK");
        }

        public DemoXamarinPage()
        {
            InitializeComponent();
        }
    }
}
