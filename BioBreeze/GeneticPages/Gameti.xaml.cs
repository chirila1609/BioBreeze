using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class Gameti : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Gameti() : this(AudioManager.Current)
    {
    }

    public Gameti(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("gameti.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenGameti(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenGameti());
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
                new Span { FontSize = 15, Text = "Gametii sunt celule specializate implicate în reproducerea sexuală la organisme multicelulare. Aceste celule sunt esențiale pentru procesul de reproducere, deoarece conțin jumătate din materialul genetic al organismului și sunt implicate în formarea noilor indivizi." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Există două tipuri principale de gameti: spermatozoizii la masculi și ovulele la femele. Spermatozoizii sunt celule mici și mobile, produse de testiculele organismelor masculine. Aceștia sunt specializați în transportul materialului genetic masculin către ovulul feminin. Ovulele, pe de altă parte, sunt cele mai mari celule din corpul uman și sunt produse de ovarele organismelor feminine. Acestea conțin materialul genetic feminin și oferă mediul optim pentru dezvoltarea embrionului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Procesul de formare a gametilor este cunoscut sub numele de gametogeneză și implică mai multe etape complexe de diviziune celulară și diferențiere. La om, gametogeneza începe la pubertate și continuă de-a lungul vieții fertile a individului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "La unirea unui spermatozoid cu un ovul într-un proces numit fertilizare, cele două gameti se combină pentru a forma un zigot unic, care conține materialul genetic complet al noului organism. Acest zigot va începe să se divizeze și să se dezvolte, formând ulterior un embrion care va crește și se va dezvolta într-un organism adult." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, gametii sunt esențiali pentru reproducerea sexuală la majoritatea organismelor multicelulare și joacă un rol crucial în transferul materialului genetic de la o generație la alta." },
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
                new Span { Text = "Gaméták:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A gaméták specializált sejtek, amelyek a többsejtű szervezetek szexuális szaporodásában vesznek részt. Ezek a sejtek nélkülözhetetlenek a szaporodási folyamathoz, mivel a szervezet genetikai anyagának felét tartalmazzák és új egyedek kialakulásában vesznek részt." },
new Span { Text = "\n" },
new Span { Text = "Két fő típusa van a gamétáknak: a hímivarsejtek (spermiumok) a hímeknél és a petesejtek a nőknél. A spermiumok kicsi és mozgékony sejtek, amelyeket a hímek heréi termelnek. Ezek a sejtek specializálódtak a férfi genetikai anyag szállítására a női petesejthez. A petesejtek ezzel szemben a legnagyobb sejtek az emberi testben, és a női szervezetek petefészkeiben termelődnek. Ezek a sejtek női genetikai anyagot tartalmaznak és optimális környezetet biztosítanak az embrió fejlődéséhez." },
new Span { Text = "\n" },
new Span { Text = "A gaméták kialakulási folyamata a gametogenezis, amely számos komplex sejtosztódási és differenciálódási szakaszt foglal magában. Az embereknél a gametogenezis a pubertáskor kezdődik és az egyén termékeny életszakaszán keresztül folytatódik." },
new Span { Text = "\n" },
new Span { Text = "Amikor egy spermium egy petesejttel egyesül a megtermékenyítésnek nevezett folyamat során, a két gaméta egyesül, hogy egy egyedi zigótát alkosson, amely az új szervezet teljes genetikai anyagát tartalmazza. Ez a zigóta osztódni és fejlődni kezd, majd később embrióvá alakul, amely növekedni és fejlődni fog egy felnőtt szervezetté." },
new Span { Text = "\n" },
new Span { Text = "Összefoglalva, a gaméták nélkülözhetetlenek a többsejtű szervezetek szexuális szaporodásához, és létfontosságú szerepet játszanak a genetikai anyag generációról generációra történő átadásában." },
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
                new Span { Text = "Гамети:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Гамети - це спеціалізовані клітини, які беруть участь у статевому розмноженні у багатоклітинних організмів. Ці клітини є важливими для процесу розмноження, оскільки містять половину генетичного матеріалу організму та беруть участь у формуванні нових особин." },
new Span { Text = "\n" },
new Span { Text = "Існує два основних типи гамет: сперматозоїди у чоловіків і яйцеклітини у жінок. Сперматозоїди - це дрібні та рухливі клітини, які виробляються яєчками чоловічих організмів. Вони спеціалізуються на перенесенні чоловічого генетичного матеріалу до жіночої яйцеклітини. Яйцеклітини, з іншого боку, є найбільшими клітинами в організмі людини та виробляються яєчниками жіночих організмів. Вони містять жіночий генетичний матеріал і забезпечують оптимальне середовище для розвитку ембріона." },
new Span { Text = "\n" },
new Span { Text = "Процес формування гамет відомий як гаметогенез і включає кілька складних етапів поділу клітин і диференціації. У людей гаметогенез починається в період статевого дозрівання і продовжується протягом репродуктивного віку індивіда." },
new Span { Text = "\n" },
new Span { Text = "При злитті сперматозоїда з яйцеклітиною в процесі, який називається заплідненням, дві гамети з'єднуються, утворюючи унікальну зиготу, що містить повний генетичний матеріал нового організму. Ця зигота починає ділитися і розвиватися, згодом формуючи ембріон, який росте і розвивається в дорослий організм." },
new Span { Text = "\n" },
new Span { Text = "Отже, гамети є необхідними для статевого розмноження у більшості багатоклітинних організмів і відіграють важливу роль у передачі генетичного матеріалу від одного покоління до іншого." },
new Span { Text = "\n" }
            }
        };
    }
}
