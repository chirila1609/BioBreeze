namespace BioBreeze.Teste;

public partial class ZooNeverte : ContentPage
{
	public ZooNeverte()
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

        if (Question5OptionD.IsChecked)
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care sunt două exemple de artropode menționate în text?";
                Question1OptionALabel.Text = "a) Melci și caracatițe";
                Question1OptionBLabel.Text = "b) Păianjeni și scorpioni";
                Question1OptionCLabel.Text = "c) Rechini și delfini";
                Question1OptionDLabel.Text = "d) Păsări și mamifere";

                Question2Label.Text = "2. Unde trăiesc în principal crustaceele?";
                Question2OptionALabel.Text = "a) În deșerturi aride";
                Question2OptionBLabel.Text = "b) Pe fundul oceanului";
                Question2OptionCLabel.Text = "c) În păduri tropicale";
                Question2OptionDLabel.Text = "d) În regiuni montane";

                Question3Label.Text = "3. Ce grup de animale include stelele de mare și castraveții de mare?";
                Question3OptionALabel.Text = "a) Artropodele";
                Question3OptionBLabel.Text = "b) Moluștele";
                Question3OptionCLabel.Text = "c) Echinodermii";
                Question3OptionDLabel.Text = "d) Nevertebratele marine";

                Question4Label.Text = "4. Care dintre următoarele animale nu este considerată nevertebrată?";
                Question4OptionALabel.Text = "a) Păianjen";
                Question4OptionBLabel.Text = "b) Melc";
                Question4OptionCLabel.Text = "c) Pește";
                Question4OptionDLabel.Text = "d) Caracatiță";

                Question5Label.Text = "5. Care este caracteristica comună a animalelor nevertebrate din grupul artropodelor?";
                Question5OptionALabel.Text = "a) Au cochilii externe";
                Question5OptionBLabel.Text = "b) Nu au picioare";
                Question5OptionCLabel.Text = "c) Au coloană vertebrală";
                Question5OptionDLabel.Text = "d) Au membre articulate";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik két ízeltlábú példa szerepel a szövegben?";
                Question1OptionALabel.Text = "a) Csigák és polipok";
                Question1OptionBLabel.Text = "b) Pók és skorpió";
                Question1OptionCLabel.Text = "c) Cápák és delfinek";
                Question1OptionDLabel.Text = "d) Madarak és emlősök";

                Question2Label.Text = "2. Hol élnek főként a rákok?";
                Question2OptionALabel.Text = "a) Száraz sivatagokban";
                Question2OptionBLabel.Text = "b) Az óceán fenekén";
                Question2OptionCLabel.Text = "c) Trópusi erdőkben";
                Question2OptionDLabel.Text = "d) Hegyi régiókban";

                Question3Label.Text = "3. Melyik állatcsoport tartalmazza a tengeri csillagokat és a tengeri uborkákat?";
                Question3OptionALabel.Text = "a) Ízeltlábúak";
                Question3OptionBLabel.Text = "b) Puha testűek";
                Question3OptionCLabel.Text = "c) Echinodermák";
                Question3OptionDLabel.Text = "d) Tengeri gerinctelenek";

                Question4Label.Text = "4. Melyik állat nem gerinctelen?";
                Question4OptionALabel.Text = "a) Pók";
                Question4OptionBLabel.Text = "b) Csiga";
                Question4OptionCLabel.Text = "c) Hal";
                Question4OptionDLabel.Text = "d) Polip";

                Question5Label.Text = "5. Mi a közös jellemzője az ízeltlábú gerincteleneknek?";
                Question5OptionALabel.Text = "a) Külső héjuk van";
                Question5OptionBLabel.Text = "b) Nincsenek lábaik";
                Question5OptionCLabel.Text = "c) Van gerincük";
                Question5OptionDLabel.Text = "d) Ízelt végtagjaik vannak";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які два приклади членистоногих згадуються в тексті?";
                Question1OptionALabel.Text = "a) Черевики та восьминоги";
                Question1OptionBLabel.Text = "b) Павуки та скорпіони";
                Question1OptionCLabel.Text = "c) Акули та дельфіни";
                Question1OptionDLabel.Text = "d) Птахи та ссавці";

                Question2Label.Text = "2. Де в основному живуть раки?";
                Question2OptionALabel.Text = "a) У сухих пустелях";
                Question2OptionBLabel.Text = "b) На дні океану";
                Question2OptionCLabel.Text = "c) У тропічних лісах";
                Question2OptionDLabel.Text = "d) У гірських регіонах";

                Question3Label.Text = "3. Яка група тварин включає морських зірок і морських огірків?";
                Question3OptionALabel.Text = "a) Ракоподібні";
                Question3OptionBLabel.Text = "b) Молюски";
                Question3OptionCLabel.Text = "c) Ехінодерми";
                Question3OptionDLabel.Text = "d) Морські безхребетні";

                Question4Label.Text = "4. Яка з наступних тварин не є безхребетною?";
                Question4OptionALabel.Text = "a) Павук";
                Question4OptionBLabel.Text = "b) Равлик";
                Question4OptionCLabel.Text = "c) Риба";
                Question4OptionDLabel.Text = "d) Восьминіг";

                Question5Label.Text = "5. Яка загальна характеристика безхребетних тварин з групи членистоногих?";
                Question5OptionALabel.Text = "a) Має зовнішню оболонку";
                Question5OptionBLabel.Text = "b) Не має ніг";
                Question5OptionCLabel.Text = "c) Має хребет";
                Question5OptionDLabel.Text = "d) Має суглобисті кінцівки";
                break;
        }
    }

}