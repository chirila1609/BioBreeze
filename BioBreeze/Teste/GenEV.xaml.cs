namespace BioBreeze.Teste;

public partial class GenEV : ContentPage
{
	public GenEV()
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

        if (Question2OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionC.IsChecked)
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
                Question1Label.Text = "1. Ce este ereditatea în biologie?";
                Question1OptionALabel.Text = "a) Transmiterea trăsăturilor genetice de la părinți la urmași";
                Question1OptionBLabel.Text = "b) Variabilitatea individuală în cadrul unei populații";
                Question1OptionCLabel.Text = "c) Procesul de adaptare la mediu";
                Question1OptionDLabel.Text = "d) Schimbul de informații genetice între organisme";

                Question2Label.Text = "2. Care dintre următoarele nu este o trăsătură a variabilității?";
                Question2OptionALabel.Text = "a) Aspectul fizic";
                Question2OptionBLabel.Text = "b) Comportamentul";
                Question2OptionCLabel.Text = "c) Ereditatea";
                Question2OptionDLabel.Text = "d) Adaptările la mediu";

                Question3Label.Text = "3. Ce transportă materialul genetic de la o generație la alta?";
                Question3OptionALabel.Text = "a) ARN";
                Question3OptionBLabel.Text = "b) Proteinele";
                Question3OptionCLabel.Text = "c) ADN";
                Question3OptionDLabel.Text = "d) Carbohidrații";

                Question4Label.Text = "4. Care dintre următoarele nu este un mecanism important al variabilității genetice?";
                Question4OptionALabel.Text = "a) Mutatiile genetice";
                Question4OptionBLabel.Text = "b) Recombinarea genetică";
                Question4OptionCLabel.Text = "c) Selecția artificială";
                Question4OptionDLabel.Text = "d) Selecția naturală";

                Question5Label.Text = "5. Ce contribuie la adaptarea la mediu și la apariția de noi specii?";
                Question5OptionALabel.Text = "a) Ereditatea și variabilitatea";
                Question5OptionBLabel.Text = "b) Selecția artificială";
                Question5OptionCLabel.Text = "c) Recombinarea genetică";
                Question5OptionDLabel.Text = "d) Mutatiile genetice";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi az öröklődés a biológiában?";
                Question1OptionALabel.Text = "a) A genetikai tulajdonságok átadása a szülőktől az utódokhoz";
                Question1OptionBLabel.Text = "b) Az egyéni változékonyság egy populáción belül";
                Question1OptionCLabel.Text = "c) Az alkalmazkodási folyamat";
                Question1OptionDLabel.Text = "d) A genetikai információ cseréje az organizmusok között";

                Question2Label.Text = "2. Melyik nem a változékonyság jellemzője?";
                Question2OptionALabel.Text = "a) Fizikai megjelenés";
                Question2OptionBLabel.Text = "b) Viselkedés";
                Question2OptionCLabel.Text = "c) Öröklődés";
                Question2OptionDLabel.Text = "d) Környezeti alkalmazkodás";

                Question3Label.Text = "3. Mi szállítja a genetikai anyagot egyik generációról a másikra?";
                Question3OptionALabel.Text = "a) RNS";
                Question3OptionBLabel.Text = "b) Fehérjék";
                Question3OptionCLabel.Text = "c) DNS";
                Question3OptionDLabel.Text = "d) Szénhidrátok";

                Question4Label.Text = "4. Melyik nem fontos mechanizmusa a genetikai változékonyságnak?";
                Question4OptionALabel.Text = "a) Genetikai mutációk";
                Question4OptionBLabel.Text = "b) Genetikai rekombináció";
                Question4OptionCLabel.Text = "c) Mesterséges szelekció";
                Question4OptionDLabel.Text = "d) Természetes szelekció";

                Question5Label.Text = "5. Mi járul hozzá a környezeti alkalmazkodáshoz és új fajok megjelenéséhez?";
                Question5OptionALabel.Text = "a) Öröklődés és változékonyság";
                Question5OptionBLabel.Text = "b) Mesterséges szelekció";
                Question5OptionCLabel.Text = "c) Genetikai rekombináció";
                Question5OptionDLabel.Text = "d) Genetikai mutációk";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Що таке спадковість у біології?";
                Question1OptionALabel.Text = "a) Передача генетичних ознак від батьків до нащадків";
                Question1OptionBLabel.Text = "b) Індивідуальна варіабельність у межах популяції";
                Question1OptionCLabel.Text = "c) Процес адаптації до середовища";
                Question1OptionDLabel.Text = "d) Обмін генетичною інформацією між організмами";

                Question2Label.Text = "2. Яка з наступних не є характеристикою варіабельності?";
                Question2OptionALabel.Text = "a) Фізичний вигляд";
                Question2OptionBLabel.Text = "b) Поведінка";
                Question2OptionCLabel.Text = "c) Спадковість";
                Question2OptionDLabel.Text = "d) Адаптації до середовища";

                Question3Label.Text = "3. Що переносить генетичний матеріал з покоління в покоління?";
                Question3OptionALabel.Text = "a) РНК";
                Question3OptionBLabel.Text = "b) Білки";
                Question3OptionCLabel.Text = "c) ДНК";
                Question3OptionDLabel.Text = "d) Вуглеводи";

                Question4Label.Text = "4. Який з наступних не є важливим механізмом генетичної варіабельності?";
                Question4OptionALabel.Text = "a) Генетичні мутації";
                Question4OptionBLabel.Text = "b) Генетична рекомбінація";
                Question4OptionCLabel.Text = "c) Штучний відбір";
                Question4OptionDLabel.Text = "d) Природний відбір";

                Question5Label.Text = "5. Що сприяє адаптації до середовища і появі нових видів?";
                Question5OptionALabel.Text = "a) Спадковість і варіабельність";
                Question5OptionBLabel.Text = "b) Штучний відбір";
                Question5OptionCLabel.Text = "c) Генетична рекомбінація";
                Question5OptionDLabel.Text = "d) Генетичні мутації";
                break;
        }
    }


}