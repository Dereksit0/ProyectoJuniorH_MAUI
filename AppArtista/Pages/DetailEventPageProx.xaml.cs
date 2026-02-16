using AppArtista.Models;
namespace AppArtista.Pages;

[QueryProperty(nameof(EventosProximos), "EventPr")]
public partial class DetailEventPageProx : ContentPage
{
	private EventosProximos _eventosProximos;

	public EventosProximos EventosProximos
	{
		set 
		{ 
			_eventosProximos = value;
        }
	}
    public DetailEventPageProx()
	{
		InitializeComponent();
		_eventosProximos = new EventosProximos();
    }

	protected override void OnAppearing()
	{ 
		base.OnAppearing();
		dateLabelPr.Text = $"Fecha del concierto: " + _eventosProximos.Date;
		cityLabelPr.Text = _eventosProximos.City;
		countryLabelPr.Text = _eventosProximos.Country;
		descriptionLabelPr.Text = _eventosProximos.Description;
		timeLabelPr.Text = $"Hora: {_eventosProximos.Time}";
    }
}