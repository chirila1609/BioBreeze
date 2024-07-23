namespace BioBreeze.Teste;

public partial class ZooMoluste : ContentPage
{
	public ZooMoluste()
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

        if (Question4OptionB.IsChecked)
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
                Question1Label.Text = "1. Care este unul dintre trăsăturile anatomice comune ale moluștelor?";
                Question1OptionALabel.Text = "a) Aripioare pentru zbor";
                Question1OptionBLabel.Text = "b) Cochilie externă";
                Question1OptionCLabel.Text = "c) Coarne pentru înot";

                Question2Label.Text = "2. Care este organul principal al moluștelor care secretă cochilia?";
                Question2OptionALabel.Text = "a) Piciorul";
                Question2OptionBLabel.Text = "b) Mantia";
                Question2OptionCLabel.Text = "c) Gura";

                Question3Label.Text = "3. Unde pot trăi moluștele?";
                Question3OptionALabel.Text = "a) Doar pe uscat";
                Question3OptionBLabel.Text = "b) Doar în apă dulce";
                Question3OptionCLabel.Text = "c) În medii marine, terestre și de apă dulce";

                Question4Label.Text = "4. Care este rolul ecologic al moluștelor în ecosisteme?";
                Question4OptionALabel.Text = "a) Nu au un rol ecologic";
                Question4OptionBLabel.Text = "b) Contribuie la reciclarea materiei organice";
                Question4OptionCLabel.Text = "c) Sunt doar pradă pentru alte animale";

                Question5Label.Text = "5. Care este una dintre importanțele economice ale moluștelor?";
                Question5OptionALabel.Text = "a) Ele nu au importanță economică";
                Question5OptionBLabel.Text = "b) Sunt pescuite pentru consumul uman ";
                Question5OptionCLabel.Text = "c) Sunt doar o atracție turistică";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a közös anatómiai jellemzője a puhatestűeknek?";
                Question1OptionALabel.Text = "a) Szárnyak a repüléshez";
                Question1OptionBLabel.Text = "b) Külső héj";
                Question1OptionCLabel.Text = "c) Uszonyok úszáshoz";

                Question2Label.Text = "2. Mi a puhatestűek fő szervje, amely a héjat termeli?";
                Question2OptionALabel.Text = "a) Láb";
                Question2OptionBLabel.Text = "b) Köpeny";
                Question2OptionCLabel.Text = "c) Száj";

                Question3Label.Text = "3. Hol élhetnek a puhatestűek?";
                Question3OptionALabel.Text = "a) Csak szárazföldön";
                Question3OptionBLabel.Text = "b) Csak édesvízben";
                Question3OptionCLabel.Text = "c) Tengeri, szárazföldi és édesvízi környezetben";

                Question4Label.Text = "4. Mi a puhatestűek ökológiai szerepe az ökoszisztémákban?";
                Question4OptionALabel.Text = "a) Nincs ökológiai szerepük";
                Question4OptionBLabel.Text = "b) Hozzájárulnak az organikus anyagok újrahasznosításához";
                Question4OptionCLabel.Text = "c) Csak táplálék más állatok számára";

                Question5Label.Text = "5. Mi a puhatestűek gazdasági jelentősége?";
                Question5OptionALabel.Text = "a) Nincs gazdasági jelentőségük";
                Question5OptionBLabel.Text = "b) Emberi fogyasztásra halásznak";
                Question5OptionCLabel.Text = "c) Csak turisztikai attrakció";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка одна з загальних анатомічних рис молюсків?";
                Question1OptionALabel.Text = "a) Крила для польоту";
                Question1OptionBLabel.Text = "b) Зовнішня раковина";
                Question1OptionCLabel.Text = "c) Плавники для плавання";

                Question2Label.Text = "2. Який основний орган молюсків, що секретує раковину?";
                Question2OptionALabel.Text = "a) Нога";
                Question2OptionBLabel.Text = "b) Мантія";
                Question2OptionCLabel.Text = "c) Рот";

                Question3Label.Text = "3. Де можуть жити молюски?";
                Question3OptionALabel.Text = "a) Тільки на суші";
                Question3OptionBLabel.Text = "b) Тільки в прісній воді";
                Question3OptionCLabel.Text = "c) В морських, наземних і прісноводних середовищах";

                Question4Label.Text = "4. Яка екологічна роль молюсків в екосистемах?";
                Question4OptionALabel.Text = "a) Не мають екологічної ролі";
                Question4OptionBLabel.Text = "b) Сприяють переробці органічних речовин";
                Question4OptionCLabel.Text = "c) Є лише їжею для інших тварин";

                Question5Label.Text = "5. Яке економічне значення молюсків?";
                Question5OptionALabel.Text = "a) Не мають економічного значення";
                Question5OptionBLabel.Text = "b) Ловлять для споживання людиною";
                Question5OptionCLabel.Text = "c) Є лише туристичною атракцією";
                break;
        }
    }

}