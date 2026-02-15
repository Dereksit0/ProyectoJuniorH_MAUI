using AppArtista.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace AppArtista.Views
{
    // Página que muestra las giras y conciertos del artista, con una lista de eventos próximos y pasados

    public partial class GirasPage : ContentPage
    {
        public ObservableCollection<Concierto> ListaEventos { get; set; }

        public GirasPage()
        {
            InitializeComponent();

            ListaEventos = new ObservableCollection<Concierto>
            {
                new Concierto {
                    Ciudad = "Ciudad de México",
                    Fecha = "23 de Noviembre 2026",
                    Recinto = "Foro Sol",
                    Imagen = "ticket_icon.png"
                },
                new Concierto {
                    Ciudad = "Monterrey",
                    Fecha = "2 de Diciembre 2026",
                    Recinto = "Arena Monterrey",
                    Imagen = "ticket_icon.png"
                },
                new Concierto {
                    Ciudad = "Guadalajara",
                    Fecha = "15 de Diciembre 2026",
                    Recinto = "Auditorio Telmex",
                    Imagen = "ticket_icon.png"
                }
            };

            listaGiras.ItemsSource = ListaEventos;
        }

        private async void OnGiraSelected(object sender, SelectionChangedEventArgs e)
        {
            var eventoSeleccionado = e.CurrentSelection.FirstOrDefault() as Concierto;

            if (eventoSeleccionado != null)
            {
                // Deseleccionamos el item
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}