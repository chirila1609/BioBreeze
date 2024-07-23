namespace BioBreeze;

public partial class Despre : ContentPage
{
	public Despre()
	{
        InitializeComponent();
	}

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    private void OnLanguageButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                DescriptionLabel.Text = "Proiect realizat de Chirilă Mihnea-Ștefan\nClasa a IX-a A Colegiul Național Octav Onicescu\nAplicație destinată elevilor de gimnaziu și pentru a învăța mai ușor și mai rapid noțiuni privind biologia.  Această aplicație este intuitivă și prietenoasă, pentru a o folosi mergeți pe clasa și categoria dorită și accesați informațiile colectate și selecționate cu mare grijă pentru a vă acorda suport în sedimentarea unor date despre biologie. Mult succes!";
                UserManualLabel.Text = "Manual de utilizare:";
                break;

            case "hu":
                DescriptionLabel.Text = "Projekt készítette Chirilă Mihnea-Ștefan\nIX.A osztály, Octav Onicescu Nemzeti Főiskola\nAz alkalmazás célja, hogy a középiskolás diákok könnyebben és gyorsabban megtanulják a biológia fogalmait. Ez az alkalmazás intuitív és barátságos, használatához válassza ki a kívánt osztályt és kategóriát, és hozzáférhet a biológiai adatok megtanulását támogató, gondosan kiválasztott információkhoz. Sok sikert!";
                UserManualLabel.Text = "Használati utasítás:";
                break;

            case "uk":
                DescriptionLabel.Text = "Проект виконаний Кирилою Міхнеа-Штефаном\nКлас IX-A Національний коледж Октав Оніческу\nДодаток призначений для учнів середніх шкіл і для легкого та швидкого вивчення біологічних понять. Цей додаток є інтуїтивно зрозумілим і зручним для користувачів, щоб ним користуватися, виберіть бажаний клас і категорію та отримайте доступ до ретельно відібраної інформації, яка допоможе вам засвоїти дані про біологію. Бажаємо успіхів!";
                UserManualLabel.Text = "Інструкція з використання:";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}