namespace BioBreeze.Teste;

public partial class ZooArtropode : ContentPage
{
	public ZooArtropode()
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

        if (Question2OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionB.IsChecked)
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
                Question1Label.Text = "1. Ce reprezintă exoscheletul în anatomia artropodelor?";
                Question1OptionALabel.Text = "a) Un organ intern esențial";
                Question1OptionBLabel.Text = "b) O structură externă rigidă formată din chitină";
                Question1OptionCLabel.Text = "c) Un organ de reproducere";

                Question2Label.Text = "2. Care dintre următoarele nu este o subclasă a artropodelor?";
                Question2OptionALabel.Text = "a) Chelicerate";
                Question2OptionBLabel.Text = "b) Miriapode";
                Question2OptionCLabel.Text = "c) Osteoderme";

                Question3Label.Text = "3. Care grup de artropode include crabii, homarul și creveții?";
                Question3OptionALabel.Text = "a) Chelicerate";
                Question3OptionBLabel.Text = "b) Crustacee";
                Question3OptionCLabel.Text = "c) Insecte";

                Question4Label.Text = "4. Ce rol îndeplinesc multe artropode în ecosisteme?";
                Question4OptionALabel.Text = "a) Polenizare";
                Question4OptionBLabel.Text = "b) Descompunerea materiei organice";
                Question4OptionCLabel.Text = "c) Ambele variantele de mai sus";

                Question5Label.Text = "5. Care dintre următoarele este o caracteristică comună a tuturor artropodelor?";
                Question5OptionALabel.Text = "a) Corp segmentat";
                Question5OptionBLabel.Text = "b) Prezența a patru picioare";
                Question5OptionCLabel.Text = "c) Absența membrelor articulate";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mit jelent az exoszkeleton az ízeltlábúak anatómiájában?";
                Question1OptionALabel.Text = "a) Egy létfontosságú belső szerv";
                Question1OptionBLabel.Text = "b) Külső merev szerkezet kitinből";
                Question1OptionCLabel.Text = "c) Egy szaporodási szerv";

                Question2Label.Text = "2. Melyik nem az ízeltlábúak alosztálya?";
                Question2OptionALabel.Text = "a) Chelicerate";
                Question2OptionBLabel.Text = "b) Myriapoda";
                Question2OptionCLabel.Text = "c) Osteoderme";

                Question3Label.Text = "3. Melyik ízeltlábú csoportba tartoznak a rákok, homárok és garnélarákok?";
                Question3OptionALabel.Text = "a) Chelicerate";
                Question3OptionBLabel.Text = "b) Crustacea";
                Question3OptionCLabel.Text = "c) Insecta";

                Question4Label.Text = "4. Milyen szerepet töltenek be az ízeltlábúak az ökoszisztémákban?";
                Question4OptionALabel.Text = "a) Beporzás";
                Question4OptionBLabel.Text = "b) Szerves anyagok lebontása";
                Question4OptionCLabel.Text = "c) Mindkettő";

                Question5Label.Text = "5. Melyik a közös jellemzője minden ízeltlábúnak?";
                Question5OptionALabel.Text = "a) Szegmentált test";
                Question5OptionBLabel.Text = "b) Négy láb jelenléte";
                Question5OptionCLabel.Text = "c) Az ízületes végtagok hiánya";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Що таке екзоскелет у анатомії членистоногих?";
                Question1OptionALabel.Text = "a) Внутрішній важливий орган";
                Question1OptionBLabel.Text = "b) Зовнішня тверда структура, що складається з хітину";
                Question1OptionCLabel.Text = "c) Орган розмноження";

                Question2Label.Text = "2. Яка з наступних не є підкласом членистоногих?";
                Question2OptionALabel.Text = "a) Chelicerata";
                Question2OptionBLabel.Text = "b) Myriapoda";
                Question2OptionCLabel.Text = "c) Osteoderme";

                Question3Label.Text = "3. Яка група членистоногих включає крабів, омарів та креветок?";
                Question3OptionALabel.Text = "a) Chelicerata";
                Question3OptionBLabel.Text = "b) Crustacea";
                Question3OptionCLabel.Text = "c) Insecta";

                Question4Label.Text = "4. Яку роль виконують багато членистоногих в екосистемах?";
                Question4OptionALabel.Text = "a) Запилення";
                Question4OptionBLabel.Text = "b) Розкладання органічних речовин";
                Question4OptionCLabel.Text = "c) Обидві варіанти";

                Question5Label.Text = "5. Яка спільна риса всіх членистоногих?";
                Question5OptionALabel.Text = "a) Сегментоване тіло";
                Question5OptionBLabel.Text = "b) Наявність чотирьох ніг";
                Question5OptionCLabel.Text = "c) Відсутність зчленованих кінцівок";
                break;
        }
    }

}