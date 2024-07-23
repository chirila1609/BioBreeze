using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Limba : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Limba() : this(AudioManager.Current)
    {
    }

    public Limba(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("limba.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieLimba(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieLimba());
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
                    new Span { FontSize = 15, Text = "Limba umană este un organ complex și esențial al sistemului respirator și al aparatului digestiv, cu multiple funcții vitale, printre care gustarea, masticarea, înghițirea și vorbirea. Este situată în cavitatea orală și este responsabilă pentru producerea sunetelor folosite în comunicare, precum și pentru gustul și textura alimentelor." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Structura limbii umane este alcătuită din mai multe elemente, inclusiv mușchii, papilele gustative, papilele linguale, glandele salivare și mucoasa orală. Mușchii limbii permit mișcarea acesteia în interiorul cavitatei orale, ceea ce facilitează procesul de masticare și înghițire. Papilele gustative sunt situate pe suprafața limbii și sunt responsabile pentru detectarea gusturilor diferite, cum ar fi dulce, sărat, acru și amar. Papilele linguale sunt mici proeminențe situate pe suprafața limbii care contribuie la textura sa și la percepția gusturilor. Glandele salivare produc salivă, care ajută la umectarea și lubrifierea alimentelor și la începerea procesului de digestie în cavitatea orală. Mucoasa orală este stratul de țesut care acoperă interiorul cavității orale și protejează limba și alte structuri împotriva leziunilor și infecțiilor." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Una dintre cele mai importante funcții ale limbii este vorbirea. Prin mișcarea și poziționarea diferitelor părți ale limbii, precum și prin controlul fluxului de aer și rezonanța în cavitățile nazale și bucale, sunetele sunt produse și modulate pentru a forma cuvinte și propoziții. Limba joacă, de asemenea, un rol crucial în procesul de înghițire, ajutând la direcționarea alimentelor către faringe și apoi spre esofag pentru a fi transportate în stomac." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Pe lângă funcțiile sale fizice, limba umană are și o semnificație culturală și socială profundă. Prin intermediul limbii, oamenii pot exprima gânduri, sentimente, idei și informații, facilitând comunicarea și interacțiunea între indivizi și comunități. Limbajul este un aspect fundamental al identității umane și este esențial pentru dezvoltarea și perpetuarea culturii și civilizației umane." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "În concluzie, limba umană este un organ complex și multifuncțional, având atât roluri fiziologice vitale, cum ar fi gustarea, masticarea și înghițirea, cât și roluri sociale și culturale, cum ar fi vorbirea și comunicarea. Structura și funcționarea sa reflectă interacțiunea complexă dintre aspectele biologice, psihologice, sociale și culturale ale existenței umane." },
                    new Span { Text = "\n" },
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Az emberi nyelv egy bonyolult és nélkülözhetetlen szerv a légzőrendszer és emésztőrendszer részeként, számos életfontosságú funkcióval, mint például az ízlelés, rágás, nyelés és beszéd. A szájüregben található, és felelős a kommunikációban használt hangok létrehozásáért, valamint az ételek ízéért és textúrájáért." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az emberi nyelv szerkezete több elemet foglal magában, beleértve az izmokat, ízlelőbimbókat, nyelvi bimbókat, nyálmirigyeket és a szájüreg nyálkahártyáját. Az izmok lehetővé teszik a nyelv mozgását a szájüregen belül, így segítve a rágás és nyelés folyamatát. Az ízlelőbimbók a nyelv felületén helyezkednek el, és felelősek különböző ízek érzékeléséért, mint például édes, sós, savanyú és keserű. A nyelvi bimbók kis kiemelkedések a nyelv felszínén, amelyek hozzájárulnak annak textúrájához és az ízek észleléséhez. A nyálmirigyek nyálat termelnek, amely segít az ételek nedvesítésében és kenésében, valamint elindítja az emésztési folyamatot a szájüregben. A szájüreg nyálkahártyája a szövetréteg, amely borítja a szájüreg belsejét, és védi a nyelvet és más szerkezeteket sérülésektől és fertőzésektől." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az egyik legfontosabb funkciója a beszéd. A nyelv különböző részeinek mozgatásával és pozícionálásával, valamint a levegőáramlás és rezonancia irányításával az orr- és szájüregben hangokat hozunk létre és formálunk, hogy szavakat és mondatokat alkossunk. A nyelv szintén kulcsszerepet játszik a nyelési folyamatban, segítve az ételek irányítását a garatba, majd az ételcsőbe a gyomorba történő szállításhoz." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A fizikai funkcióin túl az emberi nyelv mély kulturális és társadalmi jelentőséggel bír. A nyelv segítségével az emberek kifejezhetik gondolataikat, érzéseiket, ötleteiket és információikat, elősegítve a kommunikációt és az interakciót az egyének és közösségek között. A nyelv alapvető szerepet játszik az emberi identitásban, és nélkülözhetetlen a kultúra és civilizáció fejlődéséhez és fenntartásához." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Összefoglalva, az emberi nyelv egy bonyolult és sokoldalú szerv, amely fontos fiziológiai funkciókat lát el, mint például az ízlelés, rágás és nyelés, valamint társadalmi és kulturális szerepeket, mint például a beszéd és a kommunikáció. Szerkezete és működése tükrözi az emberi létezés biológiai, pszichológiai, társadalmi és kulturális összetett kölcsönhatásait." },
                    new Span { Text = "\n" },
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Людська мова є складним і важливим органом дихальної системи та травного апарату, з численними життєво важливими функціями, включаючи смакування, жування, ковтання та мовлення. Вона розташована в ротовій порожнині і відповідає за створення звуків, що використовуються в комунікації, а також за смак і текстуру їжі." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Структура людської мови складається з різних елементів, включаючи м'язи, смакові рецептори, мовні смакові рецептори, слинні залози та слизову оболонку ротової порожнини. М'язи мови дозволяють її рухатися в межах ротової порожнини, що сприяє процесу жування та ковтання. Смакові рецептори знаходяться на поверхні мови і відповідають за розпізнавання різних смаків, таких як солодкий, солоний, кислий та гіркий. Мовні смакові рецептори є невеликими виступами на поверхні мови, які сприяють її текстурі та сприйняттю смаків. Слинні залози виробляють слину, яка допомагає зволожувати та змащувати їжу та розпочинає процес травлення в ротовій порожнині. Слизова оболонка ротової порожнини є шаром тканини, який покриває внутрішність ротової порожнини і захищає мову та інші структури від ушкоджень та інфекцій." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Одна з найважливіших функцій мови - мовлення. Шляхом руху і позиціонування різних частин мови, а також контролю потоку повітря та резонансу в носових і ротових порожнинах, звуки створюються і модулюються для формування слів і речень. Мова також відіграє ключову роль у процесі ковтання, допомагаючи направляти їжу в глотку і потім в стравохід для перенесення до шлунка." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Поміж її фізичними функціями людська мова має глибоке культурне і соціальне значення. За допомогою мови люди можуть висловлювати думки, почуття, ідеї та інформацію, сприяючи комунікації та взаємодії між особами і спільнотами. Мова є фундаментальним аспектом людської ідентичності і є важливою для розвитку та підтримки культури і цивілізації." },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "У висновку, людська мова є складним і багатофункціональним органом, який виконує важливі фізіологічні функції, такі як смакування, жування і ковтання, а також соціальні і культурні функції, такі як мовлення і комунікація. Її структура і функціонування відображають складну взаємодію біологічних, психологічних, соціальних і культурних аспектів людського існування." },
                    new Span { Text = "\n" },
                }
        };
    }
}
