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