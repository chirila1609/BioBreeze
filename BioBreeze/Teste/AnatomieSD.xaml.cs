namespace BioBreeze.Teste;

public partial class AnatomieSD : ContentPage
{
	public AnatomieSD()
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

        if (Question4OptionB.IsChecked)
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este rolul principal al sistemului digestiv?";
                Question1OptionALabel.Text = "a) De a pompa sângele prin corp";
                Question1OptionBLabel.Text = "b) De a descompune alimentele în nutrienți absorbabili.";
                Question1OptionCLabel.Text = "c) De a produce hormoni pentru reglarea greutății.";

                Question2Label.Text = "2. Unde începe procesul digestiv în corpul uman?";
                Question2OptionALabel.Text = "a) În intestinul subțire";
                Question2OptionBLabel.Text = "b) În gură";
                Question2OptionCLabel.Text = "c) În stomac";

                Question3Label.Text = "3. Ce substanță din gură ajută la descompunerea carbohidraților?";
                Question3OptionALabel.Text = "a) Acid gastric";
                Question3OptionBLabel.Text = "b) Bilă";
                Question3OptionCLabel.Text = "c) Salivă";

                Question4Label.Text = "4. Ce rol are pancreasul în digestie?";
                Question4OptionALabel.Text = "a) Produce suc gastric";
                Question4OptionBLabel.Text = "b) Eliberează enzime digestive în intestinul subțire";
                Question4OptionCLabel.Text = "c) Absorbția apei și a electroliților";

                Question5Label.Text = "5. Ce parte a sistemului digestiv este responsabilă pentru absorbția apei și a electroliților din alimente?";
                Question5OptionALabel.Text = "a) Stomacul";
                Question5OptionBLabel.Text = "b) Intestinul subțire";
                Question5OptionCLabel.Text = "c) Intestinul gros";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a fő szerepe az emésztőrendszernek?";
                Question1OptionALabel.Text = "a) A vér pumpálása a testben";
                Question1OptionBLabel.Text = "b) Az ételek lebontása tápanyagokká, amelyeket a test felszívhat.";
                Question1OptionCLabel.Text = "c) Hormonszabályozás a testsúly szabályozására.";

                Question2Label.Text = "2. Hol kezdődik az emésztési folyamat az emberi testben?";
                Question2OptionALabel.Text = "a) A vékonybélben";
                Question2OptionBLabel.Text = "b) A szájban";
                Question2OptionCLabel.Text = "c) A gyomorban";

                Question3Label.Text = "3. Milyen anyag segít a szénhidrátok lebontásában a szájban?";
                Question3OptionALabel.Text = "a) Gyomorsav";
                Question3OptionBLabel.Text = "b) Epe";
                Question3OptionCLabel.Text = "c) Nyál";

                Question4Label.Text = "4. Mi az hasnyálmirigy szerepe az emésztésben?";
                Question4OptionALabel.Text = "a) Gyomornedvet termel";
                Question4OptionBLabel.Text = "b) Emésztőenzimeket szabadít fel a vékonybélben";
                Question4OptionCLabel.Text = "c) Víz és elektrolitok felszívódása";

                Question5Label.Text = "5. Melyik része az emésztőrendszernek felelős a víz és elektrolitok felszívódásáért az ételekből?";
                Question5OptionALabel.Text = "a) Gyomor";
                Question5OptionBLabel.Text = "b) Véka-bél";
                Question5OptionCLabel.Text = "c) Vastagbél";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка основна роль травної системи?";
                Question1OptionALabel.Text = "a) Перекачувати кров по тілу";
                Question1OptionBLabel.Text = "b) Розкладати їжу на засвоювані поживні речовини.";
                Question1OptionCLabel.Text = "c) Виробляти гормони для регулювання ваги.";

                Question2Label.Text = "2. Де починається процес травлення в людському тілі?";
                Question2OptionALabel.Text = "a) У тонкому кишечнику";
                Question2OptionBLabel.Text = "b) У роті";
                Question2OptionCLabel.Text = "c) У шлунку";

                Question3Label.Text = "3. Яка речовина в роті допомагає розщеплювати вуглеводи?";
                Question3OptionALabel.Text = "a) Шлунковий сік";
                Question3OptionBLabel.Text = "b) Жовч";
                Question3OptionCLabel.Text = "c) Слина";

                Question4Label.Text = "4. Яка роль підшлункової залози в травленні?";
                Question4OptionALabel.Text = "a) Виробляє шлунковий сік";
                Question4OptionBLabel.Text = "b) Вивільняє травні ферменти в тонкий кишечник";
                Question4OptionCLabel.Text = "c) Абсорбція води і електролітів";

                Question5Label.Text = "5. Яка частина травної системи відповідає за всмоктування води та електролітів з їжі?";
                Question5OptionALabel.Text = "a) Шлунок";
                Question5OptionBLabel.Text = "b) Тонкий кишечник";
                Question5OptionCLabel.Text = "c) Товстий кишечник";
                break;
        }
    }

}