namespace BioBreeze.Teste;

public partial class ZooCAnimale : ContentPage
{
	public ZooCAnimale()
	{
		InitializeComponent();
	}
    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        
        if (Question1OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 5 este incorectă.\n";

        if (score == 5)
            GlobalVariables.TestsPassed++;

        
        ScoreLabel.Text = $"Scorul tău este: {score} din 5\n" + feedback;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnLanguageButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            string languageCode = button.CommandParameter.ToString();
            ChangeLanguage(languageCode);
        }
    }

    private void ChangeLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Ce este circulația sângelui?";
                Question1OptionALabel.Text = "a) Un proces de respirație";
                Question1OptionBLabel.Text = "b) Un proces vital care furnizează substanțe nutritive și oxigen în întregul corp";
                Question1OptionCLabel.Text = "c) Un proces de digestie";

                Question2Label.Text = "2. Care este principalul tip de sângele la vertebrate?";
                Question2OptionALabel.Text = "a) Sângele albastru";
                Question2OptionBLabel.Text = "b) Sângele roșu";
                Question2OptionCLabel.Text = "c) Sângele verde";

                Question3Label.Text = "3. Ce este un sistem circulator deschis la animale?";
                Question3OptionALabel.Text = "a) Un sistem în care sângele este pompat în cavitățile corpului";
                Question3OptionBLabel.Text = "b) Un sistem în care sângele circulă printr-un circuit închis de vase de sânge";
                Question3OptionCLabel.Text = "c) Un sistem în care inima are patru camere distincte";

                Question4Label.Text = "4. Cum funcționează inima la vertebrate?";
                Question4OptionALabel.Text = "a) Ca un organ pasiv";
                Question4OptionBLabel.Text = "b) Ca o cameră unică de pompare";
                Question4OptionCLabel.Text = "c) Ca o pompă care contractă și pompează sângele în jurul corpului";

                Question5Label.Text = "5. Ce se întâmplă în sinusele sistemului circulator deschis la nevertebrate?";
                Question5OptionALabel.Text = "a) Sângele este filtrat și trimis înapoi în inimă pentru reciclare";
                Question5OptionBLabel.Text = "b) Sângele este pompat în cavitățile corpului";
                Question5OptionCLabel.Text = "c) Sângele este transportat direct la țesuturi";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi az a vérkeringés?";
                Question1OptionALabel.Text = "a) Egy légzési folyamat";
                Question1OptionBLabel.Text = "b) Egy létfontosságú folyamat, amely tápanyagokat és oxigént juttat az egész testbe";
                Question1OptionCLabel.Text = "c) Egy emésztési folyamat";

                Question2Label.Text = "2. Mi a fő vértípus a gerinceseknél?";
                Question2OptionALabel.Text = "a) Kék vér";
                Question2OptionBLabel.Text = "b) Vörös vér";
                Question2OptionCLabel.Text = "c) Zöld vér";

                Question3Label.Text = "3. Mi a nyílt keringési rendszer az állatoknál?";
                Question3OptionALabel.Text = "a) Olyan rendszer, amelyben a vér a test üregeibe pumpálódik";
                Question3OptionBLabel.Text = "b) Olyan rendszer, amelyben a vér egy zárt érhálózaton keresztül kering";
                Question3OptionCLabel.Text = "c) Olyan rendszer, amelyben a szív négy különálló kamrából áll";

                Question4Label.Text = "4. Hogyan működik a szív a gerinceseknél?";
                Question4OptionALabel.Text = "a) Mint egy passzív szerv";
                Question4OptionBLabel.Text = "b) Mint egy egykamrás pumpa";
                Question4OptionCLabel.Text = "c) Mint egy szivattyú, amely összehúzódik és pumpálja a vért a test körül";

                Question5Label.Text = "5. Mi történik a nyílt keringési rendszerben az ízeltlábúaknál?";
                Question5OptionALabel.Text = "a) A vért kiszűrik és visszaküldik a szívbe újrahasznosításra";
                Question5OptionBLabel.Text = "b) A vért a test üregeibe pumpálják";
                Question5OptionCLabel.Text = "c) A vért közvetlenül a szövetekhez szállítják";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Що таке кровообіг?";
                Question1OptionALabel.Text = "a) Процес дихання";
                Question1OptionBLabel.Text = "b) Життєво важливий процес, що постачає поживні речовини та кисень по всьому організму";
                Question1OptionCLabel.Text = "c) Процес травлення";

                Question2Label.Text = "2. Який основний тип крові у хребетних?";
                Question2OptionALabel.Text = "a) Синя кров";
                Question2OptionBLabel.Text = "b) Червона кров";
                Question2OptionCLabel.Text = "c) Зелена кров";

                Question3Label.Text = "3. Що таке відкрита кровоносна система у тварин?";
                Question3OptionALabel.Text = "a) Система, в якій кров накачується в порожнини тіла";
                Question3OptionBLabel.Text = "b) Система, в якій кров циркулює через замкнутий контур кровоносних судин";
                Question3OptionCLabel.Text = "c) Система, в якій серце має чотири окремі камери";

                Question4Label.Text = "4. Як функціонує серце у хребетних?";
                Question4OptionALabel.Text = "a) Як пасивний орган";
                Question4OptionBLabel.Text = "b) Як однокамерний насос";
                Question4OptionCLabel.Text = "c) Як насос, що скорочується і накачує кров по всьому організму";

                Question5Label.Text = "5. Що відбувається в синусах відкритої кровоносної системи у безхребетних?";
                Question5OptionALabel.Text = "a) Кров фільтрується і повертається в серце для переробки";
                Question5OptionBLabel.Text = "b) Кров накачується в порожнини тіла";
                Question5OptionCLabel.Text = "c) Кров транспортується безпосередньо до тканин";
                break;
        }
    }

}