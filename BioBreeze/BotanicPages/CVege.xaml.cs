using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class CVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public CVege() : this(AudioManager.Current)
    {
    }

    public CVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("cvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotCVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotCVege());
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
                    new Span { FontSize = 15, Text = "Circulația la plante este un proces esențial pentru viața și dezvoltarea lor sănătoasă. Deși în mod tradițional asociată cu sistemele circulatorii ale organismelor animate, plantele au evoluat pentru a dezvolta mecanisme proprii de transport al substanțelor vitale prin corpul lor." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Sistemul vascular la plante:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Principalul sistem responsabil de circulația la plante este sistemul vascular, care constă din două tipuri principale de țesuturi: xilem și floem. Xilemul este responsabil pentru transportul apei și substanțelor minerale de la rădăcini spre partea de sus a plantei, în timp ce floemul transportă substanțele organice, cum ar fi zaharurile, de la frunze spre alte părți ale plantei." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Transpirația și transpirația gutată:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Transpirația este un proces crucial în circulația la plante, prin care apa este absorbită de rădăcini, urcă prin xilem și este eliberată în aer prin stomatele din frunze. Acest proces ajută la menținerea echilibrului apei și la răcirea plantei. Transpirația gutată este un fenomen suplimentar, prin care apa este eliminată prin porii specializați de pe suprafața frunzelor sau alte părți ale plantei." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Circulația de substanțe organice:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Floemul este responsabil pentru transportul substanțelor organice, precum zaharurile și alte substanțe nutritive, de la zonele de producție, cum ar fi frunzele, spre alte părți ale plantei, inclusiv rădăcinile, mugurii și fructele. Acest proces este vital pentru creșterea și dezvoltarea plantelor." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Adaptări la medii variate:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Plantele au dezvoltat o varietate de adaptări pentru a face față diferitelor medii și condiții de creștere. De exemplu, plantele din medii uscate au evoluat pentru a avea mecanisme eficiente de conservare a apei, cum ar fi stomatele închise în timpul zilei. În schimb, plantele din medii umede pot avea sisteme vasculare mai puțin dezvoltate, deoarece nu trebuie să transporte apă pe distanțe mari." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Concluzie:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Circulația la plante este un proces complex și esențial pentru supraviețuirea și prosperitatea lor într-o varietate de medii. Sistemele vasculare și mecanismele de transport al substanțelor nutritive sunt adaptate pentru a satisface nevoile specifice ale fiecărei specii și ale mediului în care acestea se dezvoltă." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                   new Span { FontSize = 15, Text = "A növények keringése egy létfontosságú folyamat az életben maradásuk és egészséges fejlődésük szempontjából. Habár hagyományosan az élőlények keringési rendszereivel társították, a növények kifejlesztettek saját mechanizmusokat az életfontosságú anyagok szállítására testükön keresztül." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Növényi érrendszer:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A növények keringéséért legfőképpen a növényi érrendszer felelős, amely két fő típusú szövetből áll: xilém és floém. A xilém felelős a víz és ásványi anyagok szállításáért a gyökerektől a növény felső részei felé, míg a floém szállítja az organikus anyagokat, mint például a cukrokat, a levelekből a növény más részeibe." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Transzpiráció és gutációs transzpiráció:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A transzpiráció létfontosságú folyamat a növények keringésében, amely során a víz felszívódik a gyökerekből, feljut a xilémen keresztül, majd levegőbe juttatják a levelek stomatáin keresztül. Ez a folyamat segít a vízháztartás egyensúlyának fenntartásában és a növény hűtésében. A gutációs transzpiráció egy további jelenség, amikor a víz speciális pórusokon keresztül ürül ki a levelek vagy más növényrészek felszínén." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Organikus anyagok keringése:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A floém felelős az organikus anyagok, például a cukrok és egyéb tápanyagok szállításáért a termelési helyekről, mint például a levelek, a növény más részeibe, beleértve a gyökereket, rügyeket és gyümölcsöket. Ez a folyamat alapvető fontosságú a növények növekedéséhez és fejlődéséhez." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Adaptációk változatos környezetekhez:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A növények különböző adaptációkat fejlesztettek ki a különböző környezetek és növekedési feltételek kezelésére. Például a száraz környezetben élő növények hatékony vízmegtartási mechanizmusokat fejlesztettek ki, mint például a nappal zárt levelek. Ezzel szemben a nedves környezetben élő növények érrendszeri rendszere kevésbé fejlett lehet, mivel nem kell nagy távolságokon keresztül vizet szállítaniuk." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Következtetés:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A növények keringése egy összetett és létfontosságú folyamat a túlélésük és fejlődésük szempontjából különböző környezetekben. Az érrendszeri rendszerek és a tápanyagok szállításának mechanizmusai alkalmazkodtak minden faj és környezet specifikus igényeihez." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                   new Span { FontSize = 15, Text = "Циркуляція у рослин є важливим процесом для їхнього життя та здорового розвитку. Незважаючи на те, що традиційно асоціюється з кровоносними системами тварин, рослини еволюціонували для розвитку власних механізмів транспорту важливих речовин через їх тіла." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Рослинна васкулярна система:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Основною системою, відповідальною за циркуляцію у рослин, є васкулярна система, яка складається з двох основних типів тканин: ксилема та флоема. Ксилем відповідає за транспортування води та мінеральних речовин від коренів до верхньої частини рослини, у той час як флоем транспортує органічні речовини, такі як цукри, від листків до інших частин рослини." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Транспірація та гутаційна транспірація:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Транспірація є критичним процесом у циркуляції рослин, за допомогою якого вода поглинається коренями, підіймається по ксилемі та виділяється в повітря через стомати листків. Цей процес допомагає зберігати водний баланс та охолоджувати рослину. Гутаційна транспірація є додатковим явищем, коли вода виділяється через спеціалізовані пори на поверхні листків або інших частин рослини." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Циркуляція органічних речовин:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Флоем відповідає за транспортування органічних речовин, таких як цукри та інші поживні речовини, з виробничих зон, таких як листя, до інших частин рослини, включаючи корені, бруньки та плоди. Цей процес є важливим для зростання та розвитку рослин." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Адаптації до різноманітних середовищ:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Рослини розвинули різноманітні адаптації для подолання різних середовищ і умов зростання. Наприклад, рослини, які зростають у сухих середовищах, еволюціонували ефективні механізми збереження води, такі як закриті стомати вдень. З іншого боку, рослини, які зростають у вологих середовищах, можуть мати менш розвинені васкулярні системи, оскільки їм не потрібно транспортувати воду на великі відстані." },
                    new Span { Text = "\n\n" },
                    new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Циркуляція у рослин є складним і важливим процесом для їхнього виживання та процвітання у різних середовищах. Васкулярні системи та механізми транспортування поживних речовин адаптувалися до специфічних потреб кожного виду та середовища, в якому вони розвиваються." }
                }
        };
    }
}
