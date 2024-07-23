namespace BioBreeze.Teste;

public partial class BotRVege : ContentPage
{
	public BotRVege()
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

        if (Question3OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionB.IsChecked)
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
                TitleLabel.Text = "Test respirație la plante";
                Question1Label.Text = "1. Care este principalul organ implicat în respirația la plante?";
                Question1OptionALabel.Text = "a) Rădăcinile";
                Question1OptionBLabel.Text = "b) Frunzele";
                Question1OptionCLabel.Text = "c) Tulpinile";
                Question1OptionDLabel.Text = "d) Florile";

                Question2Label.Text = "2. Ce rol au stomatele în procesul de respirație la plante?";
                Question2OptionALabel.Text = "a) Absorbția oxigenului";
                Question2OptionBLabel.Text = "b) Eliminarea dioxidului de carbon";
                Question2OptionCLabel.Text = "c) Descompunerea zaharurilor";
                Question2OptionDLabel.Text = "d) Toate cele de mai sus";

                Question3Label.Text = "3. Cum diferă procesul de respirație la plante de la fotosinteză?";
                Question3OptionALabel.Text = "a) Plantele nu respiră";
                Question3OptionBLabel.Text = "b) În respirație, se absorb oxigenul și se elimină dioxidul de carbon";
                Question3OptionCLabel.Text = "c) În respirație, se elimină oxigenul și se absorb dioxidul de carbon";
                Question3OptionDLabel.Text = "d) Nu există diferențe între cele două procese";

                Question4Label.Text = "4. Care este importanța respirației pentru plante?";
                Question4OptionALabel.Text = "a) Producerea oxigenului";
                Question4OptionBLabel.Text = "b) Obținerea energiei necesare pentru supraviețuire și creștere";
                Question4OptionCLabel.Text = "c) Absorbția apei";
                Question4OptionDLabel.Text = "d) Transportul nutrienților în întreaga plantă";

                Question5Label.Text = "5. Ce adaptări pot avea plantele pentru a gestiona respirația în medii diferite?";
                Question5OptionALabel.Text = "a) Închiderea stomatelor în timpul zilei";
                Question5OptionBLabel.Text = "b) Deschiderea stomatelor în timpul nopții";
                Question5OptionCLabel.Text = "c) Utilizarea altor structuri pentru schimbul de gaze";
                Question5OptionDLabel.Text = "d) Toate cele de mai sus";
                break;

            case "hu":
                TitleLabel.Text = "Növényi légzési teszt";
                Question1Label.Text = "1. Mi a fő szerv, amely részt vesz a növények légzésében?";
                Question1OptionALabel.Text = "a) Gyökerek";
                Question1OptionBLabel.Text = "b) Levelek";
                Question1OptionCLabel.Text = "c) Szárak";
                Question1OptionDLabel.Text = "d) Virágok";

                Question2Label.Text = "2. Mi a szerepe a légzőnyílásoknak a növények légzésében?";
                Question2OptionALabel.Text = "a) Oxigén felszívása";
                Question2OptionBLabel.Text = "b) Szén-dioxid eltávolítása";
                Question2OptionCLabel.Text = "c) Cukrok lebontása";
                Question2OptionDLabel.Text = "d) Minden fent említett";

                Question3Label.Text = "3. Hogyan különbözik a növények légzési folyamata a fotoszintézistől?";
                Question3OptionALabel.Text = "a) A növények nem lélegeznek";
                Question3OptionBLabel.Text = "b) A légzés során oxigént vesznek fel és szén-dioxidot bocsátanak ki";
                Question3OptionCLabel.Text = "c) A légzés során oxigént bocsátanak ki és szén-dioxidot vesznek fel";
                Question3OptionDLabel.Text = "d) Nincs különbség a két folyamat között";

                Question4Label.Text = "4. Mi a légzés jelentősége a növények számára?";
                Question4OptionALabel.Text = "a) Oxigén termelése";
                Question4OptionBLabel.Text = "b) A túléléshez és növekedéshez szükséges energia megszerzése";
                Question4OptionCLabel.Text = "c) Víz felszívása";
                Question4OptionDLabel.Text = "d) Tápanyagok szállítása a növényben";

                Question5Label.Text = "5. Milyen alkalmazkodások segíthetnek a növényeknek a légzés kezelésében különböző környezetekben?";
                Question5OptionALabel.Text = "a) A légzőnyílások zárása nappal";
                Question5OptionBLabel.Text = "b) A légzőnyílások nyitása éjszaka";
                Question5OptionCLabel.Text = "c) Más struktúrák használata a gázcserére";
                Question5OptionDLabel.Text = "d) Minden fent említett";
                break;

            case "uk":
                TitleLabel.Text = "Тест на дихання рослин";
                Question1Label.Text = "1. Який основний орган бере участь у диханні рослин?";
                Question1OptionALabel.Text = "a) Корені";
                Question1OptionBLabel.Text = "b) Листя";
                Question1OptionCLabel.Text = "c) Стебла";
                Question1OptionDLabel.Text = "d) Квіти";

                Question2Label.Text = "2. Яка роль продихів у процесі дихання рослин?";
                Question2OptionALabel.Text = "a) Поглинання кисню";
                Question2OptionBLabel.Text = "b) Виведення вуглекислого газу";
                Question2OptionCLabel.Text = "c) Розщеплення цукрів";
                Question2OptionDLabel.Text = "d) Всі вищезазначені";

                Question3Label.Text = "3. Як процес дихання у рослин відрізняється від фотосинтезу?";
                Question3OptionALabel.Text = "a) Рослини не дихають";
                Question3OptionBLabel.Text = "b) Під час дихання поглинається кисень і виводиться вуглекислий газ";
                Question3OptionCLabel.Text = "c) Під час дихання виводиться кисень і поглинається вуглекислий газ";
                Question3OptionDLabel.Text = "d) Немає різниці між цими двома процесами";

                Question4Label.Text = "4. Яке значення дихання для рослин?";
                Question4OptionALabel.Text = "a) Виробництво кисню";
                Question4OptionBLabel.Text = "b) Отримання енергії, необхідної для виживання і росту";
                Question4OptionCLabel.Text = "c) Поглинання води";
                Question4OptionDLabel.Text = "d) Транспорт поживних речовин по всій рослині";

                Question5Label.Text = "5. Які адаптації можуть мати рослини для управління диханням в різних умовах?";
                Question5OptionALabel.Text = "a) Закриття продихів вдень";
                Question5OptionBLabel.Text = "b) Відкриття продихів вночі";
                Question5OptionCLabel.Text = "c) Використання інших структур для обміну газами";
                Question5OptionDLabel.Text = "d) Всі вищезазначені";
                break;
        }
    }

}