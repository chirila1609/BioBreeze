namespace BioBreeze.Teste;

public partial class AnatomieF : ContentPage
{
	public AnatomieF()
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
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                TitleLabel.Text = "Test ficat";
                Question1Label.Text = "1. Care este principalul loc de amplasare a ficatului în corpul uman?";
                Question1OptionALabel.Text = "a) În partea stângă a abdomenului";
                Question1OptionBLabel.Text = "b) În partea dreaptă a abdomenului";
                Question1OptionCLabel.Text = "c) În spatele stomacului";

                Question2Label.Text = "2. Ce funcție importantă îndeplinește ficatul în metabolismul uman?";
                Question2OptionALabel.Text = "a) Produce bila";
                Question2OptionBLabel.Text = "b) Detoxifică corpul";
                Question2OptionCLabel.Text = "c) Produce sângele";

                Question3Label.Text = "3. Ce substanță produsă de ficat ajută la digestia grăsimilor?";
                Question3OptionALabel.Text = "a) Insulina";
                Question3OptionBLabel.Text = "b) Bilirubina";
                Question3OptionCLabel.Text = "c) Bila";

                Question4Label.Text = "4. Care dintre următoarele afirmații este adevărată despre capacitatea de regenerare a ficatului?";
                Question4OptionALabel.Text = "a) Ficatul nu se poate regenera niciodată";
                Question4OptionBLabel.Text = "b) Ficatul are capacitatea de regenerare după leziuni";
                Question4OptionCLabel.Text = "c) Ficatul se poate regenera doar în cazul copiilor";

                Question5Label.Text = "5. Ce rol important joacă ficatul în sistemul imunitar?";
                Question5OptionALabel.Text = "a) Produce globulele roșii";
                Question5OptionBLabel.Text = "b) Neutralizează bacteriile și alte agenți patogeni";
                Question5OptionCLabel.Text = "c) Menține echilibrul hormonal";
                break;

            case "hu":
                TitleLabel.Text = "Máj teszt";
                Question1Label.Text = "1. Hol helyezkedik el a máj az emberi testben?";
                Question1OptionALabel.Text = "a) A has bal oldalán";
                Question1OptionBLabel.Text = "b) A has jobb oldalán";
                Question1OptionCLabel.Text = "c) A gyomor mögött";

                Question2Label.Text = "2. Milyen fontos funkciót lát el a máj az emberi anyagcserében?";
                Question2OptionALabel.Text = "a) Epe termelése";
                Question2OptionBLabel.Text = "b) Méregteleníti a testet";
                Question2OptionCLabel.Text = "c) Vér termelése";

                Question3Label.Text = "3. Mely anyag, amelyet a máj termel, segít a zsírok emésztésében?";
                Question3OptionALabel.Text = "a) Inzulin";
                Question3OptionBLabel.Text = "b) Bilirubin";
                Question3OptionCLabel.Text = "c) Epe";

                Question4Label.Text = "4. Melyik állítás igaz a máj regenerációs képességére vonatkozóan?";
                Question4OptionALabel.Text = "a) A máj soha nem képes regenerálódni";
                Question4OptionBLabel.Text = "b) A máj képes regenerálódni sérülések után";
                Question4OptionCLabel.Text = "c) A máj csak gyermekek esetében képes regenerálódni";

                Question5Label.Text = "5. Milyen fontos szerepet játszik a máj az immunrendszerben?";
                Question5OptionALabel.Text = "a) Vörösvérsejtek termelése";
                Question5OptionBLabel.Text = "b) Baktériumok és egyéb kórokozók semlegesítése";
                Question5OptionCLabel.Text = "c) Hormonális egyensúly fenntartása";
                break;

            case "uk":
                TitleLabel.Text = "Тест печінки";
                Question1Label.Text = "1. Де знаходиться основне місце розташування печінки в організмі людини?";
                Question1OptionALabel.Text = "a) Ліва частина живота";
                Question1OptionBLabel.Text = "b) Права частина живота";
                Question1OptionCLabel.Text = "c) За шлунком";

                Question2Label.Text = "2. Яку важливу функцію виконує печінка в метаболізмі людини?";
                Question2OptionALabel.Text = "a) Виробляє жовч";
                Question2OptionBLabel.Text = "b) Детоксифікує організм";
                Question2OptionCLabel.Text = "c) Виробляє кров";

                Question3Label.Text = "3. Яка речовина, що виробляється печінкою, допомагає в травленні жирів?";
                Question3OptionALabel.Text = "a) Інсулін";
                Question3OptionBLabel.Text = "b) Білірубін";
                Question3OptionCLabel.Text = "c) Жовч";

                Question4Label.Text = "4. Яке з наступних тверджень є правильним щодо здатності печінки до регенерації?";
                Question4OptionALabel.Text = "a) Печінка ніколи не може регенерувати";
                Question4OptionBLabel.Text = "b) Печінка здатна регенерувати після травм";
                Question4OptionCLabel.Text = "c) Печінка може регенерувати лише у дітей";

                Question5Label.Text = "5. Яку важливу роль відіграє печінка в імунній системі?";
                Question5OptionALabel.Text = "a) Виробляє червоні кров'яні клітини";
                Question5OptionBLabel.Text = "b) Нейтралізує бактерії та інші патогени";
                Question5OptionCLabel.Text = "c) Підтримує гормональний баланс";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}