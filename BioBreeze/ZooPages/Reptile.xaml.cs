using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Reptile : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Reptile() : this(AudioManager.Current)
    {
    }

    public Reptile(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("reptile.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooReptile(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooReptile());
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
                new Span { FontSize = 15, Text = "Reptilele sunt un grup divers și fascinant de animale cu sânge rece, care includ șerpi, țestoase, șopârle și crocodilii. Aceste creaturi au evoluat pentru a trăi pe uscat, în apă și în aer, adaptându-se la o varietate de medii și condiții extreme de viață. În timp ce majoritatea reptilelor sunt carnivore, există și specii erbivore și omnivore în acest grup divers." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Unul dintre trăsăturile distinctive ale reptilelor este prezența solzilor pe pielea lor, care le oferă o protecție împotriva pierderii de apă și a prădătorilor. Acești solzi, de obicei, sunt formați din keratină, același material din care sunt făcute unghiile și părul la mamifere." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Majoritatea reptilelor se reproduc prin ouă, deși există câteva specii care nasc pui vii. Unele reptile, cum ar fi șerpii, își depun ouăle în locuri ascunse, în timp ce altele, precum crocodilii, își construiesc cu grijă cuiburi pentru ouăle lor. Perioada de incubație variază în funcție de specie și de condițiile de mediu." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Reptilele sunt deosebit de bine adaptate pentru a trăi într-o varietate de medii, de la deșerturi aride la jungle umede și râuri adânci. Unele specii, cum ar fi șerpii deșertului și șopârlele cu coadă scurtă, au dezvoltat abilități impresionante de supraviețuire în medii ostile, cum ar fi capacitatea de a supraviețui perioadelor lungi fără apă sau hrănire." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "De-a lungul istoriei, reptilele au captivat imaginația oamenilor și au fost subiect de mituri și legende în culturile din întreaga lume. De la reprezentările lor ca zei în mitologia egipteană la folosirea lor ca simboluri ale puterii și regalității în diverse culturi antice, reptilele au jucat un rol semnificativ în imaginarul uman." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Cu toate acestea, unele specii de reptile sunt în pericol din cauza pierderii habitatului, vânătorii excesive și schimbările climatice. Protejarea și conservarea habitatelor naturale ale acestor creaturi sunt cruciale pentru a asigura supraviețuirea lor pe termen lung." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, reptilele sunt creaturi fascinante și uimitoare, care au evoluat pentru a trăi într-o varietate de medii și condiții. Cu o istorie care se întinde pe milioane de ani și o diversitate remarcabilă de forme și comportamente, aceste animale continuă să inspire și să fascineze oamenii din întreaga lume." },
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
                new Span { Text = "Hüllők:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A hüllők egy sokszínű és lenyűgöző csoportja hidegvérű állatoknak, amelyek közé tartoznak a kígyók, teknősök, gyíkok és krokodilok. Ezek a lények adaptálódtak a szárazföldi, vízi és légi élethez, alkalmazkodva a különböző környezetekhez és az élet extrém feltételeihez. Habár a hüllők többsége ragadozó, ebben a sokszínű csoportban megtalálhatók növényevő és mindenevő fajok is." },
new Span { Text = "\n" },
new Span { Text = "A hüllők egyik jellegzetes jellemzője a bőrükön található pikkelyek jelenléte, amelyek védelmet nyújtanak számukra a vízvesztés és a ragadozók ellen. Ezek a pikkelyek általában keratinból készülnek, ugyanabból a anyagból, amelyből az emlősök körmei és szőrzete is." },
new Span { Text = "\n" },
new Span { Text = "A legtöbb hüllő tojásokkal szaporodik, bár vannak olyan fajok is, amelyek élve szülnek utódaikat. Néhány hüllő, mint például a kígyók, rejtekhelyekre helyezik el a tojásaikat, míg mások, mint a krokodilok, gondosan építenek fészkét a tojásaik számára. Az inkubációs idő a fajtól és a környezeti feltételektől függ." },
new Span { Text = "\n" },
new Span { Text = "A hüllők különösen jól alkalmazkodtak a különböző környezetekhez, a száraz sivatagoktól kezdve az nedves esőerdőkig és a mély folyókig. Néhány faj, például a sivatagi kígyók és a rövidfarkú gyíkok, lenyűgöző túlélési képességeket fejlesztettek ki ellenséges környezetekben, mint például a hosszú víz- és táplálék nélküli időszakok túlélésének képessége." },
new Span { Text = "\n" },
new Span { Text = "A történelem során a hüllők lenyűgözték az emberek képzeletét, és mítoszok és legendák témái voltak a világ különböző kultúráiban. Az egyiptomi mitológiában istenként való megjelenítésüktől kezdve az ősi kultúrákban a hatalom és királyi méltóság szimbólumaiként való felhasználásukig a hüllők jelentős szerepet játszottak az emberi képzeletben." },
new Span { Text = "\n" },
new Span { Text = "Azonban néhány hüllőfaj veszélyeztetett a természetes élőhelyek elvesztése, a túlzott vadászat és a klímaváltozás miatt. Ezeknek a lényeknek a természetes élőhelyeinek védelme és megőrzése létfontosságú a hosszú távú fennmaradásuk biztosításához." },
new Span { Text = "\n" },
new Span { Text = "Összességében a hüllők lenyűgöző és elképesztő lények, amelyek alkalmazkodtak a különböző környezetekhez és feltételekhez. A több millió éves történelemmel és a formák és viselkedések lenyűgöző sokféleségével ezek az állatok folytatják az emberek világszerte való megihletését és lenyűgözését." },
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
                new Span { Text = "Рептилії:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Рептилії - це різноманітна і захоплююча група тварин з холоднокровною кров'ю, до якої входять змії, черепахи, ящірки та крокодили. Ці створіння пристосувалися жити на суходолі, у воді та в повітрі, адаптуючись до різноманітних середовищ і екстремальних умов життя. Більшість рептилій є хижаками, але в цій різноманітній групі є і травоїдні та всеядні види." },
new Span { Text = "\n" },
new Span { Text = "Однією з відмітних рис рептилій є наявність луски на їх шкірі, які забезпечують їм захист від втрати води та ворогів. Ці луски, як правило, складаються з кератину, такого ж матеріалу, з якого зроблені нігті та волосся у ссавців." },
new Span { Text = "\n" },
new Span { Text = "Більшість рептилій розмножуються шляхом яєць, хоча є кілька видів, що народжують живих молодняків. Деякі рептилії, наприклад змії, відкладають свої яйця в сховані місця, тоді як інші, як крокодили, дбайливо будують гнізда для своїх яєць. Час інкубації варіюється залежно від виду та умов середовища." },
new Span { Text = "\n" },
new Span { Text = "Рептилії особливо добре пристосовані для життя в різноманітних середовищах, від сухих пустель до вологих джунглів та глибоких рік. Деякі види, наприклад пустельні змії та ящірки з короткими хвостами, розвинули вражаючі навички виживання в умовах, які багато в чому ворожі, таких як здатність виживати впродовж тривалих періодів без води або живлення." },
new Span { Text = "\n" },
new Span { Text = "Протягом історії рептилії захоплювали уяву людей і були предметом міфів та легенд у культурах по всьому світу. Від їх зображень як богів у єгипетській міфології до використання їх як символів влади та королівства в різних давніх культурах, рептилії відіграли значну роль у людській уяві." },
new Span { Text = "\n" },
new Span { Text = "Проте деякі види рептилій знаходяться під загрозою через втрату середовища, надмірне полювання та зміни клімату. Збереження та охорона природних місць існування цих створінь є важливими для забезпечення їх довгострокового виживання." },
new Span { Text = "\n" },
new Span { Text = "У підсумку, рептилії - це захоплюючі та дивовижні створіння, які пристосувалися для життя в різних середовищах і умовах. З відстежуваною історією мільйонів років і помітною різноманітністю форм і поведінок, ці тварини продовжують надихати і захоплювати людей по всьому світу." },
new Span { Text = "\n" }

            }
        };
    }
}
