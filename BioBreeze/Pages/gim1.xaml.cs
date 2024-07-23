using BioBreeze.ZooPages;

namespace BioBreeze.Pages;

public partial class gim1 : ContentPage
{
	public gim1()
	{
		InitializeComponent();
	}
    private void GoTo_AV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vertebrate());
    }
    private void GoTo_ANV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nevertebrate());
    }
    private void GoTo_SC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SsiC());
    }
    private void GoTo_V(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Viermi());
    }
    private void GoTo_M(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Moluste());
    }
    private void GoTo_A(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Artropode());
    }
    private void GoTo_P(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Peste());
    }
    private void GoTo_AM(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Amfibieni());
    }
    private void GoTo_R(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Reptile());
    }
    private void GoTo_PA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pasari());
    }
    private void GoTo_MAM(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Mamifere());
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
                WelcomeLabel.Text = "Bine ați venit la clasa a V-a!";
                VertebrateButton.Text = "Animale vertebrate";
                InvertebrateButton.Text = "Animale nevertebrate";
                SpongesButton.Text = "Spongieri și celenterate";
                WormsButton.Text = "Viermi";
                MolluscsButton.Text = "Moluște";
                ArthropodsButton.Text = "Artropode";
                FishButton.Text = "Pești";
                AmphibiansButton.Text = "Amfibieni";
                ReptilesButton.Text = "Reptile";
                BirdsButton.Text = "Păsări";
                MammalsButton.Text = "Mamifere";
                break;

            case "hu":
                WelcomeLabel.Text = "Üdvözöljük az ötödik osztályban!";
                VertebrateButton.Text = "Gerinces állatok";
                InvertebrateButton.Text = "Gerinctelen állatok";
                SpongesButton.Text = "Szivacsok és csalánozók";
                WormsButton.Text = "Férgek";
                MolluscsButton.Text = "Puhatestűek";
                ArthropodsButton.Text = "Ízeltlábúak";
                FishButton.Text = "Halak";
                AmphibiansButton.Text = "Kétéltűek";
                ReptilesButton.Text = "Hüllők";
                BirdsButton.Text = "Madarak";
                MammalsButton.Text = "Emlősök";
                break;

            case "uk":
                WelcomeLabel.Text = "Ласкаво просимо до п'ятого класу!";
                VertebrateButton.Text = "Хребетні тварини";
                InvertebrateButton.Text = "Безхребетні тварини";
                SpongesButton.Text = "Губки та кнідарії";
                WormsButton.Text = "Черви";
                MolluscsButton.Text = "Молюски";
                ArthropodsButton.Text = "Членистоногі";
                FishButton.Text = "Риби";
                AmphibiansButton.Text = "Амфібії";
                ReptilesButton.Text = "Плазуни";
                BirdsButton.Text = "Птахи";
                MammalsButton.Text = "Ссавці";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}