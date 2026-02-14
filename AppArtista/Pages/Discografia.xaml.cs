using AppArtista.Models;

namespace AppArtista.Pages
{
	public partial class Discografia : ContentPage
	{
		private List<AlbumsModel> _albums = [
		  new() { Title = "Atrapado en un Sueño", ReleaseDate = "2020", Genre = "Corridos Tumbados" }, 
		  new(){Title = "Cruisin' with Junior H", ReleaseDate = "2020", Genre = "Corridos Tumbados" }, 
		  new () { Title = "Mi Vida en un Cigarro", ReleaseDate = "2022", Genre = "Corridos Tumbados" },
		  new() { Title = "Sad Boy 2005", ReleaseDate = "2023", Genre = "Corridos Tumbados / Sad Sierreño" },
		  new() { Title = "Contingente", ReleaseDate = "2024", Genre = "Corridos Tumbados" },
		  new() { Title = "DEPR</3$$ED MFKZ", ReleaseDate = "2025", Genre = "Corridos Tumbados" }];
		public Discografia()
		{
			InitializeComponent();
			albumsListView.ItemsSource = _albums;
		}
	}
}