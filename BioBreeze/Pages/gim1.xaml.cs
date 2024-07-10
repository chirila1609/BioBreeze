using BioBreeze.ZooPages;

namespace BioBreeze.Pages;

public partial class gim1 : ContentPage
{
	public gim1()
	{
		InitializeComponent();
	}
    private void GoTo_AV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vertebrate());
    }
    private void GoTo_ANV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nevertebrate());
    }
    private void GoTo_SC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SsiC());
    }
    private void GoTo_V(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Viermi());
    }
    private void GoTo_M(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Moluste());
    }
    private void GoTo_A(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Artropode());
    }
    private void GoTo_P(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Peste());
    }
    private void GoTo_AM(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Amfibieni());
    }
    private void GoTo_R(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Reptile());
    }
    private void GoTo_PA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pasari());
    }
    private void GoTo_MAM(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Mamifere());
    }

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}