using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class CAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public CAnimale() : this(AudioManager.Current)
    {
    }

    public CAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("canimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooCAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooCAnimale());
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
                new Span { FontSize = 15, Text = "Circulația sângelui este un proces vital în organismele animale, furnizând substanțe nutritive și oxigen în întregul corp și eliminând deșeurile metabolice. Acest proces este realizat prin intermediul unui sistem complex de vase de sânge și inimi care variază în funcție de tipul de animal." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Sistemul Circulator la Vertebrate", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Majoritatea vertebratelor, inclusiv mamiferele, păsările, reptilele și peștii, prezintă un sistem circulator închis, în care sângele este pompat printr-un circuit închis de vase de sânge. Acest sistem este compus din două tipuri principale de vase de sânge: artere și vene. Arterele transportă sângele de la inimă la țesuturi, în timp ce venele îl transportă înapoi la inimă." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Inima la vertebrate poate fi un organ simplu, cum ar fi inima la pești, care constă dintr-o cameră simplă de pompare, sau un organ mai complex, cum ar fi inima umană, care are patru camere distincte. Inima funcționează ca o pompă, contractându-se și pompează sângele în jurul corpului." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Sistemul Circulator la Nevertebrate", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În contrast, nevertebratele, cum ar fi insectele și moluștele, au adesea un sistem circulator deschis, în care sângele este pompat direct în cavitățile corpului, numite hemoceli. Sângele transportă substanțe nutritive și oxigen direct la țesuturi și apoi este colectat în vase speciale numite sinuse, unde este filtrat și trimis înapoi în inimă pentru reciclare." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Adaptări și Varietăți", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Circulația sângelui la animale s-a adaptat în moduri variate pentru a satisface cerințele specifice ale fiecărui mediu și stil de viață. De exemplu, la animalele care trăiesc la altitudini mari sau în apă rece, sângele poate avea niveluri mai ridicate de hemoglobină pentru a transporta mai mult oxigen. La animalele care trăiesc în medii extreme, cum ar fi păsările migratoare, inima și vasele de sânge pot fi adaptate pentru a face față stresului suplimentar." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "Concluzie", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Circulația sângelui este o caracteristică esențială a vieții animale și este esențială pentru funcționarea corectă a organismelor. Varietatea de sisteme circulatorii întâlnite în regnul animal reflectă diversitatea adaptărilor la medii și moduri de viață diferite. Studiul circulației la animale aduce o înțelegere mai profundă a complexității biologice și a modului în care organismele se adaptează la mediul lor." },
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
                new Span { Text = "A vérkeringés az állatokban:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A vérkeringés egy létfontosságú folyamat az állatokban, táplálékokat és oxigént szállítva az egész testben, és eltávolítva az anyagcsere hulladékait. Ez a folyamat egy bonyolult vérerek és szívek rendszerén keresztül valósul meg, amely változik az állat típusától függően." },
new Span { Text = "\n" },
new Span { Text = "A Keringési Rendszer Gerinceseknél:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A gerincesek többsége, beleértve a emlősöket, madarakat, hüllőket és halakat, zárt keringési rendszert mutatnak be, ahol a vér egy zárt vérerek körén keresztül pumpálódik. Ez a rendszer két fő vérerek típusból áll: artériák és vénák. Az artériák a szívből szállítják a vért a szövetekbe, míg a vénák visszaadják azt a szívbe." },
new Span { Text = "\n" },
new Span { Text = "A Szív Gerinceseknél:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A nem gerincesek, mint például az rovarok és puhatestűek, gyakran nyitott keringési rendszert mutatnak be, ahol a vér közvetlenül a test üregeibe, a hemocoelokba pumpálódik. A vér táplálékokat és oxigént szállít közvetlenül a szövetekhez, majd speciális sinusokban gyűjtik össze, ahol szűrik és visszaküldik a szívbe újrafelhasználásra." },
new Span { Text = "\n" },
new Span { Text = "Adaptációk és Variációk:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A vérkeringés az állatoknál különböző módon alkalmazkodott minden környezet és életmód specifikus követelményéhez. Például magas tengerszintű és hideg vízi környezetben élő állatoknál a vér magas hemoglobin szinttel rendelkezhet, hogy több oxigént szállítson. Az extrém környezetekben élő állatoknál, mint például a vándormadaraknál, a szív és a vérerek alkalmazkodhatnak a további stresszel való megbirkózásra." },
new Span { Text = "\n" },
new Span { Text = "Következtetés:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A vérkeringés létfontosságú jellemző az állati életben, és alapvető a szervezetek megfelelő működéséhez. Az állatok királyságában előforduló keringési rendszerek sokfélesége tükrözi az adaptációk sokféleségét a különböző környezetekhez és életmódokhoz. Az állatok vérkeringésének tanulmányozása mélyebb megértést nyújt a biológiai bonyolultságról és arról, hogyan alkalmazkodnak az élőlények környezetükhöz." },
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
                new Span { Text = "Циркуляція крові у тваринах:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Циркуляція крові є життєво важливим процесом у тваринах, який забезпечує постачання поживних речовин і кисню по всьому організму та видалення метаболічних відходів. Цей процес здійснюється через складну систему кровоносних судин і сердець, які варіюються залежно від типу тварини." },
new Span { Text = "\n" },
new Span { Text = "Кровообіг у хребетних:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Більшість хребетних, включаючи ссавців, птахів, плазунів та риб, мають закриту кровообігову систему, в якій кров перекачується через закритий круг кровоносних судин. Ця система складається з двох основних типів кровоносних судин: артерій і вен. Артерії переносять кров від серця до тканин, тоді як вени повертають її назад до серця." },
new Span { Text = "\n" },
new Span { Text = "Серце у хребетних:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "У відміну від хребетних, безхребетні, такі як комахи та молюски, часто мають відкриту кровообігову систему, де кров прямо перекачується в порожнини тіла, звані гемоцели. Кров переносить поживні речовини і кисень безпосередньо до тканин, а потім збирається в спеціальних синусах, де її фільтрують і відправляють назад у серце для повторного використання." },
new Span { Text = "\n" },
new Span { Text = "Адаптації та різноманіття:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Циркуляція крові у тваринах адаптувалася на різні способи, щоб задовольнити специфічні вимоги кожного середовища та способу життя. Наприклад, у тварин, які живуть на великій висоті або в холодній воді, кров може містити високі рівні гемоглобіну для транспорту більше кисню. У тварин, які живуть в екстремальних середовищах, таких як мігруючі птахи, серце і кровоносні судини можуть адаптуватися для подолання додаткового стресу." },
new Span { Text = "\n" },
new Span { Text = "Висновок:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Циркуляція крові є невід'ємною ознакою тваринного життя і важлива для правильної роботи організмів. Різноманіття систем кровообігу, що зустрічаються в царстві тварин, відображає різноманітність адаптацій до різних середовищ та способів життя. Вивчення циркуляції у тварин приносить глибше розуміння біологічної складності та того, як організми адаптуються до свого середовища." },
new Span { Text = "\n" }
            }
        };
    }
}
