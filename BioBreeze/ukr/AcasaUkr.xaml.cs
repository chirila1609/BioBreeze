namespace BioBreeze.ukr;

public partial class AcasaUkr : ContentPage
{
	public AcasaUkr()
	{
		InitializeComponent();
	}
    private void GoTo_Anatomie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieUkr());
    }

    private void GoTo_Zoologie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZoologieUkr());
    }

    private void GoTo_Botanica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotanicaUkr());
    }

    private void GoTo_Nutritie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutritieUkr());
    }
    private void GoTo_Genetica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GeneticaUkr());
    }

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}