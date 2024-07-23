namespace BioBreeze.Teste;

public partial class NutriHSN : ContentPage
{
	public NutriHSN()
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este principala sursă de hrană pentru organismele care practică nutriția heterotrofă saprofită?";
                Question1OptionALabel.Text = "a) Materiale organice în descompunere";
                Question1OptionBLabel.Text = "b) Soarele";
                Question1OptionCLabel.Text = "c) Apa curată";
                Question1OptionDLabel.Text = "d) Substanțe minerale din sol";

                Question2Label.Text = "2. Ce rol joacă organismele saprofite în ecosistemele naturale?";
                Question2OptionALabel.Text = "a) Ele produc oxigen";
                Question2OptionBLabel.Text = "b) Ele reciclează materialele organice moarte sau în descompunere";
                Question2OptionCLabel.Text = "c) Ele produc hrană pentru alte organisme";
                Question2OptionDLabel.Text = "d) Ele sunt prădătoare";

                Question3Label.Text = "3. Care dintre următoarele grupuri de organisme sunt exemple de saprofite?";
                Question3OptionALabel.Text = "a) Rechini și delfini";
                Question3OptionBLabel.Text = "b) Ciuperci și bacterii";
                Question3OptionCLabel.Text = "c) Alge marine și corali";
                Question3OptionDLabel.Text = "d) Lupi și vulpi";

                Question4Label.Text = "4. Ce fac enzimele secretate de organismele saprofite în procesul de nutriție heterotrofă saprofită?";
                Question4OptionALabel.Text = "a) Produc energie solară";
                Question4OptionBLabel.Text = "b) Descompun materialele organice în componente mai simple";
                Question4OptionCLabel.Text = "c) Protejează organismele împotriva prădătorilor";
                Question4OptionDLabel.Text = "d) Îndeplinesc funcții de reproducere";

                Question5Label.Text = "5. De ce sunt esențiale organismele saprofite în ecosistemele naturale?";
                Question5OptionALabel.Text = "a) Ele mențin echilibrul ecologic";
                Question5OptionBLabel.Text = "b) Ele sunt precursoare ale vieții";
                Question5OptionCLabel.Text = "c) Ele sunt prădătoare";
                Question5OptionDLabel.Text = "d) Ele produc hrană pentru plante";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a fő táplálékforrás az heterotróf szaprofitákat tápláló szervezetek számára?";
                Question1OptionALabel.Text = "a) Lebomló szerves anyagok";
                Question1OptionBLabel.Text = "b) Napfény";
                Question1OptionCLabel.Text = "c) Tiszta víz";
                Question1OptionDLabel.Text = "d) Talaj ásványi anyagok";

                Question2Label.Text = "2. Milyen szerepet játszanak a szaprofiták a természetes ökoszisztémákban?";
                Question2OptionALabel.Text = "a) Oxigént termelnek";
                Question2OptionBLabel.Text = "b) Lebomló vagy elhalt szerves anyagokat hasznosítanak";
                Question2OptionCLabel.Text = "c) Táplálékot termelnek más szervezetek számára";
                Question2OptionDLabel.Text = "d) Ragadozók";

                Question3Label.Text = "3. Melyik csoportok a szaprofiták példái?";
                Question3OptionALabel.Text = "a) Cápák és delfinek";
                Question3OptionBLabel.Text = "b) Gombák és baktériumok";
                Question3OptionCLabel.Text = "c) Tengeri algák és korallok";
                Question3OptionDLabel.Text = "d) Farkasok és rókák";

                Question4Label.Text = "4. Mit csinálnak a szaprofiták által kiválasztott enzimek a heterotróf szaprofit táplálkozás során?";
                Question4OptionALabel.Text = "a) Napenergiát termelnek";
                Question4OptionBLabel.Text = "b) Lebomló szerves anyagokat egyszerűbb komponensekre bontanak";
                Question4OptionCLabel.Text = "c) Megvédik a szervezeteket a ragadozóktól";
                Question4OptionDLabel.Text = "d) Reprodukciós funkciókat látnak el";

                Question5Label.Text = "5. Miért fontosak a szaprofiták a természetes ökoszisztémákban?";
                Question5OptionALabel.Text = "a) Fenntartják az ökológiai egyensúlyt";
                Question5OptionBLabel.Text = "b) Az élet előfutárai";
                Question5OptionCLabel.Text = "c) Ragadozók";
                Question5OptionDLabel.Text = "d) Táplálékot termelnek a növények számára";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яке основне джерело їжі для організмів, які практикують гетеротрофне сапрофітне харчування?";
                Question1OptionALabel.Text = "a) Розкладені органічні матеріали";
                Question1OptionBLabel.Text = "b) Сонце";
                Question1OptionCLabel.Text = "c) Чиста вода";
                Question1OptionDLabel.Text = "d) Мінеральні речовини з ґрунту";

                Question2Label.Text = "2. Яку роль відіграють сапрофіти в природних екосистемах?";
                Question2OptionALabel.Text = "a) Вони виробляють кисень";
                Question2OptionBLabel.Text = "b) Вони переробляють мертві або розкладені органічні матеріали";
                Question2OptionCLabel.Text = "c) Вони виробляють їжу для інших організмів";
                Question2OptionDLabel.Text = "d) Вони є хижаками";

                Question3Label.Text = "3. Які з наступних груп організмів є прикладами сапрофітів?";
                Question3OptionALabel.Text = "a) Акули та дельфіни";
                Question3OptionBLabel.Text = "b) Гриби та бактерії";
                Question3OptionCLabel.Text = "c) Морські водорості та корали";
                Question3OptionDLabel.Text = "d) Вовки та лисиці";

                Question4Label.Text = "4. Що роблять ферменти, які виділяються сапрофітами, в процесі гетеротрофного сапрофітного харчування?";
                Question4OptionALabel.Text = "a) Виробляють сонячну енергію";
                Question4OptionBLabel.Text = "b) Розкладають органічні матеріали на простіші компоненти";
                Question4OptionCLabel.Text = "c) Захищають організми від хижаків";
                Question4OptionDLabel.Text = "d) Виконують функції розмноження";

                Question5Label.Text = "5. Чому сапрофіти важливі для природних екосистем?";
                Question5OptionALabel.Text = "a) Вони підтримують екологічну рівновагу";
                Question5OptionBLabel.Text = "b) Вони є попередниками життя";
                Question5OptionCLabel.Text = "c) Вони є хижаками";
                Question5OptionDLabel.Text = "d) Вони виробляють їжу для рослин";
                break;
        }
    }

}