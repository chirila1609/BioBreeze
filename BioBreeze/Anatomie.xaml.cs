using BioBreeze.AnatomPages;

namespace BioBreeze;

public partial class Anatomie : ContentPage
{
	public Anatomie()
	{
		InitializeComponent();
	}

    private void GoTo_Skeleton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Skeleton());
    }

    private void GoTo_Muscle(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Muscle());
    }

    private void GoTo_SN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SistemulNervos());
    }
    private void GoTo_SC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SistemulCirculator());
    }
    private void GoTo_SR(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SistemulRespirator());
    }
    private void GoTo_SD(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SistemulDigestiv());
    }
    private void GoTo_SRep(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SistemulReproductiv());
    }
    private void GoTo_Brain(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Creierul());
    }
    private void GoTo_Heart(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Inima());
    }
    private void GoTo_Stom(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stomacul());
    }
    private void GoTo_PL(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Plamani());
    }
    private void GoTo_F(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ficatul());
    }
    private void GoTo_O(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ochiul());
    }
    private void GoTo_U(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Urechea());
    }
    private void GoTo_N(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nasul());
    }
    private void GoTo_L(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Limba());
    }
    private void GoTo_P(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Piele());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}