namespace BioBreeze.Teste;

public partial class BotCVege : ContentPage
{
	public BotCVege()
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

        if (Question4OptionB.IsChecked)
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
                TitleLabel.Text = "Test sistemul circulator vegetal";
                Question1Label.Text = "1. Care sunt cele două tipuri principale de țesuturi care alcătuiesc sistemul vascular la plante?";
                Question1OptionALabel.Text = "a) Epidermă și parenchim";
                Question1OptionBLabel.Text = "b) Xilem și floem";
                Question1OptionCLabel.Text = "c) Meristem și colenchim";
                Question1OptionDLabel.Text = "d) Stomate și tricomi";

                Question2Label.Text = "2. Ce rol are transpirația în circulația la plante?";
                Question2OptionALabel.Text = "a) Absorbția substanțelor minerale";
                Question2OptionBLabel.Text = "b) Transportul zaharurilor prin floem";
                Question2OptionCLabel.Text = "c) Răcirea plantei și menținerea echilibrului apei";
                Question2OptionDLabel.Text = "d) Deschiderea stomatelor";

                Question3Label.Text = "3. Ce substanțe sunt transportate prin floem?";
                Question3OptionALabel.Text = "a) Apă și substanțe minerale";
                Question3OptionBLabel.Text = "b) Zaharuri și alte substanțe organice";
                Question3OptionCLabel.Text = "c) Oxigen și dioxid de carbon";
                Question3OptionDLabel.Text = "d) Substanțe toxice";

                Question4Label.Text = "4. Cum se numește fenomenul prin care apa este eliminată prin porii specializați de pe suprafața frunzelor?";
                Question4OptionALabel.Text = "a) Transpirație";
                Question4OptionBLabel.Text = "b) Transpirație gutată";
                Question4OptionCLabel.Text = "c) Evapotranspirație";
                Question4OptionDLabel.Text = "d) Absorție";

                Question5Label.Text = "5. Care este rolul principal al xilemului în circulația la plante?";
                Question5OptionALabel.Text = "a) Transportul apei și substanțelor minerale de la rădăcini spre partea de sus a plantei";
                Question5OptionBLabel.Text = "b) Transportul zaharurilor prin floem";
                Question5OptionCLabel.Text = "c) Răcirea plantei";
                Question5OptionDLabel.Text = "d) Menținerea echilibrului apei";
                break;

            case "hu":
                TitleLabel.Text = "Növényi keringési rendszer teszt";
                Question1Label.Text = "1. Melyik két fő szövet típust alkotja a növények keringési rendszerét?";
                Question1OptionALabel.Text = "a) Epidermisz és parenchima";
                Question1OptionBLabel.Text = "b) Xilema és floéma";
                Question1OptionCLabel.Text = "c) Merisztéma és kollenchima";
                Question1OptionDLabel.Text = "d) Stomák és trichomák";

                Question2Label.Text = "2. Mi a szerepe a transzspirációnak a növények keringésében?";
                Question2OptionALabel.Text = "a) Ásványi anyagok felszívása";
                Question2OptionBLabel.Text = "b) Cukrok szállítása a floémán keresztül";
                Question2OptionCLabel.Text = "c) A növény hűtése és a víz egyensúlyának fenntartása";
                Question2OptionDLabel.Text = "d) Stomák nyitása";

                Question3Label.Text = "3. Milyen anyagok szállítódnak a floémán keresztül?";
                Question3OptionALabel.Text = "a) Víz és ásványi anyagok";
                Question3OptionBLabel.Text = "b) Cukrok és egyéb szerves anyagok";
                Question3OptionCLabel.Text = "c) Oxigén és szén-dioxid";
                Question3OptionDLabel.Text = "d) Mérgező anyagok";

                Question4Label.Text = "4. Hogyan nevezik azt a jelenséget, amikor a víz a levelek speciális pórusain keresztül távozik?";
                Question4OptionALabel.Text = "a) Transzspiráció";
                Question4OptionBLabel.Text = "b) Gutáció";
                Question4OptionCLabel.Text = "c) Evapotranszpiráció";
                Question4OptionDLabel.Text = "d) Felszívódás";

                Question5Label.Text = "5. Mi a xilema fő szerepe a növények keringésében?";
                Question5OptionALabel.Text = "a) Víz és ásványi anyagok szállítása a gyökerektől a növény tetejéig";
                Question5OptionBLabel.Text = "b) Cukrok szállítása a floémán keresztül";
                Question5OptionCLabel.Text = "c) Növény hűtése";
                Question5OptionDLabel.Text = "d) Víz egyensúlyának fenntartása";
                break;

            case "uk":
                TitleLabel.Text = "Тест на рослинну циркуляцію";
                Question1Label.Text = "1. Які два основні типи тканин утворюють судинну систему рослин?";
                Question1OptionALabel.Text = "a) Епідерміс і паренхіма";
                Question1OptionBLabel.Text = "b) Ксилема і флоема";
                Question1OptionCLabel.Text = "c) Меристем і коленхіма";
                Question1OptionDLabel.Text = "d) Стоми і трихоми";

                Question2Label.Text = "2. Яка роль транспірації в циркуляції рослин?";
                Question2OptionALabel.Text = "a) Абсорбція мінеральних речовин";
                Question2OptionBLabel.Text = "b) Транспортування цукрів через флоему";
                Question2OptionCLabel.Text = "c) Охолодження рослини і підтримка водного балансу";
                Question2OptionDLabel.Text = "d) Відкриття стом";

                Question3Label.Text = "3. Які речовини транспортуються через флоему?";
                Question3OptionALabel.Text = "a) Вода і мінеральні речовини";
                Question3OptionBLabel.Text = "b) Цукри та інші органічні речовини";
                Question3OptionCLabel.Text = "c) Кисень і вуглекислий газ";
                Question3OptionDLabel.Text = "d) Токсичні речовини";

                Question4Label.Text = "4. Як називається явище, при якому вода вивільняється через спеціалізовані пори на поверхні листя?";
                Question4OptionALabel.Text = "a) Транспірація";
                Question4OptionBLabel.Text = "b) Гуттація";
                Question4OptionCLabel.Text = "c) Евапотранспірація";
                Question4OptionDLabel.Text = "d) Абсорбція";

                Question5Label.Text = "5. Яка головна роль ксилеми в циркуляції рослин?";
                Question5OptionALabel.Text = "a) Транспортування води та мінеральних речовин від коренів до верхньої частини рослини";
                Question5OptionBLabel.Text = "b) Транспортування цукрів через флоему";
                Question5OptionCLabel.Text = "c) Охолодження рослини";
                Question5OptionDLabel.Text = "d) Підтримка водного балансу";
                break;
        }
    }

}