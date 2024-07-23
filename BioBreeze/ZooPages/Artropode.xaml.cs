using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Artropode : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Artropode() : this(AudioManager.Current)
    {
    }

    public Artropode(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("artropode.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooArtropode(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooArtropode());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnRomanianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { FontSize = 15, Text = "Artropodele reprezintă unul dintre cele mai diverse și abundente grupuri de organisme de pe Pământ, cuprinzând aproximativ 80% din totalul speciilor cunoscute. Aceste creaturi sunt caracterizate de prezența unui exoschelet (schelet extern), corp segmentat și membre articulate. Termenul artropod derivă din grecescul arthron, care înseamnă articulație, și podos, care înseamnă picior." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Morfologie și Anatomi:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Corpul artropodelor este format din mai multe segmente distincte, fiecare având perechi de membre articulate. Exoscheletul este format dintr-un compus numit chitină, care oferă sprijin și protecție organismului. Acest exoschelet necesită periodic năpăstuire pentru a permite creșterea, un proces cunoscut sub numele de exuviație." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Diversitate:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Artropodele sunt grupate în patru subfili principale:" },
new Span { Text = "\n" },
new Span { Text = "1. Chelicerate: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Includ păianjeni, scorpioni, acarieni și crustacee. Acestea au o pereche de apendice chelicere folosite pentru hrănire și un alt set de apendice numite pedipalpi." },
new Span { Text = "\n" },
new Span { Text = "2. Miriapode: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Această subclasă include centipedele și milipedele, cu corpuri lungi și segmentate și perechi variate de picioare." },
new Span { Text = "\n" },
new Span { Text = "3. Crustacee: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Acest grup este divers și cuprinde crabii, homarul, creveții și multe alte specii care trăiesc în mediul acvatic, terestru sau chiar în aer. Majoritatea crustaceelor sunt acvatici și au un corp acoperit cu o cochilie dură." },
new Span { Text = "\n" },
new Span { Text = "4. Insecte: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Cu aproximativ un milion de specii descrise, insectele formează cea mai mare parte a clasei Artropodelor. Ele includ fluturi, muște, gândaci și multe alte grupuri." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Habitat și Rol Ecologic:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Artropodele ocupă o gamă largă de habitate, de la fundul oceanului până în cel mai înalt vârf muntos. Ele joacă roluri esențiale în ecosisteme, contribuind la descompunerea materiei organice, polenizare, hrănirea altor organisme și menținerea echilibrului ecologic." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Interacțiune cu Oamenii:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Unele artropode sunt considerate dăunătoare pentru culturi agricole sau pot transmite boli oamenilor și animalelor domestice. Totuși, multe artropode sunt benefice, cum ar fi albinele care polenizează culturile sau păianjenii care controlează populațiile de insecte dăunătoare." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Importanța Științifică:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Datorită diversității lor și a adaptărilor remarcabile, artropodele sunt subiectul unor cercetări științifice intense. Ele oferă oportunități de înțelegere a evoluției, ecologiei și biologiei în general." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Concluzie:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Artropodele sunt printre cele mai reușite forme de viață de pe Pământ, adaptându-se la o gamă largă de medii și îndeplinind roluri vitale în ecosistemele globale. Cunoașterea și înțelegerea acestor creaturi sunt esențiale pentru conservarea biodiversității și pentru bunăstarea umană." },
new Span { Text = "\n" }
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Морфологія та Анатомія:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Тіло артропод складається з кількох відмінних сегментів, кожен з парними суглобовими кінцівками. Екзоскелет складається з сполуки, що називається хітином, який забезпечує підтримку та захист організму. Цей екзоскелет періодично вимагає лущіння для забезпечення росту, процес відомий як екзувація." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Різноманіття:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Артроподи групуються в чотири основні підфіли:" },
new Span { Text = "\n" },
new Span { Text = "1. Хелицерати:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Включають павуків, скорпіонів, кліщів та ракоподібних. Вони мають пару хеліцеральних відгалужень, призначених для живлення, та інший набір відгалужень, що називають педіпальпи." },
new Span { Text = "\n" },
new Span { Text = "2. Міріаподи:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Цей підклас включає сотенні та тисячні, з довгими сегментованими тілами і різноманітними парами ніг." },
new Span { Text = "\n" },
new Span { Text = "3. Ракоподібні:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Ця група різноманітна і включає крабів, омарів, креветок та багато інших видів, які живуть у водних, наземних або навіть повітряних середовищах. Більшість ракоподібних є водними і мають тіло, покрите твердим панцирем." },
new Span { Text = "\n" },
new Span { Text = "4. Комахи:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Із приблизно мільйоном описаних видів комахи становлять найбільшу частину класу Артропод. До них входять метелики, мухи, жуки та багато інших груп." },
new Span { Text = "\n" },
new Span { Text = "Життєве середовище та екологічна роль:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Артроподи займають широкий спектр середовищ, від дна океану до найвищих гірських вершин. Вони відіграють важливу роль у екосистемах, сприяючи розкладанню органічної речовини, запиленню, живленню інших організмів та підтримці екологічного балансу." },
new Span { Text = "\n" },
new Span { Text = "Взаємодія з людиною:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Деякі артроподи вважаються шкідниками сільськогосподарських культур або можуть передавати хвороби людині та домашнім тваринам. Однак багато артропод корисні, такі як бджоли, які запилюють культури, або павуки, які контролюють популяції шкідливих комах." },
new Span { Text = "\n" },
new Span { Text = "Наукове значення:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Завдяки своїй різноманітності та виразним адаптаціям артроподи є предметом інтенсивних наукових досліджень. Вони надають можливості для розуміння еволюції, екології та біології загалом." },
new Span { Text = "\n" },
new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Артроподи є одними з найуспішніших форм життя на Землі, адаптуючись до широкого спектру середовищ і виконуючи важливі ролі у глобальних екосистемах. Розуміння цих створінь є важливим для збереження біорізноманіття та благополуччя людини." },
new Span { Text = "\n" }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Morfológia és Anatómia:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A rákfejűek testét több különböző szegmense alkotja, mindegyik párosított ízületes végtagokkal. A kitin nevű vegyületből álló exoskeleton támogatást és védelmet nyújt az organizmusnak. Ez az exoskeleton időszakos levedésre szorul a növekedés lehetővé tétele érdekében, amit exuviationak neveznek." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Alkalmazkodás:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A rákfejűeket négy fő alalfilumba sorolják:" },
new Span { Text = "\n" },
new Span { Text = "1. Kélcératák:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Pókokat, skorpiókat, atkákat és rákokat foglal magában. Ezeknek van egy pár cheliceral apendixük, amit a táplálkozásra használnak, és egy másik apendix készlet, amit pedipalpikének neveznek." },
new Span { Text = "\n" },
new Span { Text = "2. Miriápódok:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Ez a subclass tartalmazza a százlábúkat és ezerlábúakat, hosszú, szegmentált testekkel és változatos lábpárokkal." },
new Span { Text = "\n" },
new Span { Text = "3. Rákok:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Ez a csoport sokféle és magában foglalja a rákokat, homárokat, garnélarákot és sok más fajt, amelyek vízi, szárazföldi vagy akár légi környezetben élnek. A rákok többsége vízi, és kemény héj borítja testüket." },
new Span { Text = "\n" },
new Span { Text = "4. Rovarok:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Kb. egymillió leírt fajjal a rovarok teszik ki az Arthropoda osztály legnagyobb részét. Ide tartoznak a lepkék, legyek, bogarak és sok más csoport." },
new Span { Text = "\n" },
new Span { Text = "Életközösség és Ökológiai szerep:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A rákfejűek széles körű életközösségeket foglalnak magukba, az óceánok aljától a legmagasabb hegyi csúcsokig. Létfontosságú szerepet játszanak az ökoszisztémákban, hozzájárulva a szerves anyag lebontásához, a porozáshez, más szervezetek táplálkozásához és az ökológiai egyensúly fenntartásához." },
new Span { Text = "\n" },
new Span { Text = "Interakció az emberekkel:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Néhány rákfejű károsnak tekinthető mezőgazdasági kultúrákra, vagy betegségeket terjeszthet emberre és háziállatokra. Azonban sok rákfejű hasznos, például a méhek, amelyek porozzák a kultúrákat, vagy a pókok, amelyek ellenőrzik a káros rovarpopulációkat." },
new Span { Text = "\n" },
new Span { Text = "Tudományos fontosság:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az arthropodák sokféleségének és feltűnő alkalmazkodásainak köszönhetően intenzív tudományos kutatások tárgyai. Lehetőségeket kínálnak az evolúció, az ökológia és a biológia általános megértésére." },
new Span { Text = "\n" },
new Span { Text = "Következtetés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A rákfejűek a Föld egyik legsikeresebb életformái közé tartoznak, alkalmazkodva a különböző környezetekhez és fontos szerepeket játszanak a globális ökoszisztémákban. A lények megértése fontos a biológiai sokféleség megőrzése és az emberi jólét szempontjából." },
new Span { Text = "\n" }
            }
        };
    }
}
