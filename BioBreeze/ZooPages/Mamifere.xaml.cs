using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Mamifere : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Mamifere() : this(AudioManager.Current)
    {
    }

    public Mamifere(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("mamifere.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooMamifere(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooMamifere());
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
                new Span { FontSize = 15, Text = "Mamiferele sunt o clasă distinctă de animale vertebrate care se remarcă prin prezența glandelor mamare, care produc laptele pentru hrănirea puiilor. Cu peste 5.400 de specii cunoscute, mamiferele sunt prezente pe toate continentele și în majoritatea mediilor, de la cele mai reci zone polare până la cele mai fierbinți pustii. Această diversitate incredibilă reflectă capacitatea adaptativă a acestor creaturi remarcabile." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Structura corpului mamiferelor variază considerabil în funcție de mediul în care trăiesc și de modul lor de viață. De exemplu, mamiferele marine, cum ar fi balenele și delfinii, au evoluat pentru a se adapta la viața în apă, dezvoltând corpuri hidrodinamice și sistemul respirator adaptat la mediul acvatic. În schimb, mamiferele terestre au o gamă variată de adaptații, inclusiv gheare pentru săpare (cum ar fi la tăușoare), cozi prehensile pentru agățat (cum ar fi la maimuțe) și gâturi lungi pentru pășunat (cum ar fi la girafele)." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "O trăsătură comună a mamiferelor este prezența părului sau a blănii pe corp, care servește la termoreglare și protecție împotriva mediului înconjurător. Aceste creaturi au și o circulație sanguină bine dezvoltată și un sistem nervos complex, ceea ce le permite să răspundă rapid la schimbările din mediu și să interacționeze cu acesta în moduri variate." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Un aspect remarcabil al mamiferelor este comportamentul lor social și complexitatea relațiilor sociale. De la formele simple de asociere între perechi de parteneri, cum ar fi la unele specii de lilieci, până la societăți extrem de elaborate, cum ar fi la elefanți și balene, mamiferele demonstrează că interacțiunea socială poate fi esențială pentru supraviețuirea și succesul lor în mediul înconjurător." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Pe lângă diversitatea comportamentală și morfologică, mamiferele sunt de o importanță imensă pentru ecosistemele terestre și marine. Ele ocupă roluri cheie în lanțurile trofice, de la prădători de vârf până la erbivore și decompozitori, contribuind astfel la menținerea echilibrului și sănătății ecosistemelor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, mamiferele sunt printre cele mai diverse și fascinante grupuri de animale de pe Pământ. Capacitatea lor de a se adapta la o varietate de medii și condiții, combinată cu comportamentul lor social și impactul lor asupra ecosistemelor, le fac subiecte de studiu fascinante și esențiale pentru înțelegerea și conservarea biodiversității planetei noastre." },
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
                new Span { Text = "Emlősök:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az emlősök különálló osztályt képeznek a gerinces állatok között, amelyeket a tejmirigyek jelenléte jellemző, melyek a kölykök táplálására szolgáló tejet termelnek. Több mint 5,400 ismert fajuk van, jelen vannak minden kontinensen és a legkülönbözőbb élőhelyeken, a jeges sarkvidékektől a forró sivatagokig. Ez a hihetetlen sokféleség tükrözi ezeknek a kivételes lényeknek az adaptációs képességét." },
new Span { Text = "\n" },
new Span { Text = "A test szerkezete:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az emlősök testfelépítése jelentősen változik attól függően, hogy milyen környezetben élnek és milyen életmódot folytatnak. Például a tengeri emlősök, mint például a bálnák és delfinek, alkalmazkodtak az életükhöz a vízben, hidrodinamikus testet és a vízi környezethez alkalmazkodott légzőrendszert fejlesztve ki. Ezzel szemben a szárazföldi emlősöknek számos adaptációjuk van, például kaparó karmaik (mint például a vakondoknál), ragadófarkuk (mint például a majmoknál) vagy hosszú nyakuk a legeléshez (mint például a zsiráfoknál)." },
new Span { Text = "\n" },
new Span { Text = "Jellemzők:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az emlősök egyik közös jellemzője a testüket borító szőrzet vagy bunda, amely a testhő szabályozására és a környezeti védelemre szolgál. Jól kifejlett vérkeringésük és bonyolult idegrendszerük van, ami lehetővé teszi számukra, hogy gyorsan reagáljanak a környezeti változásokra és különböző módon interakcióba lépjenek vele." },
new Span { Text = "\n" },
new Span { Text = "Szociális viselkedés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az emlősök egyik figyelemre méltó tulajdonsága a társas viselkedés bonyolultsága és a társas kapcsolatok összetettsége. Az egyszerű partneri kapcsolatoktól, mint például egyes denevérfajoknál, az elefántok és bálnák rendkívül bonyolult társadalmi szerkezetéig az emlősök azt mutatják, hogy a társadalmi interakció kulcsfontosságú lehet túlélésük és sikerük szempontjából a környező világban." },
new Span { Text = "\n" },
new Span { Text = "Ökológiai jelentőség:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A viselkedési és morfológiai sokféleség mellett az emlősök kulcsfontosságú szerepet játszanak a szárazföldi és a tengeri ökoszisztémákban. Kulcsfontosságú szerepet töltenek be a táplálkozási láncokban, a csúcsragadozóktól a növényevőkig és a lebontókig, hozzájárulva ezzel az ökológiai egyensúly és az ökoszisztémák egészségének fenntartásához." },
new Span { Text = "\n" },
new Span { Text = "Összegzés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az emlősök az egyik legváltozatosabb és legérdekesebb állatcsoportok a Földön. Képességük, hogy alkalmazkodjanak a különböző környezetekhez és feltételekhez, összekapcsolva társas viselkedésüket és hatásukat az ökoszisztémákra, izgalmas tanulmányi tárggyá és fontossá teszik őket a bolygónk biológiai sokféleségének megértése és megőrzése szempontjából." }

            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Ссавці:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Ссавці — це окремий клас хребетних тварин, які відрізняються наявністю молочних залоз, що виробляють молоко для годування дитинчат. Із понад 5,400 відомих видів ссавців вони поширені на всіх континентах і в різних середовищах, від найхолодніших полярних зон до найспекотніших пустель. Це неймовірне різноманіття відображає адаптивність цих видів до змінюваних умов." },
new Span { Text = "\n" },
new Span { Text = "Структура тіла:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Будова тіла ссавців значно відрізняється залежно від середовища, в якому вони живуть, і їх способу життя. Наприклад, морські ссавці, такі як кити і дельфіни, адаптувалися до життя у воді, розвиваючи гідродинамічне тіло та дихальну систему, пристосовану до акватичного середовища. На відміну від них, ссавці, що живуть на суходолі, мають різноманітні адаптації, такі як кігті для копання (наприклад, у кротів), хвости-хвата для лізання (наприклад, у мавп), або довгі шиї для пасовищ (наприклад, у жираф)." },
new Span { Text = "\n" },
new Span { Text = "Особливості:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Середні ссавців є наявність волосини або шерсті на тілі, яка служить для терморегуляції та захисту від зовнішнього середовища. Вони також мають добре розвинену кровообіг і складну нервову систему, що дозволяє їм швидко реагувати на зміни в середовищі та взаємодіяти з ним різними способами." },
new Span { Text = "\n" },
new Span { Text = "Соціальна поведінка:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Однією з відмінностей ссавців є складність їх соціальної поведінки та взаємовідносин. Від простих форм партнерських асоціацій, таких як у деяких видів кажанів, до високорозвинених суспільств, наприклад у слонів та китів, ссавці демонструють, що соціальна взаємодія може бути вирішальною для їх виживання та успіху в навколишньому середовищі." },
new Span { Text = "\n" },
new Span { Text = "Екологічна важливість:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Окрім поведінкової і морфологічної різноманітності, ссавці відіграють важливу роль у наземних і морських екосистемах. Вони займають ключові позиції у трофічних ланцюгах, від вершкових хижаків до травоїдних і розкладаючих, сприяючи таким чином збереженню екологічного балансу та здоров'я екосистем." },
new Span { Text = "\n" },
new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Ссавці належать до найрізноманітніших і найцікавіших груп тварин на Землі. Їх здатність адаптуватися до різних середовищ і умов, поєднана з соціальною поведінкою та впливом на екосистеми, робить їх захоплюючими об'єктами для вивчення і важливими для збереження біорізноманіття нашої планети." }

            }
        };
    }
}
