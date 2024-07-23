namespace BioBreeze.Teste;

public partial class AnatomieBrain : ContentPage
{
	public AnatomieBrain()
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

        if (Question3OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionB.IsChecked)
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
                TitleLabel.Text = "Test creierul";
                Question1Label.Text = "1. Care este cea mai mare și mai complexă parte a creierului, responsabilă pentru funcții cognitive superioare precum gândirea și percepția?";
                Question1OptionALabel.Text = "a) Creierul mijlociu";
                Question1OptionBLabel.Text = "b) Creierul posterior";
                Question1OptionCLabel.Text = "c) Creierul anterior";

                Question2Label.Text = "2. Care parte a creierului servește ca un pod care leagă diferite părți ale creierului?";
                Question2OptionALabel.Text = "a) Cerebelul";
                Question2OptionBLabel.Text = "b) Puntea";
                Question2OptionCLabel.Text = "c) Hipotalamusul";

                Question3Label.Text = "3. Ce parte a creierului este responsabilă pentru coordonarea mișcării, echilibrului și posturii?";
                Question3OptionALabel.Text = "a) Thalamusul";
                Question3OptionBLabel.Text = "b) Cerebelul";
                Question3OptionCLabel.Text = "c) Cortexul cerebral";

                Question4Label.Text = "4. Ce celule nervoase formează rețele intricate care permit procesarea și transmiterea informațiilor în întregul creier și corp?";
                Question4OptionALabel.Text = "a) Neuroni";
                Question4OptionBLabel.Text = "b) Gliale";
                Question4OptionCLabel.Text = "c) Fibre nervoase";

                Question5Label.Text = "5. Care parte a creierului controlează funcții vitale precum bătăile inimii și respirația?";
                Question5OptionALabel.Text = "a) Hipotalamusul";
                Question5OptionBLabel.Text = "b) Bulbul rahidian";
                Question5OptionCLabel.Text = "c) Talamusul";
                break;

            case "hu":
                TitleLabel.Text = "Agy teszt";
                Question1Label.Text = "1. Melyik az agy legnagyobb és legösszetettebb része, amely felelős a magasabb kognitív funkciókért, mint például a gondolkodás és az észlelés?";
                Question1OptionALabel.Text = "a) Középagy";
                Question1OptionBLabel.Text = "b) Hátsó agy";
                Question1OptionCLabel.Text = "c) Elülső agy";

                Question2Label.Text = "2. Melyik agyrész szolgál hídként, amely összeköti az agy különböző részeit?";
                Question2OptionALabel.Text = "a) Kisagy";
                Question2OptionBLabel.Text = "b) Híd";
                Question2OptionCLabel.Text = "c) Hipotalamusz";

                Question3Label.Text = "3. Melyik agyrész felelős a mozgás, egyensúly és testtartás koordinálásáért?";
                Question3OptionALabel.Text = "a) Talamusz";
                Question3OptionBLabel.Text = "b) Kisagy";
                Question3OptionCLabel.Text = "c) Agykéreg";

                Question4Label.Text = "4. Melyik idegsejtek alkotják azokat a bonyolult hálózatokat, amelyek lehetővé teszik az információk feldolgozását és továbbítását az egész agyban és testben?";
                Question4OptionALabel.Text = "a) Neuronok";
                Question4OptionBLabel.Text = "b) Glia sejtek";
                Question4OptionCLabel.Text = "c) Idegrostok";

                Question5Label.Text = "5. Melyik agyrész irányítja az életfontosságú funkciókat, mint például a szívverés és a légzés?";
                Question5OptionALabel.Text = "a) Hipotalamusz";
                Question5OptionBLabel.Text = "b) Nyúltvelő";
                Question5OptionCLabel.Text = "c) Talamusz";
                break;

            case "uk":
                TitleLabel.Text = "Тест мозку";
                Question1Label.Text = "1. Яка найбільша і найскладніша частина мозку, відповідальна за вищі когнітивні функції, такі як мислення та сприйняття?";
                Question1OptionALabel.Text = "a) Середній мозок";
                Question1OptionBLabel.Text = "b) Задній мозок";
                Question1OptionCLabel.Text = "c) Передній мозок";

                Question2Label.Text = "2. Яка частина мозку слугує мостом, що з'єднує різні частини мозку?";
                Question2OptionALabel.Text = "a) Мозочок";
                Question2OptionBLabel.Text = "b) Міст";
                Question2OptionCLabel.Text = "c) Гіпоталамус";

                Question3Label.Text = "3. Яка частина мозку відповідає за координацію рухів, рівноваги та постави?";
                Question3OptionALabel.Text = "a) Таламус";
                Question3OptionBLabel.Text = "b) Мозочок";
                Question3OptionCLabel.Text = "c) Кора головного мозку";

                Question4Label.Text = "4. Які нервові клітини утворюють складні мережі, які дозволяють обробляти та передавати інформацію по всьому мозку та тілу?";
                Question4OptionALabel.Text = "a) Нейрони";
                Question4OptionBLabel.Text = "b) Гліальні клітини";
                Question4OptionCLabel.Text = "c) Нервові волокна";

                Question5Label.Text = "5. Яка частина мозку контролює життєво важливі функції, такі як серцебиття та дихання?";
                Question5OptionALabel.Text = "a) Гіпоталамус";
                Question5OptionBLabel.Text = "b) Довгастий мозок";
                Question5OptionCLabel.Text = "c) Таламус";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }

}