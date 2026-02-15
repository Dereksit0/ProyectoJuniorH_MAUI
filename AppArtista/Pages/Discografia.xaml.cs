using AppArtista.Models;

namespace AppArtista.Pages
{
	public partial class Discografia : ContentPage
	{
        private List<AlbumsModel> _albums = [
		  new() { Title = "Atrapado en un Sueño", ReleaseDate = "2020", Genre = "Corridos Tumbados", Description = "Álbum que marcó su consolidación en la escena, con letras sobre sueños, lucha y vida personal." },
		  new() { Title = "Cruisin' with Junior H", ReleaseDate = "2020", Genre = "Corridos Tumbados", Description = "Proyecto con estilo relajado y urbano, enfocado en viajes, éxito y experiencias juveniles." },
		  new() { Title = "Mi Vida en un Cigarro", ReleaseDate = "2022", Genre = "Corridos Tumbados", Description = "Disco más introspectivo, con temas sobre amor, excesos y reflexión personal." },
		  new() { Title = "Sad Boy 2005", ReleaseDate = "2023", Genre = "Corridos Tumbados / Sad Sierreño", Description = "Álbum con enfoque emocional, donde expresa tristeza, nostalgia y crecimiento personal." },
		  new() { Title = "Contingente", ReleaseDate = "2024", Genre = "Corridos Tumbados", Description = "Material con sonido más maduro, reflejando su evolución artística y éxito comercial." },
		  new() { Title = "DEPR</3$$ED MFKZ", ReleaseDate = "2025", Genre = "Corridos Tumbados", Description = "Álbum con temática oscura y sentimental, centrado en emociones profundas y experiencias personales." }
		];


        public Discografia()
		{
			InitializeComponent();
            albumsCollectionView.ItemsSource = _albums;
        }
	}
}