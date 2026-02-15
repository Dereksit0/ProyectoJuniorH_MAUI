namespace AppArtista
{
    // La aplicación principal que se encarga de inicializar la interfaz y manejar la navegación entre páginas

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}