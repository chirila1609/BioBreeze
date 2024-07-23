using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class ADN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public ADN() : this(AudioManager.Current)
    {
    }

    public ADN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("adn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenADN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenADN());
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
                new Span { FontSize = 15, Text = "Acidul dezoxiribonucleic, cunoscut sub acronimul ADN, este o moleculă complexă și fascinantă care servește drept material genetic în majoritatea organismelor vii. Descoperit în anul 1869 de către chimistul elvețian Friedrich Miescher, ADN-ul reprezintă unul dintre pilonii fundamentali ai biologiei moleculare și geneticii moderne." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { FontSize = 15, Text = "Structura sa în formă de dublu helix, elucidată în anii 1950 de către James Watson și Francis Crick, este o realizare-cheie în știința biologică. Dubla helix constă din două lanțuri de nucleotide care se încolăcesc în jurul unuia altuia, formând o scară în spirală. Nucleotidele sunt compuse dintr-un zahăr (deoxiriboză), un grup fosfat și o bază azotată. Bazele azotate sunt adenina (A), citozina (C), guanina (G) și timina (T). Acest model structural oferă ADN-ului stabilitate și capacitatea de a stoca și transmite informații genetice într-un mod eficient." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Funcția principală a ADN-ului este de a codifica instrucțiunile necesare pentru dezvoltarea, funcționarea și moștenirea caracteristicilor organismelor vii. Aceste instrucțiuni sunt transmise sub formă de secvențe specifice de bază azotate, care determină secvența de aminoacizi în proteinele organismului. Proteinele sunt molecule esențiale pentru structura și funcționarea celulară, fiind implicate într-o varietate de procese biologice, cum ar fi metabolismul, replicarea celulară și răspunsul imun." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "ADN-ul este subiectul unor cercetări intense în diverse domenii științifice, cum ar fi biologia moleculară, genetică, medicina și biotehnologia. În medicină, înțelegerea ADN-ului și a mutațiilor sale asociate cu diferite boli a deschis noi posibilități în diagnosticare, tratament și chiar prevenirea unor afecțiuni genetice ereditare." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, ADN-ul este o moleculă esențială pentru viață și este responsabil pentru diversitatea și ereditatea caracteristicilor organismelor vii. Cunoașterea sa adâncă și exploatarea în diverse domenii ale științei au revoluționat înțelegerea noastră despre viață și au deschis drumuri noi pentru inovație și progres în domeniul biologic." },
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
                new Span { Text = "Dezoxiribonukleinsav:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "A dezoxiribonukleinsav, azaz DNS, egy összetett és lenyűgöző molekula, amely genetikai anyagként szolgál a legtöbb élő szervezetben. Az 1869-ben Friedrich Miescher svájci kémikus által felfedezett DNS a molekuláris biológia és a modern genetika egyik alapvető pillére." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { FontSize = 15, Text = "Az 1950-es években James Watson és Francis Crick által feltárt kettős spirál alakú szerkezete kulcsfontosságú eredmény a biológiai tudományban. A kettős spirál két nukleotidláncból áll, amelyek egymás köré csavarodnak, és spirális létrát alkotnak. A nukleotidok egy cukorból (dezoxiribóz), egy foszfátcsoportból és egy nitrogéntartalmú bázisból állnak. A nitrogéntartalmú bázisok az adenint (A), citozint (C), guanint (G) és timint (T) tartalmazzák. Ez a szerkezeti modell stabilitást és hatékony információtárolást biztosít a DNS számára." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "A DNS fő funkciója az élő szervezetek fejlődéséhez, működéséhez és öröklődéséhez szükséges utasítások kódolása. Ezeket az utasításokat specifikus nitrogéntartalmú bázisszekvenciák formájában továbbítják, amelyek meghatározzák a szervezet fehérjéinek aminosavszekvenciáját. A fehérjék alapvető molekulák a sejtszerkezet és a funkció szempontjából, és számos biológiai folyamatban részt vesznek, például az anyagcserében, a sejtosztódásban és az immunválaszban." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "A DNS különféle tudományos területeken, például a molekuláris biológiában, a genetikában, az orvostudományban és a biotechnológiában intenzív kutatások tárgya. Az orvostudományban a DNS és a különböző betegségekkel összefüggő mutációk megértése új lehetőségeket nyitott meg a diagnosztikában, a kezelésben és még a genetikai örökletes betegségek megelőzésében is." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Összegzésül, a DNS egy létfontosságú molekula, amely felelős az élő szervezetek tulajdonságainak sokféleségéért és öröklődéséért. Mélyreható ismerete és különböző tudományterületeken való alkalmazása forradalmasította az élet megértését, és új utakat nyitott meg az innováció és a biológiai fejlődés számára." }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Дезоксирибонуклеїнова кислота:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { FontSize = 15, Text = "Дезоксирибонуклеїнова кислота, відома під абревіатурою ДНК, є складною та захоплюючою молекулою, яка служить генетичним матеріалом у більшості живих організмів. Відкрита в 1869 році швейцарським хіміком Фрідріхом Мішером, ДНК є одним із основних стовпів молекулярної біології та сучасної генетики." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { FontSize = 15, Text = "Її подвійну спіральну структуру, з’ясовану в 1950-х роках Джеймсом Вотсоном і Френсісом Кріком, є ключовим досягненням у біологічній науці. Подвійна спіраль складається з двох ланцюгів нуклеотидів, які закручуються один навколо одного, утворюючи спіральну драбину. Нуклеотиди складаються з цукру (дезоксирибози), фосфатної групи та азотистої основи. Азотисті основи включають аденін (A), цитозин (C), гуанін (G) і тимін (T). Ця структурна модель забезпечує стабільність ДНК і здатність ефективно зберігати та передавати генетичну інформацію." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Основна функція ДНК полягає в кодуванні інструкцій, необхідних для розвитку, функціонування та успадкування характеристик живих організмів. Ці інструкції передаються у вигляді специфічних послідовностей азотистих основ, які визначають послідовність амінокислот у білках організму. Білки є основними молекулами для структури та функціонування клітин, вони беруть участь у різноманітних біологічних процесах, таких як метаболізм, клітинна реплікація та імунна відповідь." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "ДНК є предметом інтенсивних досліджень у різних наукових галузях, таких як молекулярна біологія, генетика, медицина та біотехнологія. У медицині розуміння ДНК та її мутацій, пов’язаних із різними захворюваннями, відкрило нові можливості в діагностиці, лікуванні та навіть профілактиці деяких спадкових генетичних захворювань." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "На закінчення, ДНК є основною молекулою для життя і відповідає за різноманітність і спадковість характеристик живих організмів. Глибоке знання і використання її в різних галузях науки революціонізували наше розуміння життя та відкрили нові шляхи для інновацій і прогресу в біологічній сфері." }
            }
        };
    }
}
