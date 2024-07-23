using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Nevertebrate : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Nevertebrate() : this(AudioManager.Current)
    {
    }

    public Nevertebrate(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("nevertebrate.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooNeverte(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooNeverte());
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
                new Span { FontSize = 15, Text = "Animalele nevertebrate sunt o parte fascinantă și variată a regnului animal. Aceste creaturi, lipsite de o coloană vertebrală, sunt printre cele mai numeroase și diverse forme de viață de pe Pământ. Ele pot fi găsite într-o varietate incredibilă de medii, de la adâncimile oceanului până în deșerturi aride și chiar în propriile noastre grădini." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Unul dintre cele mai cunoscute și diverse grupuri de animale nevertebrate sunt artropodele. Acestea includ nevertebrate precum insecte, arahnide, crustacee și miriapode. Insectele, cu aripile lor colorate și abilitatea de a se adapta la o gamă incredibilă de habitate, sunt poate cele mai familiare dintre toate nevertebratele. De la fluturi eleganți la gândaci de bucătărie și furnici muncitoare, insectele sunt omniprezente în viața noastră de zi cu zi." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Arahnidele, cum ar fi păianjenii și scorpionii, împărtășesc, de asemenea, lumea noastră. Cu abilitățile lor de vânătoare și construcție de pânze de păianjen, aceste creaturi fascinante pot provoca un amestec de frică și admirație în rândul oamenilor. În timp ce unii arahnizi sunt veninoși și pot fi periculoși pentru oameni, mulți alții sunt complet inofensivi și joacă un rol vital în controlul populațiilor de insecte." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Crustaceele, incluzând crabii, creveții și homarul, trăiesc în principal în mediile acvatice, de la adâncimile oceanului până la apele dulci de coastă. Aceste nevertebrate au carapace exterioară și membre articulate, adaptate pentru viața în medii diverse, de la recifele de corali până la peșterile marine adânci." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În afară de artropode, lumea nevertebratelor include și alte grupuri fascinante. De exemplu, moluștele, cu cochiliile lor caracteristice, variază de la melci de grădină până la caracatițe de adâncime. Echinodermii, care includ stele de mare și castraveți de mare, au un sistem vascular unic și sunt adesea întâlniți în ecosistemele marine." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, animalele nevertebrate reprezintă o parte esențială a biodiversității globale. Ele ocupă o varietate de nișe ecologice și aduc o diversitate incredibilă în lumea naturală. De la micile insecte care zboară prin aer la crustaceele uriașe care umblă pe fundul oceanului, animalele nevertebrate ne fascinează și ne învață multe despre minunata diversitate a vieții pe Pământ." },
new Span { Text = "\n" }

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
new Span { Text = "Összességében a gerinctelen állatok létfontosságú részét képezik a globális biológiai sokféleségnek. Különböző ökológiai nicheket töltenek be, és hihetetlen változatosságot hoznak létre a természetes világban. A légköri rovaroktól a tengerfenéken járó hatalmas rákokig, a gerinctelen állatok megfogják a figyelmünket, és sok mindent megtanítanak a Föld életének csodálatos változatosságáról.", FontAttributes = FontAttributes.Bold }

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
new Span { Text = "Загалом, безхребетні тварини є суттєвою частиною глобальної біорізноманітності. Вони займають різноманітні екологічні ніші та приносять неймовірне різноманіття у природному світі. Від малих комах, які летять повітрям, до гігантських ракоподібних, які рухаються по дну океану, безхребетні тварини цікавлять нас і навчають багато про чудове різноманіття життя на Землі.", FontAttributes = FontAttributes.Bold }

            }
        };
    }
}
