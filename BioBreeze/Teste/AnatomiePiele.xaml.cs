namespace BioBreeze.Teste;

public partial class AnatomiePiele : ContentPage
{
	public AnatomiePiele()
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

        if (Question3OptionD.IsChecked)
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
                
                Title = "Test piele";
                Question1Label.Text = "1. Care este principalul rol al pielii umane?";
                Question1OptionALabel.Text = "a) Protecția împotriva agenților externi și reglarea temperaturii corpului";
                Question1OptionBLabel.Text = "b) Absorbția nutrienților din mediul înconjurător";
                Question1OptionCLabel.Text = "c) Funcționarea ca organ de respirație";
                Question1OptionDLabel.Text = "d) Transmiterea semnalelor nervoase către creier";
                Question2Label.Text = "2. Ce strat al pielii este responsabil pentru producerea melaninei?";
                Question2OptionALabel.Text = "a) Epidermul";
                Question2OptionBLabel.Text = "b) Dermul";
                Question2OptionCLabel.Text = "c) Hipodermul";
                Question2OptionDLabel.Text = "d) Straturile de grăsime subcutanată";
                Question3Label.Text = "3. Care dintre următoarele nu este o funcție a pielii umane?";
                Question3OptionALabel.Text = "a) Transmiterea semnalelor nervoase";
                Question3OptionBLabel.Text = "b) Protecția împotriva pierderii de apă";
                Question3OptionCLabel.Text = "c) Reglarea temperaturii corpului";
                Question3OptionDLabel.Text = "d) Absorbția oxigenului din aer";
                Question4Label.Text = "4. Ce role îndeplinesc glandele sudoripare și sebacee din piele?";
                Question4OptionALabel.Text = "a) Hidratarea pielii și producerea de vitamină D";
                Question4OptionBLabel.Text = "b) Reglarea temperaturii și eliminarea deșeurilor";
                Question4OptionCLabel.Text = "c) Producerea de melanină și elastină";
                Question4OptionDLabel.Text = "d) Transmiterea semnalelor nervoase și senzațiile tactile";
                Question5Label.Text = "5. Care strat al pielii conține celulele responsabile pentru formarea stratului exterior protector?";
                Question5OptionALabel.Text = "a) Epidermul";
                Question5OptionBLabel.Text = "b) Dermul";
                Question5OptionCLabel.Text = "c) Hipodermul";
                Question5OptionDLabel.Text = "d) Straturile de grăsime subcutanată";
                break;
            case "uk":
                
                Title = "Тест про шкіру";
                Question1Label.Text = "1. Яка головна роль людської шкіри?";
                Question1OptionALabel.Text = "a) Захист від зовнішніх агентів та регулювання температури тіла";
                Question1OptionBLabel.Text = "b) Поглинання поживних речовин з навколишнього середовища";
                Question1OptionCLabel.Text = "c) Виконання функції органу дихання";
                Question1OptionDLabel.Text = "d) Передача нервових сигналів до мозку";
                Question2Label.Text = "2. Який шар шкіри відповідає за виробництво меланіну?";
                Question2OptionALabel.Text = "a) Епідерміс";
                Question2OptionBLabel.Text = "b) Дерма";
                Question2OptionCLabel.Text = "c) Гіподерма";
                Question2OptionDLabel.Text = "d) Підшкірні жирові шари";
                Question3Label.Text = "3. Яка з наступних функцій не є функцією людської шкіри?";
                Question3OptionALabel.Text = "a) Передача нервових сигналів";
                Question3OptionBLabel.Text = "b) Захист від втрати води";
                Question3OptionCLabel.Text = "c) Регулювання температури тіла";
                Question3OptionDLabel.Text = "d) Поглинання кисню з повітря";
                Question4Label.Text = "4. Які функції виконують потові та сальні залози шкіри?";
                Question4OptionALabel.Text = "a) Зволоження шкіри та вироблення вітаміну D";
                Question4OptionBLabel.Text = "b) Регулювання температури та виведення відходів";
                Question4OptionCLabel.Text = "c) Виробництво меланіну та еластину";
                Question4OptionDLabel.Text = "d) Передача нервових сигналів та дотикові відчуття";
                Question5Label.Text = "5. Який шар шкіри містить клітини, відповідальні за формування зовнішнього захисного шару?";
                Question5OptionALabel.Text = "a) Епідерміс";
                Question5OptionBLabel.Text = "b) Дерма";
                Question5OptionCLabel.Text = "c) Гіподерма";
                Question5OptionDLabel.Text = "d) Підшкірні жирові шари";
                break;
            case "hu":
                
                Title = "Bőrteszt";
                Question1Label.Text = "1. Mi a bőr egyik fő szerepe?";
                Question1OptionALabel.Text = "a) Védelem a külső tényezők ellen és a testhőmérséklet szabályozása";
                Question1OptionBLabel.Text = "b) A tápanyagok felszívása a környezetből";
                Question1OptionCLabel.Text = "c) Légzőszervek működése";
                Question1OptionDLabel.Text = "d) Az idegi jelek továbbítása az agyba";
                Question2Label.Text = "2. Melyik bőrréteg felelős a melanin termeléséért?";
                Question2OptionALabel.Text = "a) Epidermisz";
                Question2OptionBLabel.Text = "b) Dermisz";
                Question2OptionCLabel.Text = "c) Hipodermisz";
                Question2OptionDLabel.Text = "d) Bőr alatti zsírrétegek";
                Question3Label.Text = "3. Az alábbiak közül melyik nem a bőr funkciója?";
                Question3OptionALabel.Text = "a) Az idegi jelek továbbítása";
                Question3OptionBLabel.Text = "b) Vízveszteség elleni védelem";
                Question3OptionCLabel.Text = "c) Testhőmérséklet szabályozása";
                Question3OptionDLabel.Text = "d) Oxigénfelszívás a levegőből";
                Question4Label.Text = "4. Milyen szerepet töltenek be a bőr verejtékmirigyei és faggyúmirigyei?";
                Question4OptionALabel.Text = "a) A bőr hidratálása és a D-vitamin előállítása";
                Question4OptionBLabel.Text = "b) A testhőmérséklet szabályozása és a salakanyagok eltávolítása";
                Question4OptionCLabel.Text = "c) Melanin és elasztin előállítása";
                Question4OptionDLabel.Text = "d) Az idegi jelek továbbítása és az érzékelés";
                Question5Label.Text = "5. Melyik bőrréteg tartalmazza azokat a sejteket, amelyek felelősek a külső védőréteg kialakulásáért?";
                Question5OptionALabel.Text = "a) Epidermisz";
                Question5OptionBLabel.Text = "b) Dermisz";
                Question5OptionCLabel.Text = "c) Hipodermisz";
                Question5OptionDLabel.Text = "d) Bőr alatti zsírrétegek";
                break;
        }
    }

}