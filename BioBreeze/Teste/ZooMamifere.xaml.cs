namespace BioBreeze.Teste;

public partial class ZooMamifere : ContentPage
{
	public ZooMamifere()
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este o trăsătură distinctivă a mamiferelor?";
                Question1OptionALabel.Text = "a) Prezența solzilor";
                Question1OptionBLabel.Text = "b) Glande mamare care produc lapte";
                Question1OptionCLabel.Text = "c) Prezența aripilor";

                Question2Label.Text = "2. Care este o adaptare specifică a mamiferelor marine?";
                Question2OptionALabel.Text = "a) Blana densă";
                Question2OptionBLabel.Text = "b) Cozile prehensile";
                Question2OptionCLabel.Text = "c) Sistem respirator adaptat la mediul acvatic";

                Question3Label.Text = "3. Care este funcția părului sau a blănii la mamifere?";
                Question3OptionALabel.Text = "a) Protecție împotriva radiațiilor solare";
                Question3OptionBLabel.Text = "b) Termoreglare și protecție împotriva mediului înconjurător";
                Question3OptionCLabel.Text = "c) Absorbția nutrienților din mediu";

                Question4Label.Text = "4. Care mamifere demonstrează comportament social elaborat?";
                Question4OptionALabel.Text = "a) Liliecii";
                Question4OptionBLabel.Text = "b) Elefanții";
                Question4OptionCLabel.Text = "c) Tăușoarele";

                Question5Label.Text = "5. Care este importanța mamiferelor în ecosisteme?";
                Question5OptionALabel.Text = "a) Ele contribuie la poluarea mediului";
                Question5OptionBLabel.Text = "b) Ele sunt prădători de vârf în lanțurile trofice";
                Question5OptionCLabel.Text = "c) Ele ocupă roluri cheie în menținerea echilibrului și sănătății ecosistemelor";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a jellemző a emlősökre?";
                Question1OptionALabel.Text = "a) Tarlók jelenléte";
                Question1OptionBLabel.Text = "b) Tejet termelő emlőmirigyek";
                Question1OptionCLabel.Text = "c) Szárnyak jelenléte";

                Question2Label.Text = "2. Mi a tengeri emlősök egyik alkalmazkodása?";
                Question2OptionALabel.Text = "a) Sűrű szőr";
                Question2OptionBLabel.Text = "b) Fogó farok";
                Question2OptionCLabel.Text = "c) A légzőrendszer alkalmazkodása vízi környezethez";

                Question3Label.Text = "3. Mi a szőr vagy a bunda funkciója az emlősöknél?";
                Question3OptionALabel.Text = "a) Védelem a nap UV-sugarai ellen";
                Question3OptionBLabel.Text = "b) Hőszabályozás és védelem a környezettől";
                Question3OptionCLabel.Text = "c) Tápanyagok felszívása a környezetből";

                Question4Label.Text = "4. Mely emlősök mutatnak kiemelkedő társadalmi viselkedést?";
                Question4OptionALabel.Text = "a) Denevérek";
                Question4OptionBLabel.Text = "b) Elefántok";
                Question4OptionCLabel.Text = "c) Rovarok";

                Question5Label.Text = "5. Mi az emlősök szerepe az ökoszisztémákban?";
                Question5OptionALabel.Text = "a) Környezetszennyezést okoznak";
                Question5OptionBLabel.Text = "b) Csúcsragadozók az táplálékláncban";
                Question5OptionCLabel.Text = "c) Kulcsszerepet töltenek be az ökoszisztémák egyensúlyának és egészségének fenntartásában";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка характерна риса ссавців?";
                Question1OptionALabel.Text = "a) Наявність луски";
                Question1OptionBLabel.Text = "b) Молочні залози, що виробляють молоко";
                Question1OptionCLabel.Text = "c) Наявність крил";

                Question2Label.Text = "2. Яка особливість адаптації морських ссавців?";
                Question2OptionALabel.Text = "a) Щільне хутро";
                Question2OptionBLabel.Text = "b) Хватальні хвости";
                Question2OptionCLabel.Text = "c) Дихальна система, адаптована до водного середовища";

                Question3Label.Text = "3. Яка функція шерсті або хутра у ссавців?";
                Question3OptionALabel.Text = "a) Захист від сонячного випромінювання";
                Question3OptionBLabel.Text = "b) Терморегуляція і захист від навколишнього середовища";
                Question3OptionCLabel.Text = "c) Абсорбція поживних речовин з навколишнього середовища";

                Question4Label.Text = "4. Які ссавці демонструють складну соціальну поведінку?";
                Question4OptionALabel.Text = "a) Летючі миші";
                Question4OptionBLabel.Text = "b) Слони";
                Question4OptionCLabel.Text = "c) Слоновики";

                Question5Label.Text = "5. Яка роль ссавців в екосистемах?";
                Question5OptionALabel.Text = "a) Вони сприяють забрудненню середовища";
                Question5OptionBLabel.Text = "b) Вони є верхівковими хижаками в трофічних ланцюгах";
                Question5OptionCLabel.Text = "c) Вони відіграють ключову роль у підтримці балансу і здоров’я екосистем";
                break;
        }
    }

}