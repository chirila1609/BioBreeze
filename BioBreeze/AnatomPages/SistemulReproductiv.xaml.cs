using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulReproductiv : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulReproductiv() : this(AudioManager.Current)
    {
    }

    public SistemulReproductiv(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulreproductiv.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSRep(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSRep());
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
                    new Span { FontSize = 15, Text = "Sistemul reproductiv este unul dintre cele mai fundamentale și fascinante aspecte ale biologiei umane și a altor organisme vii. Acesta înglobează o serie complexă de organe, hormoni și procese care permit reproducerea și perpetuarea speciei." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "La femei, sistemul reproductiv este format din organele interne și externe. Organele interne includ ovarele, care produc ovulele, tuburile uterine, care transportă ovulele către uter, uterul, unde are loc fertilizarea și dezvoltarea embrionului, și vaginul, care permite introducerea spermei în tractul reproductiv. Organele externe, cum ar fi vulva, sunt responsabile pentru protecție și plăcere sexuală." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "La bărbați, sistemul reproductiv constă în principal din testicule, care produc spermatozoizii și hormonul testosteron, și organele reproductive externe, cum ar fi penisul și scrotul. Sperma este transportată de la testicule prin intermediul unui sistem complex de canale și este ejaculată prin penis în timpul actului sexual." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Reproducerea implică întâlnirea unui spermatozoid cu un ovul, proces cunoscut sub numele de fertilizare. Această întâlnire are loc de obicei în tuburile uterine. După fertilizare, ovulul fertilizat se divide și se dezvoltă într-un embrion, care este apoi implantat în uter pentru a continua să crească și să se dezvolte într-un fetus." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sistemul reproductiv este strâns reglat de către hormoni, cum ar fi estrogenul și progesteronul la femei și testosteronul la bărbați. Acești hormoni controlează ciclul menstrual la femei, producția de spermă la bărbați și alte aspecte ale funcționării sistemului reproductiv." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "A reproduktív rendszer az egyik leg alapvetőbb és legizgalmasabb aspektusa az emberi biológiának és más élő szervezeteknek. Ez egy bonyolult rendszer, amely szervekből, hormonokból és folyamatokból áll, amelyek lehetővé teszik a faj folytonosságának és fenntartásának." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "A nők reproduktív rendszere belső és külső szervekből áll. A belső szervek magukban foglalják a petefészkeket, amelyek termelik a petesejteket, a petevezetékeket, amelyek a petesejteket a méhbe szállítják, a méhet, ahol a megtermékenyítés és az embrió fejlődése zajlik, valamint a hüvelyt, amely lehetővé teszi a sperma bejutását a reproduktív traktusba. A külső szervek, mint például a vulva, felelősek a védelemért és a szexuális örömért." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "A férfiak reproduktív rendszere főként a herékből áll, amelyek a spermiumokat és a tesztoszteron hormont termelik, valamint a külső reproduktív szervekből, mint például a pénisz és a herezacskó. A spermiumokat a herékből egy bonyolult csatornarendszeren keresztül szállítják, és a szexuális aktus során a péniszen keresztül ürítik ki." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A reprodukció magában foglalja a spermium és petesejt találkozását, amit megtermékenyítésnek nevezünk. Ez a találkozás általában a petevezetékekben történik. A megtermékenyítés után a megtermékenyített petesejt osztódik és fejlődik embriónak, amelyet aztán a méhbe ültetnek be, hogy tovább növekedjen és fejlődjön magzattá." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A reproduktív rendszert szorosan szabályozzák hormonok, mint például az ösztrogén és a progeszteron a nőknél, valamint a tesztoszteron a férfiaknál. Ezek a hormonok irányítják a nők menstruációs ciklusát, a férfiak spermiumtermelését és a reproduktív rendszer működésének egyéb aspektusait." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Репродуктивна система є одним з найбільш фундаментальних і захоплюючих аспектів біології людини та інших живих організмів. Вона об'єднує складну систему органів, гормонів і процесів, які забезпечують репродукцію та збереження виду." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "У жінок репродуктивна система складається з внутрішніх і зовнішніх органів. Внутрішні органи включають яйники, які виробляють яйцеклітини, маткові труби, які транспортують яйцеклітини до матки, матку, де відбувається запліднення і розвиток ембріона, та вагіну, яка дозволяє введення сперми в репродуктивний тракт. Зовнішні органи, такі як вульва, відповідають за захист і сексуальне задоволення." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "У чоловіків репродуктивна система включає головним чином яєчка, які виробляють сперматозоїди і гормон тестостерон, і зовнішні репродуктивні органи, такі як пеніс і яєчка. Сперма транспортується з яєчок через складну систему каналів і викидається через пеніс під час статевого акту." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Репродукція включає зустріч сперматозоїда з яйцеклітиною, процес відомий як запліднення. Ця зустріч зазвичай відбувається в маткових трубах. Після запліднення оплодотворене яйцеклітина розділяється і розвивається в ембріон, який потім імплантується в матку для подальшого росту і розвитку в плід." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Репродуктивна система тісно регулюється гормонами, такими як естроген і прогестерон у жінок і тестостерон у чоловіків. Ці гормони контролюють менструальний цикл у жінок, вироблення сперми у чоловіків та інші аспекти функціонування репродуктивної системи." }
                }
        };
    }
}
