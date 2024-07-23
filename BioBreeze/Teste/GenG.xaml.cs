namespace BioBreeze.Teste;

public partial class GenG : ContentPage
{
	public GenG()
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

        if (Question3OptionB.IsChecked)
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
                Question1Label.Text = "1. Care este unitatea fundamentală a eredității responsabilă pentru transmiterea trăsăturilor de la părinți la urmași?";
                Question1OptionALabel.Text = "a) Cromozomii";
                Question1OptionBLabel.Text = "b) Genele";
                Question1OptionCLabel.Text = "c) Celulele";
                Question1OptionDLabel.Text = "d) Proteinele";

                Question2Label.Text = "2. Ce sunt exoni și introni în structura genelor?";
                Question2OptionALabel.Text = "a) Exoni sunt secvențe non-coding, iar intronii sunt secvențe de ADN care sunt transcrise în proteine.";
                Question2OptionBLabel.Text = "b) Exoni sunt secvențe de ADN care sunt transcrise în proteine, iar intronii sunt secvențe non-coding.";
                Question2OptionCLabel.Text = "c) Exoni sunt secvențe de ARN care sunt transcrise în proteine, iar intronii sunt secvențe non-coding.";
                Question2OptionDLabel.Text = "d) Exoni și intronii sunt același lucru.";

                Question3Label.Text = "3. Cum se realizează moștenirea genetică?";
                Question3OptionALabel.Text = "a) Prin transmiterea genelor de la un singur părinte către descendenți.";
                Question3OptionBLabel.Text = "b) Prin transmiterea genelor de la părinți la descendenți prin intermediul gametelor în timpul reproducerii sexuate.";
                Question3OptionCLabel.Text = "c) Prin transmiterea genelor de la descendenți către părinți.";
                Question3OptionDLabel.Text = "d) Prin transmiterea genelor prin intermediul alimentației.";

                Question4Label.Text = "4. Ce reprezintă mutațiile genetice?";
                Question4OptionALabel.Text = "a) Modificări în secvența de ARN.";
                Question4OptionBLabel.Text = "b) Modificări în structura proteinelor.";
                Question4OptionCLabel.Text = "c) Modificări în secvența de ADN care pot apărea spontan sau ca rezultat al factorilor externi.";
                Question4OptionDLabel.Text = "d) Modificări în metabolismul celular.";

                Question5Label.Text = "5. Care este impactul geneticii în medicină și biotehnologie?";
                Question5OptionALabel.Text = "a) Genetica nu are niciun impact în medicină sau biotehnologie.";
                Question5OptionBLabel.Text = "b) Studiul geneticii este crucial pentru înțelegerea bolilor genetice și pentru dezvoltarea unor tratamente personalizate și terapii genice.";
                Question5OptionCLabel.Text = "c) Genetica are impact doar în agricultură, dar nu în medicină.";
                Question5OptionDLabel.Text = "d) Biotehnologia nu folosește cunoștințele din domeniul genetic.";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi az öröklődés alapvető egysége, amely felelős a tulajdonságok szülőkről utódokra történő átviteléért?";
                Question1OptionALabel.Text = "a) Kromoszómák";
                Question1OptionBLabel.Text = "b) Gének";
                Question1OptionCLabel.Text = "c) Sejtek";
                Question1OptionDLabel.Text = "d) Fehérjék";

                Question2Label.Text = "2. Mik az exonok és az intronok a gének szerkezetében?";
                Question2OptionALabel.Text = "a) Az exonok nem kódoló szekvenciák, míg az intronok olyan DNS szekvenciák, amelyek fehérjékké transzkripálódnak.";
                Question2OptionBLabel.Text = "b) Az exonok olyan DNS szekvenciák, amelyek fehérjékké transzkripálódnak, míg az intronok nem kódoló szekvenciák.";
                Question2OptionCLabel.Text = "c) Az exonok olyan RNS szekvenciák, amelyek fehérjékké transzkripálódnak, míg az intronok nem kódoló szekvenciák.";
                Question2OptionDLabel.Text = "d) Az exonok és intronok ugyanazt jelentik.";

                Question3Label.Text = "3. Hogyan történik a genetikai öröklés?";
                Question3OptionALabel.Text = "a) A gének egyetlen szülőtől az utódokhoz történő átadása révén.";
                Question3OptionBLabel.Text = "b) A gének szülőktől az utódokhoz történő átadása révén a szexuális reprodukció során.";
                Question3OptionCLabel.Text = "c) A gének utódoktól a szülőkig történő átadása révén.";
                Question3OptionDLabel.Text = "d) A gének táplálkozás útján történő átadása révén.";

                Question4Label.Text = "4. Mit jelentenek a genetikai mutációk?";
                Question4OptionALabel.Text = "a) Változások az RNS szekvenciájában.";
                Question4OptionBLabel.Text = "b) Változások a fehérjék szerkezetében.";
                Question4OptionCLabel.Text = "c) Változások a DNS szekvenciájában, amelyek spontán vagy külső tényezők hatására léphetnek fel.";
                Question4OptionDLabel.Text = "d) Változások a sejtek anyagcseréjében.";

                Question5Label.Text = "5. Mi a genetika hatása az orvostudományra és a biotechnológiára?";
                Question5OptionALabel.Text = "a) A genetikának nincs hatása az orvostudományra vagy a biotechnológiára.";
                Question5OptionBLabel.Text = "b) A genetika tanulmányozása kulcsfontosságú a genetikai betegségek megértéséhez és személyre szabott kezelések és génterápiák kidolgozásához.";
                Question5OptionCLabel.Text = "c) A genetikának csak a mezőgazdaságra van hatása, de az orvostudományra nincs.";
                Question5OptionDLabel.Text = "d) A biotechnológia nem használja a genetikai ismereteket.";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Що є основною одиницею спадковості, відповідальною за передачу ознак від батьків до нащадків?";
                Question1OptionALabel.Text = "a) Хромосоми";
                Question1OptionBLabel.Text = "b) Гени";
                Question1OptionCLabel.Text = "c) Клітини";
                Question1OptionDLabel.Text = "d) Білки";

                Question2Label.Text = "2. Що таке екзони і інтрони у структурі генів?";
                Question2OptionALabel.Text = "a) Екзони є некодуючими послідовностями, а інтрони - це послідовності ДНК, які транскрибуються у білки.";
                Question2OptionBLabel.Text = "b) Екзони є послідовностями ДНК, які транскрибуються у білки, а інтрони - некодуючими послідовностями.";
                Question2OptionCLabel.Text = "c) Екзони є послідовностями РНК, які транскрибуються у білки, а інтрони - некодуючими послідовностями.";
                Question2OptionDLabel.Text = "d) Екзони і інтрони - це одне і те ж.";

                Question3Label.Text = "3. Як здійснюється генетична спадковість?";
                Question3OptionALabel.Text = "a) Через передачу генів від одного батька до нащадків.";
                Question3OptionBLabel.Text = "b) Через передачу генів від батьків до нащадків за допомогою гамет під час статевого розмноження.";
                Question3OptionCLabel.Text = "c) Через передачу генів від нащадків до батьків.";
                Question3OptionDLabel.Text = "d) Через передачу генів за допомогою харчування.";

                Question4Label.Text = "4. Що таке генетичні мутації?";
                Question4OptionALabel.Text = "a) Зміни у послідовності РНК.";
                Question4OptionBLabel.Text = "b) Зміни у структурі білків.";
                Question4OptionCLabel.Text = "c) Зміни у послідовності ДНК, які можуть виникати спонтанно або в результаті зовнішніх факторів.";
                Question4OptionDLabel.Text = "d) Зміни у клітинному метаболізмі.";

                Question5Label.Text = "5. Який вплив має генетика на медицину та біотехнології?";
                Question5OptionALabel.Text = "a) Генетика не має впливу на медицину чи біотехнології.";
                Question5OptionBLabel.Text = "b) Вивчення генетики є вирішальним для розуміння генетичних захворювань і для розробки персоналізованих лікувань і генних терапій.";
                Question5OptionCLabel.Text = "c) Генетика має вплив тільки на сільське господарство, але не на медицину.";
                Question5OptionDLabel.Text = "d) Біотехнологія не використовує знання генетики.";
                break;

            default:
                break;
        }
    }

}