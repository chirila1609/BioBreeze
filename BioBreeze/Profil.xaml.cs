namespace BioBreeze;
public static class GlobalVariables
{
    public static int TestsPassed { get; set; } = 0;
}
public partial class Profil : ContentPage
{
	public Profil()
	{
		InitializeComponent();

        Badge1.Source = GlobalVariables.TestsPassed >= 1 ? "unuok.png" : "ununu.png";
        Badge5.Source = GlobalVariables.TestsPassed >= 5 ? "cinciok.png" : "cincinu.png";
        Badge10.Source = GlobalVariables.TestsPassed >= 10 ? "zeceok.png" : "zecenu.png";
        Badge25.Source = GlobalVariables.TestsPassed >= 25 ? "doicinciok.png" : "doicincinu.png";
        Badge50.Source = GlobalVariables.TestsPassed >= 50 ? "cincizerook.png" : "cincizeronu.png";
    }
}