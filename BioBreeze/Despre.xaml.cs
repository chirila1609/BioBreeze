namespace BioBreeze;

public partial class Despre : ContentPage
{
	public Despre()
	{
        InitializeComponent();
	}

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}