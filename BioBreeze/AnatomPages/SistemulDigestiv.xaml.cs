using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulDigestiv : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulDigestiv() : this(AudioManager.Current)
    {
    }

    public SistemulDigestiv(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemuldigestiv.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSD(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSD());
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
                    new Span { FontSize = 15, Text = "Sistemul digestiv este unul dintre cele mai complexe și esențiale sisteme din corpul uman. Rolul său principal este de a descompune alimentele consumate în nutrienți absorbabili și de a elimina deșeurile reziduale." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Procesul digestiv începe în gură, unde alimentele sunt sfărâmate de dinți și amestecate cu saliva, care conține enzime care încep descompunerea carbohidraților. Apoi, alimentele trec prin esofag în stomac, unde sunt descompuse și digerate de acidul gastric și enzimele digestive. Din stomac, hrana parțial digerată ajunge în intestinul subțire, unde majoritatea nutrienților sunt absorbiți în sânge prin pereții intestinali și transportați către restul corpului." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Intestinul subțire este format din trei părți: duodenul, jejunul și ileonul. În duoden, sucurile pancreatice și biliare sunt eliberate pentru a descompune grăsimile și proteinele. În timp ce hrana trece prin jejun și ileon, nutrienții sunt absorbiți înainte ca deșeurile nedigerate să ajungă în intestinul gros." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Intestinul gros este responsabil pentru absorbția apei și a electroliților din alimente, transformând deșeurile în fecale și pregătindu-le pentru eliminare. Acestea călătoresc în rect și sunt eliminate prin anus în timpul defecației." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Sistemul digestiv este orchestrat de o serie de organe, inclusiv ficatul, vezica biliară și pancreasul, care eliberează substanțe chimice vitale pentru procesul de digestie. O alimentație echilibrată și sănătoasă, bogată în fibre, nutrienți și apă, este esențială pentru menținerea sănătății sistemului digestiv. Orice disfuncționalitate a acestui sistem poate duce la probleme de sănătate precum indigestia, refluxul gastroesofagian, sindromul de colon iritabil sau chiar boli mai grave precum cancerul de colon. Prin urmare, este crucial să avem grijă de sistemul nostru digestiv și să acordăm atenție alimentației și stilului de viață sănătos." }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Шлунково-кишкова система є однією з найбільш складних і важливих систем у людському організмі. Її головною функцією є розщеплення споживаних продуктів на поживні речовини, які можуть бути засвоєні, та видалення відходів." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Переварювальний процес починається у роті, де їжа розмелюється зубами та змішується з слиною, що містить ферменти, які розпочинають розщеплення вуглеводів. Потім їжа проходить через стравохід у шлунок, де вона розщеплюється та перетравлюється шлунковим соком та печінковими ферментами. Зі шлунка частково переварена їжа потрапляє в тонкий кишечник, де більшість поживних речовин поглинаються у кров через стінки кишечника та транспортуються до всього організму." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Тонкий кишечник складається з трьох частин: дванадцятипалої кишки, тощої кишки та ілеалу. У дванадцятипалій кишці вивільнюються підшлункові та жовчні соки для розщеплення жирів і білків. Під час проходження їжі через тощо та ілеал, поживні речовини поглинаються, перш ніж непереварені відходи потрапляють у товстий кишечник." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Товстий кишечник відповідає за поглинання води та електролітів з їжі, перетворення відходів у кал та підготовку їх до виведення. Вони подорожують до прямої кишки та виводяться через анус під час дефекації." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Шлунково-кишкова система координується рядом органів, включаючи печінку, жовчний міхур та підшлункову залозу, які вивільняють життєво важливі хімічні речовини для перетравлення їжі. Збалансоване та здорове харчування, багате на волокна, поживні речовини та воду, є ключовим для підтримки здоров'я шлунково-кишкової системи. Будь-яке порушення цієї системи може призвести до проблем зі здоров'ям, такими як несправності шлункового тракту, рефлюкс гастроезофагеальний, синдром подразненого кишечника або навіть більш серйозні захворювання, такі як рак товстої кишки. Тому догляд за нашою шлунково-кишковою системою та увага до харчування і здорового способу життя є надзвичайно важливими." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Az emésztőrendszer az egyik legbonyolultabb és legfontosabb rendszer az emberi testben. Fő szerepe, hogy az elfogyasztott ételeket emészthető tápanyagokká bontsa, és eltávolítsa a maradék hulladékot." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az emésztő folyamat a szájban kezdődik, ahol az ételeket fogakkal darálják és nyálka keverik, amely enzimeket tartalmaz, amelyek elkezdik a szénhidrátok lebontását. Ezután az étel áthalad a nyelőcsőn a gyomorba, ahol gyomorsav és emésztőenzimek bontják le és emésztik meg. A gyomorból részben emésztett étel jut a vékonybélbe, ahol a tápanyagok többsége felszívódik a vérbe az emésztőrendszer falain keresztül, és szállítják a test többi részébe." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A vékonybél három részből áll: a patkóbélből, a sötétbélből és az ileumból. A patkóbélben hasnyálmirigy- és epelelhalásokat szabadítanak fel a zsírok és fehérjék lebontására. Ahogy az étel halad át a sötétbél és az ileumban, a tápanyagok felszívódnak, mielőtt emésztetlen hulladék kerülne a vastagbélbe." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "A vastagbél felelős a víz és elektrolitok felszívásáért az ételekből, a hulladékok székletbe történő átalakításáért és készítéséért. Ezek az utazások a végbélbe és az anuson keresztül történő elimináció során történnek." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az emésztőrendszer egy sor szerv által szervezett, beleértve a májat, az epehólyagot és a hasnyálmirigyet, amelyek életfontosságú vegyi anyagokat bocsátanak fel az emésztési folyamatban. Egy kiegyensúlyozott és egészséges táplálkozás, amely rostokban, tápanyagokban és vízben gazdag, kulcsfontosságú az emésztőrendszer egészségének fenntartásában. Bármely rendellenesség ebben a rendszerben emésztési problémákhoz vezethet, például a gastrooesophagealis reflux, az irritábilis bél szindróma vagy akár súlyosabb betegségek, mint például a vastagbélrák. Ezért rendkívül fontos gondoskodni az emésztőrendszerünkről és figyelmet fordítani az egészséges életmódra és táplálkozásra." }
                }
        };
    }
}
