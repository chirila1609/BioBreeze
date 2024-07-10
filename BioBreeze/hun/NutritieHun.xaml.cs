using BioBreeze.NutriPages;

namespace BioBreeze.hun;

public partial class NutritieHun : ContentPage
{
	public NutritieHun()
	{
		InitializeComponent();
	}
    private void GoTo_HSNutri(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HSN());
    }
    private void GoTo_HPNutri(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HPN());
    }
    private void GoTo_MNutri(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MN());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}