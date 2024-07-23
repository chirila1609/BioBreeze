namespace BioBreeze.Teste;

public partial class BotISVVege : ContentPage
{
	public BotISVVege()
	{
		InitializeComponent();
	}
    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        
        if (Question1OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionC.IsChecked)
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
                TitleLabel.Text = "Test înmulțirea prin spori și vegetativă la plante";
                Question1Label.Text = "1. Care este principalul proces de reproducere în rândul plantelor fungice?";
                Question1OptionALabel.Text = "a) Fotosinteza";
                Question1OptionBLabel.Text = "b) Înmulțirea vegetativă";
                Question1OptionCLabel.Text = "c) Sporularea";
                Question1OptionDLabel.Text = "d) Polenizarea";

                Question2Label.Text = "2. Ce reprezintă sporii în cadrul reproducției plantelor?";
                Question2OptionALabel.Text = "a) Structuri de reproducere unicelulare sau multicelulare";
                Question2OptionBLabel.Text = "b) Semințe";
                Question2OptionCLabel.Text = "c) Flori";
                Question2OptionDLabel.Text = "d) Fructe";

                Question3Label.Text = "3. Care dintre următoarele metode NU este o formă de înmulțire vegetativă?";
                Question3OptionALabel.Text = "a) Propagarea prin butași";
                Question3OptionBLabel.Text = "b) Împărțirea tufei";
                Question3OptionCLabel.Text = "c) Rezecția";
                Question3OptionDLabel.Text = "d) Polenizarea";

                Question4Label.Text = "4. Ce este necesar pentru ca un spor să germină și să dezvolte o nouă plantă?";
                Question4OptionALabel.Text = "a) Apă și lumină";
                Question4OptionBLabel.Text = "b) Nutrienți și oxigen";
                Question4OptionCLabel.Text = "c) Polen și fructe";
                Question4OptionDLabel.Text = "d) Mediu adecvat și condiții favorabile";

                Question5Label.Text = "5. Înmulțirea vegetativă este utilizată în principal în care dintre următoarele domenii?";
                Question5OptionALabel.Text = "a) În microbiologie";
                Question5OptionBLabel.Text = "b) În industria alimentară";
                Question5OptionCLabel.Text = "c) În horticultură și agricultură";
                Question5OptionDLabel.Text = "d) În domeniul medicinii";
                break;

            case "hu":
                TitleLabel.Text = "Teszt a spórás és vegetatív szaporodásról növényeknél";
                Question1Label.Text = "1. Mi a fő szaporodási folyamat a gombás növények között?";
                Question1OptionALabel.Text = "a) Fotoszintézis";
                Question1OptionBLabel.Text = "b) Vegetatív szaporodás";
                Question1OptionCLabel.Text = "c) Spóraképzés";
                Question1OptionDLabel.Text = "d) Pollinizáció";

                Question2Label.Text = "2. Mi a szerepe a spóráknak a növények szaporodásában?";
                Question2OptionALabel.Text = "a) Egyszerű vagy többsejtű szaporodási struktúrák";
                Question2OptionBLabel.Text = "b) Magvak";
                Question2OptionCLabel.Text = "c) Virágok";
                Question2OptionDLabel.Text = "d) Gyümölcsök";

                Question3Label.Text = "3. Melyik módszer NEM a vegetatív szaporodás egy formája?";
                Question3OptionALabel.Text = "a) Hajtásokkal történő szaporítás";
                Question3OptionBLabel.Text = "b) Tőosztás";
                Question3OptionCLabel.Text = "c) Rezekció";
                Question3OptionDLabel.Text = "d) Pollinizáció";

                Question4Label.Text = "4. Mi szükséges ahhoz, hogy egy spóra csírázzon és új növényt fejlesszen?";
                Question4OptionALabel.Text = "a) Víz és fény";
                Question4OptionBLabel.Text = "b) Tápanyagok és oxigén";
                Question4OptionCLabel.Text = "c) Pollen és gyümölcsök";
                Question4OptionDLabel.Text = "d) Megfelelő környezet és kedvező feltételek";

                Question5Label.Text = "5. Hol használják elsősorban a vegetatív szaporodást?";
                Question5OptionALabel.Text = "a) Mikrobiológiában";
                Question5OptionBLabel.Text = "b) Élelmiszeriparban";
                Question5OptionCLabel.Text = "c) Kertészetben és mezőgazdaságban";
                Question5OptionDLabel.Text = "d) Orvostudományban";
                break;

            case "uk":
                TitleLabel.Text = "Тест на розмноження через спори та вегетативно у рослин";
                Question1Label.Text = "1. Який основний процес розмноження серед грибкових рослин?";
                Question1OptionALabel.Text = "a) Фотосинтез";
                Question1OptionBLabel.Text = "b) Вегетативне розмноження";
                Question1OptionCLabel.Text = "c) Спороутворення";
                Question1OptionDLabel.Text = "d) Запилення";

                Question2Label.Text = "2. Яке значення спори в розмноженні рослин?";
                Question2OptionALabel.Text = "a) Одноклітинні або багатоклітинні розмножувальні структури";
                Question2OptionBLabel.Text = "b) Насіння";
                Question2OptionCLabel.Text = "c) Квіти";
                Question2OptionDLabel.Text = "d) Плоди";

                Question3Label.Text = "3. Який з наступних методів НЕ є формою вегетативного розмноження?";
                Question3OptionALabel.Text = "a) Розмноження живцями";
                Question3OptionBLabel.Text = "b) Поділ куща";
                Question3OptionCLabel.Text = "c) Резекція";
                Question3OptionDLabel.Text = "d) Запилення";

                Question4Label.Text = "4. Що потрібно для того, щоб спора проросла і розвинула нову рослину?";
                Question4OptionALabel.Text = "a) Вода і світло";
                Question4OptionBLabel.Text = "b) Поживні речовини і кисень";
                Question4OptionCLabel.Text = "c) Пилок і плоди";
                Question4OptionDLabel.Text = "d) Відповідне середовище та сприятливі умови";

                Question5Label.Text = "5. Де в основному використовується вегетативне розмноження?";
                Question5OptionALabel.Text = "a) В мікробіології";
                Question5OptionBLabel.Text = "b) В харчовій промисловості";
                Question5OptionCLabel.Text = "c) В садівництві та сільському господарстві";
                Question5OptionDLabel.Text = "d) В медицині";
                break;
        }
    }

}