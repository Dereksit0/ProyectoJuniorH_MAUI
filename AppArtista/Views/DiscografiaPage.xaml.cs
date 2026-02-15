using AppArtista.Models;
using System.Collections.ObjectModel;

namespace AppArtista.Views;

public partial class DiscografiaPage : ContentPage
{
    public ObservableCollection<Album> MisAlbumes { get; set; }

    public DiscografiaPage()
    {
        InitializeComponent();

        MisAlbumes = new ObservableCollection<Album>
        {
            new Album {
                Nombre = "$ad Boyz 4 Life II",
                Anio = "2023",
                Portada = "https://i.scdn.co/image/ab67616d0000b273b3062f4365ced902e4aebb63",
                Descripcion = "La esperada continuación del álbum que definió una generación. Incluye temas profundos sobre el desamor y el estilo de vida tumbado."
            },
            new Album {
                Nombre = "Contingente",
                Anio = "2022",
                Portada = "https://is1-ssl.mzstatic.com/image/thumb/Music112/v4/cc/01/a6/cc01a661-c7c1-418e-afed-285112e58a42/5054197462276.jpg/600x600bf-60.jpg",
                Descripcion = "Un álbum lleno de energía donde Junior H experimenta con ritmos de trap más agresivos sin dejar atrás sus raíces."
            },
            new Album {
                Nombre = "Mi Vida En Un Cigarro 2",
                Anio = "2022",
                Portada = "https://is1-ssl.mzstatic.com/image/thumb/Music116/v4/11/33/97/1133978a-d03c-2c62-c712-8e2567bbd666/190296227486.jpg/600x600bf-60.jpg",
                Descripcion = "Un regreso a lo básico. Letras crudas y guitarras melancólicas que narran historias reales de la calle y el éxito."
            },
                new Album {
                    Nombre = "Atrapado En Un Sueño",
                    Anio = "2021",
                    Portada = "https://is1-ssl.mzstatic.com/image/thumb/Music124/v4/83/86/2a/83862a9a-aac3-8337-2135-6796108202f1/190296802195.jpg/1200x630bb.jpg",
                    Descripcion = "Un álbum lleno de energía donde Junior H experimenta con ritmos de trap más agresivos sin dejar atrás sus raíces."
                }
        };

        coleccionAlbumes.ItemsSource = MisAlbumes;
    }

    private async void OnAlbumSelected(object sender, SelectionChangedEventArgs e)
    {
        var album = e.CurrentSelection.FirstOrDefault() as Album;
        if (album != null)
        {
            await Navigation.PushAsync(new DetalleAlbumPage { BindingContext = album });
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}