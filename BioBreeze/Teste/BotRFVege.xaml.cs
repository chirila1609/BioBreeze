namespace BioBreeze.Teste;

public partial class BotRFVege : ContentPage
{
	public BotRFVege()
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

        if (Question3OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionA.IsChecked)
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
                Question1Label.Text = "1. Care sunt cele două etape majore ale reproducerii la plantele cu flori?";
                Question1OptionALabel.Text = "a) Polenizarea și germinarea";
                Question1OptionBLabel.Text = "b) Polenizarea și fertilizarea";
                Question1OptionCLabel.Text = "c) Fertilizarea și germinarea";

                Question2Label.Text = "2. Ce este polenizarea anemofilă?";
                Question2OptionALabel.Text = "a) Polenizarea realizată de insecte";
                Question2OptionBLabel.Text = "b) Polenizarea realizată de vânt";
                Question2OptionCLabel.Text = "c) Polenizarea realizată de păsări";

                Question3Label.Text = "3. Care parte a florii este responsabilă pentru producerea polenului?";
                Question3OptionALabel.Text = "a) Petalele";
                Question3OptionBLabel.Text = "b) Pistilul";
                Question3OptionCLabel.Text = "c) Staminele";

                Question4Label.Text = "4. Ce se întâmplă în ovarul din pistil după fertilizare?";
                Question4OptionALabel.Text = "a) Se formează fructul";
                Question4OptionBLabel.Text = "b) Se formează sămânța";
                Question4OptionCLabel.Text = "c) Se formează polenul";

                Question5Label.Text = "5. Care este rolul fructului în reproducerea plantelor cu flori?";
                Question5OptionALabel.Text = "a) Protejează și susține sămânța";
                Question5OptionBLabel.Text = "b) Produce polenul";
                Question5OptionCLabel.Text = "c) Asigură fotosinteza plantei";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mik a virágos növények szaporodásának két fő szakasza?";
                Question1OptionALabel.Text = "a) Beporzás és csírázás";
                Question1OptionBLabel.Text = "b) Beporzás és megtermékenyítés";
                Question1OptionCLabel.Text = "c) Megtermékenyítés és csírázás";

                Question2Label.Text = "2. Mi az anemofil beporzás?";
                Question2OptionALabel.Text = "a) Rovarok általi beporzás";
                Question2OptionBLabel.Text = "b) Szél általi beporzás";
                Question2OptionCLabel.Text = "c) Madarak általi beporzás";

                Question3Label.Text = "3. A virágnak melyik része felelős a pollen előállításáért?";
                Question3OptionALabel.Text = "a) Sziromlevelek";
                Question3OptionBLabel.Text = "b) Bibe";
                Question3OptionCLabel.Text = "c) Porzók";

                Question4Label.Text = "4. Mi történik a bibében lévő petefészekben a megtermékenyítés után?";
                Question4OptionALabel.Text = "a) A gyümölcs kialakul";
                Question4OptionBLabel.Text = "b) A mag kialakul";
                Question4OptionCLabel.Text = "c) A pollen kialakul";

                Question5Label.Text = "5. Mi a gyümölcs szerepe a virágos növények szaporodásában?";
                Question5OptionALabel.Text = "a) Védi és támogatja a magot";
                Question5OptionBLabel.Text = "b) Pollen előállítása";
                Question5OptionCLabel.Text = "c) Biztosítja a növény fotoszintézisét";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які дві основні стадії розмноження у квіткових рослин?";
                Question1OptionALabel.Text = "a) Запилення та проростання";
                Question1OptionBLabel.Text = "b) Запилення та запліднення";
                Question1OptionCLabel.Text = "c) Запліднення та проростання";

                Question2Label.Text = "2. Що таке анемофільне запилення?";
                Question2OptionALabel.Text = "a) Запилення комахами";
                Question2OptionBLabel.Text = "b) Запилення вітром";
                Question2OptionCLabel.Text = "c) Запилення птахами";

                Question3Label.Text = "3. Яка частина квітки відповідає за виробництво пилку?";
                Question3OptionALabel.Text = "a) Пелюстки";
                Question3OptionBLabel.Text = "b) Маточка";
                Question3OptionCLabel.Text = "c) Тичинки";

                Question4Label.Text = "4. Що відбувається в зав’язі маточки після запліднення?";
                Question4OptionALabel.Text = "a) Утворюється плід";
                Question4OptionBLabel.Text = "b) Утворюється насіння";
                Question4OptionCLabel.Text = "c) Утворюється пилок";

                Question5Label.Text = "5. Яка роль плоду у розмноженні квіткових рослин?";
                Question5OptionALabel.Text = "a) Захищає і підтримує насіння";
                Question5OptionBLabel.Text = "b) Виробляє пилок";
                Question5OptionCLabel.Text = "c) Забезпечує фотосинтез рослини";
                break;
        }
    }

}