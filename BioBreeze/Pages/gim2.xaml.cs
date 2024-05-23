namespace BioBreeze.Pages;

public partial class gim2 : ContentPage
{
	public gim2()
	{
		InitializeComponent();
	}
    private void GoTo_TA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.TAnimale());
    }
    private void GoTo_HA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.HAnimale());
    }
    private void GoTo_RA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.RAnimale());
    }
    private void GoTo_CA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.CAnimale());
    }
    private void GoTo_EA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.EAnimale());
    }
    private void GoTo_TV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.TVege());
    }
    private void GoTo_HP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.HVege());
    }
    private void GoTo_RP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.RVege());
    }
    private void GoTo_CP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.CVege());
    }
    private void GoTo_EP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.EVege());
    }
}