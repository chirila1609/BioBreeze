namespace BioBreeze.Teste;

public partial class ZooEAnimale : ContentPage
{
	public ZooEAnimale()
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

        if (Question2OptionC.IsChecked)
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este rolul excreției în organismele animale?";
                Question1OptionALabel.Text = "a) Menținerea echilibrului intern și eliminarea deșeurilor";
                Question1OptionBLabel.Text = "b) Producția de energie";
                Question1OptionCLabel.Text = "c) Reproducția";

                Question2Label.Text = "2. Care este unul dintre organele principale de excreție la majoritatea vertebratelor?";
                Question2OptionALabel.Text = "a) Ficatul";
                Question2OptionBLabel.Text = "b) Plămânii";
                Question2OptionCLabel.Text = "c) Rinichii";

                Question3Label.Text = "3. Ce sistem de excreție este utilizat de insecte și moluște?";
                Question3OptionALabel.Text = "a) Rinichii";
                Question3OptionBLabel.Text = "b) Intestinele";
                Question3OptionCLabel.Text = "c) Tuburile Malpighi";

                Question4Label.Text = "4. Cum se adaptează animalele deșertice la mediul lor uscat în ceea ce privește excreția?";
                Question4OptionALabel.Text = "a) Prin eliminarea cantităților mari de urină";
                Question4OptionBLabel.Text = "b) Prin dezvoltarea unui sistem de excreție concentrat";
                Question4OptionCLabel.Text = "c) Prin eliminarea excesului de apă prin piele";

                Question5Label.Text = "5. Ce organ specializat ajută peștii și rechinii să facă față excreției deșeurilor în mediul marin?";
                Question5OptionALabel.Text = "a) Glandele sudoripare";
                Question5OptionBLabel.Text = "b) Glandele salivare";
                Question5OptionCLabel.Text = "c) Rinichii și glandele speciale de excreție";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a szerepe a kiválasztásnak az állati szervezetekben?";
                Question1OptionALabel.Text = "a) A belső egyensúly fenntartása és a hulladékok eltávolítása";
                Question1OptionBLabel.Text = "b) Energia termelés";
                Question1OptionCLabel.Text = "c) Szaporodás";

                Question2Label.Text = "2. Melyik a fő kiválasztó szerv a legtöbb gerincesnél?";
                Question2OptionALabel.Text = "a) Máj";
                Question2OptionBLabel.Text = "b) Tüdők";
                Question2OptionCLabel.Text = "c) Vesék";

                Question3Label.Text = "3. Milyen kiválasztó rendszert használnak a rovarok és puhatestűek?";
                Question3OptionALabel.Text = "a) Vesék";
                Question3OptionBLabel.Text = "b) Bélrendszer";
                Question3OptionCLabel.Text = "c) Malpighi-csövek";

                Question4Label.Text = "4. Hogyan alkalmazkodnak a sivatagi állatok a száraz környezethez a kiválasztás szempontjából?";
                Question4OptionALabel.Text = "a) Nagy mennyiségű vizelet ürítésével";
                Question4OptionBLabel.Text = "b) Koncentrált kiválasztó rendszer kifejlesztésével";
                Question4OptionCLabel.Text = "c) A bőrön keresztül történő vízfelesleg eltávolításával";

                Question5Label.Text = "5. Melyik specializált szerv segít a halaknak és cápáknak a hulladékok kiválasztásában a tengeri környezetben?";
                Question5OptionALabel.Text = "a) Izzadságmirigyek";
                Question5OptionBLabel.Text = "b) Nyálmirigyek";
                Question5OptionCLabel.Text = "c) Vesék és speciális kiválasztó mirigyek";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка роль екскреції в організмах тварин?";
                Question1OptionALabel.Text = "a) Підтримання внутрішньої рівноваги та видалення відходів";
                Question1OptionBLabel.Text = "b) Виробництво енергії";
                Question1OptionCLabel.Text = "c) Розмноження";

                Question2Label.Text = "2. Який один з основних екскреторних органів у більшості хребетних?";
                Question2OptionALabel.Text = "a) Печінка";
                Question2OptionBLabel.Text = "b) Легені";
                Question2OptionCLabel.Text = "c) Нирки";

                Question3Label.Text = "3. Яка екскреторна система використовується комахами і молюсками?";
                Question3OptionALabel.Text = "a) Нирки";
                Question3OptionBLabel.Text = "b) Кишечник";
                Question3OptionCLabel.Text = "c) Трубочки Мальпігі";

                Question4Label.Text = "4. Як тварини пустелі адаптуються до сухого середовища в плані екскреції?";
                Question4OptionALabel.Text = "a) Виведенням великої кількості сечі";
                Question4OptionBLabel.Text = "b) Розвитком концентрованої екскреторної системи";
                Question4OptionCLabel.Text = "c) Виведенням надлишку води через шкіру";

                Question5Label.Text = "5. Який спеціалізований орган допомагає рибам і акулам впоратися з екскрецією відходів у морському середовищі?";
                Question5OptionALabel.Text = "a) Потові залози";
                Question5OptionBLabel.Text = "b) Слинні залози";
                Question5OptionCLabel.Text = "c) Нирки та спеціальні екскреторні залози";
                break;
        }
    }


}