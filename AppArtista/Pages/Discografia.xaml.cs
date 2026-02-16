using AppArtista.Models;

namespace AppArtista.Pages
{
	public partial class Discografia : ContentPage
	{
        private List<AlbumsModel> _albums = [
          new() { Title = "Atrapado en un Sueño", ReleaseDate = "2020", Genre = "Corridos Tumbados", Description = "Álbum que marcó su consolidación en la escena, con letras sobre sueños, lucha y vida personal.", ImageLink = "https://i.scdn.co/image/ab67616d00001e02a360516982fbcaa2db0bb938" },
          new() { Title = "Cruisin' with Junior H", ReleaseDate = "2020", Genre = "Corridos Tumbados", Description = "Proyecto con estilo relajado y urbano, enfocado en viajes, éxito y experiencias juveniles.", ImageLink = "https://i.scdn.co/image/ab67616d0000b273123c8dbf0fa84a38b7d0380a" },
          new() { Title = "Mi Vida en un Cigarro", ReleaseDate = "2022", Genre = "Corridos Tumbados", Description = "Disco más introspectivo, con temas sobre amor, excesos y reflexión personal.", ImageLink = "https://akamai.sscdn.co/uploadfile/letras/albuns/a/5/5/4/01644838011.jpg" },
          new() { Title = "Sad Boy 2005", ReleaseDate = "2023", Genre = "Corridos Tumbados / Sad Sierreño", Description = "Álbum con enfoque emocional, donde expresa tristeza, nostalgia y crecimiento personal.", ImageLink = "" },
          new() { Title = "Contingente", ReleaseDate = "2024", Genre = "Corridos Tumbados", Description = "Material con sonido más maduro, reflejando su evolución artística y éxito comercial.", ImageLink = "https://i.scdn.co/image/ab67616d0000b273ba27fc75f9f6599b97afeb45" },
          new() { Title = "DEPR</3$$ED MFKZ", ReleaseDate = "2025", Genre = "Corridos Tumbados", Description = "Álbum con temática oscura y sentimental, centrado en emociones profundas y experiencias personales.", ImageLink = "https://i.scdn.co/image/ab67616d0000b2732ad154d7a7e3e2353b2bd2f9" }
        ];


        public Discografia()
		{
			InitializeComponent();
            albumsCollectionView.ItemsSource = _albums;
        }

        private async void OnAlbumSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is AlbumsModel selectedAlbum)
            {
                await Shell.Current.GoToAsync(nameof(DetailAlbumPage), new Dictionary<string, object>
            {
                { "Album", selectedAlbum}
            });

                albumsCollectionView.SelectedItem = null;
            }
        }
    }
}