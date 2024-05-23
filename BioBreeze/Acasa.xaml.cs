using System.Globalization;
using System.Threading;

namespace BioBreeze;

public partial class Acasa : ContentPage
{
	public Acasa()
	{
		InitializeComponent();
	}

    private void GoTo_Anatomie(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Anatomie());
	}

    private void GoTo_Zoologie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Zoologie());
    }

    private void GoTo_Botanica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Botanica());
    }

    private void GoTo_Nutritie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nutritie());
    }
    private void GoTo_Genetica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Genetica());
    }
    private void GoTo_AcasaHun(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.hun.AcasaHun());
    }
    private void GoTo_AcasaUkr(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ukr.AcasaUkr());
    }
    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

}

