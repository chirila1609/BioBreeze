namespace BioBreeze.Teste;

public partial class ZooReptile : ContentPage
{
	public ZooReptile()
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

        if (Question3OptionB.IsChecked)
            score++;
        else
            feedback += "Question 3 is incorrect.\n";

        if (Question4OptionC.IsChecked)
            score++;
        else
            feedback += "Question 4 is incorrect.\n";

        if (Question5OptionD.IsChecked)
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
                Question1Label.Text = "1. Care este una dintre trăsăturile distinctive ale reptilelor?";
                Question1OptionALabel.Text = "a) Părul";
                Question1OptionBLabel.Text = "b) Solzii";
                Question1OptionCLabel.Text = "c) Blana";
                Question1OptionDLabel.Text = "d) Penajul";

                Question2Label.Text = "2. Cum se reproduc majoritatea reptilelor?";
                Question2OptionALabel.Text = "a) Prin metamorfoză";
                Question2OptionBLabel.Text = "b) Prin ouă";
                Question2OptionCLabel.Text = "c) Prin nașterea de pui vii";
                Question2OptionDLabel.Text = "d) Prin separarea asexuată";

                Question3Label.Text = "3. Unde își depun unele reptile ouăle?";
                Question3OptionALabel.Text = "a) În apă";
                Question3OptionBLabel.Text = "b) În cuiburi speciale";
                Question3OptionCLabel.Text = "c) În aer";
                Question3OptionDLabel.Text = "d) În vizuinile lor";

                Question4Label.Text = "4. Care specii de reptile sunt bine adaptate pentru a trăi în medii ostile, cum ar fi deșerturile aride?";
                Question4OptionALabel.Text = "a) Crocodilii";
                Question4OptionBLabel.Text = "b) Șerpii de apă";
                Question4OptionCLabel.Text = "c) Șopârlele cu coadă scurtă";
                Question4OptionDLabel.Text = "d) Șerpii de grădină";

                Question5Label.Text = "5. De ce sunt unele specii de reptile în pericol?";
                Question5OptionALabel.Text = "a) Din cauza schimbărilor climatice";
                Question5OptionBLabel.Text = "b) Din cauza vânătorii excesive";
                Question5OptionCLabel.Text = "c) Din cauza pierderii habitatului";
                Question5OptionDLabel.Text = "d) Toate variantele de mai sus";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi az egyik jellegzetes vonása a hüllőknek?";
                Question1OptionALabel.Text = "a) Szőr";
                Question1OptionBLabel.Text = "b) Pikkelyek";
                Question1OptionCLabel.Text = "c) Bundázat";
                Question1OptionDLabel.Text = "d) Tollazat";

                Question2Label.Text = "2. Hogyan szaporodnak a legtöbb hüllő?";
                Question2OptionALabel.Text = "a) Metamorfózissal";
                Question2OptionBLabel.Text = "b) Tojásokkal";
                Question2OptionCLabel.Text = "c) Élő utódok szülésével";
                Question2OptionDLabel.Text = "d) Asexualis szaporodással";

                Question3Label.Text = "3. Hol rakják le tojásaikat egyes hüllők?";
                Question3OptionALabel.Text = "a) Vízben";
                Question3OptionBLabel.Text = "b) Különleges fészkekben";
                Question3OptionCLabel.Text = "c) Levegőben";
                Question3OptionDLabel.Text = "d) Üregeikben";

                Question4Label.Text = "4. Mely hüllőfajok alkalmazkodtak jól az ellenséges környezetekhez, például száraz sivatagokhoz?";
                Question4OptionALabel.Text = "a) Krokodilok";
                Question4OptionBLabel.Text = "b) Vízilovak";
                Question4OptionCLabel.Text = "c) Rövid farkú gyíkok";
                Question4OptionDLabel.Text = "d) Kerti kígyók";

                Question5Label.Text = "5. Miért vannak veszélyben egyes hüllőfajok?";
                Question5OptionALabel.Text = "a) Éghajlatváltozás miatt";
                Question5OptionBLabel.Text = "b) Túlságos vadászat miatt";
                Question5OptionCLabel.Text = "c) Élőhelyek elvesztése miatt";
                Question5OptionDLabel.Text = "d) Minden fenti ok miatt";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка одна з характерних рис рептилій?";
                Question1OptionALabel.Text = "a) Волосся";
                Question1OptionBLabel.Text = "b) Луска";
                Question1OptionCLabel.Text = "c) Шерсть";
                Question1OptionDLabel.Text = "d) Пір'я";

                Question2Label.Text = "2. Як розмножуються більшість рептилій?";
                Question2OptionALabel.Text = "a) Через метаморфозу";
                Question2OptionBLabel.Text = "b) Яйцями";
                Question2OptionCLabel.Text = "c) Народжуючи живих дитинчат";
                Question2OptionDLabel.Text = "d) Безстатевим розмноженням";

                Question3Label.Text = "3. Де деякі рептилії відкладають свої яйця?";
                Question3OptionALabel.Text = "a) У воді";
                Question3OptionBLabel.Text = "b) У спеціальних гніздах";
                Question3OptionCLabel.Text = "c) В повітрі";
                Question3OptionDLabel.Text = "d) У своїх норах";

                Question4Label.Text = "4. Які види рептилій добре адаптовані до життя в суворих умовах, таких як посушливі пустелі?";
                Question4OptionALabel.Text = "a) Крокодили";
                Question4OptionBLabel.Text = "b) Водяні змії";
                Question4OptionCLabel.Text = "c) Ящірки з коротким хвостом";
                Question4OptionDLabel.Text = "d) Садові змії";

                Question5Label.Text = "5. Чому деякі види рептилій перебувають під загрозою?";
                Question5OptionALabel.Text = "a) Через зміни клімату";
                Question5OptionBLabel.Text = "b) Через надмірний промисел";
                Question5OptionCLabel.Text = "c) Через втрату середовища існування";
                Question5OptionDLabel.Text = "d) Усі наведені варіанти";
                break;
        }
    }

}