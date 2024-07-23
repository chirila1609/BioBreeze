namespace BioBreeze.Teste;

public partial class AnatomieSN : ContentPage
{
	public AnatomieSN()
	{
		InitializeComponent();
	}

    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        
        if (Question1OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionB.IsChecked)
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
                Question1Label.Text = "1. Care sunt cele două componente principale ale sistemului nervos uman?";
                Question1OptionALabel.Text = "a) Creierul și măduva spinării";
                Question1OptionBLabel.Text = "b) Inimă și plămâni";
                Question1OptionCLabel.Text = "c) Stomac și intestine";

                Question2Label.Text = "2. Ce sunt neuronii și care este rolul lor în sistemul nervos?";
                Question2OptionALabel.Text = "a) Celulele responsabile pentru respirație";
                Question2OptionBLabel.Text = "b) Celulele care permit transmiterea rapidă a semnalelor electrochimice";
                Question2OptionCLabel.Text = "c) Celulele care produc hormoni";

                Question3Label.Text = "3. Ce este creierul și care este funcția sa principală în corpul uman?";
                Question3OptionALabel.Text = "a) Un organ responsabil pentru digestie";
                Question3OptionBLabel.Text = "b) Centrul de comandă al corpului, controlând fiecare acțiune și reacție";
                Question3OptionCLabel.Text = "c) Un organ implicat în respirație";

                Question4Label.Text = "4. Care este rolul sistemului nervos periferic în corpul uman?";
                Question4OptionALabel.Text = "a) Conectarea sistemului nervos central la restul corpului";
                Question4OptionBLabel.Text = "b) Controlul respirației";
                Question4OptionCLabel.Text = "c) Controlul digestiei";

                Question5Label.Text = "5. Ce înseamnă plasticitatea neuronală și de ce este importantă?";
                Question5OptionALabel.Text = "a) Capacitatea de a forma conexiuni între neuroni";
                Question5OptionBLabel.Text = "b) Capacitatea de a reorganiza conexiunile dintre neuroni";
                Question5OptionCLabel.Text = "c) Capacitatea de a respira";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyek az emberi idegrendszer fő összetevői?";
                Question1OptionALabel.Text = "a) Az agy és a gerincvelő";
                Question1OptionBLabel.Text = "b) A szív és a tüdők";
                Question1OptionCLabel.Text = "c) A gyomor és a belek";

                Question2Label.Text = "2. Mik a neuronok és mi a szerepük az idegrendszerben?";
                Question2OptionALabel.Text = "a) A légzésért felelős sejtek";
                Question2OptionBLabel.Text = "b) Az elektrokémiai jelek gyors továbbítására szolgáló sejtek";
                Question2OptionCLabel.Text = "c) A hormonokat termelő sejtek";

                Question3Label.Text = "3. Mi az agy és mi a fő funkciója az emberi testben?";
                Question3OptionALabel.Text = "a) Az emésztésért felelős szerv";
                Question3OptionBLabel.Text = "b) A test parancsközpontja, minden cselekvést és reakciót irányítva";
                Question3OptionCLabel.Text = "c) A légzésben részt vevő szerv";

                Question4Label.Text = "4. Mi a perifériás idegrendszer szerepe az emberi testben?";
                Question4OptionALabel.Text = "a) A központi idegrendszer összekapcsolása a test többi részével";
                Question4OptionBLabel.Text = "b) A légzés irányítása";
                Question4OptionCLabel.Text = "c) Az emésztés irányítása";

                Question5Label.Text = "5. Mit jelent a neuronális plaszticitás és miért fontos?";
                Question5OptionALabel.Text = "a) A neuronok közötti kapcsolatok kialakításának képessége";
                Question5OptionBLabel.Text = "b) A neuronok közötti kapcsolatok átszervezésének képessége";
                Question5OptionCLabel.Text = "c) A légzés képessége";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які дві основні складові нервової системи людини?";
                Question1OptionALabel.Text = "a) Мозок і спинний мозок";
                Question1OptionBLabel.Text = "b) Серце і легені";
                Question1OptionCLabel.Text = "c) Шлунок і кишечник";

                Question2Label.Text = "2. Що таке нейрони і яка їх роль у нервовій системі?";
                Question2OptionALabel.Text = "a) Клітини, відповідальні за дихання";
                Question2OptionBLabel.Text = "b) Клітини, які забезпечують швидку передачу електрохімічних сигналів";
                Question2OptionCLabel.Text = "c) Клітини, які виробляють гормони";

                Question3Label.Text = "3. Що таке мозок і яка його основна функція в тілі людини?";
                Question3OptionALabel.Text = "a) Орган, відповідальний за травлення";
                Question3OptionBLabel.Text = "b) Командний центр тіла, контролюючи кожну дію і реакцію";
                Question3OptionCLabel.Text = "c) Орган, що бере участь у диханні";

                Question4Label.Text = "4. Яка роль периферичної нервової системи в тілі людини?";
                Question4OptionALabel.Text = "a) Зв'язок центральної нервової системи з рештою тіла";
                Question4OptionBLabel.Text = "b) Контроль дихання";
                Question4OptionCLabel.Text = "c) Контроль травлення";

                Question5Label.Text = "5. Що означає нейрональна пластичність і чому вона важлива?";
                Question5OptionALabel.Text = "a) Здатність утворювати зв'язки між нейронами";
                Question5OptionBLabel.Text = "b) Здатність реорганізовувати зв'язки між нейронами";
                Question5OptionCLabel.Text = "c) Здатність дихати";
                break;
        }
    }

}