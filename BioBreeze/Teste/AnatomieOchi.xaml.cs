namespace BioBreeze.Teste;

public partial class AnatomieOchi : ContentPage
{
	public AnatomieOchi()
	{
		InitializeComponent();
	}
    void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        string feedback = "";

        
        if (Question1OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 1 este incorectă.\n";

        if (Question2OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 4 este incorectă.\n";

        if (Question5OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 5 este incorectă.\n";

        if (Question6OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 6 este incorectă.\n";

        if (Question7OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 7 este incorectă.\n";

        if (Question8OptionD.IsChecked)
            score++;
        else
            feedback += "Întrebarea 8 este incorectă.\n";

        if (Question9OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 9 este incorectă.\n";

        if (Question10OptionB.IsChecked)
            score++;
        else
            feedback += "Întrebarea 10 este incorectă.\n";

        if (score == 10)
            GlobalVariables.TestsPassed++;

        
        ScoreLabel.Text = $"Scorul tău este: {score} din 10\n" + feedback;
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
            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mi a szaruhártya egyik fő funkciója?";
                Question1OptionALabel.Text = "a) Tanulóméret-vezérlő";
                Question1OptionBLabel.Text = "b) Vizuális jelek továbbítása az agyba";
                Question1OptionCLabel.Text = "c) Írisz- és pupillafedettség";
                Question1OptionDLabel.Text = "d) Fény átalakítása elektromos jelekké";
                Question2Label.Text = "Mi történik a tüdő alveolusaiban?";
                Question2OptionALabel.Text = "a) A fény feldolgozva";
                Question2OptionBLabel.Text = "b) Gyors gázcsere érhető el a levegő és a vér között";
                Question2OptionCLabel.Text = "c) A lencse kialakul";
                Question2OptionDLabel.Text = "d) Elektromos jelek keletkeznek";
                Question3Label.Text = "A szem mely része segíti a fényt a retinára fókuszálni?";
                Question3OptionALabel.Text = "a) Az írisz";
                Question3OptionBLabel.Text = "b) Tanuló";
                Question3OptionCLabel.Text = "c) Retina";
                Question3OptionDLabel.Text = "d) Kristályos";
                Question4Label.Text = "4. Az alábbiak közül melyik igaz a látóidegre?";
                Question4OptionALabel.Text = "a) Szabályozza a pupilla méretét";
                Question4OptionBLabel.Text = "b) Az írisz eltakarásáért felelős";
                Question4OptionCLabel.Text = "c) Vizuális jeleket továbbít a retinából az agyba";
                Question4OptionDLabel.Text = "d) Segít átalakítani a fényt elektromos jelekké";
                Question5Label.Text = "5. Mi a tüdő egyik fő funkciója?";
                Question5OptionALabel.Text = "a) Testhőmérséklet-szabályozás";
                Question5OptionBLabel.Text = "b) Élelmiszer-emésztés";
                Question5OptionCLabel.Text = "c) Légzés";
                Question5OptionDLabel.Text = "d) Méreganyagok eltávolítása a vérből";
                Question6Label.Text = "6. A szem mely része szabályozza a pupilla méretét, hogy szabályozza a bejutó fény mennyiségét?";
                Question6OptionALabel.Text = "a) Szaruhártya";
                Question6OptionBLabel.Text = "b) Az írisz";
                Question6OptionCLabel.Text = "c) Retina";
                Question6OptionDLabel.Text = "d) Kristályos";
                Question7Label.Text = "7. Mi a szerepe a tüdő alveolusai körüli vérkapillárisoknak?";
                Question7OptionALabel.Text = "a) Eltávolítja a szén-dioxidot";
                Question7OptionBLabel.Text = "b) Megkönnyíti a levegő és a vér közötti gyors gázcserét";
                Question7OptionCLabel.Text = "c) Véd a fertőzések ellen";
                Question7OptionDLabel.Text = "d) Elektromos jelek előállítása";
                Question8Label.Text = "8. A szem mely része alakítja át a fényt elektromos jelekké, és továbbítja azokat az agynak?";
                Question8OptionALabel.Text = "a) Szaruhártya";
                Question8OptionBLabel.Text = "b) Az írisz";
                Question8OptionCLabel.Text = "c) Tanuló";
                Question8OptionDLabel.Text = "d) Retina";
                Question9Label.Text = "9. Mi az objektív egyik fő funkciója?";
                Question9OptionALabel.Text = "a) Vizuális jelek továbbítása az agyba";
                Question9OptionBLabel.Text = "b) Írisz- és pupillafedettség";
                Question9OptionCLabel.Text = "c) Segít a fényt a retinára összpontosítani";
                Question9OptionDLabel.Text = "d) Tanulóméret-vezérlő";
                Question10Label.Text = "10. A szem melyik része felelős az írisz és a pupilla eltakarásáért?";
                Question10OptionALabel.Text = "a) Cornea";
                Question10OptionBLabel.Text = "b) Az írisz";
                Question10OptionCLabel.Text = "c) Tanuló";
                Question10OptionDLabel.Text = "d) Retina";
                break;

            case "ro":
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Care este una dintre funcțiile principale ale corneei?\"";
                Question1OptionALabel.Text = "a) Controlul dimensiunii pupilei";
                Question1OptionBLabel.Text = "b) Transmiterea semnalelor vizuale către creier";
                Question1OptionCLabel.Text = "c) Acoperirea irisului și a pupilei";
                Question1OptionDLabel.Text = "d) Conversia luminii în semnale electrice";
                Question2Label.Text = "2. Ce se întâmplă în alveolele plămânilor?";
                Question2OptionALabel.Text = "a) Este procesată lumina";
                Question2OptionBLabel.Text = "b) Se realizează schimbul rapid de gaze între aer și sânge";
                Question2OptionCLabel.Text = "c) Se formează cristalinul";
                Question2OptionDLabel.Text = "d) Se produc semnale electrice";
                Question3Label.Text = "3. Ce parte a ochiului ajută la focalizarea luminii pe retina?";
                Question3OptionALabel.Text = "a) Irisul";
                Question3OptionBLabel.Text = "b) Pupila";
                Question3OptionCLabel.Text = "c) Retina";
                Question3OptionDLabel.Text = "d) Cristalinul";
                Question4Label.Text = "4. Care dintre următoarele este adevărat despre nervul optic?";
                Question4OptionALabel.Text = "a) Controlează dimensiunea pupilei";
                Question4OptionBLabel.Text = "b) Este responsabil pentru acoperirea irisului";
                Question4OptionCLabel.Text = "c) Transmite semnalele vizuale de la retina la creier";
                Question4OptionDLabel.Text = "d) Ajută la conversia luminii în semnale electrice";
                Question5Label.Text = "5. Care este una dintre funcțiile principale ale plămânilor?";
                Question5OptionALabel.Text = "a) Controlul temperaturii corpului";
                Question5OptionBLabel.Text = "b) Digestia alimentelor";
                Question5OptionCLabel.Text = "c) Respirația";
                Question5OptionDLabel.Text = "d) Eliminarea toxinelor din sânge";
                Question6Label.Text = "6. Ce parte a ochiului reglează dimensiunea pupilei pentru a controla cantitatea de lumină care intră?";
                Question6OptionALabel.Text = "a) Corneea";
                Question6OptionBLabel.Text = "b) Irisul";
                Question6OptionCLabel.Text = "c) Retina";
                Question6OptionDLabel.Text = "d) Cristalinul";
                Question7Label.Text = "7. Care este rolul capilarelor sanguine în jurul alveolelor plămânilor?";
                Question7OptionALabel.Text = "a) Elimină dioxidul de carbon";
                Question7OptionBLabel.Text = "b) Facilitează schimbul rapid de gaze între aer și sânge";
                Question7OptionCLabel.Text = "c) Protejează împotriva infecțiilor";
                Question7OptionDLabel.Text = "d) Produc semnale electrice";
                Question8Label.Text = "8. Ce parte a ochiului convertește lumina în semnale electrice și le transmite către creier?";
                Question8OptionALabel.Text = "a) Corneea";
                Question8OptionBLabel.Text = "b) Irisul";
                Question8OptionCLabel.Text = "c) Pupila";
                Question8OptionDLabel.Text = "d) Retina";
                Question9Label.Text = "9. Care este una dintre funcțiile principale ale cristalinului?";
                Question9OptionALabel.Text = "a) Transmiterea semnalelor vizuale către creier";
                Question9OptionBLabel.Text = "b) Acoperirea irisului și a pupilei";
                Question9OptionCLabel.Text = "c) Ajută la focalizarea luminii pe retina";
                Question9OptionDLabel.Text = "d) Controlul dimensiunii pupilei";
                Question10Label.Text = "10. Ce parte a ochiului este responsabilă pentru acoperirea irisului și a pupilei?";
                Question10OptionALabel.Text = "a) Corneea";
                Question10OptionBLabel.Text = "b) Irisul";
                Question10OptionCLabel.Text = "c) Pupila";
                Question10OptionDLabel.Text = "d) Retina";
                break;

            case "uk":
                TitleLabel.Text = "Test";
                Question1Label.Text = "1. Яка одна з основних функцій рогівки?";
                Question1OptionALabel.Text = "a) Контроль розміру зіниці";
                Question1OptionBLabel.Text = "b) Передача візуальних сигналів до мозку";
                Question1OptionCLabel.Text = "c) Покриття райдужки та зіниці";
                Question1OptionDLabel.Text = "d) Перетворення світла в електричні сигнали";
                Question2Label.Text = "2. Що відбувається в альвеолах легень?";
                Question2OptionALabel.Text = "a) Обробка світла";
                Question2OptionBLabel.Text = "b) Швидкий обмін газами між повітрям і кров'ю";
                Question2OptionCLabel.Text = "c) Формування кришталика";
                Question2OptionDLabel.Text = "d) Виробництво електричних сигналів";
                Question3Label.Text = "3. Яка частина ока допомагає фокусувати світло на сітківці?";
                Question3OptionALabel.Text = "a) Райдужка";
                Question3OptionBLabel.Text = "b) Зіниця";
                Question3OptionCLabel.Text = "c) Сітківка";
                Question3OptionDLabel.Text = "d) Кришталик";
                Question4Label.Text = "4. Що з наведеного нижче є правдою про зоровий нерв?";
                Question4OptionALabel.Text = "a) Контролює розмір зіниці";
                Question4OptionBLabel.Text = "b) Відповідає за покриття райдужки";
                Question4OptionCLabel.Text = "c) Передає візуальні сигнали від сітківки до мозку";
                Question4OptionDLabel.Text = "d) Допомагає перетворювати світло в електричні сигнали";
                Question5Label.Text = "5. Яка одна з основних функцій легень?";
                Question5OptionALabel.Text = "a) Контроль температури тіла";
                Question5OptionBLabel.Text = "b) Перетравлення їжі";
                Question5OptionCLabel.Text = "c) Дихання";
                Question5OptionDLabel.Text = "d) Виведення токсинів з крові";
                Question6Label.Text = "6. Яка частина ока регулює розмір зіниці для контролю кількості світла, що потрапляє?";
                Question6OptionALabel.Text = "a) Рогівка";
                Question6OptionBLabel.Text = "b) Райдужка";
                Question6OptionCLabel.Text = "c) Сітківка";
                Question6OptionDLabel.Text = "d) Кришталик";
                Question7Label.Text = "7. Яка роль капілярів навколо альвеол легень?";
                Question7OptionALabel.Text = "a) Видаляють вуглекислий газ";
                Question7OptionBLabel.Text = "b) Сприяють швидкому обміну газами між повітрям і кров'ю";
                Question7OptionCLabel.Text = "c) Захищають від інфекцій";
                Question7OptionDLabel.Text = "d) Виробляють електричні сигнали";
                Question8Label.Text = "8. Яка частина ока перетворює світло в електричні сигнали і передає їх до мозку?";
                Question8OptionALabel.Text = "a) Рогівка";
                Question8OptionBLabel.Text = "b) Райдужка";
                Question8OptionCLabel.Text = "c) Зіниця";
                Question8OptionDLabel.Text = "d) Сітківка";
                Question9Label.Text = "9. Яка одна з основних функцій кришталика?";
                Question9OptionALabel.Text = "a) Передача візуальних сигналів до мозку";
                Question9OptionBLabel.Text = "b) Покриття райдужки та зіниці";
                Question9OptionCLabel.Text = "c) Допомагає фокусувати світло на сітківці";
                Question9OptionDLabel.Text = "d) Контроль розміру зіниці";
                Question10Label.Text = "10. Яка частина ока відповідає за покриття райдужки та зіниці?";
                Question10OptionALabel.Text = "a) Рогівка";
                Question10OptionBLabel.Text = "b) Райдужка";
                Question10OptionCLabel.Text = "c) Зіниця";
                Question10OptionDLabel.Text = "d) Сітківка";

                break;

            default:
                break;
        }
    }
}