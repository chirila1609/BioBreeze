using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Pasari : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Pasari() : this(AudioManager.Current)
    {
    }

    public Pasari(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("pasari.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooPasari(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooPasari());
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
                new Span { FontSize = 15, Text = "Păsările sunt unele dintre cele mai fascinante și diversificate creaturi care împânzesc cerul și pământul. Cu peste 10,000 de specii cunoscute, ele ocupă aproape fiecare colț al globului, de la înghețurile polare până la pădurile tropicale luxuriante și deșerturile aride. Aceste creaturi își trăiesc viețile cu un spectru larg de comportamente și adaptări, transformându-le în subiecte de interes pentru oameni de știință, pasionați de natură și simpli observatori." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Adaptări și Caracteristici", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Păsările sunt cunoscute pentru adaptările lor extraordinare la mediul lor de viață. De exemplu, ciocurile lor variază considerabil în formă și dimensiune, adaptându-se pentru a se hrăni cu o gamă diversă de alimente, inclusiv semințe, insecte, pești și chiar alte păsări. Aripile lor sunt perfect adaptate pentru zbor, cu structuri complexe care le oferă puterea și manevrabilitatea necesară pentru a naviga prin aer." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Multe specii de păsări sunt cunoscute pentru cântecele lor melodioase și variate. Aceste cântece servesc adesea la atragerea partenerilor sau la stabilirea teritoriului. De asemenea, penele lor colorate și modelele distinctive contribuie la comunicarea inter-speciilor și la camuflajul în medii diverse." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Comportament și Biologie", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Păsările sunt adesea socotite pentru comportamentul lor social complex. Multe specii formează perechi de viață lungă și sunt implicate în îngrijirea puiilor pentru o perioadă extinsă de timp. În plus, migrația este un aspect crucial al vieții multor păsări, cu rute elaborate și destinații care se întind pe mii de kilometri." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Cât despre biologie, sistemul lor respirator este unul dintre cele mai eficiente din regnul animal, permițându-le să zboare la înălțimi extreme și să trăiască în medii cu niveluri scăzute de oxigen. De asemenea, păsările sunt cunoscute pentru inteligența lor, cu anumite specii care demonstrează abilități complexe de învățare și rezolvare a problemelor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Impactul Asupra Oamenilor și Mediului", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Păsările au avut întotdeauna un impact semnificativ asupra vieții umane și a ecosistemelor în care trăiesc. Ele servesc ca indicatori ai sănătății mediului înconjurător, reflectând schimbările în habitate și poluare. De asemenea, păsările sunt esențiale pentru echilibrul ecologic, contribuind la controlul populațiilor de insecte și la dispersia semințelor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Pe lângă aceste aspecte, păsările au influențat cultura umană de-a lungul istoriei, fiind subiecte ale artei, mitologiei și literaturii. Ele au inspirat oamenii să zboare și să exploreze, și au devenit simboluri ale libertății și a spiritului aventurier." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, păsările sunt creaturi remarcabile, adaptate la o varietate impresionantă de medii și moduri de viață. Prin diversitatea lor, comportamentul lor fascinant și impactul lor asupra lumii, ele continuă să captiveze și să inspire oamenii de pe întregul glob." }

            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Madarak:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A madarak az egyik leginkább lenyűgöző és változatos teremtmények, amelyek az eget és a földet borítják. Több mint 10,000 ismert fajukkal majdnem mindenhol megtalálhatók a világon, a sarkvidéki jégtábláktól kezdve a buja trópusi erdőkön át a száraz sivatagokig. Ezek a teremtmények széles spektrumú viselkedéssel és alkalmazkodással élnek, amelyeket a tudósok, a természetkedvelők és az egyszerű megfigyelők érdeklődése is felkelt." },
new Span { Text = "\n" },
new Span { Text = "Alkalmazkodások és jellemzők:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A madarakat rendkívüli alkalmazkodóképességük miatt ismerik. Például csőrük jelentősen különbözik formájukban és méretben, alkalmazkodva a különböző élelemfajtákhoz, beleértve a magvakat, rovarokat, halakat és más madarakat is. Szárnyaik tökéletesen alkalmazkodtak a repüléshez, összetett szerkezetük segíti őket a levegő navigálásában szükséges erő és manőverezőképesség biztosításában." },
new Span { Text = "\n" },
new Span { Text = "Sok madárfaj ismert dallamos és változatos énekeikről. Ezek az énekek gyakran szolgálnak a partnerek vonzására vagy területük meghatározására. Színpompás tollazatuk és jellegzetes mintázataik is hozzájárulnak az fajok közötti kommunikációhoz és a különböző környezetekben való álcázáshoz." },
new Span { Text = "\n" },
new Span { Text = "Viselkedés és biológia:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A madarak gyakran összetett társas viselkedésük miatt ismertek. Sok faj hosszú távú párokat alkot és hosszú ideig gondoskodik utódaikról. Emellett a migráció sok madár életének fontos része, bonyolult útvonalakkal és több ezer kilométerre terjedő célpontokkal." },
new Span { Text = "\n" },
new Span { Text = "Biológiájuk szempontjából légzőrendszerük az állatok között az egyik legkifinomultabb, lehetővé téve számukra, hogy nagy magasságokba repüljenek és oxigénszegény környezetben éljenek. Emellett intelligenciájuk ismert, néhány faj komplex tanulási és problémamegoldó képességeket mutat.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Hatás az emberekre és a környezetre:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A madarak mindig is jelentős hatással voltak az emberek életére és azokra az ökoszisztémákra, amelyekben élnek. Ezek szolgálnak a környezet egészségének mutatójaként, tükrözve a környezetváltozásokat és a szennyezést. Emellett nélkülözhetetlenek az ökológiai egyensúly fenntartásához, hozzájárulva a rovarpopulációk szabályozásához és a magvak elterjesztéséhez." },
new Span { Text = "\n" },
new Span { Text = "Emellett a madarak jelentősen befolyásolták az emberi kultúrát az idők során, művészet, mitológia és irodalom tárgyai voltak. Inspirálták az embereket a repülésre és felfedezésre, szabadság és kaland szimbólumaivá váltak." },
new Span { Text = "\n" },
new Span { Text = "Összegzésül, a madarak lenyűgöző lények, alkalmazkodva a különféle környezetekhez és életmódokhoz. Sokszínűségükkel, lenyűgöző viselkedésükkel és világra gyakorolt hatásukkal folytatják az emberek világszerte való lenyűgözését és inspirálását.", FontAttributes = FontAttributes.Bold }

            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Птахи:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Птахи - одні з найбільш захоплюючих і різноманітних істот, які підкорюють небо і землю. З більш ніж 10,000 відомих видів вони займають майже кожний куточок земної кулі, від полярних льодів до розкішних тропічних лісів і засушливих пустель. Ці створіння живуть своїми життями з широким спектром поведінки і адаптацій, що робить їх предметом інтересу для вчених, природолюбів та простих спостерігачів." },
new Span { Text = "\n" },
new Span { Text = "Адаптації та особливості:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Птахи відомі своїми надзвичайними адаптаціями до свого середовища. Наприклад, їх дзьоби значно відрізняються за формою та розміром, адаптуючись для живлення різноманітною їжею, включаючи насіння, комах, рибу і навіть інших птахів. Їх крила ідеально пристосовані для польоту, з складними структурами, які надають їм силу і маневреність, необхідні для навігації повітряним простором." },
new Span { Text = "\n" },
new Span { Text = "Багато видів птахів відомі своїми мелодійними та різноманітними співами. Ці співи часто служать для залучення партнерів або встановлення територій. Крім того, їх яскраве оперення і характерні малюнки сприяють комунікації між видами та камуфляжуванню в різноманітних середовищах." },
new Span { Text = "\n" },
new Span { Text = "Поведінка та біологія:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Птахи часто відомі своєю складною соціальною поведінкою. Багато видів формують довгострокові пари та беруть участь у догляді за пташенятами протягом тривалого часу. Крім того, міграція є важливою частиною життя багатьох птахів, з складними маршрутами та місцями призначення, які простягаються на тисячі кілометрів." },
new Span { Text = "\n" },
new Span { Text = "Щодо біології, їхній дихальний апарат є одним з найефективніших в царстві тварин, що дозволяє їм літати на великі висоти і жити в умовах з низьким рівнем кисню. Крім того, птахи відомі своєю інтелектуальністю, з деякими видами, які демонструють складні навчальні та проблемні вміння.", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Вплив на людей та середовище:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Птахи завжди мали значний вплив на життя людей і екосистеми, в яких вони живуть. Вони служать індикаторами здоров'я навколишнього середовища, відображаючи зміни в середовищі і забрудненні. Крім того, птахи є необхідними для екологічного балансу, сприяючи контролю популяцій комах і розповсюдженню насіння." },
new Span { Text = "\n" },
new Span { Text = "Крім цього, птахи вплинули на культуру людства протягом історії, були об'єктами мистецтва, міфології та літератури. Вони надихали людей на польоти і дослідження, стали символами свободи і пригодницького духу." },
new Span { Text = "\n" },
new Span { Text = "Загалом, птахи є видатними істотами, адаптованими до вражаючого різноманіття середовищ і способів життя. За їхньою різноманітністю, захоплюючим поведінком та впливом на світ вони продовжують захоплювати і надихати людей по всьому світу.", FontAttributes = FontAttributes.Bold }

            }
        };
    }
}
