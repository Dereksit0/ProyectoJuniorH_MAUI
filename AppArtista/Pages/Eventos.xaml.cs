using AppArtista.Models;
namespace AppArtista.Pages;

public partial class Eventos : ContentPage
{
    private List<EventosPasados> _eventosPasados = [
        new() { Date = "07/11/2025", City = "Los Angeles, CA", Country = "USA", Description = "Concierto en el Hollywood Bowl como parte del Sad Boyz Live & Broken Tour 2025." },
        new() { Date = "02/11/2025", City = "Albuquerque, NM", Country = "USA", Description = "Presentación en el Isleta Amphitheater durante la gira 2025." },
        new() { Date = "01/11/2025", City = "Las Vegas, NV", Country = "USA", Description = "Show en el T-Mobile Arena dentro de la gira Sad Boyz Live & Broken Tour." },
        new() { Date = "31/10/2025", City = "Phoenix, AZ", Country = "USA", Description = "Actuación en el Talking Stick Resort Amphitheatre como parte de la gira." },
        new() { Date = "25/10/2025", City = "Dallas, TX", Country = "USA", Description = "Concierto en Dos Equis Pavilion en la gira 2025 Sad Boyz Live & Broken Tour." }
    ];


    public Eventos()
	{
		InitializeComponent();
        eventListView.ItemsSource = _eventosPasados;
    }

    private async void OnEventSelectedPa(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is EventosPasados selectedEvent)
        {
            await Shell.Current.GoToAsync(nameof(DetailEventPage), new Dictionary<string, object>
            {
                { "Event", selectedEvent}
            });

            eventListView.SelectedItem = null;
        }
    }
}