namespace BioBreeze.Teste;

public partial class ZooSsiC : ContentPage
{
	public ZooSsiC()
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

        if (Question4OptionA.IsChecked)
            score++;
        else
            feedback += "Question 4 is incorrect.\n";

        if (Question5OptionB.IsChecked)
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
                Question1Label.Text = "1. Care dintre următoarele organisme sunt cunoscute și sub numele de bureți de mare?";
                Question1OptionALabel.Text = "a) Meduzele";
                Question1OptionBLabel.Text = "b) Spongierii";
                Question1OptionCLabel.Text = "c) Anemonele de mare";

                Question2Label.Text = "2. Care este una dintre caracteristicile distinctive ale spongierilor?";
                Question2OptionALabel.Text = "a) Tentacule pentru capturarea prăzii";
                Question2OptionBLabel.Text = "b) Schelet intern de fibre proteice numite spongina";
                Question2OptionCLabel.Text = "c) Prezența cnidocitelor în jurul gurii";

                Question3Label.Text = "3. Ce tip de celulă specializată conțin celenteratele pentru capturarea prăzii sau pentru apărare?";
                Question3OptionALabel.Text = "a) Cnidocite";
                Question3OptionBLabel.Text = "b) Nematozite";
                Question3OptionCLabel.Text = "c) Spongocite";

                Question4Label.Text = "4. Care dintre următoarele organisme sunt celenterate?";
                Question4OptionALabel.Text = "a) Coraliile";
                Question4OptionBLabel.Text = "b) Spongierii";
                Question4OptionCLabel.Text = "c) Melcii";

                Question5Label.Text = "5. Care dintre următoarele organisme marine sunt cunoscute pentru capacitatea lor de a filtra apa și de a se hrăni cu particule microscopice din mediul lor?";
                Question5OptionALabel.Text = "a) Meduzele";
                Question5OptionBLabel.Text = "b) Spongierii";
                Question5OptionCLabel.Text = "c) Crabii eremit";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik organizmusok ismertek tengeribőrökként?";
                Question1OptionALabel.Text = "a) Medúzák";
                Question1OptionBLabel.Text = "b) Spongia";
                Question1OptionCLabel.Text = "c) Tengeri anemónák";

                Question2Label.Text = "2. Mi az egyik jellegzetes tulajdonsága a spongióknak?";
                Question2OptionALabel.Text = "a) Csápok a zsákmány elkapására";
                Question2OptionBLabel.Text = "b) Belső váz fehérje szálakból, spongin";
                Question2OptionCLabel.Text = "c) Cnidociták a száj körül";

                Question3Label.Text = "3. Milyen típusú specializált sejteket tartalmaznak a csalánozók a zsákmány elfogására vagy védelemre?";
                Question3OptionALabel.Text = "a) Cnidociták";
                Question3OptionBLabel.Text = "b) Nematozitek";
                Question3OptionCLabel.Text = "c) Spongociták";

                Question4Label.Text = "4. Melyik organizmusok csalánozók?";
                Question4OptionALabel.Text = "a) Korallok";
                Question4OptionBLabel.Text = "b) Spongiók";
                Question4OptionCLabel.Text = "c) Csigák";

                Question5Label.Text = "5. Melyik tengeri organizmusok ismertek arról, hogy víz szűrése és mikroszkopikus részecskék táplálkozása?";
                Question5OptionALabel.Text = "a) Medúzák";
                Question5OptionBLabel.Text = "b) Spongiók";
                Question5OptionCLabel.Text = "c) Hermafrodita rákok";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які з наступних організмів відомі як морські губки?";
                Question1OptionALabel.Text = "a) Медузи";
                Question1OptionBLabel.Text = "b) Губки";
                Question1OptionCLabel.Text = "c) Морські анемони";

                Question2Label.Text = "2. Яка одна з характерних рис губок?";
                Question2OptionALabel.Text = "a) Щупальці для ловлі здобичі";
                Question2OptionBLabel.Text = "b) Внутрішній скелет з білкових волокон, спонгіна";
                Question2OptionCLabel.Text = "c) Нідоцити навколо рота";

                Question3Label.Text = "3. Який тип спеціалізованих клітин мають кишечнопорожнинні для ловлі здобичі або захисту?";
                Question3OptionALabel.Text = "a) Нідоцити";
                Question3OptionBLabel.Text = "b) Нематоцити";
                Question3OptionCLabel.Text = "c) Спонгоцити";

                Question4Label.Text = "4. Які з наступних організмів є кишечнопорожнинними?";
                Question4OptionALabel.Text = "a) Корали";
                Question4OptionBLabel.Text = "b) Губки";
                Question4OptionCLabel.Text = "c) Черевики";

                Question5Label.Text = "5. Які з морських організмів відомі своєю здатністю фільтрувати воду та живитися мікроскопічними частками?";
                Question5OptionALabel.Text = "a) Медузи";
                Question5OptionBLabel.Text = "b) Губки";
                Question5OptionCLabel.Text = "c) Рак-бурячки";
                break;
        }
    }

}