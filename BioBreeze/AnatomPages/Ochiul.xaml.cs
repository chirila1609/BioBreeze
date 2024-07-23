using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Ochiul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Ochiul() : this(AudioManager.Current)
    {
    }

    public Ochiul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ochiul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieOCHI(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieOchi());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnRomanianClicked(object sender, EventArgs e)
    {
        SetRomanianContent();
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        SetHungarianContent();
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        SetUkrainianContent();
    }

    private void SetRomanianContent()
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Ochiul Uman", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Ochiul uman este un organ complex și fascinant responsabil pentru percepția vizuală. Este esențial nu numai pentru funcționarea cotidiană, ci și pentru experiența noastră senzorială și emoțională a lumii din jurul nostru." }
                }
        };

        ContentImage.Source = "ochi1.png";

        DetailsLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Structura Ochilor Umani", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Ochiul uman este alcătuit din mai multe componente esențiale:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Cornee: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este partea transparentă și convexă a ochiului care acoperă irisul și pupila. Corneea ajută la focalizarea luminii către retina." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Iris: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este membrana colorată a ochiului care controlează dimensiunea pupilei și, prin urmare, cantitatea de lumină care pătrunde în ochi." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. Pupila: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este deschiderea circulară din mijlocul irisului prin care lumina intră în ochi." },
                    new Span { Text = "\n" },
                    new Span { Text = "4. Retină: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este stratul sensibil la lumină al ochiului care convertește lumina în semnale electrice, transmițând informațiile vizuale către creier prin nervul optic." },
                    new Span { Text = "\n" },
                    new Span { Text = "5. Nervul optic: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este calea prin care semnalele vizuale sunt transmise de la retina la creier pentru interpretare." },
                    new Span { Text = "\n" },
                    new Span { Text = "6. Cristalin: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Este o lentilă transparentă care se află în spatele irisului și care ajută la focalizarea luminii pe retina." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Funcționarea Ochilor Umani", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Procesul de vedere implică mai multe etape complexe:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Focalizarea: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Lumina care intră în ochi este refractată de cornee și cristalin pentru a fi focalizată pe retina. Acest proces este esențial pentru a asigura claritatea imaginii." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Conversia în semnale electrice: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Celulele fotosensibile din retina, numite bastonașe și conuri, convertește lumina în semnale electrice. Bastonașele sunt implicate în percepția luminii și a contrastului, în timp ce conurile sunt responsabile pentru percepția culorilor." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. Transmiterea semnalelor către creier: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Semnalele electrice generate în retina sunt transmise de-a lungul nervului optic către creier, mai precis către cortexul vizual, unde sunt interpretate și transformate în imagini conștiente." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Importanța Ochilor Umani", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Ochiul uman este esențial pentru explorarea și înțelegerea lumii din jurul nostru. Capacitatea sa de a percepe culori, forme și mișcare ne permite să navigăm în mediul înconjurător și să interacționăm cu el în mod eficient. Ochiul uman este, de asemenea, un instrument valoros pentru exprimarea emoțiilor și comunicarea non-verbală, deoarece multe informații sunt transmise prin contactul vizual." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Îngrijirea adecvată a ochilor este crucială pentru menținerea sănătății lor pe termen lung. Vizitele regulate la oftalmolog, protejarea ochilor împotriva expunerii excesive la lumină ultravioletă și utilizarea corectă a ochelarilor sau a lentilelor de contact sunt câteva dintre modalitățile în care putem îngriji și proteja acest organ deosebit de important." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "În concluzie, ochiul uman reprezintă o minune a naturii, cu o complexitate și un potențial remarcabil. Capacitatea sa de a percepe lumea înconjurătoare este fundamentală pentru experiența umană și merită să fie protejată și prețuită." }
                }
        };
    }

    private void SetHungarianContent()
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Az Emberi Szem", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az emberi szem egy összetett és lenyűgöző szerv, amely a látásért felelős. Nemcsak a mindennapi működéshez, hanem a körülöttünk lévő világ érzékszervi és érzelmi tapasztalásához is elengedhetetlen." }
                }
        };

        ContentImage.Source = "ochi1.png";

        DetailsLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Az Emberi Szem Felépítése", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az emberi szem több alapvető összetevőből áll:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Szaruhártya: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Az átlátszó és domború rész a szem elülső részén, amely az íriszt és a pupillát fedi. A szaruhártya segít a fény fókuszálásában a retinára." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Írisz: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "A szem színes része, amely szabályozza a pupilla méretét, és így a szembe jutó fény mennyiségét." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. Pupilla: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Az írisz közepén lévő kör alakú nyílás, amelyen keresztül a fény bejut a szembe." },
                    new Span { Text = "\n" },
                    new Span { Text = "4. Retina: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "A fényérzékeny réteg a szemben, amely a fényt elektromos jelekké alakítja, és továbbítja a vizuális információkat az agyba a látóidegen keresztül." },
                    new Span { Text = "\n" },
                    new Span { Text = "5. Látóideg: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Az út, amelyen keresztül a vizuális jelek a retináról az agyba jutnak értelmezésre." },
                    new Span { Text = "\n" },
                    new Span { Text = "6. Lencse: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Az írisz mögött található átlátszó lencse, amely segít a fény fókuszálásában a retinára." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Az Emberi Szem Működése", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A látás folyamata több összetett lépést foglal magában:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Fókuszálás: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "A szembe jutó fény a szaruhártya és a lencse által fókuszálódik a retinára. Ez a folyamat elengedhetetlen a kép tisztaságának biztosításához." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Átalakítás elektromos jelekké: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "A retina fényérzékeny sejtjei, az úgynevezett pálcikák és csapok, a fényt elektromos jelekké alakítják. A pálcikák a fény és a kontraszt érzékelésében, míg a csapok a színek érzékelésében vesznek részt." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. A jelek továbbítása az agyba: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "A retinában keletkezett elektromos jeleket a látóideg továbbítja az agy vizuális kéregébe, ahol azokat képekké értelmezik és alakítják át." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Az Emberi Szem Jelentősége", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az emberi szem elengedhetetlen a körülöttünk lévő világ felfedezéséhez és megértéséhez. Színérzékelési, forma- és mozgásérzékelési képessége lehetővé teszi számunkra, hogy hatékonyan navigáljunk a környezetünkben és kapcsolatba lépjünk vele. Az emberi szem emellett értékes eszköz az érzelmek kifejezésére és a nonverbális kommunikációra, mivel sok információt közvetítünk szemkontaktuson keresztül." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A szem megfelelő gondozása létfontosságú a hosszú távú egészségük megőrzése érdekében. A rendszeres szemészeti vizsgálatok, a túlzott ultraibolya fénynek való kitettség elleni védelem és a szemüveg vagy kontaktlencse megfelelő használata néhány módja annak, hogy vigyázzunk és megvédjük ezt a rendkívül fontos szervet." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Összefoglalva, az emberi szem a természet csodája, lenyűgöző összetettséggel és kivételes képességekkel. A világ érzékelésének képessége alapvető az emberi tapasztalathoz, és megérdemli, hogy védjük és értékeljük." }
                }
        };
    }

    private void SetUkrainianContent()
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Людське Око", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Людське око є складним і захоплюючим органом, відповідальним за візуальне сприйняття. Воно є важливим не тільки для повсякденного функціонування, але й для нашого сенсорного та емоційного досвіду світу навколо нас." }
                }
        };

        ContentImage.Source = "ochi1.png";

        DetailsLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Структура Людського Ока", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Людське око складається з кількох основних компонентів:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Рогівка: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Прозора і опукла частина ока, яка покриває райдужку та зіницю. Рогівка допомагає фокусувати світло на сітківку." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Райдужка: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Кольорова частина ока, яка контролює розмір зіниці, а отже, кількість світла, що потрапляє в око." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. Зіниця: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Круглий отвір у центрі райдужки, через який світло потрапляє в око." },
                    new Span { Text = "\n" },
                    new Span { Text = "4. Сітківка: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Світлочутливий шар ока, який перетворює світло на електричні сигнали і передає візуальну інформацію до мозку через зоровий нерв." },
                    new Span { Text = "\n" },
                    new Span { Text = "5. Зоровий нерв: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Шлях, через який візуальні сигнали передаються від сітківки до мозку для інтерпретації." },
                    new Span { Text = "\n" },
                    new Span { Text = "6. Кришталик: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Прозора лінза, розташована за райдужкою, яка допомагає фокусувати світло на сітківці." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Функціонування Людського Ока", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Процес зору включає кілька складних кроків:" },
                    new Span { Text = "\n" },
                    new Span { Text = "1. Фокусування: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Світло, що потрапляє в око, фокусується на сітківку за допомогою рогівки та кришталика. Цей процес є ключовим для забезпечення чіткості зображення." },
                    new Span { Text = "\n" },
                    new Span { Text = "2. Перетворення в електричні сигнали: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Світлочутливі клітини сітківки, звані паличками і колбочками, перетворюють світло на електричні сигнали. Паличкі відповідають за світлове сприйняття і контраст, тоді як колбочки — за сприйняття кольорів." },
                    new Span { Text = "\n" },
                    new Span { Text = "3. Передача сигналів до мозку: ", FontAttributes = FontAttributes.Bold },
                    new Span { FontSize = 15, Text = "Електричні сигнали, що генеруються в сітківці, передаються зоровим нервом до зорової кори мозку, де їх інтерпретують і перетворюють на зображення." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { Text = "Важливість Людського Ока", FontAttributes = FontAttributes.Bold, FontSize = 20 },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Людське око є життєво важливим для нашого розуміння та пізнання світу навколо нас. Його здатність до сприйняття кольору, форми і руху дозволяє нам ефективно орієнтуватися у навколишньому середовищі та взаємодіяти з ним. Крім того, людське око є цінним інструментом для вираження емоцій та невербальної комунікації, оскільки ми передаємо багато інформації через зоровий контакт." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Догляд за очима є важливим для збереження їх здоров'я в довгостроковій перспективі. Регулярні обстеження у офтальмолога, захист від надмірного впливу ультрафіолетового випромінювання та правильне використання окулярів або контактних лінз є деякими способами догляду та захисту цього важливого органу." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Підсумовуючи, людське око є дивом природи, з неймовірною складністю і винятковими можливостями. Здатність сприймати світ є основоположною для людського досвіду і заслуговує на те, щоб її берегти і цінувати." }
                }
        };
    }
}
