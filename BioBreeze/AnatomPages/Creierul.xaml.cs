using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Creierul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Creierul() : this(AudioManager.Current)
    {
    }

    public Creierul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }
    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("creierul.mp3"));
        player.Play();
    }
    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }
    private void GoTo_AnatomieBrain(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieBrain());
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
                    new Span { FontSize = 15, Text = "Creierul este un organ incredibil de complex care servește ca centru de comandă al corpului uman. Este responsabil pentru procesarea informațiilor senzoriale, coordonarea mișcărilor, reglarea funcțiilor corporale și chiar pentru guvernarea emoțiilor și a gândurilor." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Structurat în diferite regiuni, fiecare cu funcții specializate, creierul poate fi împărțit în trei părți principale: creierul anterior, creierul mijlociu și creierul posterior." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "1. Creierul anterior:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Cea mai mare și mai complexă parte a creierului, creierul anterior este format din cortexul cerebral, talamus și hipotalamus. Cortexul cerebral este împărțit în două emisfere și este responsabil pentru funcțiile cognitive superioare precum gândirea, percepția și luarea deciziilor. Este împărțit în patru loji: loja frontală, parietală, temporală și occipitală, fiecare având roluri distincte în procesarea diferitelor tipuri de informații. Talamusul acționează ca o stație de releu pentru informațiile senzoriale, în timp ce hipotalamusul reglează funcțiile corporale de bază precum foamea, setea și temperatura corpului." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "2. Creierul mijlociu:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Situat între creierul anterior și creierul posterior, creierul mijlociu este implicat în funcții precum mișcarea motorie, procesarea auditivă și vizuală și reglarea ciclurilor de somn și veghe." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "3. Creierul posterior:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Creierul posterior cuprinde cerebelul, puntea și bulbul rahidian. Cerebelul este responsabil în principal pentru coordonarea mișcării, echilibrului și posturii. Puntea servește ca un pod care leagă diferite părți ale creierului, în timp ce bulbul rahidian controlează funcțiile vitale precum bătăile inimii, respirația și digestia." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Creierul este alcătuit din miliarde de celule nervoase numite neuroni, care comunică între ele prin impulsuri electrice și semnale chimice. Acești neuroni formează rețele intricate care permit procesarea și transmiterea informațiilor în întregul creier și corp. În plus, creierul este susținut de celule gliale, care oferă suport structural, izolație și nutriție neuronoilor." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Az agy egy hihetetlenül összetett szerv, amely a test központi vezérlőközpontjaként szolgál. Felelős a szenzoros információk feldolgozásáért, a mozgások koordinálásáért, a testi funkciók szabályozásáért, sőt még az érzelmek és gondolatok irányításáért is." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Különböző régiók szerint strukturált, amelyek mindegyike specializált funkciókkal rendelkezik, az agyat három fő részre lehet osztani: elülső agy, középső agy és hátsó agy." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "1. Elülső agy:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A legnagyobb és legbonyolultabb része az agynak, amely az agykéregből, a talamból és a hipotalamból áll. Az agykéreg két féltekére oszlik, és felelős a gondolkodás, érzékelés és döntéshozatal magasabb kognitív funkcióiért. Négy kamrára oszlik: frontális, parietális, temporális és occipitális, mindegyik különböző szerepet játszik különböző típusú információk feldolgozásában. A talamusz szenzoros információk reléállomásként működik, míg a hipotalamusz alapvető testi funkciók szabályozásáért felelős, mint például az éhség, szomjúság és testhőmérséklet." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "2. Középső agy:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az elülső és hátsó agy között elhelyezkedő középső agy részt vesz olyan funkciókban, mint a mozgás, hangfeldolgozás és látás, valamint az alvás-ébrenlét ciklusok szabályozása." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "3. Hátsó agy:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A hátsó agy magában foglalja a kisagyat, a híd és a gerincvelői dudorot. A kisagy elsősorban a mozgás, egyensúly és testtartás koordinálásáért felelős. A híd egy hidat képez, amely összeköti az agy különböző részeit, míg a gerincvelői dudor szabályozza az életfontosságú funkciókat, mint a szívverés, légzés és emésztés." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az agy milliárd idegsejtből, úgynevezett neuronokból áll, amelyek elektromos impulzusok és vegyi jelek által kommunikálnak egymással. Ezek a neuronok bonyolult hálózatokat alkotnak, amelyek lehetővé teszik az információ feldolgozását és továbbítását az egész agyban és testben. Emellett az agyat támasztó gliasejtek biztosítják a szerkezeti támogatást, az izolációt és a neuronok táplálását." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Мозок - це неймовірно складний орган, який служить центром управління людським тілом. Він відповідає за обробку сенсорної інформації, координацію рухів, регуляцію функцій організму та навіть управління емоціями та думками." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Структурований на різних регіонах, кожен зі спеціалізованими функціями, мозок може бути розділений на три основні частини: передній мозок, середній мозок та задній мозок." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "1. Передній мозок:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Найбільша і найскладніша частина мозку, передній мозок складається з кори головного мозку, таламусу та гіпоталамусу. Кора головного мозку поділена на дві півкулі і відповідає за вищі когнітивні функції, такі як мислення, сприйняття та прийняття рішень. Вона поділена на чотири ложі: лобову, тім'яну, потиличну та потилично-височинну, кожна з яких відіграє різні ролі у обробці різних типів інформації. Таламус діє як реле для сенсорної інформації, в той час як гіпоталамус регулює основні функції організму, такі як голод, спрага та температура тіла." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "2. Середній мозок:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Розташований між переднім і заднім мозком, середній мозок відповідає за функції, такі як рухова активність, обробка аудитивної і візуальної інформації та регуляція циклів сну і бодрості." },
                    new Span { Text = "\n\n" },
                    new Span { FontAttributes = FontAttributes.Bold, FontSize = 20, Text = "3. Задній мозок:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Задній мозок включає мозочок, міст і спинний мозок. Мозочок відповідає переважно за координацію рухів, рівноваги та постави. Міст служить мостом, який з'єднує різні частини мозку, тоді як спинний мозок контролює життєво важливі функції, такі як серцебиття, дихання та травлення." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Мозок складається з мільярдів нервових клітин, які називаються нейронами, які взаємодіють один з одним за допомогою електричних імпульсів та хімічних сигналів. Ці нейрони формують складні мережі, які дозволяють обробляти та передавати інформацію по всьому мозку та тілу. Крім того, мозок підтримується гліальними клітинами, які забезпечують структурну підтримку, ізоляцію та харчування нейронів." }
                }
        };
    }

}
