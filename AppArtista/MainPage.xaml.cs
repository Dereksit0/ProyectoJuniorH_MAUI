namespace AppArtista
{
    public partial class MainPage : ContentPage
    {
        bool esModoSad = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCambiarColorClicked(object sender, EventArgs e)
        {
            esModoSad = !esModoSad;

            if (esModoSad)
            {
                // MODO MAGENTA
                Application.Current.Resources["AppFondo"] = Color.FromArgb("#101010");
                Application.Current.Resources["AppTexto"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["AppAcento"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["DinamicoJunior"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["BotonFondo"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["BotonTexto"] = Color.FromArgb("#FFFFFF");

                LineaDecorativa.WidthRequest = 300;
                BtnCambiar.Text = "VOLVER AL ORIGEN";
            }
            else
            {
                // MODO ORIGINAL
                Application.Current.Resources["AppFondo"] = Color.FromArgb("#000000");
                Application.Current.Resources["AppTexto"] = Color.FromArgb("#FFFFFF");
                Application.Current.Resources["AppAcento"] = Color.FromArgb("#0047AB");
                Application.Current.Resources["DinamicoJunior"] = Color.FromArgb("#0047AB");
                Application.Current.Resources["BotonFondo"] = Color.FromArgb("#FFFFFF");
                Application.Current.Resources["BotonTexto"] = Color.FromArgb("#000000");

                LineaDecorativa.WidthRequest = 100;
                BtnCambiar.Text = "CAMBIAR ESTILO";
            }
        }
    }
}