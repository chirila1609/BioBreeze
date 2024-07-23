using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Ficatul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Ficatul() : this(AudioManager.Current)
    {
    }

    public Ficatul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ficatul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieF(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieF());
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
                    new Span { FontSize = 15, Text = "Ficatul este un organ vital și complex, situat în partea dreaptă a abdomenului, sub coaste. Este esențial pentru funcționarea normală a corpului uman, îndeplinind o varietate de funcții critice pentru sănătatea noastră." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Primul lucru remarcabil despre ficat este capacitatea sa de a desfășura o gamă largă de funcții. Este un centru metabolic, responsabil pentru metabolizarea carbohidraților, grăsimilor și proteinelor din alimente, transformându-le în substanțe utilizabile de către corp. De asemenea, ficatul joacă un rol crucial în detoxifierea corpului, eliminând substanțele nocive sau toxice, cum ar fi alcoolul sau medicamentele." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Un alt aspect impresionant al ficatului este capacitatea sa de a produce bila, un lichid care ajută la digestia grăsimilor. Bila este stocată în vezica biliară și eliberată în intestinul subțire atunci când este nevoie să se descompună grăsimile din alimente." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Pe lângă aceste funcții metabolice și digestive, ficatul are și un rol important în sistemul imunitar al organismului. Acționează ca o barieră împotriva infecțiilor, neutralizând bacteriile și alte agenți patogeni care ar putea pătrunde în corp prin intestinul subțire." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mai mult decât atât, ficatul are un rol esențial în producerea unor substanțe vitale pentru coagularea sângelui. Fără această funcție, corpul ar fi expus unui risc ridicat de sângerare excesivă în caz de leziuni sau răni." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Cu toate aceste funcții cruciale, ficatul este un organ remarcabil în capacitatea sa de regenerare. Are capacitatea de a se vindeca și a-și restabili funcția chiar și după leziuni grave sau boli. Cu toate acestea, abuzul de alcool, expunerea la toxine sau bolile hepatice pot afecta negativ capacitatea de regenerare a ficatului." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "În concluzie, ficatul este unul dintre cele mai vitale organe din corpul uman, îndeplinind o varietate de funcții esențiale pentru sănătatea noastră generală. Îngrijirea și protejarea acestui organ sunt deosebit de importante pentru menținerea unei vieți sănătoase și echilibrate." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "A máj egy rendkívül fontos és összetett szerv, amely a has jobb oldalán, a bordák alatt található. Létfontosságú szerepet játszik az emberi test normális működésében, számos kritikus funkciót ellátva egészségünk szempontjából." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A máj egyik figyelemre méltó tulajdonsága, hogy széleskörű funkciókat képes ellátni. Ez az anyagcsere központja, felelős a szénhidrátok, zsírok és fehérjék anyagcseréjért az élelmiszerekből, azokat olyan anyagokká alakítva át, amelyeket a test hasznosítani tud. Emellett a máj kulcsfontosságú szerepet játszik a szervezet méregtelenítésében, eltávolítva a káros vagy toxikus anyagokat, mint például az alkohol vagy gyógyszerek." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A máj egyik másik lenyűgöző képessége, hogy epe termelésére képes, amely egy folyadék, ami segít a zsírok emésztésében. Az epe a epehólyagban tárolódik, és akkor szabadul fel a vékonybélben, amikor szükség van a táplálékok zsírtartalmának lebontására." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Ezen anyagcserei és emésztési funkciók mellett a máj fontos szerepet játszik a szervezet immunrendszerében is. Gátat szab az infekcióknak, semlegesítve a baktériumokat és más kórokozókat, amelyek bejuthatnak a szervezetbe a vékonybél útján." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Továbbá, a máj létfontosságú anyagokat termel a vérzéscsillapításhoz. E nélkül a funkció nélkül a szervezet nagyobb veszélynek lenne kitéve, túlzott vérvesztés esetén sérülések vagy balesetek következtében." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Minden ezen létfontosságú funkcióval a máj rendkívül képes visszanyerni szerkezetét és funkcióját súlyos sérülések vagy betegségek után is. Azonban az alkohol túlzott fogyasztása, toxikus anyagokkal való érintkezés vagy májbetegségek negatívan befolyásolhatják a máj regenerációs képességét." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Печінка - це життєво важливий і складний орган, який знаходиться в правій частині черевної порожнини, під ребрами. Вона виконує ряд критичних функцій для нормального функціонування людського організму." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Перше, на що варто звернути увагу щодо печінки, це її здатність виконувати широкий спектр функцій. Вона є центром обміну речовин, відповідає за метаболізм вуглеводів, жирів та білків з їжі, перетворюючи їх на речовини, придатні для використання організмом. Крім того, печінка виконує важливу роль у детоксикації організму, видаляючи шкідливі або отруйні речовини, такі як алкоголь або медикаменти." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Інший вражаючий аспект печінки - її здатність виробляти жовч, рідину, яка допомагає у травленні жирів. Жовч зберігається у жовчному міхурі і виділяється в тонкий кишечник у разі необхідності розщеплення жирів з їжі." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Окрім цих метаболічних та травних функцій, печінка відіграє важливу роль у імунній системі організму. Вона діє як бар'єр проти інфекцій, нейтралізуючи бактерії та інші патогени, які можуть проникнути в організм через тонкий кишечник." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Більше того, печінка грає важливу роль у виробництві життєво важливих речовин для згортання крові. Без цієї функції організм стає схильним до значного втрати крові при пораненнях або травмах." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "З усіма цими критичними функціями, печінка є надзвичайно відновлюваним органом. Вона може самостійно відновлювати свою структуру та функцію навіть після серйозних травм чи хвороб. Однак зловживання алкоголем, вплив токсинів або печінкові захворювання можуть негативно вплинути на її здатність до регенерації." }
                }
        };
    }
}
