using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class EV : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EV() : this(AudioManager.Current)
    {
    }

    public EV(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ev.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenEV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenEV());
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
                new Span { FontSize = 15, Text = "Ereditatea și variabilitatea sunt două concepte fundamentale în biologie, care stau la baza evoluției și diversității vieții pe Pământ. Ereditatea se referă la transmiterea trăsăturilor genetice de la părinți la urmași prin intermediul materialului genetic, ADN-ul (acidul dezoxiribonucleic). ADN-ul poartă informația genetică într-un cod specific de nucleotide și este responsabil pentru moștenirea caracteristicilor biologice de la o generație la alta." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Variabilitatea, pe de altă parte, se referă la variațiile individuale în cadrul unei populații sau specii. Această variație poate fi observată într-o gamă largă de trăsături, incluzând aspectul fizic, comportamentul, și adaptările la mediu. Variabilitatea este rezultatul combinației între ereditate și influențele mediului înconjurător." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Procesele de ereditate și variabilitate sunt esențiale pentru evoluție. Mutatiile genetice, recombinarea genetică și selecția naturală sunt mecanisme cheie care determină variabilitatea genetică în cadrul unei populații și, în cele din urmă, conduc la adaptarea la mediu și apariția de noi specii." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, ereditatea și variabilitatea sunt elemente centrale în înțelegerea evoluției vieții pe Pământ. Aceste concepte sunt fundamentale pentru biologie și au o importanță majoră în cercetările științifice, contribuind la elucidarea originii și diversității formelor de viață din întreaga lume." },
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
                new Span { Text = "Öröklődés és változatosság:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az öröklődés és változatosság két alapvető fogalom a biológiában, amelyek az evolúció és az élet sokféleségének alapjait képezik a Földön. Az öröklődés az a folyamat, amely során a genetikai tulajdonságok átadódnak a szülőktől az utódokhoz a genetikai anyag, azaz a DNS (dezoxiribonukleinsav) révén. A DNS egy specifikus nukleotidkód formájában hordozza a genetikai információt, és felelős a biológiai tulajdonságok generációról generációra történő öröklődéséért." },
new Span { Text = "\n" },
new Span { Text = "A változatosság ezzel szemben egy populáción vagy fajon belüli egyéni eltérésekre utal. Ez a variáció széles körű tulajdonságokban figyelhető meg, beleértve a fizikai megjelenést, a viselkedést és a környezeti alkalmazkodásokat. A változatosság az öröklődés és a környezeti hatások kombinációjának eredménye." },
new Span { Text = "\n" },
new Span { Text = "Az öröklődés és változatosság folyamatai elengedhetetlenek az evolúcióhoz. A genetikai mutációk, a genetikai rekombináció és a természetes szelekció kulcsfontosságú mechanizmusok, amelyek meghatározzák a genetikai változatosságot egy populáción belül, és végül a környezeti alkalmazkodáshoz és új fajok megjelenéséhez vezetnek." },
new Span { Text = "\n" },
new Span { Text = "Összefoglalva, az öröklődés és a változatosság központi elemek az élet evolúciójának megértésében a Földön. Ezek a fogalmak alapvetőek a biológiában, és jelentős szerepet játszanak a tudományos kutatásokban, hozzájárulva az életformák eredetének és sokféleségének megvilágításához szerte a világon." },
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
                new Span { Text = "Спадковість і мінливість:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Спадковість і мінливість - це два фундаментальні поняття в біології, які лежать в основі еволюції та різноманітності життя на Землі. Спадковість відноситься до передачі генетичних ознак від батьків до нащадків за допомогою генетичного матеріалу, ДНК (дезоксирибонуклеїнова кислота). ДНК несе генетичну інформацію у специфічному коді нуклеотидів і відповідає за спадкування біологічних характеристик від одного покоління до іншого." },
new Span { Text = "\n" },
new Span { Text = "Мінливість, з іншого боку, відноситься до індивідуальних відмінностей у межах популяції або виду. Ця варіація може спостерігатися у широкому спектрі ознак, включаючи зовнішній вигляд, поведінку та адаптації до навколишнього середовища. Мінливість є результатом поєднання спадковості та впливів навколишнього середовища." },
new Span { Text = "\n" },
new Span { Text = "Процеси спадковості та мінливості є важливими для еволюції. Генетичні мутації, генетична рекомбінація та природний відбір - це ключові механізми, які визначають генетичну мінливість у популяції і, зрештою, призводять до адаптації до навколишнього середовища та виникнення нових видів." },
new Span { Text = "\n" },
new Span { Text = "Отже, спадковість і мінливість є центральними елементами в розумінні еволюції життя на Землі. Ці поняття є основоположними для біології і мають велике значення в наукових дослідженнях, сприяючи з'ясуванню походження та різноманітності форм життя по всьому світу." },
new Span { Text = "\n" }
            }
        };
    }
}
