namespace BioBreeze.Teste;

public partial class ZooRAnimale : ContentPage
{
	public ZooRAnimale()
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
                Question1Label.Text = "1. Ce organe utilizează majoritatea animalelor terestre pentru respirație?";
                Question1OptionALabel.Text = "a) Branhiile";
                Question1OptionBLabel.Text = "b) Plămânii";
                Question1OptionCLabel.Text = "c) Membrana celulară";

                Question2Label.Text = "2. Care este sistemul respirator folosit de pești pentru a extrage oxigenul din apă?";
                Question2OptionALabel.Text = "a) Plămânii";
                Question2OptionBLabel.Text = "b) Branhiile";
                Question2OptionCLabel.Text = "c) Tracheelele";

                Question3Label.Text = "3. Cum se numește sistemul respirator unic al păsărilor, care implică un flux unidirecțional de aer în plămâni?";
                Question3OptionALabel.Text = "a) Flux bidirecțional";
                Question3OptionBLabel.Text = "b) Flux contracurent";
                Question3OptionCLabel.Text = "c) Flux difuz";

                Question4Label.Text = "4. Care organisme pot realiza schimburile de gaze prin difuzie directă prin membrana lor celulară?";
                Question4OptionALabel.Text = "a) Păsările";
                Question4OptionBLabel.Text = "b) Peștii";
                Question4OptionCLabel.Text = "c) Protozoarele și unele nevertebrate simple";

                Question5Label.Text = "5. Care este structura microscopică care facilitează schimbul de gaze între aerul inspirat și sângele circulant în plămânii mamiferelor?";
                Question5OptionALabel.Text = "a) Alveolele";
                Question5OptionBLabel.Text = "b) Bronhiile";
                Question5OptionCLabel.Text = "c) Păsări";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik szervet használják a szárazföldi állatok többsége a légzéshez?";
                Question1OptionALabel.Text = "a) Kopoltyúk";
                Question1OptionBLabel.Text = "b) Tüdő";
                Question1OptionCLabel.Text = "c) Sejtfal";

                Question2Label.Text = "2. Melyik légzőszervet használják a halak az oxigén kivonására a vízből?";
                Question2OptionALabel.Text = "a) Tüdő";
                Question2OptionBLabel.Text = "b) Kopoltyúk";
                Question2OptionCLabel.Text = "c) Tracheák";

                Question3Label.Text = "3. Mi a madarak egyedülálló légzőrendszerének neve, amely egyirányú légáramlást biztosít a tüdőben?";
                Question3OptionALabel.Text = "a) Kétirányú áramlás";
                Question3OptionBLabel.Text = "b) Ellenáramú áramlás";
                Question3OptionCLabel.Text = "c) Elágazó áramlás";

                Question4Label.Text = "4. Mely szervezetek képesek közvetlen gázcserére a sejthártyájukon keresztül?";
                Question4OptionALabel.Text = "a) Madarak";
                Question4OptionBLabel.Text = "b) Halak";
                Question4OptionCLabel.Text = "c) Egysejtűek és néhány egyszerűbb gerinctelen";

                Question5Label.Text = "5. Mi az a mikroszkopikus struktúra, amely lehetővé teszi a gázcserét a belélegzett levegő és a keringő vér között az emlősök tüdejében?";
                Question5OptionALabel.Text = "a) Léghólyagocskák";
                Question5OptionBLabel.Text = "b) Hörgők";
                Question5OptionCLabel.Text = "c) Madarak";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які органи використовують більшість наземних тварин для дихання?";
                Question1OptionALabel.Text = "a) Жабри";
                Question1OptionBLabel.Text = "b) Легені";
                Question1OptionCLabel.Text = "c) Клітинна мембрана";

                Question2Label.Text = "2. Яка система дихання використовується рибами для витягання кисню з води?";
                Question2OptionALabel.Text = "a) Легені";
                Question2OptionBLabel.Text = "b) Жабри";
                Question2OptionCLabel.Text = "c) Трахеї";

                Question3Label.Text = "3. Як називається унікальна дихальна система птахів, яка передбачає односпрямований потік повітря через легені?";
                Question3OptionALabel.Text = "a) Двосторонній потік";
                Question3OptionBLabel.Text = "b) Протилежний потік";
                Question3OptionCLabel.Text = "c) Розсіяний потік";

                Question4Label.Text = "4. Які організми можуть здійснювати газообмін через пряме дифузійне проникнення через свою клітинну мембрану?";
                Question4OptionALabel.Text = "a) Птахи";
                Question4OptionBLabel.Text = "b) Риби";
                Question4OptionCLabel.Text = "c) Одноклітинні та деякі прості безхребетні";

                Question5Label.Text = "5. Яка мікроскопічна структура сприяє обміну газів між вдихуваним повітрям і циркулюючою кров'ю в легенях ссавців?";
                Question5OptionALabel.Text = "a) Альвеоли";
                Question5OptionBLabel.Text = "b) Бронхи";
                Question5OptionCLabel.Text = "c) Птахи";
                break;
        }
    }

}