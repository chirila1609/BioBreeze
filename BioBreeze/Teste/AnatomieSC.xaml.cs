namespace BioBreeze.Teste;

public partial class AnatomieSC : ContentPage
{
    public AnatomieSC()
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

                Question1Label.Text = "1. Care este rolul principal al sistemului circulator în corpul uman?";
                Question1OptionALabel.Text = "a) Respirația";
                Question1OptionBLabel.Text = "b) Digestia";
                Question1OptionCLabel.Text = "c) Transportul substanțelor nutritive, oxigenului și hormonilor către celule și țesuturi";

                Question2Label.Text = "2. Care este organul principal al sistemului circulator responsabil pentru pomparea sângelui prin corp?";
                Question2OptionALabel.Text = "a) Plămânii";
                Question2OptionBLabel.Text = "b) Inima";
                Question2OptionCLabel.Text = "c) Creierul";

                Question3Label.Text = "3. Ce tip de vase de sânge transportă sângele de la inimă către țesuturi?";
                Question3OptionALabel.Text = "a) Venele";
                Question3OptionBLabel.Text = "b) Arterele";
                Question3OptionCLabel.Text = "c) Capilarele";

                Question4Label.Text = "4. Ce conține sângele în afară de celule roșii și albe?";
                Question4OptionALabel.Text = "a) Lichid biliar";
                Question4OptionBLabel.Text = "b) Plasmă";
                Question4OptionCLabel.Text = "c) Sângele nu conține altceva";

                Question5Label.Text = "5. Care sunt cele trei tipuri principale de celule din sânge?";
                Question5OptionALabel.Text = "a) Celule roșii - transportul oxigenului, celule albe - coagularea sângelui, trombocite - lupta împotriva infecțiilor";
                Question5OptionBLabel.Text = "b) Celule albe - transportul oxigenului, celule roșii - lupta împotriva infecțiilor, trombocite - coagularea sângelui";
                Question5OptionCLabel.Text = "c) Celule roșii - transportul oxigenului, celule albe - lupta împotriva infecțiilor, trombocite - coagularea sângelui";


                break;
            case "uk":

                Question1Label.Text = "1. Яка основна роль кровоносної системи в організмі людини?";
                Question1OptionALabel.Text = "a) Дихання";
                Question1OptionBLabel.Text = "b) Травлення";
                Question1OptionCLabel.Text = "c) Транспортування поживних речовин, кисню та гормонів до клітин і тканин";

                Question2Label.Text = "2. Який основний орган кровоносної системи відповідає за перекачування крові по тілу?";
                Question2OptionALabel.Text = "a) Легені";
                Question2OptionBLabel.Text = "b) Серце";
                Question2OptionCLabel.Text = "c) Мозок";

                Question3Label.Text = "3. Який тип кровоносних судин транспортує кров від серця до тканин?";
                Question3OptionALabel.Text = "a) Вени";
                Question3OptionBLabel.Text = "b) Артерії";
                Question3OptionCLabel.Text = "c) Капіляри";

                Question4Label.Text = "4. Що містить кров, крім червоних і білих клітин?";
                Question4OptionALabel.Text = "a) Жовчний сік";
                Question4OptionBLabel.Text = "b) Плазма";
                Question4OptionCLabel.Text = "c) Кров не містить нічого іншого";

                Question5Label.Text = "5. Які три основні типи клітин у крові?";
                Question5OptionALabel.Text = "a) Червоні клітини - транспортування кисню, білі клітини - згортання крові, тромбоцити - боротьба з інфекціями";
                Question5OptionBLabel.Text = "b) Білі клітини - транспортування кисню, червоні клітини - боротьба з інфекціями, тромбоцити - згортання крові";
                Question5OptionCLabel.Text = "c) Червоні клітини - транспортування кисню, білі клітини - боротьба з інфекціями, тромбоцити - згортання крові";


                break;
            case "hu":

                Question1Label.Text = "1. Mi a keringési rendszer fő szerepe az emberi testben?";
                Question1OptionALabel.Text = "a) Légzés";
                Question1OptionBLabel.Text = "b) Emésztés";
                Question1OptionCLabel.Text = "c) Tápanyagok, oxigén és hormonok szállítása a sejtekhez és szövetekhez";

                Question2Label.Text = "2. Melyik a keringési rendszer fő szerve, amely felelős a vér pumpálásáért a testben?";
                Question2OptionALabel.Text = "a) Tüdő";
                Question2OptionBLabel.Text = "b) Szív";
                Question2OptionCLabel.Text = "c) Agy";

                Question3Label.Text = "3. Milyen típusú vérerek szállítják a vért a szívtől a szövetekhez?";
                Question3OptionALabel.Text = "a) Vénák";
                Question3OptionBLabel.Text = "b) Artériák";
                Question3OptionCLabel.Text = "c) Kapillárisok";

                Question4Label.Text = "4. Mit tartalmaz a vér a vörös és fehérvérsejteken kívül?";
                Question4OptionALabel.Text = "a) Epefolyadék";
                Question4OptionBLabel.Text = "b) Plazma";
                Question4OptionCLabel.Text = "c) A vér nem tartalmaz mást";

                Question5Label.Text = "5. Melyek a vér három fő sejttípusa?";
                Question5OptionALabel.Text = "a) Vörösvérsejtek - oxigén szállítása, fehérvérsejtek - véralvadás, vérlemezkék - fertőzések elleni küzdelem";
                Question5OptionBLabel.Text = "b) Fehérvérsejtek - oxigén szállítása, vörösvérsejtek - fertőzések elleni küzdelem, vérlemezkék - véralvadás";
                Question5OptionCLabel.Text = "c) Vörösvérsejtek - oxigén szállítása, fehérvérsejtek - fertőzések elleni küzdelem, vérlemezkék - véralvadás";


                break;
        }
    }



}