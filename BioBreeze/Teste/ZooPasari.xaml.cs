namespace BioBreeze.Teste;

public partial class ZooPasari : ContentPage
{
	public ZooPasari()
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
                Question1Label.Text = "1. Care este una dintre adaptările remarcabile ale păsărilor pentru a se hrăni?";
                Question1OptionALabel.Text = "a) Gheare puternice";
                Question1OptionBLabel.Text = "b) Ciocuri variate";
                Question1OptionCLabel.Text = "c) Cozi lungi";

                Question2Label.Text = "2. Ce servește adesea la atragerea partenerilor sau la stabilirea teritoriului în rândul păsărilor?";
                Question2OptionALabel.Text = "a) Aripile colorate";
                Question2OptionBLabel.Text = "b) Ciocurile lungi";
                Question2OptionCLabel.Text = "c) Cântecele melodioase";

                Question3Label.Text = "3. Care este un aspect crucial al vieții multor păsări?";
                Question3OptionALabel.Text = "a) Hibernarea";
                Question3OptionBLabel.Text = "b) Migrarea";
                Question3OptionCLabel.Text = "c) Hibernarea și migrarea";

                Question4Label.Text = "4. Ce sistem al păsărilor le permite să zboare la înălțimi extreme?";
                Question4OptionALabel.Text = "a) Sistemul circulator";
                Question4OptionBLabel.Text = "b) Sistemul respirator";
                Question4OptionCLabel.Text = "c) Sistemul digestiv";

                Question5Label.Text = "5. Ce rol important au păsările în ecosisteme?";
                Question5OptionALabel.Text = "a) Controlul populațiilor de plante";
                Question5OptionBLabel.Text = "b) Controlul populațiilor de insecte și dispersia semințelor";
                Question5OptionCLabel.Text = "c) Protecția altor specii de animale";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Melyik az egyik figyelemre méltó alkalmazkodás a madarak táplálkozásához?";
                Question1OptionALabel.Text = "a) Erős karmok";
                Question1OptionBLabel.Text = "b) Változatos csőrök";
                Question1OptionCLabel.Text = "c) Hosszú farkak";

                Question2Label.Text = "2. Mi szolgál gyakran a madarak párzási partnerének vonzására vagy területük kijelölésére?";
                Question2OptionALabel.Text = "a) Színes szárnyak";
                Question2OptionBLabel.Text = "b) Hosszú csőrök";
                Question2OptionCLabel.Text = "c) Melódikus énekek";

                Question3Label.Text = "3. Mi egy fontos aspektus sok madár életében?";
                Question3OptionALabel.Text = "a) Téli álom";
                Question3OptionBLabel.Text = "b) Vándorlás";
                Question3OptionCLabel.Text = "c) Télin és vándorlás";

                Question4Label.Text = "4. Milyen rendszer teszi lehetővé a madarak számára, hogy extrém magasságokban repüljenek?";
                Question4OptionALabel.Text = "a) Keringési rendszer";
                Question4OptionBLabel.Text = "b) Légzőrendszer";
                Question4OptionCLabel.Text = "c) Emésztőrendszer";

                Question5Label.Text = "5. Mi a madarak fontos szerepe az ökoszisztémákban?";
                Question5OptionALabel.Text = "a) Növénypopulációk ellenőrzése";
                Question5OptionBLabel.Text = "b) Insect populációk ellenőrzése és magok szórása";
                Question5OptionCLabel.Text = "c) Más állatfajok védelme";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яка одна з помітних адаптацій птахів для харчування?";
                Question1OptionALabel.Text = "a) Сильні кігті";
                Question1OptionBLabel.Text = "b) Різноманітні дзьоби";
                Question1OptionCLabel.Text = "c) Довгі хвости";

                Question2Label.Text = "2. Що часто використовується птахами для приваблення партнерів або для встановлення території?";
                Question2OptionALabel.Text = "a) Яскраві крила";
                Question2OptionBLabel.Text = "b) Довгі дзьоби";
                Question2OptionCLabel.Text = "c) Мелодійні пісні";

                Question3Label.Text = "3. Який важливий аспект життя багатьох птахів?";
                Question3OptionALabel.Text = "a) Гібернація";
                Question3OptionBLabel.Text = "b) Міграція";
                Question3OptionCLabel.Text = "c) Гібернація і міграція";

                Question4Label.Text = "4. Яка система птахів дозволяє їм літати на екстремальних висотах?";
                Question4OptionALabel.Text = "a) Кровоносна система";
                Question4OptionBLabel.Text = "b) Дихальна система";
                Question4OptionCLabel.Text = "c) Травна система";

                Question5Label.Text = "5. Яка важлива роль птахів в екосистемах?";
                Question5OptionALabel.Text = "a) Контроль рослинних популяцій";
                Question5OptionBLabel.Text = "b) Контроль популяцій комах та розподіл насіння";
                Question5OptionCLabel.Text = "c) Захист інших видів тварин";
                break;
        }
    }

}