namespace BioBreeze.Teste;

public partial class AnatomieOchi : ContentPage
{
	public AnatomieOchi()
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
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 5 este incorectă.\n";

        if (Question6OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 6 este incorectă.\n";

        if (Question7OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 7 este incorectă.\n";

        if (Question8OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 8 este incorectă.\n";

        if (Question9OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 9 este incorectă.\n";

        if (Question10OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 10 este incorectă.\n";

        if (score == 10)
            GlobalVariables.TestsPassed++;

        
        ScoreLabel.Text = $"Scorul tău este: {score} din 10\n" + feedback;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

}