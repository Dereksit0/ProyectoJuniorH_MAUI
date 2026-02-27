using AppArtista.Models;
namespace AppArtista.Pages;

[QueryProperty(nameof(AlbumsModel), "Album")]
public partial class DetailAlbumPage : ContentPage
{
	private AlbumsModel _albumsModel;

	public AlbumsModel AlbumsModel
	{
		set
		{
			_albumsModel = value;
		}
    }
    public DetailAlbumPage()
	{
		InitializeComponent();
		_albumsModel = new AlbumsModel();
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		imageLabel.Source = _albumsModel.ImageLink;
        titleLabel.Text = _albumsModel.Title;
		releaseDateLabel.Text = _albumsModel.ReleaseDate;
		genreLabel.Text = $"Género: {_albumsModel.Genre}";
		descriptionLabel.Text = _albumsModel.Description;
    }


    // logica pa cambiar entre modos
    bool isDark = true;

    private void OnToggleThemeClicked(object sender, EventArgs e)
    {
        if (isDark)
        {
            // modo claro
            Resources["PageBackground"] = Colors.White;
            Resources["TextColor"] = Colors.Black;
            Resources["TextWhite"] = Colors.Black;
        }
        else
        {
            // moso oscuro
            Resources["PageBackground"] = Color.FromArgb("#121212");
            Resources["TextColor"] = Colors.White;
            Resources["TextWhite"] = Colors.White;
        }

        isDark = !isDark;
    }
}