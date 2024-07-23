namespace BioBreeze.Teste;

public partial class GenADN : ContentPage
{
	public GenADN()
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
                Question1Label.Text = "1. Ce este acronimul pentru Acidul Dezoxiribonucleic?";
                Question1OptionALabel.Text = "a) ARN";
                Question1OptionBLabel.Text = "b) ATP";
                Question1OptionCLabel.Text = "c) ADN";
                Question1OptionDLabel.Text = "d) ARNm";

                Question2Label.Text = "2. Cine a elucidat structura în formă de dublu helix a ADN-ului?";
                Question2OptionALabel.Text = "a) Friedrich Miescher";
                Question2OptionBLabel.Text = "b) Gregor Mendel";
                Question2OptionCLabel.Text = "c) James Watson și Francis Crick";
                Question2OptionDLabel.Text = "d) Rosalind Franklin";

                Question3Label.Text = "3. Care dintre următoarele nu este o bază azotată a ADN-ului?";
                Question3OptionALabel.Text = "a) Adenina (A)";
                Question3OptionBLabel.Text = "b) Citozina (C)";
                Question3OptionCLabel.Text = "c) Uracil (U)";
                Question3OptionDLabel.Text = "d) Timina (T)";

                Question4Label.Text = "4. Care este funcția principală a ADN-ului în organismele vii?";
                Question4OptionALabel.Text = "a) Sinteza proteinelor";
                Question4OptionBLabel.Text = "b) Stocarea informațiilor genetice";
                Question4OptionCLabel.Text = "c) Transmiterea impulsurilor nervoase";
                Question4OptionDLabel.Text = "d) Absorbția nutrienților";

                Question5Label.Text = "5. Ce domeniu științific se ocupă cu cercetarea ADN-ului și a mutațiilor sale asociate cu diferite boli?";
                Question5OptionALabel.Text = "a) Astronomie";
                Question5OptionBLabel.Text = "b) Biotehnologie";
                Question5OptionCLabel.Text = "c) Geologie";
                Question5OptionDLabel.Text = "d) Paleontologie";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a Dezoxiribonukleinsav rövidítése?";
                Question1OptionALabel.Text = "a) RNS";
                Question1OptionBLabel.Text = "b) ATP";
                Question1OptionCLabel.Text = "c) DNS";
                Question1OptionDLabel.Text = "d) mRNS";

                Question2Label.Text = "2. Ki derítette ki a DNS kettős hélix szerkezetét?";
                Question2OptionALabel.Text = "a) Friedrich Miescher";
                Question2OptionBLabel.Text = "b) Gregor Mendel";
                Question2OptionCLabel.Text = "c) James Watson és Francis Crick";
                Question2OptionDLabel.Text = "d) Rosalind Franklin";

                Question3Label.Text = "3. Melyik az alábbiak közül nem a DNS nitrogénbázisa?";
                Question3OptionALabel.Text = "a) Adenin (A)";
                Question3OptionBLabel.Text = "b) Citozin (C)";
                Question3OptionCLabel.Text = "c) Uracil (U)";
                Question3OptionDLabel.Text = "d) Timin (T)";

                Question4Label.Text = "4. Mi a DNS fő funkciója az élő szervezetekben?";
                Question4OptionALabel.Text = "a) Fehérjeszintézis";
                Question4OptionBLabel.Text = "b) Genetikai információ tárolása";
                Question4OptionCLabel.Text = "c) Idegimpulzusok továbbítása";
                Question4OptionDLabel.Text = "d) Tápanyagok felszívódása";

                Question5Label.Text = "5. Melyik tudományág foglalkozik a DNS kutatásával és a különböző betegségekkel kapcsolatos mutációival?";
                Question5OptionALabel.Text = "a) Csillagászat";
                Question5OptionBLabel.Text = "b) Biotechnológia";
                Question5OptionCLabel.Text = "c) Geológia";
                Question5OptionDLabel.Text = "d) Paleontológia";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка абревіатура Дезоксирибонуклеїнової кислоти?";
                Question1OptionALabel.Text = "a) РНК";
                Question1OptionBLabel.Text = "b) АТФ";
                Question1OptionCLabel.Text = "c) ДНК";
                Question1OptionDLabel.Text = "d) мРНК";

                Question2Label.Text = "2. Хто розшифрував структуру подвійної спіралі ДНК?";
                Question2OptionALabel.Text = "a) Фрідріх Мішер";
                Question2OptionBLabel.Text = "b) Грегор Мендель";
                Question2OptionCLabel.Text = "c) Джеймс Уотсон і Френсіс Крік";
                Question2OptionDLabel.Text = "d) Розалінд Франклін";

                Question3Label.Text = "3. Яка з наведених не є азотною основою ДНК?";
                Question3OptionALabel.Text = "a) Аденін (А)";
                Question3OptionBLabel.Text = "b) Цитозин (C)";
                Question3OptionCLabel.Text = "c) Урацил (U)";
                Question3OptionDLabel.Text = "d) Тимін (T)";

                Question4Label.Text = "4. Яка основна функція ДНК в живих організмах?";
                Question4OptionALabel.Text = "a) Синтез білків";
                Question4OptionBLabel.Text = "b) Зберігання генетичної інформації";
                Question4OptionCLabel.Text = "c) Передача нервових імпульсів";
                Question4OptionDLabel.Text = "d) Поглинання поживних речовин";

                Question5Label.Text = "5. Яка наукова галузь досліджує ДНК та мутації, пов’язані з різними хворобами?";
                Question5OptionALabel.Text = "a) Астрономія";
                Question5OptionBLabel.Text = "b) Біотехнологія";
                Question5OptionCLabel.Text = "c) Геологія";
                Question5OptionDLabel.Text = "d) Палеонтологія";
                break;
        }
    }

}