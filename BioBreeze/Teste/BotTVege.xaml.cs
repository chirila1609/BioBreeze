namespace BioBreeze.Teste;

public partial class BotTVege : ContentPage
{
	public BotTVege()
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

        if (Question2OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionC.IsChecked)
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
                TitleLabel.Text = "Test țesuturi vegetale";
                Question1Label.Text = "1. Care este funcția principală a meristemului apical?";
                Question1OptionALabel.Text = "a) Transportul apei și substanțelor minerale";
                Question1OptionBLabel.Text = "b) Creșterea în lungime a plantei";
                Question1OptionCLabel.Text = "c) Protecția împotriva pierderii de apă";
                Question1OptionDLabel.Text = "d) Susținerea și flexibilitatea țesuturilor";

                Question2Label.Text = "2. Ce rol are cambiu vascular în creșterea plantelor?";
                Question2OptionALabel.Text = "a) Produce țesut vascular secundar";
                Question2OptionBLabel.Text = "b) Produce țesut cortical secundar";
                Question2OptionCLabel.Text = "c) Protejează plantele împotriva stresului mecanic";
                Question2OptionDLabel.Text = "d) Transportă substanțele organice sintetizate";

                Question3Label.Text = "3. Unde se găsește țesutul epidermic într-o plantă?";
                Question3OptionALabel.Text = "a) În interiorul frunzelor";
                Question3OptionBLabel.Text = "b) La nivelul rădăcinilor";
                Question3OptionCLabel.Text = "c) Ca strat exterior al plantei";
                Question3OptionDLabel.Text = "d) În interiorul tulpinii";

                Question4Label.Text = "4. Care dintre următoarele țesuturi vegetale furnizează rigiditate și protecție împotriva stresului mecanic?";
                Question4OptionALabel.Text = "a) Colenchim";
                Question4OptionBLabel.Text = "b) Floem";
                Question4OptionCLabel.Text = "c) Parenchim";
                Question4OptionDLabel.Text = "d) Meristem lateral";

                Question5Label.Text = "5. Ce tip de țesut vegetal depozitează substanțe nutritive, precum amidonul și uleiurile?";
                Question5OptionALabel.Text = "a) Cambiu vascular";
                Question5OptionBLabel.Text = "b) Sclerenchim";
                Question5OptionCLabel.Text = "c) Peridermă";
                Question5OptionDLabel.Text = "d) Parenchim de stocare";
                break;

            case "hu":
                TitleLabel.Text = "Növényi szövetek teszt";
                Question1Label.Text = "1. Mi a fő funkciója a csúcsmerisztémának?";
                Question1OptionALabel.Text = "a) Víz és ásványi anyagok szállítása";
                Question1OptionBLabel.Text = "b) A növény hosszirányú növekedése";
                Question1OptionCLabel.Text = "c) Vízveszteség elleni védelem";
                Question1OptionDLabel.Text = "d) Szövetek támogatása és rugalmassága";

                Question2Label.Text = "2. Mi a kambium szerepe a növények növekedésében?";
                Question2OptionALabel.Text = "a) Másodlagos vaskuláris szövetet termel";
                Question2OptionBLabel.Text = "b) Másodlagos kortikális szövetet termel";
                Question2OptionCLabel.Text = "c) Védi a növényeket mechanikai stressz ellen";
                Question2OptionDLabel.Text = "d) Szerves anyagokat szállít";

                Question3Label.Text = "3. Hol található az epidermisz szövet a növényben?";
                Question3OptionALabel.Text = "a) A levelek belsejében";
                Question3OptionBLabel.Text = "b) A gyökerek szintjén";
                Question3OptionCLabel.Text = "c) A növény külső rétegében";
                Question3OptionDLabel.Text = "d) A szár belsejében";

                Question4Label.Text = "4. Melyik szövet biztosít merevséget és védelmet a mechanikai stressz ellen?";
                Question4OptionALabel.Text = "a) Kolenchima";
                Question4OptionBLabel.Text = "b) Floem";
                Question4OptionCLabel.Text = "c) Parenchima";
                Question4OptionDLabel.Text = "d) Oldalmerisztéma";

                Question5Label.Text = "5. Melyik növényi szövet tárol tápanyagokat, például keményítőt és olajokat?";
                Question5OptionALabel.Text = "a) Vaskuláris kambium";
                Question5OptionBLabel.Text = "b) Szklerenchima";
                Question5OptionCLabel.Text = "c) Peridermisz";
                Question5OptionDLabel.Text = "d) Tároló parenchima";
                break;

            case "uk":
                TitleLabel.Text = "Тест на тканини рослин";
                Question1Label.Text = "1. Яка основна функція апікального меристеми?";
                Question1OptionALabel.Text = "a) Транспорт води та мінеральних речовин";
                Question1OptionBLabel.Text = "b) Розширення рослини в довжину";
                Question1OptionCLabel.Text = "c) Захист від втрати води";
                Question1OptionDLabel.Text = "d) Підтримка і гнучкість тканин";

                Question2Label.Text = "2. Яка роль ксилеми в рості рослин?";
                Question2OptionALabel.Text = "a) Виробляє вторинну судинну тканину";
                Question2OptionBLabel.Text = "b) Виробляє вторинну кортикальну тканину";
                Question2OptionCLabel.Text = "c) Захищає рослини від механічного стресу";
                Question2OptionDLabel.Text = "d) Транспортує органічні речовини";

                Question3Label.Text = "3. Де знаходиться епідермальна тканина у рослині?";
                Question3OptionALabel.Text = "a) Всередині листя";
                Question3OptionBLabel.Text = "b) На рівні коренів";
                Question3OptionCLabel.Text = "c) Як зовнішній шар рослини";
                Question3OptionDLabel.Text = "d) Всередині стебла";

                Question4Label.Text = "4. Яка з наведених тканин рослин забезпечує жорсткість і захист від механічного стресу?";
                Question4OptionALabel.Text = "a) Коленхіма";
                Question4OptionBLabel.Text = "b) Флоема";
                Question4OptionCLabel.Text = "c) Паренхіма";
                Question4OptionDLabel.Text = "d) Боковий меристем";

                Question5Label.Text = "5. Який тип рослинної тканини зберігає поживні речовини, такі як крохмаль та олії?";
                Question5OptionALabel.Text = "a) Ксилема";
                Question5OptionBLabel.Text = "b) Склеренхіма";
                Question5OptionCLabel.Text = "c) Перидерма";
                Question5OptionDLabel.Text = "d) Паренхіма для зберігання";
                break;
        }
    }


}