using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class EAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EAnimale() : this(AudioManager.Current)
    {
    }

    public EAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("eanimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooEAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooEAnimale());
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
                new Span { FontSize = 15, Text = "Excreția este procesul prin care organismele îndepărtează substanțele deșeurilor din corp, inclusiv produsele reziduale ale metabolismului. La animale, excreția este crucială pentru menținerea echilibrului intern și eliminarea substanțelor toxice acumulate în timpul proceselor metabolice. Există o varietate de sisteme și mecanisme adaptate la diferite medii și necesități biologice." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Sisteme de excreție la animale:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { Text = "1. Excreția la nevertebrate: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Nevertebratele, cum ar fi insectele și moluștele, folosesc o gamă diversă de organe pentru excreție. De exemplu, insectele folosesc tuburi Malpighi și intestine pentru eliminarea deșeurilor." },
new Span { Text = "\n" },
new Span { Text = "2. Excreția la vertebrate: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "La vertebrate, sistemele de excreție sunt mai complexe și includ rinichii, plămânii, pielea și glandele salivare. Rinichii sunt organele principale de excreție la majoritatea vertebratelor și filtrează sângele pentru a elimina deșeurile în urină." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Adaptări ale sistemelor de excreție:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { Text = "1. Adaptări la mediu: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Animalele care trăiesc în medii uscate sau cu resurse limitate de apă, cum ar fi reptilele și unele mamifere deșertice, au dezvoltat sisteme de excreție concentrate pentru a conserva apă." },
new Span { Text = "\n" },
new Span { Text = "2. Excreția la animale marine: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Organismele marine, cum ar fi peștii și rechinii, trebuie să facă față excreției deșeurilor într-un mediu cu concentrații diferite de săruri și alte substanțe chimice. Rinichii și glandele speciale de excreție sunt adaptate pentru a gestiona aceste condiții." },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, excreția la animale este un proces esențial pentru menținerea homeostaziei și supraviețuirea în diferite medii. Variația în sistemele și adaptările pentru excreție reflectă diversitatea și complexitatea lumii naturale." }

            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "A kiválasztás az állatoknál:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "A kiválasztás folyamata, amely során az élőlények eltávolítják a testükből a hulladékanyagokat, ideértve az anyagcsere maradványait is. Az állatoknál a kiválasztás kulcsfontosságú a belső egyensúly fenntartásában és a metabolikus folyamatok során felhalmozódott toxikus anyagok eltávolításában. Számos rendszer és mechanizmus létezik, amelyeket különböző környezetekhez és biológiai igényekhez alkalmazkodva fejlesztettek ki." },
                new Span { Text = "\n" },
                new Span { Text = "Kiválasztó rendszerek az állatoknál:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "1. Kiválasztás a gerincteleneknél:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "A gerinctelenek, mint például a rovarok és a puhatestűek, számos szervet használnak a kiválasztásra. Például a rovarok Malpighi-csöveket és beleket használnak a hulladékok eltávolítására." },
                new Span { Text = "\n" },
                new Span { Text = "2. Kiválasztás a gerinceseknél:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "A gerinceseknél a kiválasztó rendszerek bonyolultabbak és magukban foglalják a veséket, tüdőket, bőrt és nyálmirigyeket. A vesék a gerincesek legfőbb kiválasztó szervei, amelyek szűrik a vért a vizeletbe kiválasztandó hulladékok számára." },
                new Span { Text = "\n" },
                new Span { Text = "A kiválasztás rendszereinek alkalmazkodásai:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "1. Környezeti alkalmazkodások:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "Olyan állatok, mint a sivatagi hüllők és néhány emlős, amelyek száraz vagy korlátozott vízforrásokkal rendelkező környezetben élnek, koncentrált kiválasztó rendszereket fejlesztettek ki a víz megőrzése érdekében." },
                new Span { Text = "\n" },
                new Span { Text = "2. Kiválasztás a tengeri állatoknál:", FontAttributes = FontAttributes.Bold },
                new Span { Text = "\n" },
                new Span { Text = "A tengeri szervezetek, mint például a halak és a cápák, szembe kell nézzenek a hulladékok kiválasztásával egy olyan környezetben, ahol eltérő sókoncentrációk és egyéb kémiai anyagok vannak jelen. A vesék és a speciális kiválasztó mirigyek alkalmazkodnak ezekhez a körülményekhez." },
                new Span { Text = "\n" },
                new Span { Text = "Következtetés: Az állatoknál a kiválasztás elengedhetetlen folyamat a homeosztázis fenntartásához és a különböző környezetekben való túléléshez. A kiválasztási rendszerek sokfélesége és az alkalmazkodások tükrözik a természetes világ sokféleségét és bonyolultságát." }
            }

    
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Екскреція у тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Екскреція - це процес, за допомогою якого організми видаляють відходи з організму, включаючи залишкові продукти обміну речовин. У тварин екскреція є важливою для підтримання внутрішнього балансу та видалення токсичних речовин, накопичених під час обміну речовин. Існує різноманіття систем та механізмів, адаптованих до різних середовищ і біологічних потреб." },
new Span { Text = "\n" },
new Span { Text = "Системи екскреції у тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "1. Екскреція у безхребетних:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Безхребетні, такі як комахи та молюски, використовують різноманітні органи для екскреції. Наприклад, комахи використовують Мальпігієві трубки та кишечник для видалення відходів." },
new Span { Text = "\n" },
new Span { Text = "2. Екскреція у хребетних:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "У хребетних системи екскреції є складнішими і включають нирки, легені, шкіру та слинні залози. Нирки є основними органами екскреції у більшості хребетних і фільтрують кров для видалення відходів у вигляді сечі." },
new Span { Text = "\n" },
new Span { Text = "Адаптації систем екскреції:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "1. Адаптації до середовища:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Тварини, які живуть в сухих або обмежених водою середовищах, такі як рептилії та деякі пустельні ссавці, розвинули концентровані системи екскреції для збереження води." },
new Span { Text = "\n" },
new Span { Text = "2. Екскреція у морських тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Морські організми, такі як риби і акули, повинні впоратися з виведенням відходів у середовищі з різною концентрацією солей та інших хімічних речовин. Нирки та спеціальні залози екскреції адаптовані для управління цими умовами." },
new Span { Text = "\n" },
new Span { Text = "Висновок: Екскреція у тварин є важливим процесом для підтримки гомеостазу та виживання у різних середовищах. Різноманітність систем та адаптації для екскреції відображає різноманіття і складність природного світу." },
new Span { Text = "\n" }
            }
        };
    }
}
