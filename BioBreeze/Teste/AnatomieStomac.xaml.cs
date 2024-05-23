﻿namespace BioBreeze.Teste;

public partial class AnatomieStomac : ContentPage
{
	public AnatomieStomac()
	{
		InitializeComponent();
	}

    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        // Check answers and update score
        if (Question1OptionC.IsChecked)
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

        if (Question4OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 5 este incorectă.\n";

        if (score == 5)
            GlobalVariables.TestsPassed++;

        // Display score
        ScoreLabel.Text = $"Scorul tău este: {score} din 5\n" + feedback;
    }

}