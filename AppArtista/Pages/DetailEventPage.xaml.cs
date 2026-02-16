using AppArtista.Models;
namespace AppArtista.Pages;

[QueryProperty(nameof(EventosPasados), "Event")]
public partial class DetailEventPage : ContentPage
{
	private EventosPasados _eventosPasados;

	public EventosPasados EventosPasados
	{
		set 
		{ 
			_eventosPasados = value;
        }
	}
    public DetailEventPage()
	{
		InitializeComponent();
		_eventosPasados = new EventosPasados();
    }

	protected override void OnAppearing() 
	{ 
		base.OnAppearing();
        dateLabel.Text = $"Fecha del concierto: " + _eventosPasados.Date;
        cityLabel.Text = _eventosPasados.City;
        countryLabel.Text = _eventosPasados.Country;
        descriptionLabel.Text = _eventosPasados.Description;
    }
}