using AppArtista.Models;

namespace AppArtista.Pages;

public partial class EventosPr : ContentPage
{
    private List<EventosProximos> _eventosProximos = [
        new() { Date = "14/03/2026", City = "Austin, TX", Country = "USA", Description = "Billboard Presents: THE STAGE at SXSW - Junior H en Moody Amphitheater", Time = "19:00" },
        new() { Date = "12/05/2026", City = "Bogotá", Country = "Colombia", Description = "Concierto en Movistar Arena - Junior H Tour", Time = "20:00" }
    ];
    public EventosPr()
	{
		InitializeComponent();
        eventPrListView.ItemsSource = _eventosProximos;
    }

    private async void OnEventSelectedPr(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is EventosProximos selectedEvent)
        {
            await Shell.Current.GoToAsync(nameof(DetailEventPageProx), new Dictionary<string, object>
            {
                { "EventPr", selectedEvent}
            });

            eventPrListView.SelectedItem = null;
        }
    }
}