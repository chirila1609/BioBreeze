namespace BioBreeze.Teste;

public partial class AnatomiePL : ContentPage
{
	public AnatomiePL()
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

        if (Question2OptionB.IsChecked)
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
                
                Title = "Test plămâni";
                TestLabel.Text = "Test plămâni";
                Question1Label.Text = "1. Care este principalul organ responsabil pentru respirație în corpul uman?";
                Question1OptionALabel.Text = "a) Inima";
                Question1OptionBLabel.Text = "b) Plămânii";
                Question1OptionCLabel.Text = "c) Rinichii";
                Question1OptionDLabel.Text = "d) Stomacul";
                Question2Label.Text = "2. Ce sunt alveolele?";
                Question2OptionALabel.Text = "a) Tuburi care transportă aerul către plămâni";
                Question2OptionBLabel.Text = "b) Saci de aer situați la capătul bronhiilor";
                Question2OptionCLabel.Text = "c) Vase de sânge care transportă oxigenul";
                Question2OptionDLabel.Text = "d) Țesuturi care protejează plămânii";
                Question3Label.Text = "3. Care este funcția principală a plămânilor?";
                Question3OptionALabel.Text = "a) Digestia alimentelor";
                Question3OptionBLabel.Text = "b) Eliminarea deșeurilor din organism";
                Question3OptionCLabel.Text = "c) Respirația";
                Question3OptionDLabel.Text = "d) Transportul de nutrienți către celule";
                Question4Label.Text = "4. Ce proces se desfășoară la nivelul alveolelor?";
                Question4OptionALabel.Text = "a) Schimbul de gaze între aerul respirat și sânge";
                Question4OptionBLabel.Text = "b) Digestia alimentelor";
                Question4OptionCLabel.Text = "c) Transportul de nutrienți către celule";
                Question4OptionDLabel.Text = "d) Eliminarea deșeurilor din organism";
                Question5Label.Text = "5. Ce factor de risc este asociat cu afecțiunile pulmonare precum cancerul pulmonar și BPOC?";
                Question5OptionALabel.Text = "a) Consumul de fructe și legume";
                Question5OptionBLabel.Text = "b) Exercițiile fizice regulate";
                Question5OptionCLabel.Text = "c) Fumatul";
                Question5OptionDLabel.Text = "d) Renunțarea la alcool";
                break;
            case "uk":
                
                Title = "Тест про легені";
                TestLabel.Text = "Тест про легені";
                Question1Label.Text = "1. Який основний орган, відповідальний за дихання в організмі людини?";
                Question1OptionALabel.Text = "a) Серце";
                Question1OptionBLabel.Text = "b) Легені";
                Question1OptionCLabel.Text = "c) Нирки";
                Question1OptionDLabel.Text = "d) Шлунок";
                Question2Label.Text = "2. Що таке альвеоли?";
                Question2OptionALabel.Text = "a) Трубки, що переносять повітря до легенів";
                Question2OptionBLabel.Text = "b) Повітряні мішечки, розташовані на кінці бронхів";
                Question2OptionCLabel.Text = "c) Кровоносні судини, що транспортують кисень";
                Question2OptionDLabel.Text = "d) Тканини, що захищають легені";
                Question3Label.Text = "3. Яка основна функція легенів?";
                Question3OptionALabel.Text = "a) Травлення їжі";
                Question3OptionBLabel.Text = "b) Виведення відходів з організму";
                Question3OptionCLabel.Text = "c) Дихання";
                Question3OptionDLabel.Text = "d) Транспортування поживних речовин до клітин";
                Question4Label.Text = "4. Який процес відбувається на рівні альвеол?";
                Question4OptionALabel.Text = "a) Газообмін між вдихуваним повітрям і кров'ю";
                Question4OptionBLabel.Text = "b) Травлення їжі";
                Question4OptionCLabel.Text = "c) Транспортування поживних речовин до клітин";
                Question4OptionDLabel.Text = "d) Виведення відходів з організму";
                Question5Label.Text = "5. Який фактор ризику пов'язаний із захворюваннями легень, такими як рак легень та ХОЗЛ?";
                Question5OptionALabel.Text = "a) Споживання фруктів та овочів";
                Question5OptionBLabel.Text = "b) Регулярні фізичні вправи";
                Question5OptionCLabel.Text = "c) Куріння";
                Question5OptionDLabel.Text = "d) Відмова від алкоголю";
                break;
            case "hu":
                
                Title = "Tüdő teszt";
                TestLabel.Text = "Tüdő teszt";
                Question1Label.Text = "1. Mi a fő szerv, amely felelős a légzésért az emberi testben?";
                Question1OptionALabel.Text = "a) Szív";
                Question1OptionBLabel.Text = "b) Tüdő";
                Question1OptionCLabel.Text = "c) Vese";
                Question1OptionDLabel.Text = "d) Gyomor";
                Question2Label.Text = "2. Mik azok az alveolusok?";
                Question2OptionALabel.Text = "a) Csövek, amelyek a levegőt a tüdőbe szállítják";
                Question2OptionBLabel.Text = "b) Légzsákok, amelyek a hörgők végén helyezkednek el";
                Question2OptionCLabel.Text = "c) Vérerek, amelyek oxigént szállítanak";
                Question2OptionDLabel.Text = "d) Szövetek, amelyek védik a tüdőt";
                Question3Label.Text = "3. Mi a tüdő fő funkciója?";
                Question3OptionALabel.Text = "a) Táplálék emésztése";
                Question3OptionBLabel.Text = "b) A hulladékok eltávolítása a szervezetből";
                Question3OptionCLabel.Text = "c) Légzés";
                Question3OptionDLabel.Text = "d) Tápanyagok szállítása a sejtekhez";
                Question4Label.Text = "4. Milyen folyamat zajlik az alveolusok szintjén?";
                Question4OptionALabel.Text = "a) Gázcsere a belélegzett levegő és a vér között";
                Question4OptionBLabel.Text = "b) Táplálék emésztése";
                Question4OptionCLabel.Text = "c) Tápanyagok szállítása a sejtekhez";
                Question4OptionDLabel.Text = "d) A hulladékok eltávolítása a szervezetből";
                Question5Label.Text = "5. Milyen kockázati tényező társul a tüdőbetegségekhez, például a tüdőrákhoz és a COPD-hez?";
                Question5OptionALabel.Text = "a) Gyümölcsök és zöldségek fogyasztása";
                Question5OptionBLabel.Text = "b) Rendszeres testmozgás";
                Question5OptionCLabel.Text = "c) Dohányzás";
                Question5OptionDLabel.Text = "d) Alkoholfogyasztás abbahagyása";
                break;
        }
    }
}