namespace BioBreeze.Teste;

public partial class BotEVege : ContentPage
{
	public BotEVege()
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

        if (Question2OptionC.IsChecked)
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
                Question1Label.Text = "1. Care este principalul mecanism de excreție la plante?";
                Question1OptionALabel.Text = "a) Fotosinteza";
                Question1OptionBLabel.Text = "b) Transpirația";
                Question1OptionCLabel.Text = "c) Respirația";
                Question1OptionDLabel.Text = "d) Absorbția";

                Question2Label.Text = "2. Ce rol are transpirația în procesul de excreție la plante?";
                Question2OptionALabel.Text = "a) Elimină oxigenul în exces";
                Question2OptionBLabel.Text = "b) Ajută la absorbția apei din sol";
                Question2OptionCLabel.Text = "c) Răcește planta și elimină apă sub formă de vapori";
                Question2OptionDLabel.Text = "d) Protejează plantele de dăunători";

                Question3Label.Text = "3. Cum se numesc glandele speciale care permit anumitor plante să elimine excesul de sare din corpul lor în medii saline?";
                Question3OptionALabel.Text = "a) Glande de transpirație";
                Question3OptionBLabel.Text = "b) Glande de sare";
                Question3OptionCLabel.Text = "c) Glande halofile";
                Question3OptionDLabel.Text = "d) Glande fotosintetice";

                Question4Label.Text = "4. Ce tip de substanțe elimină rădăcinile plantelor în sol?";
                Question4OptionALabel.Text = "a) Nutrienți";
                Question4OptionBLabel.Text = "b) Apă";
                Question4OptionCLabel.Text = "c) Substanțe toxice și deșeuri reziduale";
                Question4OptionDLabel.Text = "d) Oxigen";

                Question5Label.Text = "5. Care este rolul excreției în sol la plante?";
                Question5OptionALabel.Text = "a) Curăță solul de dăunători";
                Question5OptionBLabel.Text = "b) Menține un mediu salin";
                Question5OptionCLabel.Text = "c) Protejează plantele de radiațiile solare";
                Question5OptionDLabel.Text = "d) Menține un mediu propice pentru creșterea plantelor";
                break;

            case "hu":
                TitleLabel.Text = "Növényi exkréciós teszt";
                Question1Label.Text = "1. Mi a fő exkréciós mechanizmus a növényekben?";
                Question1OptionALabel.Text = "a) Fotoszintézis";
                Question1OptionBLabel.Text = "b) Transzpiráció";
                Question1OptionCLabel.Text = "c) Légzés";
                Question1OptionDLabel.Text = "d) Felvétel";

                Question2Label.Text = "2. Mi a szerepe a transzspirációnak a növényi exkrécióban?";
                Question2OptionALabel.Text = "a) Felesleges oxigén eltávolítása";
                Question2OptionBLabel.Text = "b) Víz felszívásának segítése a talajból";
                Question2OptionCLabel.Text = "c) A növény hűtése és víz gőz formájában történő eltávolítása";
                Question2OptionDLabel.Text = "d) Védelem a kártevők ellen";

                Question3Label.Text = "3. Hogyan nevezik azokat a speciális mirigyeket, amelyek lehetővé teszik egyes növények számára, hogy eltávolítsák a sófelesleget sós környezetben?";
                Question3OptionALabel.Text = "a) Transzpirációs mirigyek";
                Question3OptionBLabel.Text = "b) Só mirigyek";
                Question3OptionCLabel.Text = "c) Halofil mirigyek";
                Question3OptionDLabel.Text = "d) Fotoszintetikus mirigyek";

                Question4Label.Text = "4. Milyen anyagokat távolítanak el a növények gyökerei a talajba?";
                Question4OptionALabel.Text = "a) Tápanyagok";
                Question4OptionBLabel.Text = "b) Víz";
                Question4OptionCLabel.Text = "c) Toxikus anyagok és hulladékok";
                Question4OptionDLabel.Text = "d) Oxigén";

                Question5Label.Text = "5. Mi az exkréció szerepe a talajban a növényeknél?";
                Question5OptionALabel.Text = "a) Tisztítja a talajt a kártevőktől";
                Question5OptionBLabel.Text = "b) Sós környezet fenntartása";
                Question5OptionCLabel.Text = "c) Védelem a napfény káros hatásai ellen";
                Question5OptionDLabel.Text = "d) A növények növekedéséhez kedvező környezet fenntartása";
                break;

            case "uk":
                TitleLabel.Text = "Тест на екскрецію рослин";
                Question1Label.Text = "1. Який основний механізм екскреції у рослин?";
                Question1OptionALabel.Text = "a) Фотосинтез";
                Question1OptionBLabel.Text = "b) Транспірація";
                Question1OptionCLabel.Text = "c) Дихання";
                Question1OptionDLabel.Text = "d) Абсорбція";

                Question2Label.Text = "2. Яка роль транспірації в процесі екскреції у рослин?";
                Question2OptionALabel.Text = "a) Видалення надлишкового кисню";
                Question2OptionBLabel.Text = "b) Допомагає в абсорбції води з ґрунту";
                Question2OptionCLabel.Text = "c) Охолодження рослини та видалення води у вигляді пари";
                Question2OptionDLabel.Text = "d) Захист рослин від шкідників";

                Question3Label.Text = "3. Як називаються спеціальні залози, які дозволяють деяким рослинам видаляти надлишок солі з організму в солоних середовищах?";
                Question3OptionALabel.Text = "a) Транспіраційні залози";
                Question3OptionBLabel.Text = "b) Солоні залози";
                Question3OptionCLabel.Text = "c) Галофітні залози";
                Question3OptionDLabel.Text = "d) Фотосинтетичні залози";

                Question4Label.Text = "4. Які речовини видаляють корені рослин у ґрунт?";
                Question4OptionALabel.Text = "a) Поживні речовини";
                Question4OptionBLabel.Text = "b) Вода";
                Question4OptionCLabel.Text = "c) Токсичні речовини та відходи";
                Question4OptionDLabel.Text = "d) Кисень";

                Question5Label.Text = "5. Яка роль екскреції у ґрунті для рослин?";
                Question5OptionALabel.Text = "a) Очищає ґрунт від шкідників";
                Question5OptionBLabel.Text = "b) Підтримує солоний середовище";
                Question5OptionCLabel.Text = "c) Захищає рослини від сонячного випромінювання";
                Question5OptionDLabel.Text = "d) Підтримує сприятливе середовище для росту рослин";
                break;
        }
    }

}