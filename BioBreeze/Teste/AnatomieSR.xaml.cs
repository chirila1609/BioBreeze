namespace BioBreeze.Teste;

public partial class AnatomieSR : ContentPage
{
	public AnatomieSR()
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
                TitleLabel.Text = "Test sistemul respirator";
                Question1Label.Text = "1. Care sunt structurile care fac parte din căile respiratorii superioare?";
                Question1OptionALabel.Text = "a) Traheea și bronhiile";
                Question1OptionBLabel.Text = "b) Plămânii și alveolele";
                Question1OptionCLabel.Text = "c) Nasul, faringele și laringele";
                Question1OptionDLabel.Text = "d) Inimă și ficatul";

                Question2Label.Text = "2. Ce proces are loc în alveolele pulmonare?";
                Question2OptionALabel.Text = "a) Digestia alimentelor";
                Question2OptionBLabel.Text = "b) Schimbul de gaze între aerul inhalat și sânge";
                Question2OptionCLabel.Text = "c) Filtrarea aerului";
                Question2OptionDLabel.Text = "d) Transportul de oxigen către celule";

                Question3Label.Text = "3. Care este rolul principal al sistemului respirator?";
                Question3OptionALabel.Text = "a) Transportul de nutrienți către celule";
                Question3OptionBLabel.Text = "b) Menținerea echilibrului de lichide în corp";
                Question3OptionCLabel.Text = "c) Schimbul de gaze între organism și mediu";
                Question3OptionDLabel.Text = "d) Controlul temperaturii corpului";

                Question4Label.Text = "4. Ce substanță este preluată de sânge din alveolele pulmonare?";
                Question4OptionALabel.Text = "a) Oxigen";
                Question4OptionBLabel.Text = "b) Azot";
                Question4OptionCLabel.Text = "c) Dioxid de carbon";
                Question4OptionDLabel.Text = "d) Hidrogen";

                Question5Label.Text = "5. Care este importanța filtrării și umidificării aerului în sistemul respirator?";
                Question5OptionALabel.Text = "a) Protejează plămânii și ajută la schimbul de gaze";
                Question5OptionBLabel.Text = "b) Reduce riscul de fracturi osoase";
                Question5OptionCLabel.Text = "c) Îmbunătățește vederea";
                Question5OptionDLabel.Text = "d) Stimulează sistemul imunitar";
                break;

            case "hu":
                TitleLabel.Text = "Légzőrendszer teszt";
                Question1Label.Text = "1. Mely struktúrák tartoznak a felső légutakhoz?";
                Question1OptionALabel.Text = "a) A légcső és a hörgők";
                Question1OptionBLabel.Text = "b) A tüdők és az alveolusok";
                Question1OptionCLabel.Text = "c) Az orr, a garat és a gége";
                Question1OptionDLabel.Text = "d) A szív és a máj";

                Question2Label.Text = "2. Milyen folyamat zajlik a tüdőhólyagocskákban?";
                Question2OptionALabel.Text = "a) Az ételek emésztése";
                Question2OptionBLabel.Text = "b) A gázcsere a belélegzett levegő és a vér között";
                Question2OptionCLabel.Text = "c) A levegő szűrése";
                Question2OptionDLabel.Text = "d) Az oxigén szállítása a sejtekhez";

                Question3Label.Text = "3. Mi a légzőrendszer fő szerepe?";
                Question3OptionALabel.Text = "a) Tápanyagok szállítása a sejtekhez";
                Question3OptionBLabel.Text = "b) A folyadékkiegyensúlyozás fenntartása a testben";
                Question3OptionCLabel.Text = "c) A gázcsere a szervezet és a környezet között";
                Question3OptionDLabel.Text = "d) A testhőmérséklet szabályozása";

                Question4Label.Text = "4. Milyen anyagot vesz fel a vér a tüdőhólyagocskákból?";
                Question4OptionALabel.Text = "a) Oxigén";
                Question4OptionBLabel.Text = "b) Nitrogén";
                Question4OptionCLabel.Text = "c) Szén-dioxid";
                Question4OptionDLabel.Text = "d) Hidrogén";

                Question5Label.Text = "5. Mi a szerepe a levegő szűrésének és párásításának a légzőrendszerben?";
                Question5OptionALabel.Text = "a) Védi a tüdőt és segíti a gázcserét";
                Question5OptionBLabel.Text = "b) Csökkenti a csonttörések kockázatát";
                Question5OptionCLabel.Text = "c) Javítja a látást";
                Question5OptionDLabel.Text = "d) Serkenti az immunrendszert";
                break;

            case "uk":
                TitleLabel.Text = "Тест на дихальну систему";
                Question1Label.Text = "1. Які структури входять до складу верхніх дихальних шляхів?";
                Question1OptionALabel.Text = "a) Трахея і бронхи";
                Question1OptionBLabel.Text = "b) Легені та альвеоли";
                Question1OptionCLabel.Text = "c) Ніс, глотка та гортань";
                Question1OptionDLabel.Text = "d) Серце та печінка";

                Question2Label.Text = "2. Який процес відбувається в легеневих альвеолах?";
                Question2OptionALabel.Text = "a) Перетравлення їжі";
                Question2OptionBLabel.Text = "b) Газообмін між вдиханим повітрям і кров’ю";
                Question2OptionCLabel.Text = "c) Фільтрація повітря";
                Question2OptionDLabel.Text = "d) Транспортування кисню до клітин";

                Question3Label.Text = "3. Яка основна роль дихальної системи?";
                Question3OptionALabel.Text = "a) Транспортування поживних речовин до клітин";
                Question3OptionBLabel.Text = "b) Підтримка водного балансу в організмі";
                Question3OptionCLabel.Text = "c) Газообмін між організмом і навколишнім середовищем";
                Question3OptionDLabel.Text = "d) Контроль температури тіла";

                Question4Label.Text = "4. Яка речовина поглинається кров’ю з легеневих альвеол?";
                Question4OptionALabel.Text = "a) Кисень";
                Question4OptionBLabel.Text = "b) Азот";
                Question4OptionCLabel.Text = "c) Вуглекислий газ";
                Question4OptionDLabel.Text = "d) Водень";

                Question5Label.Text = "5. Яке значення має фільтрація і зволоження повітря в дихальній системі?";
                Question5OptionALabel.Text = "a) Захищає легені та допомагає в газообміні";
                Question5OptionBLabel.Text = "b) Знижує ризик переломів кісток";
                Question5OptionCLabel.Text = "c) Покращує зір";
                Question5OptionDLabel.Text = "d) Стимулює імунну систему";
                break;
        }
    }

}