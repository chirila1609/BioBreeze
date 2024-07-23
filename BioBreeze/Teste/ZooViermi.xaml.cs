namespace BioBreeze.Teste;

public partial class ZooViermi : ContentPage
{
	public ZooViermi()
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
            feedback += "Question 1 is incorrect.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Question 2 is incorrect.\n";

        if (Question3OptionC.IsChecked)
            score++;
        else
            feedback += "Question 3 is incorrect.\n";

        if (Question4OptionB.IsChecked)
            score++;
        else
            feedback += "Question 4 is incorrect.\n";

        if (Question5OptionB.IsChecked)
            score++;
        else
            feedback += "Question 5 is incorrect.\n";

        if (score == 5)
            GlobalVariables.TestsPassed++;

        
        ScoreLabel.Text = $"Your score: {score} out of 5\n{feedback}";
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
                Question1Label.Text = "1. Care este una dintre categoriile principale de viermi menționată în text?";
                Question1OptionALabel.Text = "a) Insecte";
                Question1OptionBLabel.Text = "b) Platelminți";
                Question1OptionCLabel.Text = "c) Mamifere";

                Question2Label.Text = "2. Ce rol joacă viermii pământului în ecosisteme?";
                Question2OptionALabel.Text = "a) Reducerea fertilității solului";
                Question2OptionBLabel.Text = "b) Aerisirea și îmbunătățirea fertilității solului";
                Question2OptionCLabel.Text = "c) Stimularea creșterii buruienilor";

                Question3Label.Text = "3. Care este un exemplu de impact negativ al unor specii de viermi?";
                Question3OptionALabel.Text = "a) Compostarea solului";
                Question3OptionBLabel.Text = "b) Infestarea plantelor cu nutrienți";
                Question3OptionCLabel.Text = "c) Infecțiile parazitare în organismele umane și animale";

                Question4Label.Text = "4. De ce este importantă cercetarea asupra viermilor?";
                Question4OptionALabel.Text = "a) Pentru a-i eradică complet din medii";
                Question4OptionBLabel.Text = "b) Pentru a înțelege mai bine rolul lor în ecosisteme și impactul asupra oamenilor";
                Question4OptionCLabel.Text = "c) Pentru a-i promova ca animale de companie";

                Question5Label.Text = "5. Care este una dintre modalitățile în care cercetarea asupra viermilor poate contribui la conservarea biodiversității?";
                Question5OptionALabel.Text = "a) Identificarea speciilor de viermi care nu sunt utile și eliminarea lor";
                Question5OptionBLabel.Text = "b) Studiul adaptărilor lor la medii extreme";
                Question5OptionCLabel.Text = "c) Promovarea comerțului cu viermi exotici ca animale de companie";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik a fő kategóriái a férgeknek, amelyeket a szöveg említ?";
                Question1OptionALabel.Text = "a) Rovarak";
                Question1OptionBLabel.Text = "b) Laposférgek";
                Question1OptionCLabel.Text = "c) Emlősök";

                Question2Label.Text = "2. Mi a földigiliszták szerepe az ökoszisztémákban?";
                Question2OptionALabel.Text = "a) A talaj termékenységének csökkentése";
                Question2OptionBLabel.Text = "b) A talaj szellőztetése és termékenységének javítása";
                Question2OptionCLabel.Text = "c) Gyomok növekedésének serkentése";

                Question3Label.Text = "3. Milyen negatív hatással lehetnek egyes féregfajok?";
                Question3OptionALabel.Text = "a) Talaj komposztálása";
                Question3OptionBLabel.Text = "b) Növények tápanyagokkal való fertőzése";
                Question3OptionCLabel.Text = "c) Paraziták okozta fertőzések emberi és állati szervezetekben";

                Question4Label.Text = "4. Miért fontos a férgek kutatása?";
                Question4OptionALabel.Text = "a) Az élőhelyek teljes eltávolítása miatt";
                Question4OptionBLabel.Text = "b) Az ökoszisztémákban betöltött szerepük és az emberekre gyakorolt hatásuk jobb megértése érdekében";
                Question4OptionCLabel.Text = "c) Háziállatokként való népszerűsítésük érdekében";

                Question5Label.Text = "5. Hogyan hozzájárulhat a férgek kutatása a biodiverzitás megőrzéséhez?";
                Question5OptionALabel.Text = "a) A nem hasznos férgészsékek azonosítása és eltávolítása";
                Question5OptionBLabel.Text = "b) A szélsőséges környezetekhez való alkalmazkodásuk tanulmányozása";
                Question5OptionCLabel.Text = "c) Exotikus férgek kereskedelme háziállatként";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка з основних категорій червів згадується у тексті?";
                Question1OptionALabel.Text = "a) Комахи";
                Question1OptionBLabel.Text = "b) Плоскі черви";
                Question1OptionCLabel.Text = "c) Ссавці";

                Question2Label.Text = "2. Яка роль дощових червів в екосистемах?";
                Question2OptionALabel.Text = "a) Зменшення родючості ґрунту";
                Question2OptionBLabel.Text = "b) Аерація та покращення родючості ґрунту";
                Question2OptionCLabel.Text = "c) Стимулювання росту бур’янів";

                Question3Label.Text = "3. Який негативний вплив можуть мати деякі види червів?";
                Question3OptionALabel.Text = "a) Компостування ґрунту";
                Question3OptionBLabel.Text = "b) Інфекція рослин поживними речовинами";
                Question3OptionCLabel.Text = "c) Паразитарні інфекції у людей та тварин";

                Question4Label.Text = "4. Чому важливе дослідження червів?";
                Question4OptionALabel.Text = "a) Щоб повністю їх знищити в середовищі";
                Question4OptionBLabel.Text = "b) Щоб краще зрозуміти їхню роль в екосистемах і вплив на людей";
                Question4OptionCLabel.Text = "c) Щоб популяризувати їх як домашніх тварин";

                Question5Label.Text = "5. Як дослідження червів може сприяти збереженню біорізноманіття?";
                Question5OptionALabel.Text = "a) Ідентифікація непотрібних видів червів і їх видалення";
                Question5OptionBLabel.Text = "b) Дослідження їх адаптацій до екстремальних середовищ";
                Question5OptionCLabel.Text = "c) Популяризація торгівлі екзотичними червами як домашніми тваринами";
                break;
        }
    }
}