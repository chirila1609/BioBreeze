using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class TVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public TVege() : this(AudioManager.Current)
    {
    }

    public TVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("tvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotTVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotTVege());
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
                new Span { FontSize = 15, Text = "În structura complexă a plantelor, țesuturile vegetale reprezintă o parte esențială, asigurând suport structural, transportul substanțelor și creșterea organismului. Acestea sunt clasificate în două categorii principale: țesuturi meristemice și țesuturi permanente." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "1. Țesuturi Meristemice", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesuturile meristemice sunt responsabile pentru creșterea primară și secundară a plantelor, precum și pentru producerea de celule noi. Acestea sunt împărțite în:" },
new Span { Text = "\n" },
new Span { Text = "a. Meristem Primar:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Meristem apical: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Situat în vârful rădăcinii și al tulpinii, acesta promovează creșterea longitudinală." },
new Span { Text = "\n" },
new Span { Text = "-Meristem intercalar: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Prezent la nivelul nodurilor din tulpină, acesta asigură creșterea în lungime a segmentelor intercalare ale plantei." },
new Span { Text = "\n" },
new Span { Text = "-Meristem lateral: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Se găsește sub cortexul tulpinii și al rădăcinii, contribuind la creșterea în grosime a plantei." },
new Span { Text = "\n" },
new Span { Text = "b. Meristem Secundar sau Cambiu:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Cambiu vascular: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Produce țesut vascular secundar, xilem și floem, care permit creșterea în grosime a plantei." },
new Span { Text = "\n" },
new Span { Text = "-Cambiu cortical: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Produce țesutul cortical secundar, crescând grosimea cortexului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "2. Țesuturi Permanente", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesuturile permanente sunt formate din celule mature și îndeplinesc funcții specializate în cadrul plantei. Acestea includ:" },
new Span { Text = "a. Țesuturi de Protecție:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Epidermă: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Stratul exterior al plantelor, format din celule care protejează împotriva pierderii de apă și a invaziei de organisme patogene." },
new Span { Text = "\n" },
new Span { Text = "-Peridermă: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Înlocuiește epiderma la plantele perene, asigurând protecție împotriva stresului mecanic și a infecțiilor." },
new Span { Text = "\n" },
new Span { Text = "b. Țesuturi de Conducție:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Xilem: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Transportă apă și substanțe minerale de la rădăcini către alte părți ale plantei." },
new Span { Text = "\n" },
new Span { Text = "-Floem: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Transportă substanțe organice sintetizate, precum zahărul, de la frunze și alte organe fotosintetice către alte părți ale plantei." },
new Span { Text = "\n" },
new Span { Text = "c. Țesuturi de Suport:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Colenchim: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Asigură susținerea și flexibilitatea țesuturilor în creștere." },
new Span { Text = "\n" },
new Span { Text = "-Sclerenchim: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Furnizează rigiditate și protecție împotriva stresului mecanic." },
new Span { Text = "\n" },
new Span { Text = "d. Țesuturi de Stocare:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Parenchim de stocare: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Depozitează substanțe nutritive, cum ar fi amidonul și uleiurile, în rădăcini, tulpini și semințe." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Aceste țesuturi complexe formează o rețea funcțională care susține vitalitatea plantelor, asigurându-le adaptabilitatea și capacitatea de a supraviețui în medii variate." }
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Növényi szövetek:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "A növények bonyolult szerkezetében a növényi szövetek alapvető részeket képviselnek, biztosítva a szerkezeti támogatást, az anyagok szállítását és a növekedést. Ezeket két fő kategóriába sorolják: merisztémás szövetek és állandó szövetek." },
new Span { Text = "\n" },
new Span { Text = "1. Merisztémás szövetek:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "A merisztémás szövetek felelősek a növények elsődleges és másodlagos növekedéséért, valamint új sejtek előállításáért. Ezeket a következőkre osztják:" },
new Span { Text = "\n" },
new Span { Text = "a. Elsődleges merisztéma:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Apikális merisztéma: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "A gyökér és a szár csúcsán található, és elősegíti a hosszanti növekedést." },
new Span { Text = "\n" },
new Span { Text = "-Interkaláris merisztéma: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "A szár csomópontjain található, és biztosítja a növény interkaláris szegmenseinek hosszanti növekedését." },
new Span { Text = "\n" },
new Span { Text = "-Laterális merisztéma: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "A szár és a gyökér kérge alatt található, és hozzájárul a növény vastagodásához." },
new Span { Text = "\n" },
new Span { Text = "b. Másodlagos merisztéma vagy kambium:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Vaszkuláris kambium: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Másodlagos vaszkuláris szöveteket, xilémet és floémet állít elő, amelyek lehetővé teszik a növény vastagodását." },
new Span { Text = "\n" },
new Span { Text = "-Kortikális kambium: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Másodlagos kortikális szövetet állít elő, növelve a kéreg vastagságát." },
new Span { Text = "\n" },
new Span { Text = "2. Állandó szövetek:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "Az állandó szövetek érett sejtekből állnak, és specializált funkciókat látnak el a növényen belül. Ezek a következők:" },
new Span { Text = "a. Védőszövetek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Epidermisz: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "A növények külső rétege, amely sejtekből áll, amelyek megvédik a vízveszteségtől és a kórokozó szervezetek behatolásától." },
new Span { Text = "\n" },
new Span { Text = "-Peridermisz: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "A peridermisz felváltja az epidermiszt az évelő növényekben, védelmet biztosítva a mechanikai stressz és a fertőzések ellen." },
new Span { Text = "\n" },
new Span { Text = "b. Vezetőszövetek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Xilémet: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Vizet és ásványi anyagokat szállít a gyökerektől a növény más részeibe." },
new Span { Text = "\n" },
new Span { Text = "-Floémet: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Szerves anyagokat, például cukrot szállít a levelektől és más fotoszintetikus szervektől a növény más részeibe." },
new Span { Text = "\n" },
new Span { Text = "c. Támogatószövetek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Kolenchim: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Biztosítja a növekedő szövetek támogatását és rugalmasságát." },
new Span { Text = "\n" },
new Span { Text = "-Szklérencim: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Merevséget és védelmet biztosít a mechanikai stressz ellen." },
new Span { Text = "\n" },
new Span { Text = "d. Tárolószövetek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Tároló parenchima: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Tápanyagokat, például keményítőt és olajokat tárol a gyökerekben, szárakban és magokban." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Ezek a bonyolult szövetek olyan funkcionális hálózatot alkotnak, amely támogatja a növények életképességét, biztosítva számukra az alkalmazkodóképességet és a túlélési képességet különböző környezetekben." }

            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Рослинні тканини:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "У складній структурі рослин, рослинні тканини є важливою частиною, забезпечуючи структурну підтримку, транспорт речовин і ріст організму. Вони поділяються на дві основні категорії: меристематичні тканини і постійні тканини." },
new Span { Text = "\n" },
new Span { Text = "1. Меристематичні тканини:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "Меристематичні тканини відповідають за первинний та вторинний ріст рослин, а також за виробництво нових клітин. Вони поділяються на:" },
new Span { Text = "\n" },
new Span { Text = "a. Первинна меристема:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Апікальна меристема: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Знаходиться на вершині кореня та стебла, сприяє поздовжньому росту." },
new Span { Text = "\n" },
new Span { Text = "-Інтеркалярна меристема: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Присутня на рівні вузлів у стеблі, забезпечує подовження міжвузлових сегментів рослини." },
new Span { Text = "\n" },
new Span { Text = "-Латеральна меристема: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Знаходиться під корою стебла та кореня, сприяє збільшенню товщини рослини." },
new Span { Text = "\n" },
new Span { Text = "б. Вторинна меристема або камбій:", FontAttributes = FontAttributes.Bold },
new Span { Text = "-Судинний камбій: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Виробляє вторинні судинні тканини, ксилему та флоему, які дозволяють збільшення товщини рослини." },
new Span { Text = "\n" },
new Span { Text = "-Кірковий камбій: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Виробляє вторинну кіркову тканину, збільшуючи товщину кори." },
new Span { Text = "\n" },
new Span { Text = "2. Постійні тканини:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "Постійні тканини складаються з зрілих клітин і виконують спеціалізовані функції в рослині. Вони включають:" },
new Span { Text = "a. Захисні тканини:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Епідерміс: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Зовнішній шар рослин, що складається з клітин, які захищають від втрати води та проникнення патогенних організмів." },
new Span { Text = "\n" },
new Span { Text = "-Перидерма: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Замінює епідерміс у багаторічних рослин, забезпечуючи захист від механічного стресу та інфекцій." },
new Span { Text = "\n" },
new Span { Text = "б. Провідні тканини:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Ксилема: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Транспортує воду та мінеральні речовини від коренів до інших частин рослини." },
new Span { Text = "\n" },
new Span { Text = "-Флоема: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Транспортує синтезовані органічні речовини, такі як цукор, від листя та інших фотосинтетичних органів до інших частин рослини." },
new Span { Text = "\n" },
new Span { Text = "в. Опорні тканини:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Коленхіма: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Забезпечує підтримку та гнучкість зростаючих тканин." },
new Span { Text = "\n" },
new Span { Text = "-Склеренхіма: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Забезпечує жорсткість та захист від механічного стресу." },
new Span { Text = "\n" },
new Span { Text = "г. Тканини зберігання:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "-Паренхіма зберігання: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Зберігає поживні речовини, такі як крохмаль і олії, у коренях, стеблах і насінні." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Ці складні тканини утворюють функціональну мережу, яка підтримує життєздатність рослин, забезпечуючи їм адаптивність і здатність виживати в різних середовищах." },

            }
        };
    }
}
