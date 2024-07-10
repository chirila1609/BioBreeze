namespace BioBreeze.Teste;

public partial class NutriMN : ContentPage
{
	public NutriMN()
	{
		InitializeComponent();
	}
    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        
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

}