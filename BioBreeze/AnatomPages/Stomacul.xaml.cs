using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Stomacul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player;

    public Stomacul() : this(AudioManager.Current)
    {
    }

    public Stomacul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("stomacul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieStom(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieStomac());
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
                    new Span {FontSize=15, Text="Stomacul este o parte esențială a sistemului digestiv uman, o cameră musculară în formă de sac situată în partea superioară a abdomenului. Funcționând ca un rezervor pentru alimente și un loc crucial pentru începerea procesului de digestie, stomacul are multiple roluri în transformarea alimentelor în substanțe nutritive absorbabile." },
                    new Span {Text = "\n" },
                    new Span {Text = "\n" },
                    new Span {FontSize = 15, Text = "Structura sa este adaptată pentru a descompune alimentele prin acțiunea sucurilor gastrice. Acestea conțin enzime și acid clorhidric, care descompun proteinele și ajută la sterilizarea alimentelor, protejând organismul de infecții." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Pe măsură ce alimentele sunt ingerate, stomacul le macină și le amestecă cu sucurile gastrice, transformându-le într-o substanță semilichidă cunoscută sub numele de chil. Acest chil este apoi eliberat treptat în intestinul subțire, unde continuă procesul de digestie și absorbție a nutrienților." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Stomacul este, de asemenea, dotat cu un strat protector de mucoasă care împiedică acidul să deterioreze pereții săi. Cu toate acestea, uneori, această mucoasă poate fi afectată, conducând la diverse afecțiuni cum ar fi ulcerul gastric." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Pe lângă rolul său în digestie, stomacul joacă un rol important în reglarea senzației de foame și de sațietate, trimițând semnale către creier pentru a indica când este momentul să mâncăm sau să ne oprim din alimentație." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Astfel, stomacul este un organ esențial pentru procesul de digestie și nutriție al organismului uman, contribuind în mod crucial la menținerea sănătății și a echilibrului intern." },
                    new Span {Text="\n" }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Gyomor: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A gyomor az emésztőrendszer fontos része, egy izmos, zsák alakú tér a has felső részén. Működése során tárolóként szolgál az ételek számára, és kulcsfontosságú hely az emésztési folyamat megkezdéséhez, számos szereppel a táplálékok átalakításában felszívható tápanyagokká.", FontSize = 16 },
new Span { Text = "Szerkezete alkalmas az ételek lebontására a gyomornedv hatására. Ez az emésztőnedv enzimeket és sósavat tartalmaz, amelyek lebontják a fehérjéket és segítenek az ételek sterilizálásában, védelmezve a szervezetet a fertőzésektől.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Az elfogyasztott ételekkel együtt a gyomor összemorzsoltatja és összekeveri a gyomornedvekkel, amelyek egy fél-folyékony anyaggá, az ún. kylévé alakítják. Ezután ez a kylé fokozatosan felszabadul a vékonybélbe, ahol folytatódik a táplálékok emésztésének és felszívódásának folyamata.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A gyomor továbbá egy védekező nyálkahártya réteggel van ellátva, amely megakadályozza, hogy a sav károsítsa a falát. Azonban néha ez a nyálkahártya károsodhat, különféle állapotokhoz vezetve, mint például a gyomorfekély.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Emésztési szerepe mellett a gyomor fontos szerepet játszik az éhség és telítettség érzetének szabályozásában, jeleket küldve az agynak, hogy mikor kell enni vagy leállítani az étkezést.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Ezáltal a gyomor nélkülözhetetlen szerv az emberi emésztő- és táplálkozási folyamatban, lényeges módon hozzájárulva az egészség és a belső egyensúly fenntartásához.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Шлунок: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Шлунок є важливою частиною людської травної системи, м'язовою камерою у вигляді мішка, розташованою в верхній частині черевної порожнини. Функціонуючи як резервуар для їжі та важливе місце для початку процесу травлення, шлунок виконує численні ролі в перетворенні їжі на поживні речовини, які можна поглинати.", FontSize = 16 },
new Span { Text = "Його структура пристосована для розщеплення їжі за допомогою дії шлункового соку. Він містить ферменти та соляну кислоту, які розщеплюють білки та допомагають стерилізувати їжу, захищаючи організм від інфекцій.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Приймаючи їжу, шлунок розмелює та змішує її з шлунковим соком, перетворюючи її на напіврідку речовину, відому як хіл. Потім цей хіл поступово вивільняється в тонкий кишечник, де продовжується процес травлення та поглинання поживних речовин.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Шлунок також оснащений захисним шаром слизової оболонки, який запобігає пошкодженню його стінок кислотою. Однак іноді ця слизова може пошкодитися, що призводить до різних захворювань, таких як виразкова хвороба шлунка.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Крім своєї ролі в травленні, шлунок відіграє важливу роль у регулюванні відчуття голоду та ситості, висилаючи сигнали до мозку, щоб показати, коли час їсти або зупинитися від харчування.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Таким чином, шлунок є невід'ємним органом у людському травленні та живленні, вирішальним чином сприяючи збереженню здоров'я та внутрішнього балансу.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
                }
        };
    }
}
