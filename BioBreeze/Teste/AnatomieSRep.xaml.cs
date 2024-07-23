namespace BioBreeze.Teste;

public partial class AnatomieSRep : ContentPage
{
	public AnatomieSRep()
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

        if (Question3OptionC.IsChecked)
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
                TitleLabel.Text = "Testul sistemului reproductiv";
                Question1Label.Text = "1. Care sunt organele principale ale sistemului reproductiv feminin?";
                Question1OptionALabel.Text = "a) Ovarele, uterul, tuburile uterine, vaginul";
                Question1OptionBLabel.Text = "b) Testiculele, penisul, uretra, scrotul";
                Question1OptionCLabel.Text = "c) Ovarele, penisul, uterul, vulva";

                Question2Label.Text = "2. Care organ produce ovulele la femei?";
                Question2OptionALabel.Text = "a) Uterul";
                Question2OptionBLabel.Text = "b) Ovarele";
                Question2OptionCLabel.Text = "c) Tuburile uterine";

                Question3Label.Text = "3. Ce organe transportă ovulele de la ovare către uter?";
                Question3OptionALabel.Text = "a) Vulva";
                Question3OptionBLabel.Text = "b) Vaginul";
                Question3OptionCLabel.Text = "c) Tuburile uterine";

                Question4Label.Text = "4. Cum este fertilizat ovulul în mod normal?";
                Question4OptionALabel.Text = "a) În uter";
                Question4OptionBLabel.Text = "b) În vagin";
                Question4OptionCLabel.Text = "c) În tuburile uterine";

                Question5Label.Text = "5. Care este organul extern principal al sistemului reproductiv masculin?";
                Question5OptionALabel.Text = "a) Uretra";
                Question5OptionBLabel.Text = "b) Scrotul";
                Question5OptionCLabel.Text = "c) Penisul";
                break;

            case "hu":
                TitleLabel.Text = "A reproduktív rendszer teszt";
                Question1Label.Text = "1. Melyek a női reproduktív rendszer fő szervei?";
                Question1OptionALabel.Text = "a) Petefészkek, méh, petevezetékek, hüvely";
                Question1OptionBLabel.Text = "b) Herezacskó, pénisz, húgycső, here";
                Question1OptionCLabel.Text = "c) Petefészkek, pénisz, méh, vulva";

                Question2Label.Text = "2. Melyik szerv termeli a petesejteket nőknél?";
                Question2OptionALabel.Text = "a) Méh";
                Question2OptionBLabel.Text = "b) Petefészkek";
                Question2OptionCLabel.Text = "c) Petevezetékek";

                Question3Label.Text = "3. Melyik szerv szállítja a petesejteket a petefészkekből a méhhez?";
                Question3OptionALabel.Text = "a) Vulva";
                Question3OptionBLabel.Text = "b) Hüvely";
                Question3OptionCLabel.Text = "c) Petevezetékek";

                Question4Label.Text = "4. Hol történik a petesejt megtermékenyítése általában?";
                Question4OptionALabel.Text = "a) A méhben";
                Question4OptionBLabel.Text = "b) A hüvelyben";
                Question4OptionCLabel.Text = "c) A petevezetékekben";

                Question5Label.Text = "5. Mi a férfi reproduktív rendszer fő külső szerve?";
                Question5OptionALabel.Text = "a) Húgycső";
                Question5OptionBLabel.Text = "b) Herezacskó";
                Question5OptionCLabel.Text = "c) Pénisz";
                break;

            case "uk":
                TitleLabel.Text = "Тест на репродуктивну систему";
                Question1Label.Text = "1. Які органи є основними в жіночій репродуктивній системі?";
                Question1OptionALabel.Text = "a) Яєчники, матка, маткові труби, вагіна";
                Question1OptionBLabel.Text = "b) Яєчка, пеніс, уретра, мошонка";
                Question1OptionCLabel.Text = "c) Яєчники, пеніс, матка, вульва";

                Question2Label.Text = "2. Який орган виробляє яйцеклітини у жінок?";
                Question2OptionALabel.Text = "a) Матка";
                Question2OptionBLabel.Text = "b) Яєчники";
                Question2OptionCLabel.Text = "c) Маткові труби";

                Question3Label.Text = "3. Які органи транспортують яйцеклітини з яєчників до матки?";
                Question3OptionALabel.Text = "a) Вульва";
                Question3OptionBLabel.Text = "b) Вагіна";
                Question3OptionCLabel.Text = "c) Маткові труби";

                Question4Label.Text = "4. Де зазвичай запліднюється яйцеклітина?";
                Question4OptionALabel.Text = "a) В матці";
                Question4OptionBLabel.Text = "b) У вагіні";
                Question4OptionCLabel.Text = "c) У маткових трубах";

                Question5Label.Text = "5. Який головний зовнішній орган чоловічої репродуктивної системи?";
                Question5OptionALabel.Text = "a) Уретра";
                Question5OptionBLabel.Text = "b) Мошонка";
                Question5OptionCLabel.Text = "c) Пеніс";
                break;
        }
    }

}