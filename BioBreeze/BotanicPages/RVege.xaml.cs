using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class RVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public RVege() : this(AudioManager.Current)
    {
    }

    public RVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("rvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotRVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotRVege());
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
                new Span { FontSize = 15, Text = "Respirația la plante reprezintă un proces esențial prin care plantele își obțin energia necesară pentru supraviețuire și creștere. Deși asociem adesea respirația cu organismele care au plămâni sau branhi, plantele efectuează un proces de respirație similar, dar diferit în detalii." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Procesul de Respirație", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Respirația la plante implică absorbția oxigenului și eliminarea dioxidului de carbon, într-un proces invers fotosintezei. În timpul respirației, plantele descompun moleculele organice complexe, precum zaharurile, pentru a obține energie, lăsând oxigenul și dioxidul de carbon ca produse secundare." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Organele Implicate", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Principalul organ implicat în respirația la plante este stomacul, o structură microscopica găsită în frunze și tulpini. Stomatele sunt mici deschideri care permit schimbul de gaze între plante și mediul înconjurător. Oxigenul este absorbit prin stomate în timpul respirației, iar dioxidul de carbon este eliminat prin aceleași deschideri." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Adaptări la Mediu", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Plantele au evoluat diverse adaptări pentru a-și gestiona eficient respirația în diverse medii. De exemplu, plantele deșertului pot avea stomate închise ziua pentru a reduce pierderea de apă, deschizându-le noaptea pentru a permite respirația. În același timp, plantele acvatice pot folosi alte structuri, cum ar fi aerenești sau lenticeluri, pentru a absorbi oxigenul din apă." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Importanța Respirației pentru Plante", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Respirația este vitală pentru plante, deoarece le furnizează energia necesară pentru a-și desfășura activitățile metabolice și pentru a crește. Fără un proces adecvat de respirație, plantele ar fi incapabile să producă energie și ar muri." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, respirația este un proces esențial pentru plante, permițându-le să obțină energia necesară pentru a supraviețui și a crește. Prin intermediul acestui proces, plantele demonstrează o adaptabilitate remarcabilă la medii variate și sunt parte integrantă a ecosistemelor terestre și acvatice." },
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
                new Span { Text = "Növények légzése:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények légzése létfontosságú folyamat, amely során a növények energiát szereznek túlélésükhöz és növekedésükhöz. Bár gyakran az emlőslélegzetet vagy a kopoltyúsokat társítjuk a légzéssel, a növények hasonló, ám részleteiben eltérő légzési folyamatot végeznek.", FontSize = 16 },
new Span { Text = "Légzési folyamat:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények légzése során oxigént vesznek fel és szén-dioxidot bocsátanak ki, ez a fotoszintézis ellentétes folyamata. A légzés során a növények bonyolult szerves molekulákat, például cukrokat bontanak le energiához, és oxigént és szén-dioxidot hagynak hátra melléktermékként.", FontSize = 16 },
new Span { Text = "Érintett szervek:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények légzésében érintett fő szerv a szomjúság, egy mikroszkopikus szerkezet, amelyet a levelekben és a szárakban találunk. A szomjúság kis nyílások, amelyek lehetővé teszik a gázcsere növények és környezetük között. Az oxigén a légzés során a szomjúságon keresztül kerül felszívásra, míg a szén-dioxid ugyanazon nyílásokon keresztül kerül kiürítésre.", FontSize = 16 },
new Span { Text = "Alkalmazkodás környezethez:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények számos alkalmazkodást fejlesztettek ki a légzés hatékony kezelésére különböző környezetekben. Például a sivatagi növények zárt szomjúsággal rendelkezhetnek nappal a vízveszteség csökkentése érdekében, éjjel pedig megnyitják őket a légzés lehetővé tételéhez. Ugyanakkor a vízinövények más struktúrákat is használhatnak, mint például az aerencimek vagy a lenticelák az oxigén felszívásához a vízből.", FontSize = 16 },
new Span { Text = "A légzés fontossága a növények számára:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A légzés nélkülözhetetlen a növények számára, mivel energiát biztosít a metabolikus tevékenységeikhez és növekedésükhöz. Megfelelő légzési folyamat nélkül a növények képtelenek lennének energia előállítására, és elpusztulnának.", FontSize = 16 },
new Span { Text = "Összegzés:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A légzés létfontosságú folyamat a növények számára, amely lehetővé teszi számukra az energiaszerzést túlélésükhöz és növekedésükhöz. Ezen folyamat által a növények figyelemre méltó alkalmazkodóképességet mutatnak különböző környezetekhez, és elengedhetetlen részét képezik a szárazföldi és vízi ökoszisztémáknak.", FontSize = 16 }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Дихання рослин:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Дихання рослин є життєво важливим процесом, за допомогою якого вони одержують енергію, необхідну для виживання та росту. Хоча ми часто асоціюємо дихання з організмами, які мають легені або зябра, рослини здійснюють подібний, але в деталях відмінний процес дихання.", FontSize = 16 },
new Span { Text = "Процес дихання:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Дихання рослин включає в себе поглинання кисню та виділення вуглекислого газу, у процесі, протилежному фотосинтезу. Під час дихання рослини розкладають складні органічні молекули, такі як цукри, для отримання енергії, залишаючи кисень та вуглекислий газ як побічні продукти.", FontSize = 16 },
new Span { Text = "Органи, що залучені:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Основним органом, що залучений до дихання рослин, є стомат, мікроскопічна структура, яку знаходять в листках та стеблах. Стомати - це малі отвори, які дозволяють обмін газів між рослинами та навколишнім середовищем. Кисень поглинається через стомати під час дихання, а вуглекислий газ виділяється через ті ж самі отвори.", FontSize = 16 },
new Span { Text = "Адаптації до середовища:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Рослини розвинули різноманітні адаптації для ефективного управління диханням у різних середовищах. Наприклад, пустельні рослини можуть мати закриті стомати вдень для зменшення втрати води, відкриваючи їх вночі для здійснення дихання. У той же час, водні рослини можуть використовувати інші структури, такі як аеренхіми або лентіцели, для поглинання кисню з води.", FontSize = 16 },
new Span { Text = "Важливість дихання для рослин:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Дихання є важливим для рослин, оскільки воно забезпечує їм енергію для проведення метаболічних процесів та зростання. Без належного процесу дихання рослини не змогли б виробляти енергію і загинули б.", FontSize = 16 },
new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Дихання є життєво важливим процесом для рослин, який дозволяє їм отримувати енергію для виживання та росту. Через цей процес рослини демонструють значну здатність до адаптації до різних середовищ та є невід'ємною частиною сухопутних та водних екосистем.", FontSize = 16 }
            }
        };
    }
}
