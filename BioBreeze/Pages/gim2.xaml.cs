namespace BioBreeze.Pages;

public partial class gim2 : ContentPage
{
	public gim2()
	{
		InitializeComponent();
	}
    private void GoTo_TA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.TAnimale());
    }
    private void GoTo_HA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.HAnimale());
    }
    private void GoTo_RA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.RAnimale());
    }
    private void GoTo_CA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.CAnimale());
    }
    private void GoTo_EA(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.ZooPages.EAnimale());
    }
    private void GoTo_TV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.TVege());
    }
    private void GoTo_HP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.HVege());
    }
    private void GoTo_RP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.RVege());
    }
    private void GoTo_CP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.CVege());
    }
    private void GoTo_EP(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.BotanicPages.EVege());
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
                WelcomeLabel.Text = "Bine ați venit la clasa a VI-a!";
                AnimalTissuesButton.Text = "Tesuturi animale";
                AnimalFeedingButton.Text = "Hranirea la animale";
                AnimalRespirationButton.Text = "Respiratia la animale";
                AnimalCirculationButton.Text = "Circulatia la animale";
                AnimalExcretionButton.Text = "Excretia la animale";
                PlantTissuesButton.Text = "Tesuturi vegetale";
                PlantFeedingButton.Text = "Hranirea la plante";
                PlantRespirationButton.Text = "Respiratia la plante";
                PlantCirculationButton.Text = "Circulatia la plante";
                PlantExcretionButton.Text = "Excretia la plante";
                break;

            case "hu":
                WelcomeLabel.Text = "Üdvözöljük a hatodik osztályban!";
                AnimalTissuesButton.Text = "Állati szövetek";
                AnimalFeedingButton.Text = "Állatok táplálása";
                AnimalRespirationButton.Text = "Állatok légzése";
                AnimalCirculationButton.Text = "Állatok keringése";
                AnimalExcretionButton.Text = "Állatok kiválasztása";
                PlantTissuesButton.Text = "Növényi szövetek";
                PlantFeedingButton.Text = "Növények táplálása";
                PlantRespirationButton.Text = "Növények légzése";
                PlantCirculationButton.Text = "Növények keringése";
                PlantExcretionButton.Text = "Növények kiválasztása";
                break;

            case "uk":
                WelcomeLabel.Text = "Ласкаво просимо до шостого класу!";
                AnimalTissuesButton.Text = "Тваринні тканини";
                AnimalFeedingButton.Text = "Харчування тварин";
                AnimalRespirationButton.Text = "Дихання тварин";
                AnimalCirculationButton.Text = "Кровообіг тварин";
                AnimalExcretionButton.Text = "Виділення у тварин";
                PlantTissuesButton.Text = "Рослинні тканини";
                PlantFeedingButton.Text = "Харчування рослин";
                PlantRespirationButton.Text = "Дихання рослин";
                PlantCirculationButton.Text = "Кровообіг у рослин";
                PlantExcretionButton.Text = "Виділення у рослин";
                break;

            default:
            
                SetLanguage("ro");
                break;
        }
    }
}