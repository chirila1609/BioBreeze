using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulCirculator : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulCirculator() : this(AudioManager.Current)
    {
    }

    public SistemulCirculator(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulcirculator.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSC());
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
                    new Span { FontSize = 15, Text = "Sistemul circulator este unul dintre cele mai vitale sisteme din corpul uman, responsabil pentru transportul substanțelor nutritive, oxigenului și hormonilor către toate celulele și țesuturile, precum și pentru eliminarea deșeurilor metabolice și a dioxidului de carbon. Acest sistem este compus din inimă, vase de sânge și sânge." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Inima, motorul sistemului circulator, este un organ muscular situat în partea superioară a cavității toracice. Funcționând ca o pompă, inima împinge sângele prin vasele de sânge către toate părțile corpului. Inima are patru camere: două atrii și două ventricule, care se contractă și se relaxează într-un ritm coordonat pentru a pompa sângele." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Vasele de sânge sunt ca niște căi de transport care transportă sângele de la inimă către diferite organe și țesuturi, și înapoi la inimă. Există trei tipuri principale de vase de sânge: artere, vene și capilare. Arterele transportă sângele oxigenat de la inimă către țesuturi, venele aduc sângele sărac în oxigen înapoi la inimă, iar capilarele sunt vasele de legătură între artere și vene, unde se întâmplă schimbul de substanțe între sânge și țesuturi." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sângele este un lichid complex care conține celule roșii (eritrocite), celule albe (leucocite) și trombocite suspendate într-un lichid numit plasmă. Celulele roșii transportă oxigenul de la plămâni către țesuturi, celulele albe luptă împotriva infecțiilor, iar trombocitele ajută la coagularea sângelui pentru a opri sângerarea în caz de leziuni." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Серцево-судинна система є однією з найважливіших систем у людському організмі, відповідальною за транспортування поживних речовин, кисню та гормонів до всіх клітин і тканин, а також за видалення метаболічних відходів і вуглекислого газу. Ця система складається з серця, кровоносних судин і крові." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Серце, як мотор серцево-судинної системи, є м'язовим органом, розташованим у верхній частині грудної клітки. Діючи як насос, серце проганяє кров через кровоносні судини до всіх частин тіла. Серце має чотири камери: два передсердя і два шлуночки, які згортаються і розслабляються у відповідному ритмі для того, щоб проганяти кров." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Кровоносні судини схожі на транспортні шляхи, які переносять кров від серця до різних органів і тканин, і назад до серця. Існує три основних типи кровоносних судин: артерії, вени і капіляри. Артерії переносять оксигеновану кров від серця до тканин, вени привозять кров бідну на кисень назад до серця, а капіляри є зв'язуючими вазами між артеріями і венами, де відбувається обмін речовин між кров'ю і тканинами." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Кров - це складна рідина, яка містить червоні кров'яні клітини (еритроцити), білі кров'яні клітини (лейкоцити) і тромбоцити, що плавають у рідині, званій плазмою. Червоні кров'яні клітини переносять кисень з легенів до тканин, білі кров'яні клітини борються з інфекціями, а тромбоцити допомагають в згортанні крові для зупинки кровотечі при травмах." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "A keringési rendszer az egyik legvitalitásabb rendszer az emberi testben, felelős az tápanyagok, oxigén és hormonok szállításáért az összes sejtbe és szövetbe, valamint az anyagcsere-végső termékek és a szén-dioxid eltávolításáért. Ez a rendszer a szív, az érrendszer és a vér összetevőiből áll." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A szív, mint a keringési rendszer motorja, egy izomzatú szerv, amely a mellkas felső részén helyezkedik el. Mint egy szivattyú, a szív vérrel tolja az érrendszeren keresztül az egész test különböző részei felé. A szívnek négy kamrája van: két pitvar és két kamra, amelyek koordinált ritmusban összehúzódnak és lazítanak, hogy a vért pumpálják." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az érrendszer olyan közlekedési útvonalak, amelyek a szívből szállítják a vért a különböző szervekbe és szövetekbe, és vissza a szívbe. Három fő típusú érrendszer létezik: artériák, vénák és hajszálerek. Az artériák oxigéndús vért szállítanak a szívből a szövetekbe, a vénák pedig oxigénszegény vért szállítanak vissza a szívhez, míg a hajszálerek az artériák és a vénák közötti kapcsolói, ahol a vér és a szövetek közötti anyagcsere zajlik." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A vér egy összetett folyadék, amely vörösvérsejteket (eritrociták), fehérvérsejteket (leukociták) és vérlemezkéket tartalmaz, amelyek egy folyadékban úsznak, amelyet vérplazmának neveznek. A vörösvérsejtek oxigént szállítanak a tüdőből a szövetekbe, a fehérvérsejtek harcolnak az infekciók ellen, míg a vérlemezkék segítenek a vér koagulációjában, hogy megállítsák a vérzést sérülések esetén." }
                }
        };
    }
}
