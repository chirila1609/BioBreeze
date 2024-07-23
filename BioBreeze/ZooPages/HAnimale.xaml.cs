using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class HAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public HAnimale() : this(AudioManager.Current)
    {
    }

    public HAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hanimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooHAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooHAnimale());
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
                new Span { FontSize = 15, Text = "Hranirea animalelor este un aspect crucial în îngrijirea lor, având un impact direct asupra sănătății și bunăstării acestora. De-a lungul timpului, oamenii au dezvoltat cunoștințe și tehnici variate pentru a asigura necesarul nutritiv al animalelor domestice și sălbatice." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Principii generale:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Hranirea animalelor presupune echilibrul dintre necesitățile specifice ale fiecărui animal și disponibilitatea resurselor alimentare. Principiile de bază includ asigurarea unui aport adecvat de proteine, carbohidrați, grăsimi, vitamine și minerale în dieta zilnică a animalului. Aceste necesități variază în funcție de specie, vârstă, sex, stadiul de dezvoltare și nivelul de activitate." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Tipuri de hrănire:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { Text = "1. Hranirea naturală:", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Unele animale, în special cele domestice, se hrănesc cu hrana pe care o găsesc în sălbăticie sau cu hrana produsă de om, cum ar fi iarbă, semințe, legume, fructe, carne și produse lactate." },
new Span { Text = "\n" },
new Span { Text = "2. Hranirea cu hrană procesată:", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Multe animale domestice sunt hrănite cu alimente procesate, cum ar fi hrana uscată, conservele sau hrana umedă. Aceste alimente sunt formulate pentru a satisface nevoile nutriționale specifice ale fiecărei specii și sunt convenabile pentru proprietari." },
new Span { Text = "\n" },
new Span { Text = "3. Suplimente alimentare:", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "În unele cazuri, animalele pot necesita suplimente pentru a completa deficitul de nutrienți din dieta lor principală. Acestea pot include vitamine, minerale sau alte substanțe nutritive esențiale pentru sănătatea animalului." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, hranirea animalelor este un proces complex care necesită cunoștințe și atenție pentru a asigura sănătatea și bunăstarea lor. Înțelegerea nevoilor individuale ale fiecărui animal și furnizarea unei diete echilibrate și adecvate sunt esențiale pentru a le asigura o viață sănătoasă și fericită." }

            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Állateledel:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az állateledel gondozásának fontos része, amely közvetlen hatással van az állatok egészségére és jólétére. Az emberek az idők során különféle ismereteket és technikákat fejlesztettek ki a házi és vadállatok táplálkozási igényeinek biztosítására." },
new Span { Text = "\n" },
new Span { Text = "Általános elvek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Az állatok táplálása során fontos az egyensúly kialakítása az egyes állatok specifikus igényei és az élelemforrások elérhetősége között. Az alapvető elvek magukban foglalják a fehérje, szénhidrát, zsír, vitamin és ásványi anyag megfelelő bevitelének biztosítását az állat napi étrendjében. Ezek az igények fajtától, korától, nemétől, fejlődési szakaszától és aktivitási szintjétől függően változnak." },
new Span { Text = "\n" },
new Span { Text = "Táplálkozási típusok:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "1. Természetes táplálkozás:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Néhány állat, különösen a háziállatok, vadon élő környezetben talált vagy ember által termesztett ételeket fogyasztanak, például füvet, magokat, zöldségeket, gyümölcsöket, húst és tejtermékeket." },
new Span { Text = "\n" },
new Span { Text = "2. Feldolgozott élelmiszer táplálkozás:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Sok háziállatot feldolgozott élelmiszerekkel táplálnak, például száraztáppal, konzervekkel vagy nedves táppal. Ezek az ételek az adott fajok specifikus táplálkozási igényeinek megfelelően vannak összeállítva, és kényelmesek a tulajdonosok számára." },
new Span { Text = "\n" },
new Span { Text = "3. Táplálékkiegészítők:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Bizonyos esetekben az állatoknak táplálékkiegészítőkre lehet szükségük a fő étrendjükben lévő tápanyaghiány kiegészítésére. Ezek vitaminokat, ásványi anyagokat vagy más, az állat egészsége szempontjából fontos tápanyagokat tartalmazhatnak." },
new Span { Text = "\n" },
new Span { Text = "Összegzésképpen az állateledel komplex folyamat, amely ismereteket és figyelmet igényel az állatok egészségének és jólétének biztosítása érdekében. Fontos megérteni minden állat egyedi igényeit és biztosítani egy kiegyensúlyozott és megfelelő táplálkozást annak érdekében, hogy egészséges és boldog életet élhessenek." }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Годування тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Годування тварин - це ключовий аспект їхнього догляду, який безпосередньо впливає на їхнє здоров'я і благополуччя. З часом люди розробили різноманітні знання і техніки для забезпечення необхідного харчування домашніх і диких тварин." },
new Span { Text = "\n" },
new Span { Text = "Загальні принципи:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Годування тварин передбачає баланс між конкретними потребами кожної тварини та наявністю їжових ресурсів. Основні принципи включають забезпечення достатнього прийому білків, вуглеводів, жирів, вітамінів та мінералів у щоденному раціоні тварини. Ці потреби залежать від виду, віку, статі, стадії розвитку та рівня активності." },
new Span { Text = "\n" },
new Span { Text = "Типи годування:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "1. Природне годування:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Деякі тварини, особливо домашні, харчуються їжею, яку вони знаходять у дикій природі або їжею, вирощеною людиною, такою як трава, насіння, овочі, фрукти, м'ясо та молочні продукти." },
new Span { Text = "\n" },
new Span { Text = "2. Годування обробленою їжею:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Багато домашніх тварин годують обробленою їжею, такою як суха їжа, консерви або волога їжа. Ці продукти складаються для задоволення конкретних харчових потреб кожного виду і є зручними для власників." },
new Span { Text = "\n" },
new Span { Text = "3. Харчові добавки:", FontAttributes = FontAttributes.Bold },
new Span { Text = " У деяких випадках тварини можуть потребувати добавок для компенсації дефіциту поживних речовин у їхньому основному раціоні. Ці можуть включати вітаміни, мінерали або інші необхідні поживні речовини для здоров'я тварини." },
new Span { Text = "\n" },
new Span { Text = "Висновок, годування тварин - це складний процес, який потребує знань та уваги для забезпечення їхнього здоров'я і благополуччя. Розуміння індивідуальних потреб кожної тварини та надання збалансованого і відповідного харчування є ключовими для забезпечення здорового і щасливого життя." },
new Span { Text = "\n" }
            }
        };
    }
}
