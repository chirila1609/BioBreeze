namespace BioBreeze.Teste;

public partial class ZooVerte : ContentPage
{
	public ZooVerte()
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
            feedback += "Question 1 is incorrect.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Question 2 is incorrect.\n";

        if (Question3OptionA.IsChecked)
            score++;
        else
            feedback += "Question 3 is incorrect.\n";

        if (Question4OptionB.IsChecked)
            score++;
        else
            feedback += "Question 4 is incorrect.\n";

        if (Question5OptionC.IsChecked)
            score++;
        else
            feedback += "Question 5 is incorrect.\n";

        if (score == 5)
            GlobalVariables.TestsPassed++;

        
        ScoreLabel.Text = $"Your score: {score} out of 5\n{feedback}";
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
                Question1Label.Text = "1. Care dintre următoarele animale trăiește în principal în mediul acvatic?";
                Question1OptionALabel.Text = "a) Leu";
                Question1OptionBLabel.Text = "b) Pește";
                Question1OptionCLabel.Text = "c) Elefant";
                Question1OptionDLabel.Text = "d) Lup";

                Question2Label.Text = "2. Care este caracteristica distinctivă a amfibienilor?";
                Question2OptionALabel.Text = "a) Capacitatea de a zbura";
                Question2OptionBLabel.Text = "b) Trăiesc atât pe uscat, cât și în apă";
                Question2OptionCLabel.Text = "c) Au corpul acoperit de pene";
                Question2OptionDLabel.Text = "d) Se regăsesc în majoritatea cazurilor în habitate deșertice";

                Question3Label.Text = "3. Ce grup de animale vertebrate își reglează temperatura corpului prin expunerea la surse externe de căldură?";
                Question3OptionALabel.Text = "a) Reptile";
                Question3OptionBLabel.Text = "b) Păsări";
                Question3OptionCLabel.Text = "c) Mamifere";
                Question3OptionDLabel.Text = "d) Amfibieni";

                Question4Label.Text = "4. Care dintre următoarele animale este un exemplu de reptil?";
                Question4OptionALabel.Text = "a) Pinguin";
                Question4OptionBLabel.Text = "b) Crocodil";
                Question4OptionCLabel.Text = "c) Cimpanzeu";
                Question4OptionDLabel.Text = "d) Delfin";

                Question5Label.Text = "5. Care dintre următoarele animale este cunoscută pentru abilitatea sa unică de a zbura?";
                Question5OptionALabel.Text = "a) Crocodil";
                Question5OptionBLabel.Text = "b) Șarpe";
                Question5OptionCLabel.Text = "c) Păsări";
                Question5OptionDLabel.Text = "d) Pisică";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik állat él főleg vízi környezetben?";
                Question1OptionALabel.Text = "a) Oroszlán";
                Question1OptionBLabel.Text = "b) Hal";
                Question1OptionCLabel.Text = "c) Elefánt";
                Question1OptionDLabel.Text = "d) Farkas";

                Question2Label.Text = "2. Mi a kétéltűek jellegzetessége?";
                Question2OptionALabel.Text = "a) Repülési képesség";
                Question2OptionBLabel.Text = "b) Szárazföldön és vízben is élnek";
                Question2OptionCLabel.Text = "c) Toll borítja a testüket";
                Question2OptionDLabel.Text = "d) Legtöbbször sivatagi élőhelyeken találhatóak";

                Question3Label.Text = "3. Melyik gerinces állatcsoport szabályozza a testhőmérsékletét külső hőforrásokkal?";
                Question3OptionALabel.Text = "a) Hüllők";
                Question3OptionBLabel.Text = "b) Madarak";
                Question3OptionCLabel.Text = "c) Emlősök";
                Question3OptionDLabel.Text = "d) Kétéltűek";

                Question4Label.Text = "4. Melyik állat példa egy hüllőre?";
                Question4OptionALabel.Text = "a) Pingvin";
                Question4OptionBLabel.Text = "b) Krokodil";
                Question4OptionCLabel.Text = "c) Csimpánz";
                Question4OptionDLabel.Text = "d) Delfin";

                Question5Label.Text = "5. Melyik állat híres egyedi repülési képességéről?";
                Question5OptionALabel.Text = "a) Krokodil";
                Question5OptionBLabel.Text = "b) Kígyó";
                Question5OptionCLabel.Text = "c) Madarak";
                Question5OptionDLabel.Text = "d) Macska";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка з наступних тварин переважно живе у водному середовищі?";
                Question1OptionALabel.Text = "a) Лев";
                Question1OptionBLabel.Text = "b) Риба";
                Question1OptionCLabel.Text = "c) Слон";
                Question1OptionDLabel.Text = "d) Вовк";

                Question2Label.Text = "2. Яка відмінна риса амфібій?";
                Question2OptionALabel.Text = "a) Можливість літати";
                Question2OptionBLabel.Text = "b) Живуть як на суші, так і у воді";
                Question2OptionCLabel.Text = "c) Їхнє тіло покрите пір’ям";
                Question2OptionDLabel.Text = "d) Здебільшого мешкають в пустельних середовищах";

                Question3Label.Text = "3. Яка група хребетних тварин регулює свою температуру тіла через зовнішні джерела тепла?";
                Question3OptionALabel.Text = "a) Рептилії";
                Question3OptionBLabel.Text = "b) Птахи";
                Question3OptionCLabel.Text = "c) Ссавці";
                Question3OptionDLabel.Text = "d) Амфібії";

                Question4Label.Text = "4. Яка з наступних тварин є прикладом рептилії?";
                Question4OptionALabel.Text = "a) Пінгвін";
                Question4OptionBLabel.Text = "b) Крокодил";
                Question4OptionCLabel.Text = "c) Шимпанзе";
                Question4OptionDLabel.Text = "d) Дельфін";

                Question5Label.Text = "5. Яка з наступних тварин відома своєю унікальною здатністю літати?";
                Question5OptionALabel.Text = "a) Крокодил";
                Question5OptionBLabel.Text = "b) Змія";
                Question5OptionCLabel.Text = "c) Птахи";
                Question5OptionDLabel.Text = "d) Кішка";
                break;
        }
    }
}