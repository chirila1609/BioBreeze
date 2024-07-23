namespace BioBreeze.Pages;

public partial class gim3 : ContentPage
{
	public gim3()
	{
		InitializeComponent();
	}
    private void GoTo_SN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.SistemulNervos());
    }
    private void GoTo_O(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Ochiul());
    }
    private void GoTo_U(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Urechea());
    }
    private void GoTo_N(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Nasul());
    }
    private void GoTo_L(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Limba());
    }
    private void GoTo_P(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.Piele());
    }
    private void GoTo_RF(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.RFVege());
    }
    private void GoTo_ISVVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.ISVVege());
    }
    private void GoTo_SistemulReproductiv(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.AnatomPages.SistemulReproductiv());
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
                WelcomeLabel.Text = "Bine ați venit la clasa a VII-a!";
                NervousSystemButton.Text = "Sistemul Nervos";
                EyeButton.Text = "Ochiul";
                EarButton.Text = "Urechea";
                NoseButton.Text = "Nasul";
                TongueButton.Text = "Limba";
                SkinButton.Text = "Pielea";
                FlowerReproductionButton.Text = "Reproducerea la plantele cu flori";
                SporeReproductionButton.Text = "Inmulțirea prin spori și vegetativă la plante";
                HumanReproductiveSystemButton.Text = "Sistemul reproductiv la om";
                break;

            case "hu":
                WelcomeLabel.Text = "Üdvözöljük a hetedik osztályban!";
                NervousSystemButton.Text = "Idegrendszer";
                EyeButton.Text = "Szem";
                EarButton.Text = "Fül";
                NoseButton.Text = "Orr";
                TongueButton.Text = "Nyelv";
                SkinButton.Text = "Bőr";
                FlowerReproductionButton.Text = "Virágos növények szaporodása";
                SporeReproductionButton.Text = "Sporikus és vegetatív szaporodás növényekben";
                HumanReproductiveSystemButton.Text = "Az emberi szaporító rendszer";
                break;

            case "uk":
                WelcomeLabel.Text = "Ласкаво просимо до сьомого класу!";
                NervousSystemButton.Text = "Нервова система";
                EyeButton.Text = "Око";
                EarButton.Text = "Вухо";
                NoseButton.Text = "Ніс";
                TongueButton.Text = "Язик";
                SkinButton.Text = "Шкіра";
                FlowerReproductionButton.Text = "Розмноження квіткових рослин";
                SporeReproductionButton.Text = "Розмноження спорами та вегетативне розмноження у рослин";
                HumanReproductiveSystemButton.Text = "Репродуктивна система людини";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}