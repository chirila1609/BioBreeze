using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Viermi : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Viermi() : this(AudioManager.Current)
    {
    }

    public Viermi(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("viermi.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooViermi(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooViermi());
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
                new Span { Text = "Viermi", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Viermii, o categorie diversă de organisme cu corpuri cilindrice sau în formă de șarpe, reprezintă un grup vast și variat în lumea animală. Aceste organisme sunt răspândite într-o gamă largă de medii, de la pământul umed al pădurilor tropicale la adâncimile abisale ale oceanelor. Cu toate că termenul vierme este adesea asociat cu imagini neplăcute sau chiar periculoase, multe specii de viermi sunt vitale pentru ecosisteme și au un impact semnificativ în domenii precum agricultura, medicina și ecologia." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Clasificare și Diversitate", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Viermii se împart în mai multe categorii taxonomice, inclusiv nematode (viermi cilindrici), platelminți (viermi plați), anelide (viermi segmentați), și altele. Aceștia variază în dimensiune, formă și habitat. De exemplu, nematodele, sau viermii cilindrici, sunt printre cele mai numeroase organisme de pe planetă, fiind găsite în sol, apă și chiar în organismele complexe, inclusiv în corpul uman." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Rolul Ecologic", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Multe specii de viermi joacă un rol crucial în menținerea sănătății ecosistemelor. De exemplu, viermii pământului, sau lombricii, sunt cunoscuți pentru capacitatea lor de a îmbunătăți fertilitatea solului prin procesul de compostare și aerisire a terenului. În plus, nematodele sunt implicate în ciclurile nutrienților și pot influența structura și funcționarea ecosistemelor terestre și marine." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Importanța Medicală și Economică", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În ciuda diversității și beneficiilor lor ecologice, unele specii de viermi pot fi dăunătoare. De exemplu, anumite nematode și platelminți sunt paraziți care pot afecta animalele domestice și sălbatice, precum și omul. Aceste infecții pot provoca boli grave și pot avea un impact semnificativ asupra agriculturii și sănătății umane." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Cercetare și Conservare", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Cunoașterea și înțelegerea viermilor sunt subiecte de interes în domenii precum biologia, ecologia și medicina. Cercetările asupra ecologiilor lor și a interacțiunilor cu alte organisme sunt cruciale pentru conservarea biodiversității și pentru gestionarea resurselor naturale. În plus, studiile asupra adaptărilor lor la medii extreme și capacitatea lor de a supraviețui în condiții dificile pot oferi perspective importante asupra evoluției și supraviețuirii vieții pe Pământ." },
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
                new Span { Text = "Férgek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A férgek egy sokféle szervezet kategóriája, amelyek hengeres vagy kígyó alakú testekkel rendelkeznek, és egy nagy és változatos csoportot jelentenek az állatvilágban. Ezek az organizmusok széles körben elterjedtek különböző környezetekben, a nedves talajtól a trópusi erdők mélyéig és az óceánok mélyéig. Bár a \"féreg\" kifejezés gyakran kapcsolódik kellemetlen vagy akár veszélyes képekhez, sok féregfaj létfontosságú az ökoszisztémák számára, és jelentős hatással van olyan területeken, mint a mezőgazdaság, az orvostudomány és az ökológia." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Osztályozás és sokféleség:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A férgeket több taxonómiai kategóriára osztják, ideértve a fonálférgeket (hengeres férgek), laposférgeket (lapos férgek), gyűrűsférgeket (szegmentált férgek) és másokat. Méretben, formában és élőhelyben különböznek. Például a fonálférgek, vagy hengeres férgek, a Föld egyik legelterjedtebb szervezetei közé tartoznak, megtalálhatók a talajban, a vízben és akár összetett szervezetekben is, beleértve az embert is." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Ökológiai szerep:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Sok féregfaj kulcsfontosságú szerepet játszik az ökoszisztémák egészségének fenntartásában. Például a földi férgek, vagy lombricák, ismertek talaj termékenységének javítására képes képességük miatt, amely a komposztálási folyamat és a talaj levegőztetésének eredménye. Emellett a fonálférgek részt vesznek a tápanyagciklusokban, és képesek befolyásolni a szárazföldi és tengeri ökoszisztémák szerkezetét és működését." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Orvosi és gazdasági jelentőség:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A sokféleség és ökológiai előnyök ellenére néhány féregfaj káros lehet. Például néhány fonálféreg és laposféreg paraziták, amelyek hatással lehetnek házi és vadállatokra, valamint az emberekre. Ezek az fertőzések súlyos betegségeket okozhatnak, és jelentős hatással lehetnek a mezőgazdaságra és az emberi egészségre." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Kutatás és megőrzés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A férgek ismerete és megértése érdeklődési tárgyak a biológia, az ökológia és az orvostudomány területén. Kutatások a férgek ökológiájáról és más szervezetekkel való kölcsönhatásaikról kulcsfontosságúak a biológiai sokféleség megőrzése és a természeti erőforrások kezelése szempontjából. Emellett a kutatások a férgek környezeti adaptációiról és képességükről, hogy túléljenek szélsőséges környezetekben, fontos nézőpontokat nyújtanak a Föld életének evolúciójáról és túléléséről." },
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
                new Span { Text = "Черви:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Черви — це різноманітна категорія організмів з циліндричними або змієподібними тілами, яка представляє собою велику і різноманітну групу в світі тварин. Ці організми поширені в широкому спектрі середовищ, від вологої землі тропічних лісів до глибин абісальних океанів. Хоча термін \"черв\" часто асоціюється з неприємними або навіть небезпечними уявленнями, багато видів червів є життєво важливими для екосистем і мають значний вплив у сферах, таких як сільське господарство, медицина та екологія." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Класифікація та різноманіття:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Черви поділяються на кілька таксономічних категорій, включаючи нематод (циліндричні черви), плоскі черви (плоскі черви), анеліди (сегментовані черви) та інші. Вони відрізняються за розміром, формою та середовищем існування. Наприклад, нематоди, або циліндричні черви, є одними з найчисельніших організмів на планеті, їх можна знайти в ґрунті, воді, а навіть у складних організмах, включаючи людину." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Екологічна роль:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Багато видів червів відіграють ключову роль у підтриманні здоров'я екосистем. Наприклад, земляні черви, або джмелі, відомі своєю здатністю покращувати родючість ґрунту через процес компостування та повітряння ґрунту. Крім того, нематоди беруть участь у циклах поживних речовин і можуть впливати на структуру та функціонування суходольних та морських екосистем." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Медичне та економічне значення:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Незважаючи на різноманіття та екологічні переваги, деякі види червів можуть бути шкідливими. Наприклад, деякі нематоди та плоскі черви є паразитами, які можуть впливати на домашніх тварин і диких тварин, а також людину. Ці інфекції можуть викликати серйозні захворювання і мати значний вплив на сільське господарство та здоров'я людини." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Дослідження та збереження:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Знання і розуміння червів є предметом інтересу в таких галузях, як біологія, екологія та медицина. Дослідження їх екологій та взаємодій з іншими організмами є важливими для збереження біорізноманіття та управління природними ресурсами. Крім того, вивчення їх адаптацій до екстремальних середовищ і їх здатності виживати в складних умовах може надати важливі перспективи щодо еволюції і виживання життя на Землі." },
new Span { Text = "\n" }

            }
        };
    }
}
