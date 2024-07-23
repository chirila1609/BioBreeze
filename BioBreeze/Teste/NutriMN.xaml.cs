namespace BioBreeze.Teste;

public partial class NutriMN : ContentPage
{
	public NutriMN()
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
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este definitia nutriției mixotrofe?";
                Question1OptionALabel.Text = "a) Obținerea hranei din mai multe surse";
                Question1OptionBLabel.Text = "b) Obținerea hranei doar prin fotosinteză";
                Question1OptionCLabel.Text = "c) Obținerea hranei numai din pradă";

                Question2Label.Text = "2. Care este un exemplu iconic de plantă carnivoră menționată în text?";
                Question2OptionALabel.Text = "a) Rosa canina (măceș)";
                Question2OptionBLabel.Text = "b) Nepenthes (planta gură-de-tun)";
                Question2OptionCLabel.Text = "c) Ficus (smochin)";

                Question3Label.Text = "3. Cum își atrag prada plantele carnivore, precum Drosera?";
                Question3OptionALabel.Text = "a) Cu flori colorate";
                Question3OptionBLabel.Text = "b) Cu frunze acoperite cu tentacule lipicioase";
                Question3OptionCLabel.Text = "c) Cu fructe zemoase";

                Question4Label.Text = "4. Ce funcție are enzima specifică în digestia prăzii la plantele carnivore?";
                Question4OptionALabel.Text = "a) De a atrage prada";
                Question4OptionBLabel.Text = "b) De a asigura fotosinteza";
                Question4OptionCLabel.Text = "c) De a descompune substanțele organice";

                Question5Label.Text = "5. Care este rolul fotosintezei în metabolismul plantelor carnivore?";
                Question5OptionALabel.Text = "a) Asigură o sursă suplimentară de energie și substanțe nutritive";
                Question5OptionBLabel.Text = "b) Este singura sursă de energie și substanțe nutritive";
                Question5OptionCLabel.Text = "c) Nu are niciun rol în metabolismul acestor plante";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a mixotróf táplálkozás definíciója?";
                Question1OptionALabel.Text = "a) Étel beszerzése több forrásból";
                Question1OptionBLabel.Text = "b) Étel beszerzése kizárólag fotoszintézissel";
                Question1OptionCLabel.Text = "c) Étel beszerzése kizárólag ragadozással";

                Question2Label.Text = "2. Mi az ikonikus húsevő növény példája, amely a szövegben szerepel?";
                Question2OptionALabel.Text = "a) Rosa canina (vadrózsa)";
                Question2OptionBLabel.Text = "b) Nepenthes (kanna növény)";
                Question2OptionCLabel.Text = "c) Ficus (füge)";

                Question3Label.Text = "3. Hogyan csalogatják el a ragadozót a húsevő növények, mint például a Drosera?";
                Question3OptionALabel.Text = "a) Színes virágokkal";
                Question3OptionBLabel.Text = "b) Ragadós mirigyekkel borított levelekkel";
                Question3OptionCLabel.Text = "c) Lédús gyümölcsökkel";

                Question4Label.Text = "4. Mi a szerepe az enzimának a húsevő növények preda emésztésében?";
                Question4OptionALabel.Text = "a) Az állatok csalogatása";
                Question4OptionBLabel.Text = "b) A fotoszintézis biztosítása";
                Question4OptionCLabel.Text = "c) Szerves anyagok lebontása";

                Question5Label.Text = "5. Mi a fotoszintézis szerepe a húsevő növények anyagcseréjében?";
                Question5OptionALabel.Text = "a) Kiegészítő energia és tápanyag forrást biztosít";
                Question5OptionBLabel.Text = "b) Az egyetlen energia és tápanyag forrás";
                Question5OptionCLabel.Text = "c) Nincs szerepe ezen növények anyagcseréjében";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Яке визначення гетеротрофного змішаного харчування?";
                Question1OptionALabel.Text = "a) Отримання їжі з кількох джерел";
                Question1OptionBLabel.Text = "b) Отримання їжі лише за допомогою фотосинтезу";
                Question1OptionCLabel.Text = "c) Отримання їжі лише з здобичі";

                Question2Label.Text = "2. Який іконічний приклад хижої рослини згадується в тексті?";
                Question2OptionALabel.Text = "a) Rosa canina (шипшина)";
                Question2OptionBLabel.Text = "b) Nepenthes (рослина з ротовим тунелем)";
                Question2OptionCLabel.Text = "c) Ficus (інжир)";

                Question3Label.Text = "3. Як хижі рослини, такі як Drosera, привертають свою здобич?";
                Question3OptionALabel.Text = "a) Яскравими квітами";
                Question3OptionBLabel.Text = "b) Листками, покритими липкими щупальцями";
                Question3OptionCLabel.Text = "c) Соковитими плодами";

                Question4Label.Text = "4. Яка роль специфічного ферменту в перетравленні здобичі у хижих рослин?";
                Question4OptionALabel.Text = "a) Привертає здобич";
                Question4OptionBLabel.Text = "b) Забезпечує фотосинтез";
                Question4OptionCLabel.Text = "c) Розщеплює органічні речовини";

                Question5Label.Text = "5. Яка роль фотосинтезу в метаболізмі хижих рослин?";
                Question5OptionALabel.Text = "a) Забезпечує додаткове джерело енергії та живильних речовин";
                Question5OptionBLabel.Text = "b) Є єдиним джерелом енергії та живильних речовин";
                Question5OptionCLabel.Text = "c) Не має жодної ролі в метаболізмі цих рослин";
                break;
        }
    }

}