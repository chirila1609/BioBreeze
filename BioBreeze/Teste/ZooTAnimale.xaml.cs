namespace BioBreeze.Teste;

public partial class ZooTAnimale : ContentPage
{
	public ZooTAnimale()
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
            feedback += "Question 1 is incorrect.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Question 2 is incorrect.\n";

        if (Question3OptionC.IsChecked)
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
                Question1Label.Text = "1. Care este funcția principală a țesutului epitelial în organismele animale?";
                Question1OptionALabel.Text = "a) Susținere structurală";
                Question1OptionBLabel.Text = "b) Generarea de mișcare";
                Question1OptionCLabel.Text = "c) Formarea unei bariere protective";

                Question2Label.Text = "2. Care dintre următoarele nu este un tip de țesut conjunctiv?";
                Question2OptionALabel.Text = "a) Țesut conjunctiv moale";
                Question2OptionBLabel.Text = "b) Țesut conjunctiv dur";
                Question2OptionCLabel.Text = "c) Țesut conjunctiv fibros";

                Question3Label.Text = "3. Unde se găsește în mod predominant țesutul muscular cardiac?";
                Question3OptionALabel.Text = "a) În mușchii scheletici";
                Question3OptionBLabel.Text = "b) În organele interne, cum ar fi intestinele";
                Question3OptionCLabel.Text = "c) În inimă";

                Question4Label.Text = "4. Care este principalul rol al țesutului nervos în organismele animale?";
                Question4OptionALabel.Text = "a) Contracția musculară";
                Question4OptionBLabel.Text = "b) Transmiterea semnalelor electrice";
                Question4OptionCLabel.Text = "c) Formarea unei bariere protective";

                Question5Label.Text = "5. Care dintre următoarele nu este un tip de țesut muscular?";
                Question5OptionALabel.Text = "a) Țesut muscular scheletic";
                Question5OptionBLabel.Text = "b) Țesut muscular neted";
                Question5OptionCLabel.Text = "c) Țesut muscular articulat";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a fő funkciója az állati epitélium szövetnek?";
                Question1OptionALabel.Text = "a) Támogatás";
                Question1OptionBLabel.Text = "b) Mozgás előidézése";
                Question1OptionCLabel.Text = "c) Védőbarrier képzése";

                Question2Label.Text = "2. Melyik nem kötőszövet típus?";
                Question2OptionALabel.Text = "a) Lágy kötőszövet";
                Question2OptionBLabel.Text = "b) Kemény kötőszövet";
                Question2OptionCLabel.Text = "c) Rostos kötőszövet";

                Question3Label.Text = "3. Hol található főként a szívizom szövet?";
                Question3OptionALabel.Text = "a) A vázizmokban";
                Question3OptionBLabel.Text = "b) A belső szervekben, például a belekben";
                Question3OptionCLabel.Text = "c) A szívben";

                Question4Label.Text = "4. Mi az idegszövet fő szerepe az állati szervezetekben?";
                Question4OptionALabel.Text = "a) Izomösszehúzódás";
                Question4OptionBLabel.Text = "b) Elektromos jelek továbbítása";
                Question4OptionCLabel.Text = "c) Védőbarrier képzése";

                Question5Label.Text = "5. Melyik nem izomszövet típus?";
                Question5OptionALabel.Text = "a) Vázizom szövet";
                Question5OptionBLabel.Text = "b) Simai izom szövet";
                Question5OptionCLabel.Text = "c) Kötött izom szövet";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка основна функція епітеліальної тканини в тваринних організмах?";
                Question1OptionALabel.Text = "a) Підтримка структури";
                Question1OptionBLabel.Text = "b) Генерація руху";
                Question1OptionCLabel.Text = "c) Формування захисного бар'єру";

                Question2Label.Text = "2. Який з наступних не є типом сполучної тканини?";
                Question2OptionALabel.Text = "a) М'яка сполучна тканина";
                Question2OptionBLabel.Text = "b) Тверда сполучна тканина";
                Question2OptionCLabel.Text = "c) Волокниста сполучна тканина";

                Question3Label.Text = "3. Де переважно знаходиться серцевий м'яз?";
                Question3OptionALabel.Text = "a) У скелетних м'язах";
                Question3OptionBLabel.Text = "b) У внутрішніх органах, таких як кишечник";
                Question3OptionCLabel.Text = "c) У серці";

                Question4Label.Text = "4. Яка основна роль нервової тканини в тваринних організмах?";
                Question4OptionALabel.Text = "a) М'язове скорочення";
                Question4OptionBLabel.Text = "b) Передача електричних сигналів";
                Question4OptionCLabel.Text = "c) Формування захисного бар'єру";

                Question5Label.Text = "5. Який з наступних не є типом м'язової тканини?";
                Question5OptionALabel.Text = "a) Скелетна м'язова тканина";
                Question5OptionBLabel.Text = "b) Гладка м'язова тканина";
                Question5OptionCLabel.Text = "c) Суглобова м'язова тканина";
                break;
        }
    }
}