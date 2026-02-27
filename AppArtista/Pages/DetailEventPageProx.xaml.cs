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

    bool isDark = true;

    private void OnToggleThemeClicked(object sender, EventArgs e)
    {
        if (isDark)
        {
            Resources["PageBackground"] = Colors.White;
            Resources["TextColor"] = Colors.Black;
            Resources["TextWhite"] = Colors.Black;
        }
        else
        {
            Resources["PageBackground"] = Color.FromArgb("#121212");
            Resources["TextColor"] = Colors.White;
            Resources["TextWhite"] = Colors.White;
        }

        isDark = !isDark;
    }
}