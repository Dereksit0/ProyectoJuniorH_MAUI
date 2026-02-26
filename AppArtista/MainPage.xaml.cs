namespace AppArtista
{
    public partial class MainPage : ContentPage
    {
        bool esModoSad = false;

        public MainPage()
        {
            InitializeComponent();
            // Forzamos el estado inicial claro para evitar pantallas negras al arrancar
            AplicarTema(false);
        }

        private void OnCambiarColorClicked(object sender, EventArgs e)
        {
            esModoSad = !esModoSad;
            AplicarTema(esModoSad);
        }

        private void AplicarTema(bool sad)
        {
            if (sad) // --- MODO SAD ---
            {
                Application.Current.Resources["AppFondo"] = Color.FromArgb("#101010");
                Application.Current.Resources["AppTexto"] = Color.FromArgb("#D600AA"); // Magenta
                Application.Current.Resources["DinamicoJunior"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["BotonFondo"] = Color.FromArgb("#D600AA");
                Application.Current.Resources["BotonTexto"] = Color.FromArgb("#FFFFFF");
                BtnCambiar.Text = "MODO CLARO";
            }
            else // --- MODO CLARO ---
            {
                Application.Current.Resources["AppFondo"] = Color.FromArgb("#FFFFFF");
                Application.Current.Resources["AppTexto"] = Color.FromArgb("#000000"); // Negro
                Application.Current.Resources["DinamicoJunior"] = Color.FromArgb("#0047AB"); // Azul
                Application.Current.Resources["BotonFondo"] = Color.FromArgb("#000000");
                Application.Current.Resources["BotonTexto"] = Color.FromArgb("#FFFFFF");
                BtnCambiar.Text = "MODO SAD";
            }
        }
    }
}