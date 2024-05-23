namespace BioBreeze;

public partial class Bacalaureat : ContentPage
{
	public Bacalaureat()
	{
		InitializeComponent();
	}
    private void GoTo_2024(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.TesteBac._2024());
    }
}