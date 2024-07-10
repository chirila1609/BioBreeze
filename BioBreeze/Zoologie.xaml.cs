using BioBreeze.ZooPages;

namespace BioBreeze;

public partial class Zoologie : ContentPage
{
	public Zoologie()
	{
		InitializeComponent();
	}
    private void GoTo_Verte(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vertebrate());
    }
    private void GoTo_Neverte(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nevertebrate());
    }
    private void GoTo_SsiC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SsiC());
    }
    private void GoTo_Viermi(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Viermi());
    }
    private void GoTo_Moluste(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Moluste());
    }
    private void GoTo_Artropode(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Artropode());
    }
    private void GoTo_Peste(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Peste());
    }
    private void GoTo_Amfibieni(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Amfibieni());
    }
    private void GoTo_Reptile(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Reptile());
    }
    private void GoTo_Pasari(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pasari());
    }
    private void GoTo_Mamifere(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Mamifere());
    }
    private void GoTo_TAnimal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TAnimale());
    }
    private void GoTo_HAnimal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HAnimale());
    }
    private void GoTo_RAnimal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RAnimale());
    }
    private void GoTo_CAnimal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CAnimale());
    }
    private void GoTo_EAnimal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EAnimale());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}