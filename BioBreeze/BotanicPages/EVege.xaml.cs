using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class EVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EVege() : this(AudioManager.Current)
    {
    }

    public EVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("evege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotEVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotEVege());
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
                new Span {FontSize=15, Text="Excreția la plante reprezintă un proces fundamental prin care organismele vegetale elimină substanțe deșeurilor și excesul de substanțe din corpul lor. Acest proces este crucial pentru menținerea echilibrului intern și pentru asigurarea sănătății și creșterii optime a plantelor." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Principalul mecanism de excreție la plante este reprezentat de transpirație și de eliminarea substanțelor prin glandele speciale. Transpirația constă în pierderea de apă sub formă de vapori prin stomatele situate pe suprafața frunzelor. Acest proces are loc în timpul fotosintezei și ajută la răcirea plantei și la absorbția eficientă a substanțelor nutritive și a apei din sol." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Pe lângă transpirație, plantele excretă și substanțe deșeu prin rădăcini. În sol, rădăcinile eliberează substanțe chimice reziduale și substanțe toxice care ar putea afecta sănătatea lor sau a altor plante din apropiere. Acest proces este esențial pentru curățarea solului și menținerea unui mediu propice pentru creșterea plantelor." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Unele plante dezvoltă glande speciale pentru excreție, cum ar fi glandele de sare la plantele halofile, care le permit să elimine excesul de sare din corpul lor în medii saline. De asemenea, anumite plante medicinale produc uleiuri esențiale sau alte substanțe chimice pentru a se proteja împotriva dăunătorilor sau pentru a atrage polenizatori, iar aceste substanțe pot fi considerate forme de excreție." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="În concluzie, excreția la plante este un proces esențial pentru menținerea echilibrului intern și pentru asigurarea sănătății și creșterii optime a acestora. Prin transpirație, eliminare prin rădăcini și alte mecanisme specifice, plantele își gestionează eficient deșeurile și excesul de substanțe, contribuind astfel la sănătatea ecosistemelor în care se dezvoltă." },
                new Span {Text="\n" }
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Növények kiválasztása: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények kiválasztása alapvető folyamat, amely során a növényi szervezetek eltávolítják a hulladékanyagokat és a testükben lévő anyagok feleslegét. Ez a folyamat létfontosságú a belső egyensúly fenntartásához és a növények optimális egészségének és növekedésének biztosításához.", FontSize = 16 },
new Span { Text = "A kiválasztás fő mechanizmusa a növényeknél a transzpiráció és a speciális mirigyek általi anyagok eltávolítása. A transzpiráció során a növények vizet veszítenek el gőz formájában a levelek felületén elhelyezkedő stomaták által. Ez a folyamat a fotoszintézis során történik, és segít a növény hűtésében és a talajból való hatékony tápanyagok és víz felszívásában.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A transzpiráció mellett a növények a rizómaanyagokat is kiválasztják a gyökerek révén. A gyökerek a talajban maradék kémiai anyagokat és mérgező anyagokat bocsátanak ki, amelyek befolyásolhatják egészségüket vagy más növényeket a környéken. Ez a folyamat alapvető fontosságú a talaj tisztításához és egy kedvező környezet fenntartásához a növények növekedéséhez.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Néhány növény speciális kiválasztási mirigyeket fejleszt ki, például a sómirigyek a halofil növényekben, amelyek lehetővé teszik számukra, hogy eltávolítsák a testükből a felesleges sót sós környezetben. Ezenkívül egyes gyógynövények esszenciális olajokat vagy más kémiai anyagokat termelnek, hogy védekezzenek a kártevők ellen vagy vonzzák a beporzókat, és ezeket az anyagokat a kiválasztás formáinak lehet tekinteni.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Következtetés: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények kiválasztása létfontosságú folyamat a belső egyensúly fenntartásához és a növekedésük optimális egészségének biztosításához. A transzpiráció, a gyökerek általi kiválasztás és más specifikus mechanizmusok révén a növények hatékonyan kezelik hulladékaikat és anyagfeleslegeiket, hozzájárulva ezzel a környezetek egészségéhez, ahol fejlődnek.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Виведення в рослин: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Виведення в рослин є фундаментальним процесом, за допомогою якого рослини видаляють відходи та надлишок речовин з їх тіла. Цей процес є критичним для підтримки внутрішнього балансу та забезпечення оптимального здоров'я та зростання рослин.", FontSize = 16 },
new Span { Text = "Основний механізм виведення в рослин - це транспірація та виведення речовин через спеціальні залози. Транспірація полягає в втраті води у вигляді пари через стомати, що розташовані на поверхні листків. Цей процес відбувається під час фотосинтезу і допомагає в охолодженні рослини та ефективному всмоктуванні поживних речовин і води з ґрунту.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Крім транспірації, рослини також виводять відходи через корені. У ґрунті корені виділяють хімічні залишки та токсичні речовини, які можуть впливати на їх здоров'я або здоров'я інших рослин у навколишньому середовищі. Цей процес є важливим для очищення ґрунту та забезпечення сприятливого середовища для зростання рослин.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Деякі рослини розвивають спеціальні залози для виведення, такі як солеві залози у галофільних рослин, які дозволяють їм видаляти зайвий сіль з їх тіла у солоних середовищах. Крім того, деякі лікарські рослини виробляють ефірні олії та інші хімічні речовини для захисту від шкідників або приваблювання запилювачів, і ці речовини можуть бути розглянуті як форми виведення.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Висновок: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Виведення в рослин є фундаментальним процесом для підтримки внутрішнього балансу та забезпечення оптимального здоров'я та зростання рослин. Через транспірацію, виведення через корені та інші специфічні механізми рослини ефективно вирішують виведення відходів та надлишків речовин, сприяючи здоров'ю екосистем, де вони розвиваються.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
            }
        };
    }
}
