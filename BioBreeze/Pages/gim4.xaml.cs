using BioBreeze.GeneticPages;

namespace BioBreeze.Pages;

public partial class gim4 : ContentPage
{
	public gim4()
	{
		InitializeComponent();
	}
    private void GoTo_EV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EV());
    }
    private void GoTo_ADN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ADN());
    }
    private void GoTo_G(object sender, EventArgs e)
    {
        Navigation.PushAsync(new G());
    }
    private void GoTo_Cromozomii(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cromozomii());
    }
    private void GoTo_Gameti(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gameti());
    }

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    private void OnLanguageButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                WelcomeLabel.Text = "Bine ați venit în clasa a VIII-a!";
                HeredityButton.Text = "Ereditatea și variabilitatea";
                DNAButton.Text = "ADN";
                GenesButton.Text = "Genele";
                ChromosomesButton.Text = "Cromozomii";
                GametesButton.Text = "Gameți";
                break;

            case "hu":
                WelcomeLabel.Text = "Üdvözöljük a nyolcadik osztályban!";
                HeredityButton.Text = "Öröklődés és változatosság";
                DNAButton.Text = "DNS";
                GenesButton.Text = "Gének";
                ChromosomesButton.Text = "Kromoszómák";
                GametesButton.Text = "Gaméták";
                break;

            case "uk":
                WelcomeLabel.Text = "Ласкаво просимо до восьмого класу!";
                HeredityButton.Text = "Спадковість і мінливість";
                DNAButton.Text = "ДНК";
                GenesButton.Text = "Гени";
                ChromosomesButton.Text = "Хромосоми";
                GametesButton.Text = "Гамети";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}