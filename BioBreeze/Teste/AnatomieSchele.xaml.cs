namespace BioBreeze.Teste
{
    public partial class AnatomieSchele : ContentPage
    {
        public AnatomieSchele()
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

            if (Question3OptionA.IsChecked)
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
                    Question1Label.Text = "1. Din cate oase este alcatuit craniul?";
                    Question1OptionALabel.Text = "a) 20";
                    Question1OptionBLabel.Text = "b) 18";
                    Question1OptionCLabel.Text = "c) 22";
                    Question1OptionDLabel.Text = "d) 24";

                    Question2Label.Text = "2. Din cate vertebre este alcatuita coloana vertebrala?";
                    Question2OptionALabel.Text = "a) 22";
                    Question2OptionBLabel.Text = "b) 33";
                    Question2OptionCLabel.Text = "c) 36";
                    Question2OptionDLabel.Text = "d) 24";

                    Question3Label.Text = "3. Cate perechi de coaste exista in total?";
                    Question3OptionALabel.Text = "a) 12";
                    Question3OptionBLabel.Text = "b) 7";
                    Question3OptionCLabel.Text = "c) 15";
                    Question3OptionDLabel.Text = "d) 10";

                    Question4Label.Text = "4. Pe ce sunt asezate primele 7 coaste?";
                    Question4OptionALabel.Text = "a) stern";
                    Question4OptionBLabel.Text = "b) libere";

                    Question5Label.Text = "5. Pe ce sunt asezate urmatoarele coaste?";
                    Question5OptionALabel.Text = "a) stern";
                    Question5OptionBLabel.Text = "b) libere";
                    break;

                case "hu":
                    TitleLabel.Text = "Teszt";
                    Question1Label.Text = "1. Hány csontból áll a koponya?";
                    Question1OptionALabel.Text = "a) 20";
                    Question1OptionBLabel.Text = "b) 18";
                    Question1OptionCLabel.Text = "c) 22";
                    Question1OptionDLabel.Text = "d) 24";

                    Question2Label.Text = "2. Hány csigolyából áll a gerincoszlop?";
                    Question2OptionALabel.Text = "a) 22";
                    Question2OptionBLabel.Text = "b) 33";
                    Question2OptionCLabel.Text = "c) 36";
                    Question2OptionDLabel.Text = "d) 24";

                    Question3Label.Text = "3. Hány pár borda van összesen?";
                    Question3OptionALabel.Text = "a) 12";
                    Question3OptionBLabel.Text = "b) 7";
                    Question3OptionCLabel.Text = "c) 15";
                    Question3OptionDLabel.Text = "d) 10";

                    Question4Label.Text = "4. Hol helyezkedik el az első 7 borda?";
                    Question4OptionALabel.Text = "a) szegycsont";
                    Question4OptionBLabel.Text = "b) szabad";

                    Question5Label.Text = "5. Hol helyezkedik el a következő borda?";
                    Question5OptionALabel.Text = "a) szegycsont";
                    Question5OptionBLabel.Text = "b) szabad";
                    break;

                case "uk":
                    TitleLabel.Text = "Тест";
                    Question1Label.Text = "1. Зі скількох кісток складається череп?";
                    Question1OptionALabel.Text = "a) 20";
                    Question1OptionBLabel.Text = "b) 18";
                    Question1OptionCLabel.Text = "c) 22";
                    Question1OptionDLabel.Text = "d) 24";

                    Question2Label.Text = "2. Зі скількох хребців складається хребет?";
                    Question2OptionALabel.Text = "a) 22";
                    Question2OptionBLabel.Text = "b) 33";
                    Question2OptionCLabel.Text = "c) 36";
                    Question2OptionDLabel.Text = "d) 24";

                    Question3Label.Text = "3. Скільки всього пар ребер?";
                    Question3OptionALabel.Text = "a) 12";
                    Question3OptionBLabel.Text = "b) 7";
                    Question3OptionCLabel.Text = "c) 15";
                    Question3OptionDLabel.Text = "d) 10";

                    Question4Label.Text = "4. Де розташовані перші 7 ребер?";
                    Question4OptionALabel.Text = "a) грудини";
                    Question4OptionBLabel.Text = "b) вільні";

                    Question5Label.Text = "5. Де розташовані наступні ребра?";
                    Question5OptionALabel.Text = "a) грудини";
                    Question5OptionBLabel.Text = "b) вільні";
                    break;
            }
        }


    }
}
