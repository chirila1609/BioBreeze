namespace BioBreeze.Teste;

public partial class AnatomieUreche : ContentPage
{
	public AnatomieUreche()
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

        if (Question3OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
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
                TitleLabel.Text = "Test despre Urechea Umană";
                Question1Label.Text = "1. Ce parte a urechii umane colectează și direcționează sunetele către canalul auditiv extern?";
                Question1OptionALabel.Text = "a) Membrana timpanului";
                Question1OptionBLabel.Text = "b) Pavilionul urechii";
                Question1OptionCLabel.Text = "c) Trompa lui Eustachio";
                Question1OptionDLabel.Text = "d) Osiculele auditive";

                Question2Label.Text = "2. Care dintre următoarele este o structură subțire și flexibilă care vibrează în funcție de intensitatea sunetelor?";
                Question2OptionALabel.Text = "a) Trompa lui Eustachio";
                Question2OptionBLabel.Text = "b) Cochilia";
                Question2OptionCLabel.Text = "c) Membrana timpanului";
                Question2OptionDLabel.Text = "d) Osiculele auditive";

                Question3Label.Text = "3. Ce parte a urechii umane este responsabilă pentru convertirea vibrațiilor sonore în semnale nervoase pe care creierul le poate interpreta?";
                Question3OptionALabel.Text = "a) Cochilia";
                Question3OptionBLabel.Text = "b) Pavilionul urechii";
                Question3OptionCLabel.Text = "c) Trompa lui Eustachio";
                Question3OptionDLabel.Text = "d) Membrana timpanului";

                Question4Label.Text = "4. Care dintre următoarele componente ale urechii umane reglează echilibrul și poziția corpului?";
                Question4OptionALabel.Text = "a) Osiculele auditive";
                Question4OptionBLabel.Text = "b) Trompa lui Eustachio";
                Question4OptionCLabel.Text = "c) Vestibulul";
                Question4OptionDLabel.Text = "d) Cochilia";

                Question5Label.Text = "5. Ce rol are urechea umană în sistemul nostru de comunicare și orientare în lumea înconjurătoare?";
                Question5OptionALabel.Text = "a) Percepția și interpretarea sunetelor";
                Question5OptionBLabel.Text = "b) Reglarea temperaturii corpului";
                Question5OptionCLabel.Text = "c) Transmiterea semnalelor vizuale către creier";
                Question5OptionDLabel.Text = "d) Controlul respirației";
                break;

            case "hu":
                TitleLabel.Text = "Fül Teszt";
                Question1Label.Text = "1. Melyik része a humán fülnek gyűjti és irányítja a hangokat a külső hallójáratba?";
                Question1OptionALabel.Text = "a) Tympanikus membrán";
                Question1OptionBLabel.Text = "b) Fülkagyló";
                Question1OptionCLabel.Text = "c) Eustach-kürt";
                Question1OptionDLabel.Text = "d) Hallócsontocskák";

                Question2Label.Text = "2. Melyik következő struktúra vékony és rugalmas, és rezeg a hangok intenzitása szerint?";
                Question2OptionALabel.Text = "a) Eustach-kürt";
                Question2OptionBLabel.Text = "b) Csiga";
                Question2OptionCLabel.Text = "c) Tympanikus membrán";
                Question2OptionDLabel.Text = "d) Hallócsontocskák";

                Question3Label.Text = "3. Melyik része a humán fülnek felelős a hangrezgések idegjelekre történő átalakításáért, amelyet az agy értelmezni tud?";
                Question3OptionALabel.Text = "a) Csiga";
                Question3OptionBLabel.Text = "b) Fülkagyló";
                Question3OptionCLabel.Text = "c) Eustach-kürt";
                Question3OptionDLabel.Text = "d) Tympanikus membrán";

                Question4Label.Text = "4. Melyik következő fülkomponens szabályozza az egyensúlyt és a testhelyzetet?";
                Question4OptionALabel.Text = "a) Hallócsontocskák";
                Question4OptionBLabel.Text = "b) Eustach-kürt";
                Question4OptionCLabel.Text = "c) Vestibulum";
                Question4OptionDLabel.Text = "d) Csiga";

                Question5Label.Text = "5. Milyen szerepe van az emberi fülnek a kommunikációs és környezeti orientációs rendszerünkben?";
                Question5OptionALabel.Text = "a) Hangok észlelése és értelmezése";
                Question5OptionBLabel.Text = "b) Testhőmérséklet szabályozása";
                Question5OptionCLabel.Text = "c) Vizsgálati jelek továbbítása az agyba";
                Question5OptionDLabel.Text = "d) Légzés kontrollálása";
                break;

            case "uk":
                TitleLabel.Text = "Тест на вухо";
                Question1Label.Text = "1. Яка частина людського вуха збирає і направляє звуки до зовнішнього слухового каналу?";
                Question1OptionALabel.Text = "a) Барабанна перетинка";
                Question1OptionBLabel.Text = "b) Вушна раковина";
                Question1OptionCLabel.Text = "c) Євстахієва труба";
                Question1OptionDLabel.Text = "d) Слухові кісточки";

                Question2Label.Text = "2. Яка з наступних структур тонка та гнучка, і вібрує в залежності від інтенсивності звуків?";
                Question2OptionALabel.Text = "a) Євстахієва труба";
                Question2OptionBLabel.Text = "b) Улитка";
                Question2OptionCLabel.Text = "c) Барабанна перетинка";
                Question2OptionDLabel.Text = "d) Слухові кісточки";

                Question3Label.Text = "3. Яка частина людського вуха відповідає за перетворення звукових вібрацій на нервові сигнали, які мозок може інтерпретувати?";
                Question3OptionALabel.Text = "a) Улитка";
                Question3OptionBLabel.Text = "b) Вушна раковина";
                Question3OptionCLabel.Text = "c) Євстахієва труба";
                Question3OptionDLabel.Text = "d) Барабанна перетинка";

                Question4Label.Text = "4. Яка з наступних компонентів вуха регулює баланс і положення тіла?";
                Question4OptionALabel.Text = "a) Слухові кісточки";
                Question4OptionBLabel.Text = "b) Євстахієва труба";
                Question4OptionCLabel.Text = "c) Вестибулум";
                Question4OptionDLabel.Text = "d) Улитка";

                Question5Label.Text = "5. Яка роль людського вуха в нашій комунікаційній та орієнтаційній системі в навколишньому світі?";
                Question5OptionALabel.Text = "a) Сприйняття та інтерпретація звуків";
                Question5OptionBLabel.Text = "b) Регулювання температури тіла";
                Question5OptionCLabel.Text = "c) Передача візуальних сигналів до мозку";
                Question5OptionDLabel.Text = "d) Контроль дихання";
                break;
        }
    }

}