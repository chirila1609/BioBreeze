namespace BioBreeze.Teste;

public partial class AnatomieHearth : ContentPage
{
	public AnatomieHearth()
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

        if (Question2OptionA.IsChecked)
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

    private void OnLanguageButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                TitleLabel.Text = "Test inimă";
                Question1Label.Text = "1. Care parte a inimii primește sânge dezoxigenat din corp și îl pompează către plămâni pentru oxigenare?";
                Question1OptionALabel.Text = "a) Atrii";
                Question1OptionBLabel.Text = "b) Ventricule";
                Question1OptionCLabel.Text = "c) Pericard";

                Question2Label.Text = "2. Ce grup de celule controlează acțiunea de pompare a inimii, generând impulsuri electrice?";
                Question2OptionALabel.Text = "a) Nodul sinusal (SA)";
                Question2OptionBLabel.Text = "b) Talamus";
                Question2OptionCLabel.Text = "c) Cortexul cerebral";

                Question3Label.Text = "3. Cum este protejată și susținută inima?";
                Question3OptionALabel.Text = "a) Prin coaste";
                Question3OptionBLabel.Text = "b) Prin stern";
                Question3OptionCLabel.Text = "c) Prin pericard";

                Question4Label.Text = "4. Care este dimensiunea aproximativă a inimii umane?";
                Question4OptionALabel.Text = "a) Dimensiunea unei mâini";
                Question4OptionBLabel.Text = "b) Dimensiunea unui pumn";
                Question4OptionCLabel.Text = "c) Dimensiunea unui ou";

                Question5Label.Text = "5. Care arteră furnizează sângele oxigenat către mușchiul inimii însuși?";
                Question5OptionALabel.Text = "a) Arterele coronariene";
                Question5OptionBLabel.Text = "b) Artera aortică";
                Question5OptionCLabel.Text = "c) Artera pulmonară";
                break;

            case "hu":
                TitleLabel.Text = "Szív teszt";
                Question1Label.Text = "1. Melyik rész veszi fel a testből származó oxigénszegény vért, és pumpálja a tüdőbe oxigenálás céljából?";
                Question1OptionALabel.Text = "a) Pitvarok";
                Question1OptionBLabel.Text = "b) Kamrák";
                Question1OptionCLabel.Text = "c) Szívburok";

                Question2Label.Text = "2. Melyik sejtcsopor irányítja a szív pumpáló működését elektromos impulzusok létrehozásával?";
                Question2OptionALabel.Text = "a) Sinuscsomó (SA)";
                Question2OptionBLabel.Text = "b) Talamusz";
                Question2OptionCLabel.Text = "c) Agykéreg";

                Question3Label.Text = "3. Hogyan védett és támogatott a szív?";
                Question3OptionALabel.Text = "a) Bordák által";
                Question3OptionBLabel.Text = "b) Szegycsont által";
                Question3OptionCLabel.Text = "c) Szívburok által";

                Question4Label.Text = "4. Mi az emberi szív hozzávetőleges mérete?";
                Question4OptionALabel.Text = "a) Egy kéz mérete";
                Question4OptionBLabel.Text = "b) Egy ököl mérete";
                Question4OptionCLabel.Text = "c) Egy tojás mérete";

                Question5Label.Text = "5. Melyik artéria szállít oxigénnel dúsított vért a szív izomzatába?";
                Question5OptionALabel.Text = "a) Koszorúerek";
                Question5OptionBLabel.Text = "b) Aorta";
                Question5OptionCLabel.Text = "c) Tüdőartéria";
                break;

            case "uk":
                TitleLabel.Text = "Тест серця";
                Question1Label.Text = "1. Яка частина серця отримує дезоксигеновану кров з організму і перекачує її до легенів для оксигенації?";
                Question1OptionALabel.Text = "a) Передсердя";
                Question1OptionBLabel.Text = "b) Шлуночки";
                Question1OptionCLabel.Text = "c) Перикард";

                Question2Label.Text = "2. Яка група клітин контролює насосну дію серця, генеруючи електричні імпульси?";
                Question2OptionALabel.Text = "a) Синусовий вузол (SA)";
                Question2OptionBLabel.Text = "b) Таламус";
                Question2OptionCLabel.Text = "c) Кора головного мозку";

                Question3Label.Text = "3. Як захищене і підтримується серце?";
                Question3OptionALabel.Text = "a) Ребрами";
                Question3OptionBLabel.Text = "b) Грудиною";
                Question3OptionCLabel.Text = "c) Перикардом";

                Question4Label.Text = "4. Який приблизний розмір людського серця?";
                Question4OptionALabel.Text = "a) Розмір руки";
                Question4OptionBLabel.Text = "b) Розмір кулака";
                Question4OptionCLabel.Text = "c) Розмір яйця";

                Question5Label.Text = "5. Яка артерія постачає киснем кров до м'яза самого серця?";
                Question5OptionALabel.Text = "a) Коронарні артерії";
                Question5OptionBLabel.Text = "b) Аорта";
                Question5OptionCLabel.Text = "c) Легенева артерія";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}