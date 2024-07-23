using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Vertebrate : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Vertebrate() : this(AudioManager.Current)
    {
    }

    public Vertebrate(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("vertebrate.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooVerte(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooVerte());
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
                new Span { Text = "Animalele vertebrate ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "sunt membri ai regnului Animalia care se caracterizează prin prezența unei coloane vertebrale sau a unui înlocuitor al acesteia. Această coloană vertebrală oferă sprijin și protecție pentru sistemul nervos central, care este de obicei format dintr-un creier și o măduvă spinării. Aceste animale sunt unele dintre cele mai diverse și bine adaptate creaturi de pe Pământ." },
new Span { Text = "\n\n" },
new Span { FontSize = 15, Text = "Există cinci clase principale de animale vertebrate:" },
new Span { Text = "\n" },
new Span { Text = "1. Pești: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Aceste creaturi trăiesc în mediul acvatic și sunt extrem de variate, adaptându-se la diferite habitate, de la oceanele adânci până la izvoarele de munte." },
new Span { Text = "\n" },
new Span { Text = "2. Amfibieni: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Amfibienii sunt cunoscuți pentru capacitatea lor de a trăi atât pe uscat, cât și în apă. Majoritatea amfibienilor trec printr-un ciclu de viață care include metamorfoza din ou în larvă și apoi în adult." },
new Span { Text = "\n" },
new Span { Text = "3. Reptile:", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Reptilele sunt vertebrate care își reglează temperatura corpului în principal prin expunerea la surse externe de căldură, cum ar fi soarele. Acestea includ șerpii, țestoasele, șopârlele și crocodilii." },
new Span { Text = "\n" },
new Span { Text = "4. Păsări: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Păsările sunt animale vertebrate cu corp acoperit de pene și care au capacitatea unică de a zbura. Cu toate acestea, nu toate păsările pot zbura; unele specii, cum ar fi struții și pinguinii, nu zboară." },
new Span { Text = "\n" },
new Span { Text = "5. Mamifere:", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Mamiferele sunt vertebrate cu sânge cald care se caracterizează prin prezența glandelor mamare, care produc lapte pentru hrănirea puiilor. Acestea includ o gamă largă de animale, de la câini și pisici la balene și elefanți." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Fiecare clasă de animale vertebrate are adaptări unice care le permit să supraviețuiască și să prospere în mediile lor specifice. De la agilitatea unui leopard în junglă la capacitatea unei balene de a trăi în adâncurile oceanului, diversitatea și complexitatea lumii animalelor vertebrate sunt cu adevărat uimitoare." }

            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "A gerinctelen állatok:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A gerinctelen állatok egy lenyűgöző és változatos része az állatvilágnak. Ezek a gerinctelen lények, akik nem rendelkeznek gerinccel, a Földön található életformák között a legnépesebbek és legváltozatosabbak. Hihetetlen sokféle környezetben találhatók, a mély óceánoktól kezdve az aszályos sivatagokon át egészen saját kertjeinkig." },
new Span { Text = "\n" },
new Span { Text = "A legismertebb és legváltozatosabb gerinctelen állatcsoportok egyike az ízeltlábúak. Ezek magukba foglalják az ízeltlábúakat, mint például rovarokat, pókszerűeket, rákokat és soklábúakat. A rovarok, színes szárnyaikkal és az alkalmazkodóképességükkel a lenyűgöző életközösségek széles skálájában találhatók meg, és talán a legismertebbek minden gerinctelen között. Az elegáns lepkéktől a konyhai csótányokig és a szorgos hangyákig, a rovarok mindennapjaink részévé váltak.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A pókszerűek, mint például a pókok és a skorpiók, szintén megosztják világunkat. Vadászati képességeikkel és pókhálójuk építésével ezek a lenyűgöző lények vegyes félelmet és csodálatot kelthetnek az emberekben. Míg néhány pókszerű mérgező és veszélyes lehet az emberek számára, sok más teljesen ártalmatlan és létfontosságú szerepet játszik a rovarpopulációk szabályozásában.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A rákok, beleértve a rákokat, a garnélarákokat és a homárokat, főként vízi élőhelyeken élnek, a mély óceánoktól a parti édesvízi területekig. Ezek a gerinctelenek külső páncélból és ízületes végtagokból állnak, amelyeket különböző környezetekhez alkalmazkodva fejlesztettek ki, a korallzátonyoktól a mély tengeri barlangokig.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az ízeltlábúakon kívül a gerinctelen állatok világa más lenyűgöző csoportokat is magában foglal. Például a mennyek, a jellemző kagylóikkal a kerti csigáktól a mélytengeri polipokig terjednek. Az echinodermák, amelyek a tengeri csillagokat és a tengeri uborkákat foglalják magukban, egyedülálló érrendszerrel rendelkeznek, és gyakran találkoznak a tengeri ökoszisztémákban.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Összességében a gerinctelen állatok létfontosságú részét képezik a globális biológiai sokféleségnek. Különböző ökológiai nicheket töltenek be, és hihetetlen változatosságot hoznak létre a természetes világban. A légköri rovaroktól a tengerfenéken járó hatalmas rákokig, a gerinctelen állatok megfogják a figyelmünket, és sok mindent megtanítanak a Föld életének csodálatos változatosságáról.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" }

            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Тварини безхребетні:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Тварини безхребетні є захопливою та різноманітною частиною царства тварин. Ці істоти, які не мають хребета, є одними з найчисельніших та найрізноманітніших форм життя на Землі. Вони можуть бути знайдені в неймовірному різноманітті середовищ, від глибин океану до обійстя власних садів." },
new Span { Text = "\n" },
new Span { Text = "Один з найвідоміших та різноманітніших груп безхребетних - це артроподи. Серед них належать безхребетні, такі як комахи, павукоподібні, ракоподібні та міріаподи. Комахи, з їхніми кольоровими крилами та здатністю адаптуватися до неймовірного різноманіття місць існування, є, можливо, найвідомішими серед усіх безхребетних. Від елегантних метеликів до тарганів кухонних і працьовитих мурашок, комахи є всеприсутніми в нашому щоденному житті.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Павукоподібні, такі як павуки та скорпіони, також поділяють наш світ. З їхніми мисливськими здібностями та спорудженням павутин, ці захоплюючі створіння можуть викликати суміш страху і захоплення серед людей. Тоді як деякі павукоподібні є отруйними і можуть бути небезпечними для людей, багато інших є абсолютно безпечними і відіграють важливу роль у контролі популяцій комах.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Ракоподібні, включаючи крабів, креветок і лобстерів, живуть переважно в водних середовищах, від глибин океану до прісноводних узбережжів. Ці безхребетні мають зовнішню панцирну оболонку і суглобові кінцівки, адаптовані до життя в різних середовищах, від коралових рифів до глибоких морських печер.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Окрім артропод, світ безхребетних включає й інші захоплюючі групи. Наприклад, молюски, з їхніми характерними раковинами, варіюються від садових раковин до глибоководних восьминогів. Ехінодерми, які включають морські зірки та морські огірки, мають унікальну судинну систему і часто зустрічаються в морських екосистемах.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Загалом, безхребетні тварини є суттєвою частиною глобальної біорізноманітності. Вони займають різноманітні екологічні ніші та приносять неймовірне різноманіття у природному світі. Від малих комах, які летять повітрям, до гігантських ракоподібних, які рухаються по дну океану, безхребетні тварини цікавлять нас і навчають багато про чудове різноманіття життя на Землі.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" }

            }
        };
    }
}
