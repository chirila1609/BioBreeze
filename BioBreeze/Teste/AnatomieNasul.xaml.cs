namespace BioBreeze.Teste;

public partial class AnatomieNasul : ContentPage
{
	public AnatomieNasul()
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

        if (Question2OptionD.IsChecked)
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
        Button button = (Button)sender;
        string languageCode = button.CommandParameter.ToString();
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                TitleLabel.Text = "Test despre Nasul Uman";
                Question1Label.Text = "1. Care este funcția principală a cavității nazale?";
                Question1OptionALabel.Text = "a) Detectarea mirosurilor";
                Question1OptionBLabel.Text = "b) Filtrarea particulelor din aer";
                Question1OptionCLabel.Text = "c) Dirijarea aerului către plămâni";
                Question1OptionDLabel.Text = "d) Producerea de mucus";
                Question2Label.Text = "2. Ce componentă a nasului uman conține receptorii olfactivi?";
                Question2OptionALabel.Text = "a) Septul nazal";
                Question2OptionBLabel.Text = "b) Cornetele nazale";
                Question2OptionCLabel.Text = "c) Sinusurile paranazale";
                Question2OptionDLabel.Text = "d) Membrana olfactivă";
                Question3Label.Text = "3. Care este rolul sinusurilor paranazale?";
                Question3OptionALabel.Text = "a) Detectarea mirosurilor";
                Question3OptionBLabel.Text = "b) Filtrarea particulelor din aer";
                Question3OptionCLabel.Text = "c) Reducerea greutății capului";
                Question3OptionDLabel.Text = "d) Producerea de mucus";
                Question4Label.Text = "4. Cum ajută firele de păr și mucoasa din cavitatea nazală sistemul respirator?";
                Question4OptionALabel.Text = "a) Protejează împotriva infecțiilor și alergiilor";
                Question4OptionBLabel.Text = "b) Facilitând schimbul de gaze în plămâni";
                Question4OptionCLabel.Text = "c) Asigurând hidratarea adecvată a aerului inhalat";
                Question4OptionDLabel.Text = "d) Contribuind la reglarea temperaturii aerului inhalat";
                Question5Label.Text = "5. Ce funcție suplimentară are nasul uman, în afară de respirație și olfacție?";
                Question5OptionALabel.Text = "a) Reglarea temperaturii corpului";
                Question5OptionBLabel.Text = "b) Producerea de hormoni";
                Question5OptionCLabel.Text = "c) Transmiterea semnalelor vizuale către creier";
                Question5OptionDLabel.Text = "d) Protecția împotriva particulelor străine din aer";
                SubmitButton.Text = "Finalizează";
                break;

            case "hu":
                TitleLabel.Text = "Az emberi orr tesztje";
                Question1Label.Text = "1. Mi az orrüreg fő funkciója?";
                Question1OptionALabel.Text = "a) Szagok észlelése";
                Question1OptionBLabel.Text = "b) Részecskék szűrése a levegőből";
                Question1OptionCLabel.Text = "c) Levegő irányítása a tüdőbe";
                Question1OptionDLabel.Text = "d) Nyálka termelése";
                Question2Label.Text = "2. Melyik az emberi orr része tartalmazza a szagreceptorokat?";
                Question2OptionALabel.Text = "a) Orrsövény";
                Question2OptionBLabel.Text = "b) Orrkagylók";
                Question2OptionCLabel.Text = "c) Paranazális szinuszok";
                Question2OptionDLabel.Text = "d) Szagmembrán";
                Question3Label.Text = "3. Mi a paranazális szinuszok szerepe?";
                Question3OptionALabel.Text = "a) Szagok észlelése";
                Question3OptionBLabel.Text = "b) Részecskék szűrése a levegőből";
                Question3OptionCLabel.Text = "c) Fej súlyának csökkentése";
                Question3OptionDLabel.Text = "d) Nyálka termelése";
                Question4Label.Text = "4. Hogyan segítenek az orrüreg szőrszálai és nyálkahártyája a légzőrendszerben?";
                Question4OptionALabel.Text = "a) Védelem a fertőzések és allergiák ellen";
                Question4OptionBLabel.Text = "b) Gázcsere elősegítése a tüdőben";
                Question4OptionCLabel.Text = "c) A belélegzett levegő megfelelő hidratálása";
                Question4OptionDLabel.Text = "d) A belélegzett levegő hőmérsékletének szabályozása";
                Question5Label.Text = "5. Mi az emberi orr további funkciója a légzésen és a szagláson kívül?";
                Question5OptionALabel.Text = "a) Testhőmérséklet szabályozása";
                Question5OptionBLabel.Text = "b) Hormonok termelése";
                Question5OptionCLabel.Text = "c) Vizuális jelek továbbítása az agyba";
                Question5OptionDLabel.Text = "d) Védelem a levegőben lévő részecskék ellen";
                SubmitButton.Text = "Befejez";
                break;

            case "uk":
                TitleLabel.Text = "Тест про Людський Ніс";
                Question1Label.Text = "1. Яка головна функція носової порожнини?";
                Question1OptionALabel.Text = "a) Виявлення запахів";
                Question1OptionBLabel.Text = "b) Фільтрація частинок з повітря";
                Question1OptionCLabel.Text = "c) Направлення повітря до легень";
                Question1OptionDLabel.Text = "d) Виробництво слизу";
                Question2Label.Text = "2. Який компонент людського носа містить нюхові рецептори?";
                Question2OptionALabel.Text = "a) Носова перегородка";
                Question2OptionBLabel.Text = "b) Носові раковини";
                Question2OptionCLabel.Text = "c) Придаткові пазухи";
                Question2OptionDLabel.Text = "d) Нюхова мембрана";
                Question3Label.Text = "3. Яка роль придаткових пазух?";
                Question3OptionALabel.Text = "a) Виявлення запахів";
                Question3OptionBLabel.Text = "b) Фільтрація частинок з повітря";
                Question3OptionCLabel.Text = "c) Зменшення ваги голови";
                Question3OptionDLabel.Text = "d) Виробництво слизу";
                Question4Label.Text = "4. Як волосся і слизова оболонка носової порожнини допомагають дихальній системі?";
                Question4OptionALabel.Text = "a) Захист від інфекцій та алергій";
                Question4OptionBLabel.Text = "b) Полегшення газообміну в легенях";
                Question4OptionCLabel.Text = "c) Забезпечення належного зволоження вдихуваного повітря";
                Question4OptionDLabel.Text = "d) Регулювання температури вдихуваного повітря";
                Question5Label.Text = "5. Яка додаткова функція носа, окрім дихання та нюху?";
                Question5OptionALabel.Text = "a) Регулювання температури тіла";
                Question5OptionBLabel.Text = "b) Виробництво гормонів";
                Question5OptionCLabel.Text = "c) Передача візуальних сигналів до мозку";
                Question5OptionDLabel.Text = "d) Захист від сторонніх частинок у повітрі";
                SubmitButton.Text = "Завершити";
                break;
        }
    }
}