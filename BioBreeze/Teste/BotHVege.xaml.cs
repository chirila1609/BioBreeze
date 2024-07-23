namespace BioBreeze.Teste;

public partial class BotHVege : ContentPage
{
	public BotHVege()
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
                TitleLabel.Text = "Test hrănirea plantelor";
                Question1Label.Text = "1. Care sunt cei trei macronutrienți principali necesari plantelor?";
                Question1OptionALabel.Text = "a) Azot, potasiu, calciu";
                Question1OptionBLabel.Text = "b) Azot, fosfor, potasiu";
                Question1OptionCLabel.Text = "c) Fier, fosfor, potasiu";
                Question1OptionDLabel.Text = "d) Fosfor, calciu, magneziu";

                Question2Label.Text = "2. Ce rol are azotul în dezvoltarea plantelor?";
                Question2OptionALabel.Text = "a) Stimulează creșterea radacinilor";
                Question2OptionBLabel.Text = "b) Favorizează formarea florilor";
                Question2OptionCLabel.Text = "c) Contribuie la dezvoltarea frunzelor verzi și la producerea proteinelor";
                Question2OptionDLabel.Text = "d) Îmbunătățește rezistența la stres a plantelor";

                Question3Label.Text = "3. Care este sursa principală de nutrienți pentru plante?";
                Question3OptionALabel.Text = "a) Aerul";
                Question3OptionBLabel.Text = "b) Solul";
                Question3OptionCLabel.Text = "c) Apa";
                Question3OptionDLabel.Text = "d) Lumina solară";

                Question4Label.Text = "4. Ce se întâmplă dacă plantele primesc o supra-doza de nutrienți?";
                Question4OptionALabel.Text = "a) Creșterea sănătoasă și accelerată";
                Question4OptionBLabel.Text = "b) Arsuri ale frunzelor și deficiențe nutriționale";
                Question4OptionCLabel.Text = "c) Dezvoltarea sistemului radicular";
                Question4OptionDLabel.Text = "d) Îmbunătățirea calității florilor";

                Question5Label.Text = "5. Ce trebuie să facă pentru a asigura o hrănire echilibrată a plantelor?";
                Question5OptionALabel.Text = "a) Aplicarea de îngrășăminte doar o dată pe an";
                Question5OptionBLabel.Text = "b) Utilizarea îngrășămintelor fără a respecta doza recomandată";
                Question5OptionCLabel.Text = "c) Folosirea unor îngrășăminte specifice, adaptate nevoilor plantelor, și respectarea instrucțiunilor de dozare";
                Question5OptionDLabel.Text = "d) Udarea plantelor cu apă sărată";
                break;

            case "hu":
                TitleLabel.Text = "Növények táplálkozási teszt";
                Question1Label.Text = "1. Mi a három fő makrotápanyag, amire a növényeknek szükségük van?";
                Question1OptionALabel.Text = "a) Nitrogén, kálium, kalcium";
                Question1OptionBLabel.Text = "b) Nitrogén, foszfor, kálium";
                Question1OptionCLabel.Text = "c) Vas, foszfor, kálium";
                Question1OptionDLabel.Text = "d) Foszfor, kalcium, magnézium";

                Question2Label.Text = "2. Mi a nitrogén szerepe a növények fejlődésében?";
                Question2OptionALabel.Text = "a) Serkenti a gyökerek növekedését";
                Question2OptionBLabel.Text = "b) Elősegíti a virágok képződését";
                Question2OptionCLabel.Text = "c) Hozzájárul a zöld levelek fejlődéséhez és a fehérjék előállításához";
                Question2OptionDLabel.Text = "d) Javítja a növények stresszállóságát";

                Question3Label.Text = "3. Mi a növények fő tápanyagforrása?";
                Question3OptionALabel.Text = "a) Levegő";
                Question3OptionBLabel.Text = "b) Talaj";
                Question3OptionCLabel.Text = "c) Víz";
                Question3OptionDLabel.Text = "d) Napfény";

                Question4Label.Text = "4. Mi történik, ha a növények túl sok tápanyagot kapnak?";
                Question4OptionALabel.Text = "a) Egészséges és gyors növekedés";
                Question4OptionBLabel.Text = "b) Levélégés és tápanyaghiány";
                Question4OptionCLabel.Text = "c) Gyökérzet fejlődése";
                Question4OptionDLabel.Text = "d) Virágok minőségének javítása";

                Question5Label.Text = "5. Mit kell tenni a növények kiegyensúlyozott táplálásának biztosítása érdekében?";
                Question5OptionALabel.Text = "a) Műtrágyázás évente egyszer";
                Question5OptionBLabel.Text = "b) Műtrágyák alkalmazása a javasolt adagolás figyelmen kívül hagyásával";
                Question5OptionCLabel.Text = "c) Speciális műtrágyák használata, amelyek a növények igényeihez igazodnak, és az adagolási utasítások betartása";
                Question5OptionDLabel.Text = "d) Növények öntözése sós vízzel";
                break;

            case "uk":
                TitleLabel.Text = "Тест на харчування рослин";
                Question1Label.Text = "1. Які три основні макроелементи необхідні рослинам?";
                Question1OptionALabel.Text = "a) Азот, калій, кальцій";
                Question1OptionBLabel.Text = "b) Азот, фосфор, калій";
                Question1OptionCLabel.Text = "c) Залізо, фосфор, калій";
                Question1OptionDLabel.Text = "d) Фосфор, кальцій, магній";

                Question2Label.Text = "2. Яка роль азоту у розвитку рослин?";
                Question2OptionALabel.Text = "a) Стимулює зростання коренів";
                Question2OptionBLabel.Text = "b) Сприяє формуванню квітів";
                Question2OptionCLabel.Text = "c) Сприяє розвитку зелених листків і виробництву білків";
                Question2OptionDLabel.Text = "d) Покращує стійкість рослин до стресу";

                Question3Label.Text = "3. Яке основне джерело поживних речовин для рослин?";
                Question3OptionALabel.Text = "a) Повітря";
                Question3OptionBLabel.Text = "b) Грунт";
                Question3OptionCLabel.Text = "c) Вода";
                Question3OptionDLabel.Text = "d) Сонячне світло";

                Question4Label.Text = "4. Що відбувається, якщо рослини отримують надмірну дозу поживних речовин?";
                Question4OptionALabel.Text = "a) Здорове і прискорене зростання";
                Question4OptionBLabel.Text = "b) Опіки листя і харчові дефіцити";
                Question4OptionCLabel.Text = "c) Розвиток кореневої системи";
                Question4OptionDLabel.Text = "d) Покращення якості квітів";

                Question5Label.Text = "5. Що потрібно робити для забезпечення збалансованого харчування рослин?";
                Question5OptionALabel.Text = "a) Застосовувати добрива лише раз на рік";
                Question5OptionBLabel.Text = "b) Використовувати добрива без дотримання рекомендованої дози";
                Question5OptionCLabel.Text = "c) Використовувати спеціалізовані добрива, адаптовані до потреб рослин, і дотримуватися інструкцій з дозування";
                Question5OptionDLabel.Text = "d) Поливати рослини солоною водою";
                break;
        }
    }

}