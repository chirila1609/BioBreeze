namespace BioBreeze.Teste;

public partial class ZooPeste : ContentPage
{
	public ZooPeste()
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
                Question1Label.Text = "1. Câte specii de pești sunt cunoscute în prezent?";
                Question1OptionALabel.Text = "a) Peste 10.000";
                Question1OptionBLabel.Text = "b) Peste 20.000";
                Question1OptionCLabel.Text = "c) Peste 30.000";
                Question1OptionDLabel.Text = "d) Peste 50.000";

                Question2Label.Text = "2. Care este una dintre adaptările anatomice ale peștilor pentru viața acvatică?";
                Question2OptionALabel.Text = "a) Aripioare pentru zbor";
                Question2OptionBLabel.Text = "b) Coarne pentru apărare";
                Question2OptionCLabel.Text = "c) Branhiile pentru respirație";
                Question2OptionDLabel.Text = "d) Gheare pentru săpat";

                Question3Label.Text = "3. Care este rolul peștilor în ecosistemele acvatice?";
                Question3OptionALabel.Text = "a) Să hrănească rechinii";
                Question3OptionBLabel.Text = "b) Să mențină curățenia în apă";
                Question3OptionCLabel.Text = "c) Să producă electricitate";
                Question3OptionDLabel.Text = "d) Să încălzească apa";

                Question4Label.Text = "4. Care dintre următoarele amenințări pune în pericol speciile de pești?";
                Question4OptionALabel.Text = "a) Suprapopularea";
                Question4OptionBLabel.Text = "b) Creșterea nivelului oceanului";
                Question4OptionCLabel.Text = "c) Suprapescuitul";
                Question4OptionDLabel.Text = "d) Activități vulcanice";

                Question5Label.Text = "5. Care este una dintre funcțiile importante ale solzilor la pești?";
                Question5OptionALabel.Text = "a) Pentru zbor";
                Question5OptionBLabel.Text = "b) Pentru protejarea corpului";
                Question5OptionCLabel.Text = "c) Pentru a se hrăni";
                Question5OptionDLabel.Text = "d) Pentru a străluci în întuneric";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Hány halfaj ismert jelenleg?";
                Question1OptionALabel.Text = "a) Több mint 10.000";
                Question1OptionBLabel.Text = "b) Több mint 20.000";
                Question1OptionCLabel.Text = "c) Több mint 30.000";
                Question1OptionDLabel.Text = "d) Több mint 50.000";

                Question2Label.Text = "2. Mi az egyik anatómiai alkalmazkodás a halak vízi élethez?";
                Question2OptionALabel.Text = "a) Repülő uszonyok";
                Question2OptionBLabel.Text = "b) Védekező szarvak";
                Question2OptionCLabel.Text = "c) Kopoltyúk légzéshez";
                Question2OptionDLabel.Text = "d) Ásó karmaok";

                Question3Label.Text = "3. Mi a halak szerepe a vízi ökoszisztémákban?";
                Question3OptionALabel.Text = "a) Cápák táplálása";
                Question3OptionBLabel.Text = "b) Víz tisztítása";
                Question3OptionCLabel.Text = "c) Elektromosság termelése";
                Question3OptionDLabel.Text = "d) Víz melegítése";

                Question4Label.Text = "4. Melyik fenyegetés veszélyezteti a halak fajait?";
                Question4OptionALabel.Text = "a) Túlnépesedés";
                Question4OptionBLabel.Text = "b) Tengerszint-emelkedés";
                Question4OptionCLabel.Text = "c) Túlvadászat";
                Question4OptionDLabel.Text = "d) Vulkanikus tevékenységek";

                Question5Label.Text = "5. Mi az egyik fontos funkciója a halak pikkelyeinek?";
                Question5OptionALabel.Text = "a) Repüléshez";
                Question5OptionBLabel.Text = "b) Test védelméhez";
                Question5OptionCLabel.Text = "c) Táplálkozáshoz";
                Question5OptionDLabel.Text = "d) Sötétben világításhoz";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Скільки видів риб відомо на сьогодні?";
                Question1OptionALabel.Text = "a) Більше 10.000";
                Question1OptionBLabel.Text = "b) Більше 20.000";
                Question1OptionCLabel.Text = "c) Більше 30.000";
                Question1OptionDLabel.Text = "d) Більше 50.000";

                Question2Label.Text = "2. Яке з анатомічних пристосувань риб для водного життя?";
                Question2OptionALabel.Text = "a) Плавники для польоту";
                Question2OptionBLabel.Text = "b) Роги для захисту";
                Question2OptionCLabel.Text = "c) Жабри для дихання";
                Question2OptionDLabel.Text = "d) Кігті для копання";

                Question3Label.Text = "3. Яка роль риб у водних екосистемах?";
                Question3OptionALabel.Text = "a) Харчування акул";
                Question3OptionBLabel.Text = "b) Очищення води";
                Question3OptionCLabel.Text = "c) Виробництво електрики";
                Question3OptionDLabel.Text = "d) Обігрів води";

                Question4Label.Text = "4. Яка з наступних загроз ставить під загрозу види риб?";
                Question4OptionALabel.Text = "a) Перенаселення";
                Question4OptionBLabel.Text = "b) Підвищення рівня океану";
                Question4OptionCLabel.Text = "c) Перевилов";
                Question4OptionDLabel.Text = "d) Вулканічна діяльність";

                Question5Label.Text = "5. Яка одна з важливих функцій луски у риб?";
                Question5OptionALabel.Text = "a) Для польоту";
                Question5OptionBLabel.Text = "b) Для захисту тіла";
                Question5OptionCLabel.Text = "c) Для харчування";
                Question5OptionDLabel.Text = "d) Для світіння в темряві";
                break;
        }
    }

}