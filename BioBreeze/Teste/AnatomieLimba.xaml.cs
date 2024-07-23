namespace BioBreeze.Teste;

public partial class AnatomieLimba : ContentPage
{
	public AnatomieLimba()
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

        if (Question3OptionA.IsChecked)
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
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                TitleLabel.Text = "Test despre Limba Umană";
                Question1Label.Text = "1. Care este una dintre funcțiile principale ale limbii umane?";
                Question1OptionALabel.Text = "a) Detectarea gusturilor diferite";
                Question1OptionBLabel.Text = "b) Producerea și modularea sunetelor folosite în comunicare";
                Question1OptionCLabel.Text = "c) Perceperea texturii alimentelor";
                Question1OptionDLabel.Text = "d) Protecția împotriva infecțiilor în cavitatea orală";

                Question2Label.Text = "2. Ce componentă a limbii umane permite mișcarea acesteia în interiorul cavității orale?";
                Question2OptionALabel.Text = "a) Papilele gustative";
                Question2OptionBLabel.Text = "b) Papilele linguale";
                Question2OptionCLabel.Text = "c) Mușchii limbii";
                Question2OptionDLabel.Text = "d) Glandele salivare";

                Question3Label.Text = "3. Care este rolul papilelor gustative?";
                Question3OptionALabel.Text = "a) Detectarea gusturilor diferite";
                Question3OptionBLabel.Text = "b) Producerea de salivă";
                Question3OptionCLabel.Text = "c) Facilitarea procesului de digestie";
                Question3OptionDLabel.Text = "d) Protejarea mucoasei orale";

                Question4Label.Text = "4. Care dintre următoarele este o funcție culturală și socială a limbii umane?";
                Question4OptionALabel.Text = "a) Detectarea gusturilor diferite";
                Question4OptionBLabel.Text = "b) Vorbitul și comunicarea";
                Question4OptionCLabel.Text = "c) Masticarea alimentelor";
                Question4OptionDLabel.Text = "d) Protejarea limbii împotriva leziunilor";

                Question5Label.Text = "5. Ce rol joacă limba umană în procesul de înghițire?";
                Question5OptionALabel.Text = "a) Dirijarea alimentelor către faringe și esofag";
                Question5OptionBLabel.Text = "b) Detectarea gusturilor diferite";
                Question5OptionCLabel.Text = "c) Producerea de sunete pentru comunicare";
                Question5OptionDLabel.Text = "d) Protejarea cavității orale împotriva infecțiilor";
                break;

            case "hu":
                TitleLabel.Text = "Az emberi nyelv tesztje";
                Question1Label.Text = "1. Mi az emberi nyelv egyik fő funkciója?";
                Question1OptionALabel.Text = "a) Különböző ízek érzékelése";
                Question1OptionBLabel.Text = "b) Hangok előállítása és modulálása a kommunikációhoz";
                Question1OptionCLabel.Text = "c) Az ételek textúrájának érzékelése";
                Question1OptionDLabel.Text = "d) Védelem a szájüregi fertőzések ellen";

                Question2Label.Text = "2. Melyik komponens teszi lehetővé az emberi nyelv mozgását a szájüregben?";
                Question2OptionALabel.Text = "a) Ízlelőbimbók";
                Question2OptionBLabel.Text = "b) Nyelvi papillák";
                Question2OptionCLabel.Text = "c) Nyelvizmok";
                Question2OptionDLabel.Text = "d) Nyálmirigyek";

                Question3Label.Text = "3. Mi az ízlelőbimbók szerepe?";
                Question3OptionALabel.Text = "a) Különböző ízek érzékelése";
                Question3OptionBLabel.Text = "b) Nyáltermelés";
                Question3OptionCLabel.Text = "c) Az emésztési folyamat elősegítése";
                Question3OptionDLabel.Text = "d) A szájüregi nyálkahártya védelme";

                Question4Label.Text = "4. Melyik az emberi nyelv kulturális és társadalmi funkciója?";
                Question4OptionALabel.Text = "a) Különböző ízek érzékelése";
                Question4OptionBLabel.Text = "b) Beszéd és kommunikáció";
                Question4OptionCLabel.Text = "c) Ételek rágása";
                Question4OptionDLabel.Text = "d) A nyelv védelme a sérülésektől";

                Question5Label.Text = "5. Mi az emberi nyelv szerepe a nyelési folyamatban?";
                Question5OptionALabel.Text = "a) Az étel irányítása a garatba és a nyelőcsőbe";
                Question5OptionBLabel.Text = "b) Különböző ízek érzékelése";
                Question5OptionCLabel.Text = "c) Hangok előállítása a kommunikációhoz";
                Question5OptionDLabel.Text = "d) Védelem a szájüregi fertőzések ellen";
                break;

            case "uk":
                TitleLabel.Text = "Тест про людську мову";
                Question1Label.Text = "1. Яка одна з основних функцій людської мови?";
                Question1OptionALabel.Text = "a) Відчуття різних смаків";
                Question1OptionBLabel.Text = "b) Вироблення та модулювання звуків, що використовуються в спілкуванні";
                Question1OptionCLabel.Text = "c) Відчуття текстури їжі";
                Question1OptionDLabel.Text = "d) Захист від інфекцій у ротовій порожнині";

                Question2Label.Text = "2. Який компонент людської мови дозволяє їй рухатися всередині ротової порожнини?";
                Question2OptionALabel.Text = "a) Смакові рецептори";
                Question2OptionBLabel.Text = "b) Язикові сосочки";
                Question2OptionCLabel.Text = "c) М'язи язика";
                Question2OptionDLabel.Text = "d) Слинні залози";

                Question3Label.Text = "3. Яка роль смакових рецепторів?";
                Question3OptionALabel.Text = "a) Відчуття різних смаків";
                Question3OptionBLabel.Text = "b) Вироблення слини";
                Question3OptionCLabel.Text = "c) Полегшення процесу травлення";
                Question3OptionDLabel.Text = "d) Захист слизової оболонки рота";

                Question4Label.Text = "4. Яка з наступних функцій людської мови є культурною та соціальною?";
                Question4OptionALabel.Text = "a) Відчуття різних смаків";
                Question4OptionBLabel.Text = "b) Говоріння та спілкування";
                Question4OptionCLabel.Text = "c) Жування їжі";
                Question4OptionDLabel.Text = "d) Захист язика від ушкоджень";

                Question5Label.Text = "5. Яку роль відіграє людський язик у процесі ковтання?";
                Question5OptionALabel.Text = "a) Направлення їжі до глотки та стравоходу";
                Question5OptionBLabel.Text = "b) Відчуття різних смаків";
                Question5OptionCLabel.Text = "c) Вироблення звуків для спілкування";
                Question5OptionDLabel.Text = "d) Захист ротової порожнини від інфекцій";
                break;

            default:
                SetLanguage("ro");
                break;
        }
    }
}