using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class SsiC : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SsiC() : this(AudioManager.Current)
    {
    }

    public SsiC(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ssic.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooSsiC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooSsiC());
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
                    new Span { FontSize = 15, Text = "Spongierii și celenteratele sunt două grupuri fascinante de organisme acvatice care, deși diferite în multe aspecte, împărtășesc anumite caracteristici și contribuie la diversitatea vieții marine." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Spongierii, cunoscuți și sub numele de bureți de mare, sunt organisme simple, de obicei fixate pe substraturi dure în apele sărate și dulci. Acești invertebrați au o structură unică, alcătuită dintr-un schelet intern de fibre proteice numite spongina, îmbibat cu o rețea de canale prin care apa circulă. Spongierii sunt, de asemenea, cunoscuți pentru capacitatea lor de a filtra apa și de a se hrăni cu particule microscopice din mediul lor." },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Pe de altă parte, celenteratele sunt organisme cu simetrie radială, printre care se numără meduzele, coraliile și anemonele de mare. Aceste creaturi fascinante au tentacule în jurul gurii, folosite pentru a captura prada și pentru apărare. Unul dintre trăsăturile distinctive ale celenteratelor este prezența cnidocitelor, celule specializate care conțin nematociste, structuri în formă de arpagic folosite pentru paralizarea prăzii sau pentru apărare." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Deși spongierii și celenteratele sunt organisme marine, ele ocupă nișe ecologice diferite și au strategii de viață distincte. Spongierii sunt adesea găsiți în adâncimi variabile și sunt esențiali pentru ecosistemele recifelor de corali, contribuind la ciclul substanțelor nutritive și oferind adăpost pentru multe alte organisme marine. Pe de altă parte, celenteratele, cum ar fi meduzele, pot fi întâlnite în toate oceanele lumii, de la suprafața apei până în adâncurile abisale." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Deși spongierii și celenteratele sunt în general organisme simple din punct de vedere structural, ele joacă un rol crucial în echilibrul și diversitatea ecosistemelor marine. Studiul acestor creaturi ne ajută să înțelegem mai bine evoluția vieții pe Pământ și impactul pe care îl avem asupra mediului lor fragil." },
                    new Span { Text = "\n\n" }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Szivacsok és Cnidáriák:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A szivacsok és a cnidáriák két lenyűgöző vízi szervezet csoportja, amelyek bár sok szempontból különböznek egymástól, bizonyos jellemzőket megosztanak, és hozzájárulnak a tengeri élet sokféleségéhez." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A szivacsok, amelyeket tengeri szivacsokként is ismernek, egyszerű szervezetek, általában kemény aljzatokon rögzülve a sós és édesvizekben. Ezek az ízeltlábúak egyedi szerkezettel rendelkeznek, amely belső rostos fehérjevázat tartalmaz, amelyet szponginnak neveznek, és amelyet egy víz keringtető hálózat átitat. A szivacsok ismertek víz szűrő és mikroszkopikus részecskék táplálásának képességével." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A cnidáriák viszont sugárirányú szimmetriájú szervezetek, amelyek közé tartoznak a medúzák, korallák és tengeri anémonák. Ezek a lenyűgöző lények szájuk körül tentakulumokkal rendelkeznek, amelyeket zsákmány begyűjtésére és védekezésre használnak. A cnidáriák egyik jellegzetes tulajdonsága a csalánsejtek jelenléte, amelyek speciális sejtek, amelyek nesztoriszta szerkezeteket tartalmaznak, amelyeket a zsákmány bénítása vagy védelme érdekében használnak." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Bár a szivacsok és a cnidáriák tengeri szervezetek, különböző ökológiai niche-ket foglalnak el, és különböző életstratégiákkal rendelkeznek. A szivacsok gyakran megtalálhatók különböző mélységekben, és nélkülözhetetlenek a korallzátonyok ökoszisztémái számára, hozzájárulva a tápanyagciklushoz és számos más tengeri szervezet menedékéül szolgálva. Másrészről a cnidáriák, mint például a medúzák, megtalálhatók a világ összes óceánjában, a víz felszínétől a mély tengeri árkokig." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Bár a szivacsok és a cnidáriák általában egyszerű szervezetek szerkezetileg, kulcsszerepet játszanak a tengeri ökoszisztémák egyensúlyában és sokféleségében. Ezeknek a lényeknek a tanulmányozása segít jobban megérteni az élet evolúcióját a Földön, valamint azt a hatást, amelyet mi gyakorlunk sérülékeny környezetükre." },
                    new Span { Text = "\n\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Szivacsok és Cnidáriák:" },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Bár a szivacsok és a cnidáriák általában egyszerű szervezetek szerkezetileg, kulcsszerepet játszanak a tengeri ökoszisztémák egyensúlyában és sokféleségében. Ezeknek a lényeknek a tanulmányozása segít jobban megérteni az élet evolúcióját a Földön, valamint azt a hatást, amelyet mi gyakorlunk sérülékeny környezetükre." },
                    new Span { Text = "\n\n" }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Спонжії та цнідарії:" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Спонжії та цнідарії є двома захоплюючими групами водних організмів, які, хоча різні за багатьма аспектами, мають певні спільні риси і сприяють різноманітності морського життя." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Спонжії, відомі також як морські губки, є простими організмами, зазвичай закріпленими на твердих підстилках у солонуватій та прісній воді. Ці безхребетні мають унікальну структуру, що складається з внутрішнього скелета білкових волокон, званих спонгін, пропитаного мережею каналів, через які циркулює вода. Спонжії також відомі своєю здатністю фільтрувати воду і живитися мікроскопічними частинками з їхнього середовища." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "З іншого боку, цнідарії є організмами з радіальною симетрією, до яких входять медузи, корали та морські анемони. Ці захоплюючі створіння мають тентаклі навколо рота, які використовуються для захоплення здобичі та захисту. Однією з відмінних рис цнідарій є наявність спеціалізованих клітин, які містять нематоцисти, структури в формі стрілок, що використовуються для паралізування здобичі або для захисту." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Хоча спонжії та цнідарії є морськими організмами, вони займають різні екологічні ніші та мають відмінні життєві стратегії. Спонжії часто зустрічаються на різних глибинах і є важливими для рифових екосистем, сприяючи циклу поживних речовин і надаючи притулок багатьом іншим морським організмам. З іншого боку, цнідарії, такі як медузи, можуть бути знайдені у всіх океанах світу, від поверхні води до глибоких бездонь морів." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Незважаючи на те, що спонжії та цнідарії в цілому є простими організмами за своєю структурою, вони відіграють ключову роль у рівновазі та різноманітності морських екосистем. Вивчення цих створінь допомагає нам краще зрозуміти еволюцію життя на Землі та вплив, який ми маємо на їхнє вразливе середовище." },
                    new Span { Text = "\n\n" }
                }
        };
        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Спонжії та цнідарії:" },
                    new Span { Text = "\n" }
                }
        };
        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Незважаючи на те, що спонжії та цнідарії в цілому є простими організмами за своєю структурою, вони відіграють ключову роль у рівновазі та різноманітності морських екосистем. Вивчення цих створінь допомагає нам краще зрозуміти еволюцію життя на Землі та вплив, який ми маємо на їхнє вразливе середовище." },
                    new Span { Text = "\n\n" }
                }
        };
    }
}
