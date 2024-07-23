namespace BioBreeze.Teste;

public partial class GenCromozomii : ContentPage
{
	public GenCromozomii()
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
                TitleLabel.Text = "Test cromozomii";
                Question1Label.Text = "1. Care este principala funcție a cromozomilor în cadrul celulelor?";
                Question1OptionALabel.Text = "a) Transmiterea ereditară a informației genetice";
                Question1OptionBLabel.Text = "b) Producerea energiei celulare";
                Question1OptionCLabel.Text = "c) Controlul respirației celulare";
                Question1OptionDLabel.Text = "d) Absorbția substanțelor nutritive";

                Question2Label.Text = "2. Ce sunt autosomii?";
                Question2OptionALabel.Text = "a) Cromozomii care determină sexul organismului";
                Question2OptionBLabel.Text = "b) Cromozomii care nu determină sexul organismului";
                Question2OptionCLabel.Text = "c) Cromozomii prezenți doar în celulele sexuale";
                Question2OptionDLabel.Text = "d) Cromozomii care nu conțin material genetic";

                Question3Label.Text = "3. Care este diferența principală între mitoză și meioză?";
                Question3OptionALabel.Text = "a) Mitoza produce celule sexuale, iar meioza produce celule somatice.";
                Question3OptionBLabel.Text = "b) Mitoza produce două celule fiice identice, iar meioza produce patru celule fiice cu jumătate din numărul de cromozomi.";
                Question3OptionCLabel.Text = "c) Mitoza produce celule fiice cu jumătate din numărul de cromozomi, iar meioza produce două celule fiice identice.";
                Question3OptionDLabel.Text = "d) Mitoza produce două celule fiice cu dublul numărului de cromozomi, iar meioza produce două celule fiice identice.";

                Question4Label.Text = "4. Ce este recombinarea genetică?";
                Question4OptionALabel.Text = "a) Procesul de separare a cromozomilor omologi în timpul diviziunii celulare";
                Question4OptionBLabel.Text = "b) Procesul de schimb de segmente de ADN între cromozomi omologi";
                Question4OptionCLabel.Text = "c) Procesul de duplicare a cromozomilor în timpul diviziunii celulare";
                Question4OptionDLabel.Text = "d) Procesul de împachetare a cromozomilor în jurul proteinelor histonice";

                Question5Label.Text = "5. Care este una dintre tehniciile utilizate pentru analiza cromozomilor?";
                Question5OptionALabel.Text = "a) Electroforeza";
                Question5OptionBLabel.Text = "b) Citometria de flux";
                Question5OptionCLabel.Text = "c) Hibridizarea in situ";
                Question5OptionDLabel.Text = "d) Cromatografia";
                break;

            case "hu":
                TitleLabel.Text = "Kromoszómák teszt";
                Question1Label.Text = "1. Mi a kromoszómák fő funkciója a sejtekben?";
                Question1OptionALabel.Text = "a) A genetikai információ örökítése";
                Question1OptionBLabel.Text = "b) Sejten belüli energia előállítás";
                Question1OptionCLabel.Text = "c) Sejtlégzés szabályozása";
                Question1OptionDLabel.Text = "d) Tápláló anyagok felszívása";

                Question2Label.Text = "2. Mik azok az autoszómák?";
                Question2OptionALabel.Text = "a) A szervezet nemét meghatározó kromoszómák";
                Question2OptionBLabel.Text = "b) A szervezet nemét nem meghatározó kromoszómák";
                Question2OptionCLabel.Text = "c) Csak a szexuális sejtekben jelenlévő kromoszómák";
                Question2OptionDLabel.Text = "d) Genetikai anyagot nem tartalmazó kromoszómák";

                Question3Label.Text = "3. Mi a fő különbség a mitózis és a meiózis között?";
                Question3OptionALabel.Text = "a) A mitózis szexuális sejteket, a meiózis somatikus sejteket termel.";
                Question3OptionBLabel.Text = "b) A mitózis két azonos leánysejtet, míg a meiózis négy leánysejtet termel, amelyek feleannyi kromoszómát tartalmaznak.";
                Question3OptionCLabel.Text = "c) A mitózis feleannyi kromoszómájú leánysejteket, a meiózis két azonos leánysejtet termel.";
                Question3OptionDLabel.Text = "d) A mitózis két leánysejtet termel dupla kromoszómaszámmal, a meiózis pedig két azonos leánysejtet.";

                Question4Label.Text = "4. Mi a genetikai rekombináció?";
                Question4OptionALabel.Text = "a) A homológ kromoszómák szétválása a sejtosztódás során";
                Question4OptionBLabel.Text = "b) DNS-szegmensek cseréje homológ kromoszómák között";
                Question4OptionCLabel.Text = "c) Kromoszómák duplikációja a sejtosztódás során";
                Question4OptionDLabel.Text = "d) Kromoszómák csomagolása hisztonfehérjék körül";

                Question5Label.Text = "5. Melyik technika használatos a kromoszómák analíziséhez?";
                Question5OptionALabel.Text = "a) Elektroforézis";
                Question5OptionBLabel.Text = "b) Áramlási citometria";
                Question5OptionCLabel.Text = "c) Helyben hibridizáció";
                Question5OptionDLabel.Text = "d) Kromatográfia";
                break;

            case "uk":
                TitleLabel.Text = "Тест на хромосоми";
                Question1Label.Text = "1. Яка основна функція хромосом у клітинах?";
                Question1OptionALabel.Text = "a) Передача спадкової генетичної інформації";
                Question1OptionBLabel.Text = "b) Виробництво клітинної енергії";
                Question1OptionCLabel.Text = "c) Контроль клітинного дихання";
                Question1OptionDLabel.Text = "d) Всмоктування поживних речовин";

                Question2Label.Text = "2. Що таке аутосоми?";
                Question2OptionALabel.Text = "a) Хромосоми, які визначають стать організму";
                Question2OptionBLabel.Text = "b) Хромосоми, які не визначають стать організму";
                Question2OptionCLabel.Text = "c) Хромосоми, які присутні тільки в статевих клітинах";
                Question2OptionDLabel.Text = "d) Хромосоми, які не містять генетичний матеріал";

                Question3Label.Text = "3. Яка основна відмінність між мітозом та мейозом?";
                Question3OptionALabel.Text = "a) Мітоз виробляє статеві клітини, а мейоз – соматичні клітини.";
                Question3OptionBLabel.Text = "b) Мітоз виробляє дві ідентичні дочірні клітини, а мейоз – чотири дочірні клітини з половиною кількості хромосомів.";
                Question3OptionCLabel.Text = "c) Мітоз виробляє дочірні клітини з половиною кількості хромосомів, а мейоз – дві ідентичні дочірні клітини.";
                Question3OptionDLabel.Text = "d) Мітоз виробляє дві дочірні клітини з подвоєною кількістю хромосомів, а мейоз – дві ідентичні дочірні клітини.";

                Question4Label.Text = "4. Що таке генетична рекомбінація?";
                Question4OptionALabel.Text = "a) Процес розподілу гомологічних хромосом під час клітинного поділу";
                Question4OptionBLabel.Text = "b) Процес обміну сегментами ДНК між гомологічними хромосомами";
                Question4OptionCLabel.Text = "c) Процес подвоєння хромосом під час клітинного поділу";
                Question4OptionDLabel.Text = "d) Процес упаковки хромосом навколо гістонових білків";

                Question5Label.Text = "5. Яка з технік використовується для аналізу хромосом?";
                Question5OptionALabel.Text = "a) Електрофорез";
                Question5OptionBLabel.Text = "b) Цитометрія потоку";
                Question5OptionCLabel.Text = "c) Гібридизація in situ";
                Question5OptionDLabel.Text = "d) Хроматографія";
                break;

            default:
                
                ChangeLanguage("ro");
                break;
        }
    }

}