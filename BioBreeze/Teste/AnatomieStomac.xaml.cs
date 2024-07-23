namespace BioBreeze.Teste;

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
                TitleLabel.Text = "Test stomac";
                Question1Label.Text = "1. Care este funcția principală a stomacului în sistemul digestiv?";
                Question1OptionALabel.Text = "a) Absorbția nutrienților";
                Question1OptionBLabel.Text = "b) Descompunerea carbohidraților";
                Question1OptionCLabel.Text = "c) Descompunerea și prelucrarea alimentelor";
                Question1OptionDLabel.Text = "d) Filtrarea toxinelor";

                Question2Label.Text = "2. Care substanță esențială se găsește în sucul gastric și ajută la descompunerea proteinelor?";
                Question2OptionALabel.Text = "a) Acid citric";
                Question2OptionBLabel.Text = "b) Acid acetic";
                Question2OptionCLabel.Text = "c) Acid clorhidric";
                Question2OptionDLabel.Text = "d) Acid sulfuric";

                Question3Label.Text = "3. Ce substanță este eliberată în intestinul subțire după ce alimentele sunt prelucrate în stomac?";
                Question3OptionALabel.Text = "a) Chil";
                Question3OptionBLabel.Text = "b) Suc pancreatic";
                Question3OptionCLabel.Text = "c) Salivă";
                Question3OptionDLabel.Text = "d) Bilă";

                Question4Label.Text = "4. Care este rolul mucoasei din stomac?";
                Question4OptionALabel.Text = "a) Protejează pereții stomacului de acizi";
                Question4OptionBLabel.Text = "b) Stimulează secreția de enzime digestive";
                Question4OptionCLabel.Text = "c) Absorbția nutrienților";
                Question4OptionDLabel.Text = "d) Reglează senzația de foame";

                Question5Label.Text = "5. Ce semnale trimite stomacul către creier pentru a indica că suntem sătui?";
                Question5OptionALabel.Text = "a) Senzația de sete";
                Question5OptionBLabel.Text = "b) Senzația de frig";
                Question5OptionCLabel.Text = "c) Senzația de greață";
                Question5OptionDLabel.Text = "d) Senzația de sațietate";
                break;

            case "hu":
                TitleLabel.Text = "Gyomor teszt";
                Question1Label.Text = "1. Mi a gyomor fő funkciója az emésztőrendszerben?";
                Question1OptionALabel.Text = "a) Tápanyagok felszívása";
                Question1OptionBLabel.Text = "b) Szénhidrátok lebontása";
                Question1OptionCLabel.Text = "c) Ételek lebontása és feldolgozása";
                Question1OptionDLabel.Text = "d) Toxinok szűrése";

                Question2Label.Text = "2. Melyik alapvető anyag található a gyomornedvben, és segíti a fehérjék lebontását?";
                Question2OptionALabel.Text = "a) Citromsav";
                Question2OptionBLabel.Text = "b) Ecetsav";
                Question2OptionCLabel.Text = "c) Sósav";
                Question2OptionDLabel.Text = "d) Kénsav";

                Question3Label.Text = "3. Melyik anyag szabadul fel a vékonybélbe, miután az étel feldolgozásra került a gyomorban?";
                Question3OptionALabel.Text = "a) Chime";
                Question3OptionBLabel.Text = "b) Hasnyál";
                Question3OptionCLabel.Text = "c) Nyál";
                Question3OptionDLabel.Text = "d) Epe";

                Question4Label.Text = "4. Mi a gyomor nyálkahártyájának szerepe?";
                Question4OptionALabel.Text = "a) Védi a gyomor falát a savaktól";
                Question4OptionBLabel.Text = "b) Serkenti az emésztőenzimek kiválasztását";
                Question4OptionCLabel.Text = "c) Tápanyagok felszívása";
                Question4OptionDLabel.Text = "d) Éhségérzet szabályozása";

                Question5Label.Text = "5. Milyen jeleket küld a gyomor az agynak, hogy jelezze a telítettséget?";
                Question5OptionALabel.Text = "a) Szomjúságérzet";
                Question5OptionBLabel.Text = "b) Hidegérzet";
                Question5OptionCLabel.Text = "c) Hányinger";
                Question5OptionDLabel.Text = "d) Telítettségérzet";
                break;

            case "uk":
                TitleLabel.Text = "Тест на шлунок";
                Question1Label.Text = "1. Яка основна функція шлунка в травній системі?";
                Question1OptionALabel.Text = "a) Абсорбція поживних речовин";
                Question1OptionBLabel.Text = "b) Розщеплення вуглеводів";
                Question1OptionCLabel.Text = "c) Розщеплення і переробка їжі";
                Question1OptionDLabel.Text = "d) Фільтрація токсинів";

                Question2Label.Text = "2. Яка основна речовина є в шлунковому соку і допомагає розщеплювати білки?";
                Question2OptionALabel.Text = "a) Лимонна кислота";
                Question2OptionBLabel.Text = "b) Оцтова кислота";
                Question2OptionCLabel.Text = "c) Соляна кислота";
                Question2OptionDLabel.Text = "d) Сульфатна кислота";

                Question3Label.Text = "3. Яка речовина вивільняється в тонкому кишечнику після того, як їжа оброблена в шлунку?";
                Question3OptionALabel.Text = "a) Хімус";
                Question3OptionBLabel.Text = "b) Панкреатичний сік";
                Question3OptionCLabel.Text = "c) Слина";
                Question3OptionDLabel.Text = "d) Жовч";

                Question4Label.Text = "4. Яка роль слизової оболонки шлунка?";
                Question4OptionALabel.Text = "a) Захищає стінки шлунка від кислот";
                Question4OptionBLabel.Text = "b) Стимулює виділення травних ферментів";
                Question4OptionCLabel.Text = "c) Абсорбція поживних речовин";
                Question4OptionDLabel.Text = "d) Регулює відчуття голоду";

                Question5Label.Text = "5. Які сигнали шлунок надсилає до мозку, щоб вказати на те, що ми ситі?";
                Question5OptionALabel.Text = "a) Відчуття спраги";
                Question5OptionBLabel.Text = "b) Відчуття холоду";
                Question5OptionCLabel.Text = "c) Відчуття нудоти";
                Question5OptionDLabel.Text = "d) Відчуття насиченості";
                break;
        }
    }

}