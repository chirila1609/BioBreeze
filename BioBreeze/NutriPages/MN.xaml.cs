using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.NutriPages;

public partial class MN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public MN() : this(AudioManager.Current)
    {
    }

    public MN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("mn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_MN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutriMN());
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
                new Span { FontSize = 15, Text = "Nutriția mixotrofă reprezintă o modalitate unică prin care unele organisme, inclusiv anumite plante, își obțin hrana din mai multe surse, combinând caracteristici ale fotosintezei cu capturarea și digestia unor organisme sau substanțe organice." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Plantele carnivore sunt exemplul iconic al nutriției mixotrofe în regnul vegetal. Deși majoritatea plantelor își obțin substanțele nutritive din fotosinteză, plantele carnivore au dezvoltat adaptări pentru a suplimenta această sursă de hrană cu substanțe provenite din animale mici, cum ar fi insectele, nevertebratele sau alte organisme mici." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Unul dintre cele mai cunoscute exemple de plante carnivore este Nepenthes, cunoscută sub numele de planta gură-de-tun, care își atrage prada în cupele sale pline cu un lichid digestiv. Alte exemple includ Drosera (sundew), care are frunze acoperite cu tentacule lipicioase pentru a captura insecte, și Sarracenia (pitcher plant), care are un tub lung și în formă de trompă pentru a atrage și digera prada." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Adaptările acestor plante pentru nutriția mixotrofă includ structuri specializate pentru capturarea și digestia prăzii, cum ar fi glandele digestive, enzimele specifice și mecanisme pentru a evita auto-digestia. Cu toate că plantele carnivore obțin substanțe nutritive din pradă, fotosinteza continuă să fie o componentă esențială a metabolismului lor, asigurându-le o sursă suplimentară de energie și substanțe nutritive." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, nutriția mixotrofă, exemplificată de plantele carnivore, demonstrează adaptările ingenioase ale organismelor pentru a supraviețui în medii cu resurse limitate și oferă o perspectivă fascinantă asupra diversității și complexității vieții pe Pământ." },
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
                new Span { Text = "Міксотрофне живлення:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Міксотрофне живлення - це унікальний спосіб, за допомогою якого деякі організми, включаючи деякі рослини, отримують їжу з кількох джерел, поєднуючи риси фотосинтезу з захопленням та перетравленням інших організмів або органічних речовин." },
new Span { Text = "\n" },
new Span { Text = "М'ясоїдні рослини - це іконічний приклад міксотрофного живлення у рослинному світі. Більшість рослин отримують поживні речовини за допомогою фотосинтезу, але м'ясоїдні рослини розвинули адаптації для доповнення цього джерела їжі речовинами, отриманими від малих тварин, таких як комахи, безхребетні або інші малі організми." },
new Span { Text = "\n" },
new Span { Text = "Один з найвідоміших прикладів м'ясоїдних рослин - Непентес, відомий як рослина-пастка, яка приваблює свою здобич у свої келихи, наповнені травними соками. Інші приклади включають Дрозеру (росичка), яка має листя, покрите липкими щупальцями для захоплення комах, і Саррасенію (чашечкова рослина), яка має довгу трубчасту форму для приваблення та перетравлення здобичі." },
new Span { Text = "\n" },
new Span { Text = "Адаптації цих рослин до міксотрофного живлення включають спеціалізовані структури для захоплення та перетравлення здобичі, такі як травні залози, специфічні ферменти та механізми для уникнення самоперетравлення. Хоча м'ясоїдні рослини отримують поживні речовини від здобичі, фотосинтез залишається важливою складовою їхнього обміну речовин, забезпечуючи їм додатковий джерело енергії та поживних речовин." },
new Span { Text = "\n" },
new Span { Text = "У висновку, міксотрофне живлення, яке ілюструється м'ясоїдними рослинами, демонструє винахідливі адаптації організмів для виживання в умовах обмежених ресурсів і надає захоплюючий погляд на різноманіття та складність життя на Землі." },
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
                new Span { Text = "Kevert táplálkozás:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A kevert táplálkozás egyedi módszer, amellyel bizonyos szervezetek, beleértve néhány növényt is, táplálékukat több forrásból szerzik be, ötvözve a fotoszintézis jellemzőit a szervezetek vagy szerves anyagok elfogásával és emésztésével." },
new Span { Text = "\n" },
new Span { Text = "A húsevő növények az ikonikus példája a kevert táplálkozásnak a növényvilágban. Habár a legtöbb növény táplálékát a fotoszintézis útján szerezheti meg, a húsevő növények kifejlesztettek olyan alkalmazkodásokat, amelyek kiegészítik e táplálékszerzési forrást kis állatokból, például rovarokból, gerinctelenekből vagy más kis szervezetekből származó anyagokkal." },
new Span { Text = "\n" },
new Span { Text = "A húsevő növények legismertebb példája a Nepenthes, amelyet ragadozó növényként ismernek, és amely zsákszerű növényében emésztő folyadékkal teli poharakban vonzza a zsákmányát. Más példák a Drosera (napszamár), amelynek levélszövetén ragadós tapintású hajtások vannak a rovarok elkapására, és a Sarracenia (tölcsérnövény), amely hosszú, trombita alakú csövet használ zsákmányának csalogatására és emésztésére." },
new Span { Text = "\n" },
new Span { Text = "Ezen növények alkalmazkodásai a kevert táplálkozáshoz magukban foglalják a zsákmány elfogására és emésztésére szolgáló specializált szerkezeteket, mint például emésztőmirigyek, specifikus enzimek és mechanizmusok az önemésztés elkerülésére. Habár a húsevő növények táplálékot szereznek a zsákmányból, a fotoszintézis továbbra is fontos szerepet játszik anyagcseréjükben, biztosítva számukra a további energia- és tápanyagforrást." },
new Span { Text = "\n" },
new Span { Text = "Összefoglalva, a kevert táplálkozás, amely a húsevő növényekkel illusztrálódik, az organizmusok találékonyságát mutatja be a korlátozott erőforrásokkal rendelkező környezetben való túlélésre, és lenyűgöző betekintést nyújt a Földön tapasztalható élet sokféleségébe és bonyolultságába." },
new Span { Text = "\n" }
            }
        };
    }
}
