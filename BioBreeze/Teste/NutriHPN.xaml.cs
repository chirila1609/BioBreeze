namespace BioBreeze.Teste;

public partial class NutriHPN : ContentPage
{
	public NutriHPN()
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

        if (Question3OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
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
                Question1Label.Text = "1. Ce este nutriția heterotrofă parazitară?";
                Question1OptionALabel.Text = "a) Un mod de nutriție în care organisme consumă&#x0a; materie organică produsă de alte organisme vii.";
                Question1OptionBLabel.Text = "b) Un mod de nutriție în care organisme produc &#x0a;propriile lor substanțe nutritive.";
                Question1OptionCLabel.Text = "c) Un mod de nutriție în care organismele se hrănesc &#x0a;exclusiv cu plante.";

                Question2Label.Text = "2. Cum se conectează unele plante parazite la gazdele lor?";
                Question2OptionALabel.Text = "a) Prin utilizarea unor organe speciale de prindere.";
                Question2OptionBLabel.Text = "b) Prin atașarea de rădăcinile gazdelor lor.";
                Question2OptionCLabel.Text = "c) Prin intermediul frunzelor.";

                Question3Label.Text = "3. Ce implică coevoluția în relația parazitară?";
                Question3OptionALabel.Text = "a) Dezvoltarea unei rezistențe reciproce între paraziți &#x0a;și gazdele lor.";
                Question3OptionBLabel.Text = "b) Îngrijirea reciprocă între paraziți și gazdele lor.";
                Question3OptionCLabel.Text = "c) O relație pasivă între paraziți și gazdele lor.";

                Question4Label.Text = "4. Care dintre următoarele nu este un exemplu de organism cu nutriție heterotrofă parazitară menționat în text?";
                Question4OptionALabel.Text = "a) Protozoare.";
                Question4OptionBLabel.Text = "b) Plante parazite precum ciupercile din genul &#x0a;Orobanche.";
                Question4OptionCLabel.Text = "c) Plante cu fotosinteză activă.";

                Question5Label.Text = "5. Care este unul dintre aspectele importante ale nutriției heterotrofe parazitare?";
                Question5OptionALabel.Text = "a) Capacitatea de a produce propriile substanțe &#x0a;nutritive.";
                Question5OptionBLabel.Text = "b) Capacitatea de a manipula gazdele pentru a-și &#x0a;maximiza succesul reproductiv.";
                Question5OptionCLabel.Text = "c) Capacitatea de a se conecta la surse alternative de &#x0a;hrană.";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a parazita heterotróf táplálkozás?";
                Question1OptionALabel.Text = "a) Az a táplálkozási mód, ahol az organizmusok más &#x0a;élő szervezetek által előállított szerves anyagot fogyasztanak.";
                Question1OptionBLabel.Text = "b) Az a táplálkozási mód, ahol az organizmusok saját &#x0a;tápanyagaikat állítják elő.";
                Question1OptionCLabel.Text = "c) Az a táplálkozási mód, ahol az organizmusok kizárólag növényekkel táplálkoznak.";

                Question2Label.Text = "2. Hogyan kapcsolódnak össze egyes parazita növények a gazdáikkal?";
                Question2OptionALabel.Text = "a) Speciális rögzítő szervek használatával.";
                Question2OptionBLabel.Text = "b) A gazda gyökereire való rátapadással.";
                Question2OptionCLabel.Text = "c) A leveleken keresztül.";

                Question3Label.Text = "3. Mit jelent a koevolúció a parazita kapcsolatban?";
                Question3OptionALabel.Text = "a) A kölcsönös ellenállás fejlődését a paraziták és a gazdáik között.";
                Question3OptionBLabel.Text = "b) A kölcsönös gondozás a paraziták és gazdáik között.";
                Question3OptionCLabel.Text = "c) Passzív kapcsolat a paraziták és gazdáik között.";

                Question4Label.Text = "4. Melyik nem példa a heterotróf parazita táplálkozásra az itt említett organizmusok közül?";
                Question4OptionALabel.Text = "a) Protozoák.";
                Question4OptionBLabel.Text = "b) Parazita növények, mint például Orobanche nemzetségű gombák.";
                Question4OptionCLabel.Text = "c) Fotoszintetikus növények.";

                Question5Label.Text = "5. Mi az egyik fontos aspektusa a heterotróf parazita táplálkozásnak?";
                Question5OptionALabel.Text = "a) A saját tápanyagok előállításának képessége.";
                Question5OptionBLabel.Text = "b) A gazdák manipulálásának képessége a szaporodási siker maximalizálása érdekében.";
                Question5OptionCLabel.Text = "c) Az alternatív táplálékforrásokhoz való csatlakozás képessége.";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Що таке паразитарне гетеротрофне живлення?";
                Question1OptionALabel.Text = "a) Спосіб живлення, при якому організми споживають &#x0a;органічну речовину, вироблену іншими живими організмами.";
                Question1OptionBLabel.Text = "b) Спосіб живлення, при якому організми виробляють &#x0a;свої власні поживні речовини.";
                Question1OptionCLabel.Text = "c) Спосіб живлення, при якому організми живляться &#x0a;виключно рослинами.";

                Question2Label.Text = "2. Як деякі паразитичні рослини з’єднуються зі своїми господарями?";
                Question2OptionALabel.Text = "a) Використовуючи спеціальні органи для захоплення.";
                Question2OptionBLabel.Text = "b) Прикріплюючись до коренів своїх господарів.";
                Question2OptionCLabel.Text = "c) Через листя.";

                Question3Label.Text = "3. Що таке коеволюція у паразитарних відносинах?";
                Question3OptionALabel.Text = "a) Розвиток взаємної стійкості між паразитами та їх господарями.";
                Question3OptionBLabel.Text = "b) Взаємний догляд між паразитами та їх господарями.";
                Question3OptionCLabel.Text = "c) Пасивні стосунки між паразитами та їх господарями.";

                Question4Label.Text = "4. Який з наведених прикладів не є організмом з паразитарним гетеротрофним живленням, згаданим у тексті?";
                Question4OptionALabel.Text = "a) Протозої.";
                Question4OptionBLabel.Text = "b) Паразитичні рослини, такі як гриби роду Orobanche.";
                Question4OptionCLabel.Text = "c) Рослини з активною фотосинтезою.";

                Question5Label.Text = "5. Який з важливих аспектів паразитарного гетеротрофного живлення?";
                Question5OptionALabel.Text = "a) Здатність виробляти власні поживні речовини.";
                Question5OptionBLabel.Text = "b) Здатність маніпулювати господарями для максимізації репродуктивного успіху.";
                Question5OptionCLabel.Text = "c) Здатність підключатися до альтернативних джерел їжі.";
                break;
        }
    }

}