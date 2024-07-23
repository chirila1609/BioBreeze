using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulNervos : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulNervos() : this(AudioManager.Current)
    {
    }

    public SistemulNervos(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulnervos.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSN());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnRomanianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Sistemul nervos uman este unul dintre cele mai complexe și fascinante sisteme din corpul nostru. Responsabil pentru controlul și coordonarea tuturor activităților noastre, acesta este compus din două componente principale: sistemul nervos central (SNC) și sistemul nervos periferic (SNP)." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sistemul nervos central este format din creier și măduva spinării. Creierul este centrul de comandă al corpului nostru, controlând fiecare acțiune și reacție. Măduva spinării este o extensie a creierului și este responsabilă pentru transmiterea informațiilor de la creier la restul corpului și invers." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sistemul nervos periferic include toate celelalte părți ale sistemului nervos, cum ar fi nervii și ganglionii nervoși, care conectează SNC-ul la restul corpului. Aceste componente periferice sunt responsabile pentru transmiterea informațiilor senzoriale de la organele de simț către creier și pentru transmiterea comenzilor motorii de la creier către mușchi și glande." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sistemul nervos funcționează prin intermediul a milioane de celule numite neuroni. Neuronii sunt celule speciale care pot transmite rapid semnale electrochimice prin intermediul axonilor lor lungi. Aceste semnale permit comunicarea rapidă între diferite părți ale corpului și permit corpului nostru să reacționeze la stimulii din mediu." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Pe lângă această funcție de comunicare rapidă, sistemul nervos are și multe alte funcții importante. De exemplu, este implicat în controlul funcțiilor vitale precum respirația, ritmul cardiac și digestia. De asemenea, este implicat în procesele cognitive precum gândirea, memoria și învățarea." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Людська нервова система є однією з найбільш складних і захоплюючих систем у нашому тілі. Відповідальна за керування та координацію всіх наших дій, вона складається з двох основних компонент: центральної нервової системи (ЦНС) та периферичної нервової системи (ПНС)." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Центральна нервова система складається з мозку і спинного мозку. Мозок є центром командування нашого тіла, контролюючи кожну дію і реакцію. Спинний мозок є продовженням мозку і відповідає за передачу інформації від мозку до решти тіла та назад." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Периферична нервова система включає всі інші частини нервової системи, такі як нерви і нервові вузли, які з'єднують ЦНС з рештою тіла. Ці периферичні компоненти відповідають за передачу сенсорної інформації від органів чуття до мозку та за передачу рухових команд від мозку до м'язів і залоз." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Нервова система працює завдяки мільйонам клітин, що називаються нейронами. Нейрони - це спеціальні клітини, які можуть швидко передавати електрохімічні сигнали через їхні довгі аксони. Ці сигнали дозволяють швидку комунікацію між різними частинами тіла і дозволяють нашому тілу реагувати на стимули з навколишнього середовища." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Окрім цієї функції швидкого зв'язку, нервова система має багато інших важливих функцій. Наприклад, вона відповідає за контроль важливих функцій, таких як дихання, серцебиття та травлення. Вона також залучена до когнітивних процесів, таких як мислення, пам'ять і навчання." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Az emberi idegrendszer az egyik legbonyolultabb és legfascinálóbb rendszerek egyike a testünkben. Felelős az összes tevékenységünk irányításáért és koordinálásáért, két fő komponensből áll: a központi idegrendszerből (KIR) és a perifériás idegrendszerből (PIR)." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A központi idegrendszer az agyból és a gerincvelőből áll. Az agy a testünk parancsnoki központja, amely minden cselekvést és reakciót irányít. A gerincvelő az agy kiterjesztése, és felelős az információk átviteléért az agy és a test többi része között." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A perifériás idegrendszer magában foglalja az összes többi idegrendszeri részt, például idegeket és idegcsomókat, amelyek összekötik a KIR-t a test többi részével. Ezek a perifériás komponensek felelősek a szenzoros információk átviteléért az érzékszervekből az agyba, valamint az agy motoros parancsainak átviteléért a izmokhoz és mirigyekhez." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az idegrendszer milliók által működik, amelyeket neuronoknak neveznek. A neuronok speciális sejtek, amelyek képesek gyors elektrokémiai jeleket közvetíteni hosszú axonjaikon keresztül. Ezek a jelek lehetővé teszik a gyors kommunikációt a test különböző részei között, és lehetővé teszik a testünk számára, hogy reagáljon a környezeti ingerekre." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Ezen gyors kommunikációs funkció mellett az idegrendszer számos más fontos funkciót is ellát. Például felelős az életfontosságú funkciók, mint például a légzés, a szívverés és az emésztés szabályozásáért. Emellett részt vesz a kognitív folyamatokban, például a gondolkodásban, a memóriában és a tanulásban." }
                }
        };
    }
}
