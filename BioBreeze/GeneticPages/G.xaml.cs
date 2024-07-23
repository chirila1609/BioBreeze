using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class G : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public G() : this(AudioManager.Current)
    {
    }

    public G(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("g.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenG(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenG());
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
                new Span { FontSize = 15, Text = "Genele reprezintă unitățile fundamentale ale eredității și sunt responsabile de transmiterea trăsăturilor de la părinți la urmași. Acestea sunt segmente de ADN (acid dezoxiribonucleic) localizate pe cromozomi și conțin informația genetică necesară pentru sinteza proteinelor și pentru funcționarea corectă a organismului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Structura și Funcția Genele sunt compuse din secvențe specifice de nucleotide, denumite bază azotate, care sunt adenină (A), citozină (C), guanină (G) și timină (T). Secvența acestor baze nucleotidice determină instrucțiunile genetice pentru sinteza proteinelor. În general, genele sunt formate din exoni (segmente de ADN care sunt transcrise în ARN mesager și ulterior traduse în proteine) și introni (segmente non-coding care sunt înlăturate în timpul procesului de transcripție)." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Funcția principală a genelor constă în controlul proceselor biologice, cum ar fi creșterea, dezvoltarea și metabolismul. Acestea influențează trăsăturile fizice și comportamentale ale organismelor, precum și susceptibilitatea la anumite boli sau afecțiuni. Unele gene acționează ca instrucțiuni pentru producerea anumitor proteine, în timp ce altele reglează activitatea altor gene sau sunt implicate în procese de reglare a expresiei genice." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Moștenirea și Variabilitatea Genetică Moștenirea genetică se realizează prin transmiterea genelor de la părinți la descendenți prin intermediul gametelor (ovule și spermatozoizi) în timpul reproducției sexuate. Variabilitatea genetică, rezultată din diferite combinații de gene, contribuie la diversitatea organismelor și la adaptabilitatea acestora la mediu." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Mutatiile genetice, care sunt modificări în secvența de ADN, pot apărea spontan sau pot fi cauzate de factori externi, cum ar fi radiațiile sau substanțele chimice. Unele mutații pot avea efecte negative și pot duce la boli genetice, în timp ce altele pot conferi avantaje în anumite medii sau pot fi neutre din punct de vedere al fenotipului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Impactul Geneticii în Medicină și Biotehnologie Studiul geneticii este crucial pentru înțelegerea bolilor genetice, precum și pentru dezvoltarea unor tratamente personalizate și terapii genice. Biotehnologia utilizează cunoștințele din domeniul genetic pentru a manipula și a modifica genele în scopuri terapeutice sau pentru a produce organisme modificate genetic în agricultură și în industria alimentară." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, genele reprezintă pilonii de bază ai eredității și sunt esențiale pentru diversitatea și funcționarea adecvată a vieții pe Pământ. Înțelegerea lor profundă are implicații profunde în medicină, agricultură și alte domenii ale științei și tehnologiei." },
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
                new Span { Text = "Gének:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A gének az öröklődés alapvető egységei, amelyek felelősek a tulajdonságok szülőktől utódokra történő átadásáért. Ezek a kromoszómákon található DNS (dezoxiribonukleinsav) szegmensek, amelyek tartalmazzák a fehérjeszintézishez és a szervezet megfelelő működéséhez szükséges genetikai információt." },
new Span { Text = "\n" },
new Span { Text = "Struktúra és Funkció:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A gének specifikus nukleotid szekvenciákból állnak, amelyeket bázispárok alkotnak: adenin (A), citozin (C), guanin (G) és timin (T). Ezeknek a bázisoknak a sorrendje határozza meg a fehérjeszintézis genetikai utasításait. Általánosságban a gének exonokból (DNS szegmensek, amelyek mRNS-be íródnak át és később fehérjékké fordítódnak) és intronokból (nem kódoló szegmensek, amelyeket az átírás során eltávolítanak) állnak." },
new Span { Text = "\n" },
new Span { Text = "A gének fő funkciója a biológiai folyamatok, például a növekedés, fejlődés és anyagcsere irányítása. Ezek befolyásolják az élőlények fizikai és viselkedési jellemzőit, valamint bizonyos betegségekre vagy állapotokra való hajlamukat. Egyes gének utasításokat adnak bizonyos fehérjék előállítására, míg mások más gének működését szabályozzák vagy a génexpresszió szabályozásában vesznek részt." },
new Span { Text = "\n" },
new Span { Text = "Öröklődés és Genetikai Változatosság:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A genetikai öröklődés a gének szülőktől utódokra történő átadásával valósul meg a gaméták (petesejtek és spermiumok) révén a szexuális szaporodás során. A különböző génkombinációkból eredő genetikai változatosság hozzájárul az élőlények sokféleségéhez és alkalmazkodóképességéhez a környezethez." },
new Span { Text = "\n" },
new Span { Text = "A genetikai mutációk, amelyek a DNS szekvencia változásai, spontán módon is előfordulhatnak, vagy külső tényezők, például sugárzás vagy vegyi anyagok okozhatják. Egyes mutációk negatív hatással lehetnek és genetikai betegségeket okozhatnak, míg mások előnyösek lehetnek bizonyos környezetekben vagy fenotípus szempontjából semlegesek lehetnek." },
new Span { Text = "\n" },
new Span { Text = "A Genetika Hatása az Orvostudományra és a Biotechnológiára:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A genetika tanulmányozása elengedhetetlen a genetikai betegségek megértéséhez, valamint személyre szabott kezelések és génterápiák kifejlesztéséhez. A biotechnológia a genetikai ismereteket felhasználva manipulálja és módosítja a géneket terápiás célokra vagy genetikailag módosított élőlények előállítására a mezőgazdaságban és az élelmiszeriparban." },
new Span { Text = "\n" },
new Span { Text = "Összefoglalva, a gének az öröklődés alapvető pillérei, amelyek nélkülözhetetlenek az élet sokféleségéhez és megfelelő működéséhez a Földön. Mély megértésüknek mélyreható hatásai vannak az orvostudományban, a mezőgazdaságban és a tudomány és technológia más területein." },
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
                new Span { Text = "Гени:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Гени - це основні одиниці спадковості, які відповідають за передачу ознак від батьків до нащадків. Вони є сегментами ДНК (дезоксирибонуклеїнова кислота), розташованими на хромосомах, і містять генетичну інформацію, необхідну для синтезу білків і правильного функціонування організму." },
new Span { Text = "\n" },
new Span { Text = "Структура і Функція:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Гени складаються зі специфічних послідовностей нуклеотидів, які називаються основами: аденін (A), цитозін (C), гуанін (G) і тимін (T). Послідовність цих нуклеотидних основ визначає генетичні інструкції для синтезу білків. Загалом гени складаються з екзонів (сегменти ДНК, які транскрибуються в мРНК і згодом транслюються в білки) і інтронів (некодуючі сегменти, які видаляються під час процесу транскрипції)." },
new Span { Text = "\n" },
new Span { Text = "Основна функція генів полягає в контролі біологічних процесів, таких як ріст, розвиток і метаболізм. Вони впливають на фізичні та поведінкові характеристики організмів, а також на схильність до певних хвороб або станів. Деякі гени діють як інструкції для виробництва певних білків, тоді як інші регулюють активність інших генів або беруть участь у процесах регуляції генетичної експресії." },
new Span { Text = "\n" },
new Span { Text = "Спадковість і Генетична Мінливість:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Генетична спадковість здійснюється шляхом передачі генів від батьків до нащадків через гамети (яйцеклітини та сперматозоїди) під час статевого розмноження. Генетична мінливість, яка виникає внаслідок різних комбінацій генів, сприяє різноманітності організмів і їх здатності адаптуватися до навколишнього середовища." },
new Span { Text = "\n" },
new Span { Text = "Генетичні мутації, які є змінами в послідовності ДНК, можуть виникати спонтанно або бути викликані зовнішніми факторами, такими як радіація або хімічні речовини. Деякі мутації можуть мати негативні наслідки і призводити до генетичних захворювань, тоді як інші можуть бути корисними в певних середовищах або нейтральними з точки зору фенотипу." },
new Span { Text = "\n" },
new Span { Text = "Вплив Генетики на Медицину та Біотехнологію:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Вивчення генетики є важливим для розуміння генетичних захворювань, а також для розробки персоналізованих методів лікування і генних терапій. Біотехнологія використовує знання з галузі генетики для маніпулювання та модифікації генів з терапевтичною метою або для виробництва генетично модифікованих організмів у сільському господарстві та харчовій промисловості." },
new Span { Text = "\n" },
new Span { Text = "Отже, гени є основними елементами спадковості, які є незамінними для різноманітності та належного функціонування життя на Землі. Глибоке розуміння їх впливає на медицину, сільське господарство та інші галузі науки і технологій." },
new Span { Text = "\n" }
            }
        };
    }
}
