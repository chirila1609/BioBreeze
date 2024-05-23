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

        // Check answers and update score
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

        // Display score
        ScoreLabel.Text = $"Your score: {score} out of 5\n{feedback}";
    }

}