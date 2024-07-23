namespace BioBreeze.Teste;

public partial class ZooHAnimale : ContentPage
{
	public ZooHAnimale()
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

        if (Question3OptionA.IsChecked)
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
                Question1Label.Text = "1. Care sunt principiile generale ale hranirii animalelor?";
                Question1OptionALabel.Text = "a) Asigurarea unui aport adecvat de proteine, carbohidrați, grăsimi, vitamine și minerale";
                Question1OptionBLabel.Text = "b) Hranirea cu alimente procesate";
                Question1OptionCLabel.Text = "c) Folosirea exclusivă a hranei naturale";

                Question2Label.Text = "2. Ce reprezintă una dintre metodele de hrănire a animalelor domestice?";
                Question2OptionALabel.Text = "a) Hranirea naturală";
                Question2OptionBLabel.Text = "b) Vânătoarea";
                Question2OptionCLabel.Text = "c) Consumul de iarbă";

                Question3Label.Text = "3. Ce pot include suplimentele alimentare pentru animale?";
                Question3OptionALabel.Text = "a) Vitamine, minerale și alte substanțe nutritive esențiale";
                Question3OptionBLabel.Text = "b) Numai proteine";
                Question3OptionCLabel.Text = "c) Carbohidrați și grăsimi";

                Question4Label.Text = "4. Care este concluzia textului referitoare la hranirea animalelor?";
                Question4OptionALabel.Text = "a) Hranirea animalelor este un proces simplu și nu necesită atenție specială";
                Question4OptionBLabel.Text = "b) Este esențial să se înțeleagă nevoile individuale ale fiecărui animal și să se furnizeze o dietă echilibrată și adecvată";
                Question4OptionCLabel.Text = "c) Animalele nu necesită vitamine și minerale în dieta lor";

                Question5Label.Text = "5. Care este unul dintre tipurile de hrănire a animalelor domestice menționat în text?";
                Question5OptionALabel.Text = "a) Hranirea cu pradă";
                Question5OptionBLabel.Text = "b) Hranirea cu hrană procesată";
                Question5OptionCLabel.Text = "c) Hranirea cu hamei";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mik a főbb elvei az állatok táplálkozásának?";
                Question1OptionALabel.Text = "a) A megfelelő mennyiségű fehérje, szénhidrát, zsír, vitamin és ásványi anyag biztosítása";
                Question1OptionBLabel.Text = "b) Feldolgozott ételek fogyasztása";
                Question1OptionCLabel.Text = "c) Csak természetes táplálék használata";

                Question2Label.Text = "2. Mi az egyik módszer a háziállatok etetésére?";
                Question2OptionALabel.Text = "a) Természetes táplálkozás";
                Question2OptionBLabel.Text = "b) Vadászat";
                Question2OptionCLabel.Text = "c) Fűfogyasztás";

                Question3Label.Text = "3. Mit tartalmazhatnak az állati táplálékkiegészítők?";
                Question3OptionALabel.Text = "a) Vitaminok, ásványi anyagok és egyéb esszenciális tápanyagok";
                Question3OptionBLabel.Text = "b) Csak fehérjék";
                Question3OptionCLabel.Text = "c) Szénhidrátok és zsírok";

                Question4Label.Text = "4. Mi a szöveg következtetése az állatok etetésével kapcsolatban?";
                Question4OptionALabel.Text = "a) Az állatok etetése egyszerű folyamat, és nem igényel különös figyelmet";
                Question4OptionBLabel.Text = "b) Fontos megérteni minden állat egyedi szükségleteit, és kiegyensúlyozott, megfelelő étrendet biztosítani";
                Question4OptionCLabel.Text = "c) Az állatoknak nincs szükségük vitaminokra és ásványi anyagokra az étrendjükben";

                Question5Label.Text = "5. Mi az egyik háziállatok etetési típusa, amelyet a szöveg említ?";
                Question5OptionALabel.Text = "a) Ragadozó táplálkozás";
                Question5OptionBLabel.Text = "b) Feldolgozott táplálék fogyasztása";
                Question5OptionCLabel.Text = "c) Komlóval való etetés";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які загальні принципи годування тварин?";
                Question1OptionALabel.Text = "a) Забезпечення адекватного надходження білків, вуглеводів, жирів, вітамінів та мінералів";
                Question1OptionBLabel.Text = "b) Годування переробленою їжею";
                Question1OptionCLabel.Text = "c) Використання виключно натурального корму";

                Question2Label.Text = "2. Що є одним з методів годування домашніх тварин?";
                Question2OptionALabel.Text = "a) Природне годування";
                Question2OptionBLabel.Text = "b) Полювання";
                Question2OptionCLabel.Text = "c) Споживання трави";

                Question3Label.Text = "3. Що можуть включати харчові добавки для тварин?";
                Question3OptionALabel.Text = "a) Вітаміни, мінерали та інші необхідні поживні речовини";
                Question3OptionBLabel.Text = "b) Тільки білки";
                Question3OptionCLabel.Text = "c) Вуглеводи та жири";

                Question4Label.Text = "4. Який висновок тексту щодо годування тварин?";
                Question4OptionALabel.Text = "a) Годування тварин – це простий процес і не потребує особливої уваги";
                Question4OptionBLabel.Text = "b) Важливо розуміти індивідуальні потреби кожної тварини та забезпечити збалансовану і відповідну дієту";
                Question4OptionCLabel.Text = "c) Тварини не потребують вітамінів і мінералів у своєму раціоні";

                Question5Label.Text = "5. Який один з типів годування домашніх тварин згадується в тексті?";
                Question5OptionALabel.Text = "a) Годування здобиччю";
                Question5OptionBLabel.Text = "b) Годування переробленою їжею";
                Question5OptionCLabel.Text = "c) Годування хмелем";
                break;
        }
    }

}