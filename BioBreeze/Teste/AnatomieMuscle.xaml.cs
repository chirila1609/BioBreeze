namespace BioBreeze.Teste;

public partial class AnatomieMuscle : ContentPage
{
	public AnatomieMuscle()
	{
		InitializeComponent();
	}

    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        // Check answers and update score
        if (Question1OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 5 este incorectă.\n";

        if (Question6OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 6 este incorectă.\n";

        if (Question7OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 7 este incorectă.\n";

        if (Question8OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 8 este incorectă.\n";

        if (Question9OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 9 este incorectă.\n";

        if (Question10OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 10 este incorectă.\n";

        if (score == 10)
            GlobalVariables.TestsPassed++;

        // Display score
        ScoreLabel.Text = $"Scorul tău este: {score} din 10\n" + feedback;
    }

}