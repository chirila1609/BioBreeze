using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Peste : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Peste() : this(AudioManager.Current)
    {
    }

    public Peste(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("peste.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooPeste(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooPeste());
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
                new Span { FontSize = 15, Text = "Pestii reprezintă un grup variat și fascinant de animale acvatice ce fac parte din subregatul vertebratelor. Aceștia sunt adaptabili la o mare diversitate de medii acvatice, de la râuri și lacuri până la oceane și recife de corali." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Există peste 30.000 de specii cunoscute de pesti, împărțite într-o gamă largă de familii și ordinuri. Acestea variază enorm în formă, mărime, culoare și comportament. De exemplu, pestii oscilează de la mici și transparenti, cum ar fi meduzele, până la giganticii rechini albi care domină oceanele." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Maiestria pestilor în mediul lor acvatic este evidențiată prin varietatea adaptărilor lor anatomice și comportamentale. Multe specii de pesti au solzi care le protejează corpul, înotătoare pentru deplasare și branhii pentru a extrage oxigenul din apa din jur. Altele au evoluat pentru a supraviețui în condiții extreme, cum ar fi adâncimile întunecate ale oceanelor sau în apele sărate ale marilor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Pestii sunt esențiali pentru echilibrul ecosistemelor acvatice. Ei servesc ca hrana pentru alte creaturi, ajută la menținerea curățeniei în apa prin consumul de alge și resturi organice și contribuie la dispersia nutrienților prin excremente. De asemenea, pestii sunt o resursă valoroasă pentru oameni, fiind o sursă importantă de hrană și venituri pentru comunitățile pescărești din întreaga lume." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Cu toate acestea, multe specii de pesti sunt amenințate de suprapescuit, degradarea habitatelor și schimbările climatice. Protejarea și conservarea acestor creaturi sunt cruciale pentru menținerea echilibrului ecologic al ecosistemelor acvatice și pentru sustenabilitatea resurselor piscicole pentru generațiile viitoare." },
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
                new Span { Text = "Halak:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A halak egy változatos és lenyűgöző vízi állatcsoportot képviselnek, amelyek a gerincesek altípusába tartoznak. Ezek az állatok alkalmazkodtak a vízi környezet széles skálájához, folyóktól és tavaktól kezdve az óceánokig és a korallzátonyokig." },
new Span { Text = "\n" },
new Span { Text = "Több mint 30,000 ismert hal faj létezik, amelyek széles körű családokba és rendekbe tartoznak. Ezek nagymértékben változnak alakjukban, méretükben, színükben és viselkedésükben. Például a halak lehetnek kicsik és átlátszók, mint a medúzák, vagy hatalmas fehér cápák, amelyek uralkodnak az óceánokban." },
new Span { Text = "\n" },
new Span { Text = "A halak mestersége a vízi környezetben az anatómiai és viselkedési alkalmazkodásaik sokféleségén keresztül nyilvánul meg. Sok hal fajnak védőpikkelyei vannak testük védelmére, uszonyaik a mozgásra és kopoltyúik az oxigén kinyerésére szolgálnak a körülöttük lévő vízből. Mások a túlélésre alkalmazkodtak extrém körülmények között, például az óceánok sötét mélységeiben vagy a tengerek sós vizeiben." },
new Span { Text = "\n" },
new Span { Text = "A halak elengedhetetlenek a vízi ökoszisztémák egyensúlyának fenntartásához. Szolgálnak táplálékként más élőlények számára, segítenek a víz tisztaságának fenntartásában, algák és szerves maradványok fogyasztásával, és hozzájárulnak a tápanyagok eloszlásához a kiválasztott anyagok révén. Emellett a halak értékes erőforrást jelentenek az emberek számára, fontos élelmiszerforrás és jövedelemforrás a világ minden tájáról származó halászati közösségek számára." },
new Span { Text = "\n" },
new Span { Text = "Azonban sok hal fajt fenyegeti a túlzott halászat, a természetes élőhelyek degradációja és a klímaváltozás. Ezeknek az állatoknak a megőrzése kritikus fontosságú a vízi ökoszisztémák egyensúlyának fenntartásához és a halászati erőforrások fenntarthatóságához a jövő generációi számára." },
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
                new Span { Text = "Риби:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Риби - різноманітна та захоплююча група водяних тварин, що належать до підтипу хребетних. Вони адаптовані до величезного різноманіття водних середовищ, від річок і озер до океанів і коралових рифів." },
new Span { Text = "\n" },
new Span { Text = "Існує понад 30,000 відомих видів риб, які належать до широкого спектру родин і орденів. Вони варіюються від малих і прозорих, таких як медузи, до гігантських великанів, таких як великі білі акули, які панують у світових океанах." },
new Span { Text = "\n" },
new Span { Text = "Майстерність риб у їхньому водному середовищі підкреслюється різноманіттям їх анатомічних і поведінкових адаптацій. Багато видів риб мають луску, що захищає їх тіло, плавці для переміщення та зябра для видобутку кисню з води. Інші адаптувалися для виживання в екстремальних умовах, таких як темрява глибин океанів або солоні води морів." },
new Span { Text = "\n" },
new Span { Text = "Риби є невід'ємними для екологічного балансу водних екосистем. Вони служать їжею для інших створінь, допомагають у підтримці чистоти води, споживаючи водорості та органічні залишки, і сприяють розподілу поживних речовин через відходи. Крім того, риби є цінним ресурсом для людей, що є важливим джерелом їжі та доходів для рибальських спільнот по всьому світу." },
new Span { Text = "\n" },
new Span { Text = "Однак багато видів риб знаходяться під загрозою через перенаселене рибальство, деградацію місць існування та зміни клімату. Збереження цих створінь є критичним для збереження екологічного балансу водних екосистем і стійкості рибних ресурсів для майбутніх поколінь." },
new Span { Text = "\n" }
            }
        };
    }
}
