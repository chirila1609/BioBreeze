namespace BioBreeze.Teste;

public partial class GenGameti : ContentPage
{
	public GenGameti()
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

        if (Question2OptionC.IsChecked)
            score++;
        else
            feedback += "Întrebarea 2 este incorectă.\n";

        if (Question3OptionA.IsChecked)
            score++;
        else
            feedback += "Întrebarea 3 este incorectă.\n";

        if (Question4OptionA.IsChecked)
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
                Question1Label.Text = "1. Care sunt cele două tipuri principale de gameti implicate în reproducerea sexuală la organismele multicelulare?";
                Question1OptionALabel.Text = "a) Spermatozoizi și ovulele";
                Question1OptionBLabel.Text = "b) Celule somatice și celule stem";
                Question1OptionCLabel.Text = "c) Neuroni și celule gliale";

                Question2Label.Text = "2. Care dintre următoarele caracteristici nu se aplică spermatozoizilor?";
                Question2OptionALabel.Text = "a) Sunt celule mobile";
                Question2OptionBLabel.Text = "b) Conțin materialul genetic masculin";
                Question2OptionCLabel.Text = "c) Sunt cele mai mari celule din corpul uman";

                Question3Label.Text = "3. Unde sunt produse ovulele în corpul unei femele umane?";
                Question3OptionALabel.Text = "a) Ovare";
                Question3OptionBLabel.Text = "b) Uter";
                Question3OptionCLabel.Text = "c) Trompe uterine";

                Question4Label.Text = "4. Ce este gametogeneza?";
                Question4OptionALabel.Text = "a) Procesul de formare a gametilor";
                Question4OptionBLabel.Text = "b) Procesul de diviziune celulară în embrion";
                Question4OptionCLabel.Text = "c) Procesul de formare a zigotului";

                Question5Label.Text = "5. Ce se formează prin unirea unui spermatozoid cu un ovul?";
                Question5OptionALabel.Text = "a) Zigot";
                Question5OptionBLabel.Text = "b) Embrion";
                Question5OptionCLabel.Text = "c) Placentă";
                break;

            case "hu":
                TitleLabel.Text = "Teszt";
                Question1Label.Text = "1. Mik a két fő gametikus típus, amelyek részt vesznek a többsejtű élőlények szexuális szaporodásában?";
                Question1OptionALabel.Text = "a) Spermiumok és petesejtek";
                Question1OptionBLabel.Text = "b) Szomatikus sejtek és őssejtek";
                Question1OptionCLabel.Text = "c) Neuronok és gliasejtek";

                Question2Label.Text = "2. Melyik jellemző nem vonatkozik a spermiumokra?";
                Question2OptionALabel.Text = "a) Mozgékony sejtek";
                Question2OptionBLabel.Text = "b) Tartalmazzák a férfi genetikai anyagot";
                Question2OptionCLabel.Text = "c) A legnagyobb sejtek az emberi testben";

                Question3Label.Text = "3. Hol termelődnek a petesejtek a női testben?";
                Question3OptionALabel.Text = "a) Petefészkek";
                Question3OptionBLabel.Text = "b) Méh";
                Question3OptionCLabel.Text = "c) Petevezetékek";

                Question4Label.Text = "4. Mi a gametogenezis?";
                Question4OptionALabel.Text = "a) A gameták képződési folyamata";
                Question4OptionBLabel.Text = "b) A sejtosztódás folyamata az embrióban";
                Question4OptionCLabel.Text = "c) A zigóta képződési folyamata";

                Question5Label.Text = "5. Mi alakul ki egy spermium és egy petesejt egyesüléséből?";
                Question5OptionALabel.Text = "a) Zigóta";
                Question5OptionBLabel.Text = "b) Embrió";
                Question5OptionCLabel.Text = "c) Méhlepény";
                break;

            case "uk":
                TitleLabel.Text = "Тест";
                Question1Label.Text = "1. Які два основних типи гамет беруть участь у статевому розмноженні багатоклітинних організмів?";
                Question1OptionALabel.Text = "a) Сперматозоїди та яйцеклітини";
                Question1OptionBLabel.Text = "b) Соматичні клітини та стовбурові клітини";
                Question1OptionCLabel.Text = "c) Нейрони та гліальні клітини";

                Question2Label.Text = "2. Яка з наступних характеристик не стосується сперматозоїдів?";
                Question2OptionALabel.Text = "a) Це рухливі клітини";
                Question2OptionBLabel.Text = "b) Містять чоловічий генетичний матеріал";
                Question2OptionCLabel.Text = "c) Це найбільші клітини в організмі людини";

                Question3Label.Text = "3. Де виробляються яйцеклітини в організмі жінки?";
                Question3OptionALabel.Text = "a) Яєчники";
                Question3OptionBLabel.Text = "b) Матка";
                Question3OptionCLabel.Text = "c) Маткові труби";

                Question4Label.Text = "4. Що таке гаметогенез?";
                Question4OptionALabel.Text = "a) Процес утворення гамет";
                Question4OptionBLabel.Text = "b) Процес поділу клітин в ембріоні";
                Question4OptionCLabel.Text = "c) Процес утворення зиготи";

                Question5Label.Text = "5. Що утворюється при злитті сперматозоїда з яйцеклітиною?";
                Question5OptionALabel.Text = "a) Зигота";
                Question5OptionBLabel.Text = "b) Ембріон";
                Question5OptionCLabel.Text = "c) Плацента";
                break;

            default:
                break;
        }
    }

}