using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Moluste : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Moluste() : this(AudioManager.Current)
    {
    }

    public Moluste(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("moluste.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooMoluste(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooMoluste());
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
                new Span { Text = "Anatomia Moluștelor", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Majoritatea moluștelor prezintă o anatomie caracteristică, incluzând un corp moale acoperit de o cochilie. Această cochilie poate varia în formă și consistență, de la cochilii solide și robuste la cochilii subțiri și fragile. Multe moluște au un organ muscular numit „picior” care le ajută să se miște, să sape sau să se prindă de suprafețe. În plus față de picior, majoritatea moluștelor au și un organ intern numit mantie, care secretă cochilia și poate avea funcții diverse, precum respirația și excreția." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "\n" },
new Span { Text = "Diversitatea Moluștelor", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Moluștele prezintă o gamă incredibilă de forme și funcții. De la melci terestri care se deplasează încet pe frunzele umede ale pădurii până la calmari și caracatițe care trăiesc în adâncurile oceanului, diversitatea acestor creaturi este remarcabilă. Unele moluște sunt adaptate pentru sărături, altele pentru apă dulce, iar altele pentru viața marină. Există moluște care se hrănesc de pe fundul mării cu detritus, iar altele care sunt prădătoare eficiente." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Importanța Ecologică și Economică", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Moluștele joacă un rol crucial în ecosistemele marine și terestre. Ele servesc ca hrană pentru o varietate de alte animale, contribuie la reciclarea materiei organice și pot acționa ca indicatori ai sănătății ecosistemelor. De asemenea, unele moluște au o importanță economică semnificativă, fiind pescuite pentru consumul uman sau pentru colectarea cochiliilor pentru diverse scopuri, precum bijuteriile sau materialele de construcție." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, moluștele reprezintă un grup remarcabil de animale, cu o diversitate uimitoare și o importanță ecologică și economică considerabilă. Studierea și înțelegerea lor sunt esențiale pentru protejarea și conservarea diversității naturale a lumii noastre." }
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Molluszka Anatómia:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A legtöbb molluszka jellegzetes anatómiával rendelkezik, beleértve a lágy testet, amelyet kagyló borít. Ez a kagyló változhat formában és konzisztenciában, a szilárd és strapabíró kagylóktól a vékony és törékeny kagylókig. Sok molluszkának van egy izmos szervük, amit „lábnak” nevezünk, amely segít nekik mozogni, ásni vagy felkapaszkodni a felületekre. A „láb” mellett a legtöbb molluszk rendelkezik egy belső szervvel, amit köpenynevűnek hívnak, ami kagylót választ ki és különböző funkciókat lát el, mint például a légzés és a kiválasztás." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Molluszka Sokfélesége:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A molluszka különösen széles formák és funkciók spektrumával rendelkezik. A lassan mozgó szárazföldi csigáktól, a nedves erdőleveleken át a mély óceánokban élő tintahalakig és polipokig, ezeknek az élőlényeknek a sokfélesége lenyűgöző. Vannak olyan molluszkák, amelyek alkalmazkodtak a sós vizekhez, mások a édesvízi körülményekhez, és vannak, amelyek a tengeri élethez alkalmazkodtak. Vannak molluszkák, amelyek a tengerfenéken táplálkoznak, mások pedig hatékony ragadozók." },
new Span { Text = "\n" },
new Span { Text = "Ökológiai és Gazdasági Fontosság:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A molluszka kulcsszerepet játszanak a tengeri és szárazföldi ökoszisztémákban. Szolgálnak táplálékul más állatok számára, hozzájárulnak a szerves anyagok újrafelhasználásához és jelzőként szolgálhatnak az ökoszisztémák egészségére. Néhány molluszka jelentős gazdasági fontossággal bír, emberek fogyasztásra halászották őket, vagy kagylót gyűjtenek különféle célokra, például ékszerekhez vagy építőanyagokhoz." },
new Span { Text = "\n" },
new Span { Text = "Összegzés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A molluszka a Földön található legkülönfélébb és legérdekesebb állatcsoportok egyike. Képességük, hogy alkalmazkodjanak különböző környezetekhez és feltételekhez, összekapcsolva társas viselkedésüket és hatásukat az ökoszisztémákra, izgalmas tanulmányi tárggyá és fontossá teszik őket a bolygónk biológiai sokféleségének megértése és megőrzése szempontjából." }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Анатомія Молюсків:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Більшість молюсків мають характерну анатомію, включаючи м'яке тіло, покрите черепицею. Ця черепиця може варіюватися за формою і консистенцією, від твердих і міцних до тонких і крихких. Багато молюсків мають м'язовий орган, званий \"нога\", який допомагає їм рухатися, копати або прикріплюватися до поверхонь. Крім \"ноги\", більшість молюсків мають внутрішній орган, званий мантиєю, який виділяє черепицю і може мати різні функції, такі як дихання і виділення." },
new Span { Text = "\n" }
            }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Різноманіття Молюсків:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Молюски виявляють надзвичайно широкий спектр форм і функцій. Від сухопутних равликів, що повільно пересуваються по вологих листяних лісах, до кальмарів і восьминогів, що живуть у глибинах океану, різноманіття цих істот вражає. Деякі молюски адаптовані до солонури, інші до прісноводних умов, а ще інші до морського життя. Є молюски, які живляться на дні моря рослинним мусором, інші є ефективними хижаками." },
new Span { Text = "\n" },
new Span { Text = "Екологічне та Економічне Значення:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Молюски відіграють важливу роль у морських і сухопутних екосистемах. Вони служать їжею для різноманітних інших тварин, сприяють переробці органічних речовин і можуть діяти як показники здоров'я екосистем. Також деякі молюски мають значну економічну важливість, їх виловлюють для споживання людиною або для збору черепиці для різних цілей, таких як ювелірні вироби або будівельні матеріали." },
new Span { Text = "\n" },
new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Молюски є видатною групою тварин з надзвичайною різноманітністю і значною екологічною та економічною важливістю. Вивчення та розуміння їх є важливими для захисту та збереження природного різноманіття нашої планети." },
new Span { Text = "\n" },
            }
        };
    }
}
