using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace AppArtista.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void OnBlueClicked(object sender, EventArgs e)
        {
            Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#347aeb");
        }

        private void OnGoldClicked(object sender, EventArgs e)
        {
            Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#FFD700");
        }

        private void OnRedClicked(object sender, EventArgs e)
        {
            Application.Current.Resources["PrimaryColor"] = Colors.Red;
        }
    }
}
