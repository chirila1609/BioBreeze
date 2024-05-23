namespace BioBreeze.hun;

public partial class AcasaHun : ContentPage
{
	public AcasaHun()
	{
		InitializeComponent();
	}
    private void GoTo_Anatomie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieHun());
    }

    private void GoTo_Zoologie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZoologieHun());
    }

    private void GoTo_Botanica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotanicaHun());
    }

    private void GoTo_Nutritie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutritieHun());
    }
    private void GoTo_Genetica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GeneticaHun());
    }
}