using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class ISVVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public ISVVege() : this(AudioManager.Current)
    {
    }

    public ISVVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("isvvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotISVVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotISVVege());
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
                new Span { FontSize = 15, Text = "Înmulțirea plantelor este un proces esențial în ciclul lor de viață și în conservarea biodiversității. Există două modalități principale prin care plantele se pot reproduce: prin sporulare și prin reproducere vegetativă." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Înmulțirea prin sporulare:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Sporularea este un proces specific plantelor care se reproduc prin intermediul sporilor. Sporii sunt structuri de reproducere unicelulare sau multicelulare, rezistente la condiții adverse, care permit plantelor să colonizeze noi medii și să se răspândească în mod eficient. Acest proces este comun în lumea fungilor, briofitelor (muscate, alge roșii, și altele) și a unor grupuri de plante vasculare, precum ferigile și lichenii." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Sporii sunt eliberați de plante în mediu, fie prin intermediul structurilor specializate precum sporangii sau sori, fie prin desprinderea unor părți ale plantelor, cum ar fi frunzele sau tulpinile. Odată ajunși în mediul potrivit, sporii germină și dezvoltă noi indivizi. Această formă de reproducere este esențială pentru diversificarea genetică și adaptarea plantelor la diverse condiții de mediu." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Înmulțirea vegetativă:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Înmulțirea vegetativă implică producerea unor noi plante din structuri vegetale specializate, precum fragmente de rădăcini, tulpini sau frunze. Acest proces este utilizat de mulți cultivatori pentru a produce plante identice cu plantele-mamă, păstrând astfel caracteristicile genetice și trăsăturile dorite." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Există mai multe metode de înmulțire vegetativă, inclusiv:" },
new Span { Text = "\n" },
new Span { Text = "1. Rezecția: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Înlăturarea și replantarea unei părți dintr-o plantă, cum ar fi tulpina sau o ramură, pentru a dezvolta o nouă plantă." },
new Span { Text = "\n" },
new Span { Text = "2. Propagarea prin tăiere: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Tăierea unei părți dintr-o plantă și plasarea ei într-un mediu adecvat pentru a crește rădăcini și a forma o nouă plantă." },
new Span { Text = "\n" },
new Span { Text = "3. Împărțirea tufei: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Separarea unei plante în mai multe părți pentru a forma mai multe plante individuale, fiecare cu propriul sistem de rădăcini." },
new Span { Text = "\n" },
new Span { Text = "4. Propagarea prin butași: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Prelevarea unor fragmente de tulpini tinere și plantarea lor într-un mediu umed pentru a dezvolta rădăcini și a forma noi plante." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Înmulțirea vegetativă este utilizată în special în horticultură și agricultură pentru a produce plante cu caracteristici superioare și pentru a conserva speciile rare sau amenințate." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Atât sporularea, cât și înmulțirea vegetativă sunt procese esențiale în perpetuarea speciilor de plante și în conservarea diversității lor genetice. Înțelegerea și utilizarea acestor procese sunt cruciale pentru conservarea și gestionarea durabilă a ecosistemelor naturale și a culturilor agricole." }
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "A növények szaporodása:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények szaporodása létfontosságú folyamat az életciklusukban és a biodiverzitás megőrzésében. A növények két fő módon szaporodhatnak: spórázás és vegetatív szaporodás útján.", FontSize = 16 },
new Span { Text = "Szaporodás spórázással:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A spórázás egy specifikus folyamat, amely a növények sajátja, és a spórák révén történik. A spórák egysejtű vagy többsejtű, ellenálló szerkezetek, amelyek lehetővé teszik a növények számára, hogy új környezeteket kolonizáljanak és hatékonyan terjedjenek. Ez a folyamat gyakori a gombák, moha- és zöldhínár-félék, valamint bizonyos éréses növények világában, mint például a páfrányok és a lichenek.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A spórák a növényekből szabadulnak fel a környezetbe, legyen az speciális struktúrákon keresztül, mint a sporangiumok vagy sori, vagy a növény részeinek, mint a levelek vagy szárak leválása. Miután eljutottak megfelelő környezetbe, a spórák kikelnek és új egyedeket fejlesztenek ki. Ez a szaporodási forma elengedhetetlen a genetikai sokféleség és a növények környezeti feltételekhez való alkalmazkodás szempontjából.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Vegetatív szaporodás:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A vegetatív szaporodás új növények termelését jelenti speciális növényi struktúrákból, mint például a gyökérdarabok, szárak vagy levelek. Ezt a folyamatot sok termesztő használja fel az anyanövényekkel azonos genetikai tulajdonságokkal rendelkező növények előállítására, megőrizve a kívánt genetikai jellemzőket és tulajdonságokat.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Több vegetatív szaporodási módszer létezik, ideértve:", FontSize = 16 },
new Span { Text = "1. Metszés: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Egy növényrész, például egy szár vagy ág eltávolítása és új növény kifejlesztése.", FontSize = 16 },
new Span { Text = "2. Metszés útján való elterjesztés: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Egy növényrész levágása és elhelyezése egy megfelelő környezetben, hogy gyökereket fejlesszen ki és új növényt hozzon létre.", FontSize = 16 },
new Span { Text = "3. Tövünk elosztása: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Egy növény szétválasztása több részre annak érdekében, hogy több egyedi növényt hozzon létre, mindegyik saját gyökérrendszerrel.", FontSize = 16 },
new Span { Text = "4. Hajtások útján való elterjesztés: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Fiatal hajtások darabjainak kivétele és elhelyezése nedves környezetben, hogy gyökereket fejlesszenek ki és új növényeket hozzanak létre.", FontSize = 16 },
new Span { Text = "A vegetatív szaporodás különösen fontos a kertészetben és mezőgazdaságban, a növények jellemzőinek javítására és a ritka vagy veszélyeztetett fajok megőrzésére.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Mind a spórázás, mind a vegetatív szaporodás alapvető folyamatok a növényfajok folytonosságában és genetikai sokféleségének megőrzésében. Ezeknek a folyamatoknak a megértése és alkalmazása kritikus fontosságú a természetes ökoszisztémák és mezőgazdasági kultúrák fenntartható kezelésében és megőrzésében.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Розмноження рослин:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Розмноження рослин є важливим процесом у їх життєвому циклі та збереженні біорізноманіття. Рослини можуть розмножуватися двома основними способами: споруванням і вегетативним розмноженням.", FontSize = 16 },
new Span { Text = "Розмноження спорами:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Спорування - це специфічний процес для рослин, що розмножуються за допомогою спор. Спори - це одноклітинні або багатоклітинні стійкі репродуктивні структури, які дозволяють рослинам колонізувати нові середовища та ефективно поширюватися. Цей процес поширений серед грибів, мохів (включаючи мохи, червоні водорості та інші) та деяких груп судинних рослин, таких як папороті та лишайники.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Спори вивільняються рослинами в середовище через спеціалізовані структури, такі як спорангії або сори, або через відлущення частин рослин, таких як листя або стебла. Після попадання в підходяще середовище спори проростають і розвивають нових індивідів. Цей спосіб розмноження важливий для генетичного різноманіття і адаптації рослин до різних умов середовища.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Вегетативне розмноження:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Вегетативне розмноження передбачає створення нових рослин зі спеціалізованих рослинних структур, таких як фрагменти коренів, стебел чи листя. Цей процес використовується багатьма вирощувачами для створення рослин, ідентичних материнським, зберігаючи генетичні характеристики і бажані ознаки.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Існує кілька методів вегетативного розмноження, включаючи:", FontSize = 16 },
new Span { Text = "1. Розсічення: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Видалення та пересадка частини рослини, такої як стебло або гілка, для вирощування нової рослини.", FontSize = 16 },
new Span { Text = "2. Розмноження за допомогою відбитків: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Відлущення частини рослини та розміщення її в відповідному середовищі для росту коренів та утворення нової рослини.", FontSize = 16 },
new Span { Text = "3. Ділення куща: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Розділення рослини на кілька частин для утворення декількох окремих рослин з власною кореневою системою.", FontSize = 16 },
new Span { Text = "4. Розмноження через черенки: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Відбирання фрагментів молодих стебел і їх посадка в вологе середовище для розвитку коренів та формування нових рослин.", FontSize = 16 },
new Span { Text = "Вегетативне розмноження особливо важливе в садівництві та сільському господарстві для вирощування рослин з перевагами і збереження рідкісних або загрожених видів.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Як спорування, так і вегетативне розмноження є ключовими процесами у збереженні видів рослин і їх генетичного різноманіття. Розуміння і використання цих процесів є критично важливими для стійкого управління і збереження природних екосистем і сільськогосподарських культур.", FontAttributes = FontAttributes.Bold, FontSize = 16 }

            }
        };
    }
}
