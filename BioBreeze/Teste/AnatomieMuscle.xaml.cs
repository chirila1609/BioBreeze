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

        
        ScoreLabel.Text = $"Scorul tău este: {score} din 10\n" + feedback;
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
                Question1Label.Text = "1. Care dintre următorii mușchi permit mișcarea capului în diverse direcții?";
                Question1OptionALabel.Text = "a) Mușchii gâtului";
                Question1OptionBLabel.Text = "b) Mușchii spatelui";
                Question1OptionCLabel.Text = "c) Mușchii coapsei";
                Question1OptionDLabel.Text = "d) Mușchii fesieri";
                Question2Label.Text = "2. Care este principalul rol al mușchilor spatelui?";
                Question2OptionALabel.Text = "a) Flexia și extensia piciorului";
                Question2OptionBLabel.Text = "b) Menținerea posturii corecte a corpului";
                Question2OptionCLabel.Text = "c) Susținerea arcului piciorului";
                Question2OptionDLabel.Text = "d) Rotirea coapsei";
                Question3Label.Text = "3. Care dintre următorii mușchi ajută la ridicarea și coborârea brațelor?";
                Question3OptionALabel.Text = "a) Mușchii abdomenului";
                Question3OptionBLabel.Text = "b) Mușchii umărului";
                Question3OptionCLabel.Text = "c) Mușchii încheieturii";
                Question3OptionDLabel.Text = "d) Mușchii picioarelor";
                Question4Label.Text = "4. Care dintre următorii mușchi sunt responsabili pentru mișcarea și controlul brațelor?";
                Question4OptionALabel.Text = "a) Mușchii tălpii";
                Question4OptionBLabel.Text = "b) Mușchii gambei";
                Question4OptionCLabel.Text = "c) Mușchii brațului";
                Question4OptionDLabel.Text = "d) Mușchii încheieturii";
                Question5Label.Text = "5. Ce ajută mușchii încheieturii să controleze?";
                Question5OptionALabel.Text = "a) Mișcările picioarelor";
                Question5OptionBLabel.Text = "b) Mișcările mâinilor și degetelor";
                Question5OptionCLabel.Text = "c) Flexia și extensia coapsei";
                Question5OptionDLabel.Text = "d) Rotirea trunchiului";
                Question6Label.Text = "6. Care dintre următorii mușchi ne permit să prindem obiecte și să facem mișcări precise cu mâinile?";
                Question6OptionALabel.Text = "a) Mușchii gâtului";
                Question6OptionBLabel.Text = "b) Mușchii mâinii";
                Question6OptionCLabel.Text = "c) Mușchii spatelui";
                Question6OptionDLabel.Text = "d) Mușchii abdomenului";
                Question7Label.Text = "7. Care este rolul principal al mușchilor abdomenului?";
                Question7OptionALabel.Text = "a) Menținerea posturii corecte a corpului";
                Question7OptionBLabel.Text = "b) Flexia și extensia gleznei";
                Question7OptionCLabel.Text = "c) Rotirea coapsei";
                Question7OptionDLabel.Text = "d) Susținerea arcului piciorului";
                Question8Label.Text = "8. Care dintre următorii mușchi sunt responsabili pentru susținerea bolta piciorului?";
                Question8OptionALabel.Text = "a) Mușchii coapsei";
                Question8OptionBLabel.Text = "b) Mușchii gambei";
                Question8OptionCLabel.Text = "c) Mușchii fesieri";
                Question8OptionDLabel.Text = "d) Mușchii tălpii";
                Question9Label.Text = "9. Care este principalul rol al mușchilor fesieri?";
                Question9OptionALabel.Text = "a) Flexia și extensia piciorului";
                Question9OptionBLabel.Text = "b) Rotirea coapsei";
                Question9OptionCLabel.Text = "c) Susținerea arcului piciorului";
                Question9OptionDLabel.Text = "d) Menținerea echilibrului în timpul mersului";
                Question10Label.Text = "10. Ce ajută mușchii tibiei și mușchii gemeni să facă?";
                Question10OptionALabel.Text = "a) Flexia și extensia gleznei";
                Question10OptionBLabel.Text = "b) Flexia și extensia coapsei";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik izomcsoport teszi lehetővé a fej különböző irányú mozgását?";
                Question1OptionALabel.Text = "a) Nyakizmok";
                Question1OptionBLabel.Text = "b) Hátizmok";
                Question1OptionCLabel.Text = "c) Combizmok";
                Question1OptionDLabel.Text = "d) Farizmok";
                Question2Label.Text = "2. Mi a hátizmok fő szerepe?";
                Question2OptionALabel.Text = "a) A láb hajlítása és nyújtása";
                Question2OptionBLabel.Text = "b) A helyes testtartás fenntartása";
                Question2OptionCLabel.Text = "c) A lábboltozat támogatása";
                Question2OptionDLabel.Text = "d) A comb forgatása";
                Question3Label.Text = "3. Melyik izomcsoport segít a karok emelésében és leengedésében?";
                Question3OptionALabel.Text = "a) Hasizmok";
                Question3OptionBLabel.Text = "b) Vállizmok";
                Question3OptionCLabel.Text = "c) Csuklóizmok";
                Question3OptionDLabel.Text = "d) Lábizmok";
                Question4Label.Text = "4. Melyik izomcsoport felelős a karok mozgásáért és irányításáért?";
                Question4OptionALabel.Text = "a) Talpizmok";
                Question4OptionBLabel.Text = "b) Vádliizmok";
                Question4OptionCLabel.Text = "c) Karizmok";
                Question4OptionDLabel.Text = "d) Csuklóizmok";
                Question5Label.Text = "5. Mit segítenek irányítani a csuklóizmok?";
                Question5OptionALabel.Text = "a) A lábak mozgását";
                Question5OptionBLabel.Text = "b) A kezek és ujjak mozgását";
                Question5OptionCLabel.Text = "c) A comb hajlítását és nyújtását";
                Question5OptionDLabel.Text = "d) A törzs forgatását";
                Question6Label.Text = "6. Melyik izomcsoport teszi lehetővé, hogy tárgyakat fogjunk meg és pontos mozdulatokat végezzünk a kezeinkkel?";
                Question6OptionALabel.Text = "a) Nyakizmok";
                Question6OptionBLabel.Text = "b) Kézizmok";
                Question6OptionCLabel.Text = "c) Hátizmok";
                Question6OptionDLabel.Text = "d) Hasizmok";
                Question7Label.Text = "7. Mi a hasizmok fő szerepe?";
                Question7OptionALabel.Text = "a) A helyes testtartás fenntartása";
                Question7OptionBLabel.Text = "b) A boka hajlítása és nyújtása";
                Question7OptionCLabel.Text = "c) A comb forgatása";
                Question7OptionDLabel.Text = "d) A lábboltozat támogatása";
                Question8Label.Text = "8. Melyik izomcsoport felelős a lábboltozat támogatásáért?";
                Question8OptionALabel.Text = "a) Combizmok";
                Question8OptionBLabel.Text = "b) Vádliizmok";
                Question8OptionCLabel.Text = "c) Farizmok";
                Question8OptionDLabel.Text = "d) Talpizmok";
                Question9Label.Text = "9. Mi a farizmok fő szerepe?";
                Question9OptionALabel.Text = "a) A láb hajlítása és nyújtása";
                Question9OptionBLabel.Text = "b) A comb forgatása";
                Question9OptionCLabel.Text = "c) A lábboltozat támogatása";
                Question9OptionDLabel.Text = "d) Az egyensúly fenntartása járás közben";
                Question10Label.Text = "10. Mit segítenek a sípcsonti izmok és a vádliizmok csinálni?";
                Question10OptionALabel.Text = "a) A boka hajlítása és nyújtása";
                Question10OptionBLabel.Text = "b) A comb hajlítása és nyújtása";
                break;

            case "uk":
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care dintre următorii mușchi permit mișcarea capului în diverse direcții?";
                Question1OptionALabel.Text = "a) Mușchii gâtului";
                Question1OptionBLabel.Text = "b) Mușchii spatelui";
                Question1OptionCLabel.Text = "c) Mușchii coapsei";
                Question1OptionDLabel.Text = "d) Mușchii fesieri";
                Question2Label.Text = "2. Care este principalul rol al mușchilor spatelui?";
                Question2OptionALabel.Text = "a) Flexia și extensia piciorului";
                Question2OptionBLabel.Text = "b) Menținerea posturii corecte a corpului";
                Question2OptionCLabel.Text = "c) Susținerea arcului piciorului";
                Question2OptionDLabel.Text = "d) Rotirea coapsei";
                Question3Label.Text = "3. Care dintre următorii mușchi ajută la ridicarea și coborârea brațelor?";
                Question3OptionALabel.Text = "a) Mușchii abdomenului";
                Question3OptionBLabel.Text = "b) Mușchii umărului";
                Question3OptionCLabel.Text = "c) Mușchii încheieturii";
                Question3OptionDLabel.Text = "d) Mușchii picioarelor";
                Question4Label.Text = "4. Care dintre următorii mușchi sunt responsabili pentru mișcarea și controlul brațelor?";
                Question4OptionALabel.Text = "a) Mușchii tălpii";
                Question4OptionBLabel.Text = "b) Mușchii gambei";
                Question4OptionCLabel.Text = "c) Mușchii brațului";
                Question4OptionDLabel.Text = "d) Mușchii încheieturii";
                Question5Label.Text = "5. Ce ajută mușchii încheieturii să controleze?";
                Question5OptionALabel.Text = "a) Mișcările picioarelor";
                Question5OptionBLabel.Text = "b) Mișcările mâinilor și degetelor";
                Question5OptionCLabel.Text = "c) Flexia și extensia coapsei";
                Question5OptionDLabel.Text = "d) Rotirea trunchiului";
                Question6Label.Text = "6. Care dintre următorii mușchi ne permit să prindem obiecte și să facem mișcări precise cu mâinile?";
                Question6OptionALabel.Text = "a) Mușchii gâtului";
                Question6OptionBLabel.Text = "b) Mușchii mâinii";
                Question6OptionCLabel.Text = "c) Mușchii spatelui";
                Question6OptionDLabel.Text = "d) Mușchii abdomenului";
                Question7Label.Text = "7. Care este rolul principal al mușchilor abdomenului?";
                Question7OptionALabel.Text = "a) Menținerea posturii corecte a corpului";
                Question7OptionBLabel.Text = "b) Flexia și extensia gleznei";
                Question7OptionCLabel.Text = "c) Rotirea coapsei";
                Question7OptionDLabel.Text = "d) Susținerea arcului piciorului";
                Question8Label.Text = "8. Care dintre următorii mușchi sunt responsabili pentru susținerea bolta piciorului?";
                Question8OptionALabel.Text = "a) Mușchii coapsei";
                Question8OptionBLabel.Text = "b) Mușchii gambei";
                Question8OptionCLabel.Text = "c) Mușchii fesieri";
                Question8OptionDLabel.Text = "d) Mușchii tălpii";
                Question9Label.Text = "9. Care este principalul rol al mușchilor fesieri?";
                Question9OptionALabel.Text = "a) Flexia și extensia piciorului";
                Question9OptionBLabel.Text = "b) Rotirea coapsei";
                Question9OptionCLabel.Text = "c) Susținerea arcului piciorului";
                Question9OptionDLabel.Text = "d) Menținerea echilibrului în timpul mersului";
                Question10Label.Text = "10. Ce ajută mușchii tibiei și mușchii gemeni să facă?";
                Question10OptionALabel.Text = "a) Flexia și extensia gleznei";
                Question10OptionBLabel.Text = "b) Flexia și extensia coapsei";
                break;

            default:
                break;
        }
    }
}