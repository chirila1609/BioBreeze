using BioBreeze.BotanicPages;

namespace BioBreeze.ukr;

public partial class BotanicaUkr : ContentPage
{
	public BotanicaUkr()
	{
		InitializeComponent();
	}
    private void GoTo_TVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TVege());
    }
    private void GoTo_HVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HVege());
    }
    private void GoTo_RVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RVege());
    }
    private void GoTo_CVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CVege());
    }
    private void GoTo_EVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EVege());
    }
    private void GoTo_RFVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RFVege());
    }
    private void GoTo_ISVVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ISVVege());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}