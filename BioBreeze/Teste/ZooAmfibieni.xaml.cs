namespace BioBreeze.Teste;

public partial class ZooAmfibieni : ContentPage
{
	public ZooAmfibieni()
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
                Question1Label.Text = "1. Care sunt cele trei grupuri principale de amfibieni menționate în text?";
                Question1OptionALabel.Text = "a) Broaște, crocodili, șerpi";
                Question1OptionBLabel.Text = "b) Broaște, salamandre, tritoni";
                Question1OptionCLabel.Text = "c) Păianjeni, furnici, gândaci";

                Question2Label.Text = "2. Ce reprezintă stadiul intermediar în ciclul de viață al amfibienilor?";
                Question2OptionALabel.Text = "a) Larvele";
                Question2OptionBLabel.Text = "b) Adulții";
                Question2OptionCLabel.Text = "c) Tânărul de metamorfoză";

                Question3Label.Text = "3. Cum respiră amfibienii prin piele?";
                Question3OptionALabel.Text = "a) Nu respiră prin piele";
                Question3OptionBLabel.Text = "b) Absorb oxigenul din apă prin piele";
                Question3OptionCLabel.Text = "c) Absorb oxigenul din aer prin piele";

                Question4Label.Text = "4. Care este unul dintre principalii factori de amenințare pentru amfibieni menționat în text?";
                Question4OptionALabel.Text = "a) Prezența unor prădători naturali";
                Question4OptionBLabel.Text = "b) Pierderea habitatului";
                Question4OptionCLabel.Text = "c) Creșterea populației lor";

                Question5Label.Text = "5. De ce este importantă conservarea amfibienilor?";
                Question5OptionALabel.Text = "a) Pentru a le folosi ca animale de companie";
                Question5OptionBLabel.Text = "b) Pentru menținerea echilibrului ecologic și protejarea diversității biologice";
                Question5OptionCLabel.Text = "c) Pentru a crea noi medicamente";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mik a három fő amfíbia csoport, amelyet a szöveg említ?";
                Question1OptionALabel.Text = "a) Béka, krokodilok, kígyók";
                Question1OptionBLabel.Text = "b) Béka, szalamandrák, newik";
                Question1OptionCLabel.Text = "c) Pókok, hangyák, bogarak";

                Question2Label.Text = "2. Mi az amfibiók életciklusának közbenső szakasza?";
                Question2OptionALabel.Text = "a) Lárvák";
                Question2OptionBLabel.Text = "b) Felnőttek";
                Question2OptionCLabel.Text = "c) Kifejlődés alatt álló fiatal";

                Question3Label.Text = "3. Hogyan lélegeznek a kétéltűek a bőrükön keresztül?";
                Question3OptionALabel.Text = "a) Nem lélegeznek a bőrükön keresztül";
                Question3OptionBLabel.Text = "b) Oxigént szívnak fel a vízből a bőrükön keresztül";
                Question3OptionCLabel.Text = "c) Oxigént szívnak fel a levegőből a bőrükön keresztül";

                Question4Label.Text = "4. Mi az egyik fő fenyegető tényező az amfibiókra nézve, amelyet a szöveg említ?";
                Question4OptionALabel.Text = "a) Természetes ragadozók jelenléte";
                Question4OptionBLabel.Text = "b) Élőhely elvesztése";
                Question4OptionCLabel.Text = "c) Népsűrűség növekedése";

                Question5Label.Text = "5. Miért fontos az amfibiók megőrzése?";
                Question5OptionALabel.Text = "a) Házikedvencként való használatukért";
                Question5OptionBLabel.Text = "b) Az ökológiai egyensúly fenntartása és a biológiai sokféleség védelme érdekében";
                Question5OptionCLabel.Text = "c) Új gyógyszerek kifejlesztéséért";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які три основні групи амфібій згадуються в тексті?";
                Question1OptionALabel.Text = "a) Жаби, крокодили, змії";
                Question1OptionBLabel.Text = "b) Жаби, саламандри, тритони";
                Question1OptionCLabel.Text = "c) Павуки, мурахи, жукі";

                Question2Label.Text = "2. Що представляє проміжний стадій в життєвому циклі амфібій?";
                Question2OptionALabel.Text = "a) Личинки";
                Question2OptionBLabel.Text = "b) Дорослі";
                Question2OptionCLabel.Text = "c) Молодь, що проходить метаморфоз";

                Question3Label.Text = "3. Як амфібії дихають через шкіру?";
                Question3OptionALabel.Text = "a) Не дихають через шкіру";
                Question3OptionBLabel.Text = "b) Абсорбують кисень з води через шкіру";
                Question3OptionCLabel.Text = "c) Абсорбують кисень з повітря через шкіру";

                Question4Label.Text = "4. Який один з основних факторів загрози для амфібій, згаданий в тексті?";
                Question4OptionALabel.Text = "a) Наявність природних хижаків";
                Question4OptionBLabel.Text = "b) Втрата середовища проживання";
                Question4OptionCLabel.Text = "c) Збільшення їхньої чисельності";

                Question5Label.Text = "5. Чому важлива охорона амфібій?";
                Question5OptionALabel.Text = "a) Для використання як домашніх тварин";
                Question5OptionBLabel.Text = "b) Для підтримки екологічної рівноваги та захисту біологічного різноманіття";
                Question5OptionCLabel.Text = "c) Для розробки нових ліків";
                break;
        }
    }

}