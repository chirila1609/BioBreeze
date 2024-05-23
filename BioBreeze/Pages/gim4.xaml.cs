using BioBreeze.GeneticPages;

namespace BioBreeze.Pages;

public partial class gim4 : ContentPage
{
	public gim4()
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
    private void GoTo_Cromozomii(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cromozomii());
    }
    private void GoTo_Gameti(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gameti());
    }
}