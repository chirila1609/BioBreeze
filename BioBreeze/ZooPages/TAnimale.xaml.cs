using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class TAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public TAnimale() : this(AudioManager.Current)
    {
    }

    public TAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("tanimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooTAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooTAnimale());
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
                new Span { FontSize = 15, Text = "În regnul animal, țesuturile sunt structuri esențiale care formează baza organismelor multicelulare. Acestea sunt grupuri organizate de celule care își unesc funcțiile pentru a îndeplini anumite scopuri în organism. Există patru tipuri principale de țesuturi animale:" },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "1. Țesutul epitelial:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesutul epitelial acoperă suprafețele exterioare ale organismului și liniază suprafețele interioare ale cavităților și organelor. Este caracterizat prin celule strâns aliniate care formează o barieră protectoare împotriva substanțelor străine și a daunelor mecanice. Acesta poate fi stratificat sau simplu și poate fi găsit în organe precum pielea, membranele mucoase și tractul digestiv." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "2. Țesutul conjunctiv:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesutul conjunctiv este un țesut de susținere care leagă și protejează alte țesuturi și organe în corpul animal. Include o varietate de tipuri, cum ar fi țesutul conjunctiv moale (care include grăsimea și tendoanele), țesutul conjunctiv fibros (care formează ligamentele și fasciile) și țesutul conjunctiv osos (care formează oasele). De asemenea, este responsabil pentru producerea matricei extracelulare, care oferă susținere structurală și furnizează substanțe nutritive celulelor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "3. Țesutul muscular:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesutul muscular este specializat în contracție și generarea de mișcare. Există trei tipuri principale de țesut muscular: țesut muscular scheletic (care este atașat de oase și controlează mișcarea voluntară), țesut muscular neted (care este prezent în organele interne și controlează mișcările involuntare ale organelor) și țesut muscular cardiac (care formează inima și controlează mișcarea inimii)." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "4. Țesutul nervos:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Țesutul nervos este format din celule specializate numite neuroni, care conduc semnalele electrice prin corpul animal. Aceste semnale permit organismului să răspundă la stimuli externi și interni și să coordoneze activitățile sale. În plus față de neuroni, țesutul nervos include celule de suport numite celule gliale, care își ajută în funcționarea și protecția neuronilor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, țesuturile animale sunt fundamentale pentru funcționarea organismelor multicelulare, oferind structură, susținere, protecție și capacitatea de a răspunde la mediu. Fiecare tip de țesut are rolul său specific și contribuie la sănătatea și funcționarea adecvată a organismului animal." },
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
                new Span { Text = "Állati szövetek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az állatok birodalmában a szövetek azok az alapvető struktúrák, amelyek az többsejtű szervezetek alapját képezik. Ezek szervezett sejtcsoportok, amelyek összekapcsolják funkcióikat, hogy bizonyos célokat érjenek el a szervezetben. Az állati szöveteknek négy fő típusa van:" },
new Span { Text = "\n" },
new Span { Text = "1. Epitéliális szövet:" },
new Span { Text = "\n" },
new Span { Text = "Az epitéliális szövet kívülről borítja az állat testét és belső felületeit. Szorosan egymáshoz illeszkedő sejtekből áll, amelyek védőgátként szolgálnak a külső anyagok és mechanikai sérülések ellen. Lehet réteges vagy egyszerű, és megtalálható olyan szervekben, mint a bőr, a nyálkahártyák és az emésztőrendszer." },
new Span { Text = "\n" },
new Span { Text = "2. Kötőszövet:" },
new Span { Text = "\n" },
new Span { Text = "A kötőszövet támogató szövet, amely összeköti és védi a test más szöveteit és szerveit. Tartalmazza a puha kötőszövetet (amely magában foglalja a zsírt és az ínokat), a rostos kötőszövetet (amely az ízületeket és fasciákat alkotja) és az oszteoközös kötőszövetet (amely a csontokat képezi). Felelős továbbá az extracelluláris mátrix termeléséért, amely strukturális támogatást biztosít és táplálékkal látja el a sejteket." },
new Span { Text = "\n" },
new Span { Text = "3. Izomszövet:" },
new Span { Text = "\n" },
new Span { Text = "Az izomszövet specializálódott a összehúzódásra és a mozgás generálására. Három fő típusú izomszövet létezik: a vázizomszövet (amely csontokhoz kapcsolódik és szabályozza a tudatos mozgást), a sima izomszövet (amely a belső szervekben található és szabályozza az észrevétlen szervmozgásokat) és a szívizomszövet (amely alkotja a szívet és szabályozza a szívmozgást)." },
new Span { Text = "\n" },
new Span { Text = "4. Idegszövet:" },
new Span { Text = "\n" },
new Span { Text = "Az idegszövet speciális sejtekből, úgynevezett neuronokból áll, amelyek elektromos jeleket vezetnek az állat testében. Ezek a jelek lehetővé teszik az állat számára, hogy reagáljon a külső és belső ingerekre, és koordinálja tevékenységeit. A neuronok mellett az idegszövet magában foglalja a támogató sejteket, úgynevezett gliasejteket, amelyek segítik a működésüket és védelmüket." },
new Span { Text = "\n" },
new Span { Text = "Következtetés: Az állati szövetek nélkülözhetetlenek a többsejtű szervezetek működéséhez, biztosítva számukra a szerkezetet, a támogatást, a védelmet és a környezethez való reakció képességét. Minden szövet típusnak megvan a saját specifikus szerepe, hozzájárulva az állat testének egészségéhez és megfelelő működéséhez." },
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
                new Span { Text = "Тканини тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "У царстві тварин тканини є основними структурами, які формують основу багатоклітинних організмів. Це організовані групи клітин, які об'єднують свої функції для досягнення певних цілей в організмі. Існує чотири основних типи тканин у тварин:" },
new Span { Text = "\n" },
new Span { Text = "1. Епітеліальна тканина:" },
new Span { Text = "\n" },
new Span { Text = "Епітеліальна тканина покриває зовнішні поверхні організму та вистилає внутрішні поверхні порожнин і органів. Вона характеризується тісно вирівняними клітинами, що утворюють захисний бар'єр проти чужорідних речовин і механічних пошкоджень. Ця тканина може бути шаровою або простою і знаходиться в органах, таких як шкіра, слизові оболонки та травний тракт." },
new Span { Text = "\n" },
new Span { Text = "2. З'єднувальна тканина:" },
new Span { Text = "\n" },
new Span { Text = "З'єднувальна тканина є опорною тканиною, яка з'єднує та захищає інші тканини та органи в тілі тварини. Вона включає різноманітні типи, такі як м'яка з'єднувальна тканина (яка включає жир та сухожилля), волокниста з'єднувальна тканина (яка утворює зв'язки та фасції) та кісткова з'єднувальна тканина (яка утворює кістки). Вона також відповідає за виробництво позаклітинної матриці, яка забезпечує структурну підтримку та постачає поживні речовини клітинам." },
new Span { Text = "\n" },
new Span { Text = "3. М'язова тканина:" },
new Span { Text = "\n" },
new Span { Text = "М'язова тканина спеціалізується на скороченні та генерації руху. Існує три основні типи м'язової тканини: скелетна м'язова тканина (яка прикріплюється до кісток і контролює добровільний рух), гладка м'язова тканина (яка присутня у внутрішніх органах і контролює непрохані рухи органів) та серцева м'язова тканина (яка формує серце і контролює рух серця)." },
new Span { Text = "\n" },
new Span { Text = "4. Нервова тканина:" },
new Span { Text = "\n" },
new Span { Text = "Нервова тканина складається з спеціалізованих клітин, що називаються нейронами, які проводять електричні сигнали через тіло тварини. Ці сигнали дозволяють організму реагувати на зовнішні та внутрішні подразники та координувати свої дії. Окрім нейронів, нервова тканина включає підтримуючі клітини, звані гліальні клітини, які допомагають у їх функціонуванні та захисті." },
new Span { Text = "\n" },
new Span { Text = "Висновок: тканини тварин є основою для функціонування багатоклітинних організмів, забезпечуючи їм структуру, підтримку, захист та здатність реагувати на навколишнє середовище. Кожен тип тканини має свою специфічну роль та сприяє здоров'ю та належному функціонуванню тіла тварини." },
new Span { Text = "\n" }

            }
        };
    }
}
