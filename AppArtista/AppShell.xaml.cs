namespace AppArtista
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Pages.Discografia), typeof(Pages.Discografia));
            Routing.RegisterRoute(nameof(Pages.DetailAlbumPage), typeof(Pages.DetailAlbumPage));
            Routing.RegisterRoute(nameof(Pages.Biografia), typeof(Pages.Biografia));
            Routing.RegisterRoute(nameof(Pages.Eventos), typeof(Pages.Eventos));
        }
    }
}
