namespace BioBreeze.Pages;

public partial class gim3 : ContentPage
{
	public gim3()
	{
		InitializeComponent();
	}
    private void GoTo_SN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.SistemulNervos());
    }
    private void GoTo_O(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Ochiul());
    }
    private void GoTo_U(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Urechea());
    }
    private void GoTo_N(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Nasul());
    }
    private void GoTo_L(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Limba());
    }
    private void GoTo_P(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Piele());
    }
    private void GoTo_RF(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.RFVege());
    }
    private void GoTo_ISVVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.ISVVege());
    }
    private void GoTo_SistemulReproductiv(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.SistemulReproductiv());
    }
}