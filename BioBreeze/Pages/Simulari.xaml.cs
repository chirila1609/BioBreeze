namespace BioBreeze.Pages;

public partial class Simulari : ContentPage
{
	public Simulari()
	{
		InitializeComponent();
	}

    private void GoTo_nsim(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.nsim());
    }

    private void GoTo_vsim(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.vsim());
    }

    private void GoTo_mcs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.mcs());
    }

    private void GoTo_gs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.gs());
    }

    private void GoTo_cvg(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.cvg());
    }

    private void GoTo_cag(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.cag());
    }

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}