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

}