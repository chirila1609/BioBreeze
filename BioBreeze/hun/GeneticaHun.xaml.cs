using BioBreeze.GeneticPages;

namespace BioBreeze.hun;

public partial class GeneticaHun : ContentPage
{
	public GeneticaHun()
	{
		InitializeComponent();
	}
    private void GoTo_EV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EV());
    }
    private void GoTo_ADN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ADN());
    }
    private void GoTo_G(object sender, EventArgs e)
    {
        Navigation.PushAsync(new G());
    }
    private void GoTo_Cromo(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cromozomii());
    }
    private void GoTo_Gameti(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gameti());
    }
}