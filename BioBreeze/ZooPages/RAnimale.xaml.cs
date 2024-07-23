using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class RAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public RAnimale() : this(AudioManager.Current)
    {
    }

    public RAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ranimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooRAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooRAnimale());
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
                new Span { FontSize = 15, Text = "Respirația în lumea animală este o funcție vitală esențială pentru supraviețuirea fiecărui organism. Această proces se desfășoară în moduri variate, adaptate la mediul și nevoile specifice ale fiecărei specii." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Majoritatea animalelor terestre, inclusiv mamiferele, reptilele și unele nevertebrate, utilizează un sistem de plămâni sau alte organe specializate pentru a obține oxigenul necesar și a elimina dioxidul de carbon rezidual. De exemplu, mamiferele au plămâni cu alveole, structuri microscopice care facilitează schimbul de gaze între aerul inspirat și sângele circulant în sistemul lor circulator." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Pe de altă parte, unele creaturi acvatice, precum peștii și crustaceele, folosesc branhii pentru a extrage oxigenul din apă. Branhiile sunt adesea formate din lamele subțiri sau filamentare care cresc în număr și sunt bine vascularizate pentru a permite absorbția maximă de oxigen și eliminarea eficientă a dioxidului de carbon." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În contrast, unele organisme mici, cum ar fi protozoarele și unele nevertebrate simple, pot realiza schimburile de gaze prin difuzie directă prin membrana lor celulară, deoarece dimensiunile lor reduse permit o cantitate adecvată de oxigen să pătrundă în celulele lor fără a avea nevoie de sisteme respiratorii specializate." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Un alt exemplu interesant este cel al păsărilor, care au un sistem respirator unic numit flux contracurent. Acest sistem implică faptul că aerul este direcționat printr-un flux unidirecțional în plămânii păsărilor, ceea ce optimizează schimbul de gaze și le permite să supraviețuiască la altitudini ridicate și în condiții de zbor extenuant." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, diversitatea respirației în lumea animală este remarcabilă, fiecare specie adaptându-și mecanismele de respirație în funcție de mediul său specific și cerințele sale metabolice. Acesta este un exemplu frapant al adaptării creatoare a vieții pentru a supraviețui și a prospera într-o gamă largă de medii și condiții." },
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
                new Span { Text = "Lélegzés az állatvilágban:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A lélegzés az állatok világában létfontosságú, alapvető funkció minden szervezet túléléséhez. Ez a folyamat változatos módon zajlik, amelyeket az adott fajok környezetéhez és specifikus igényeihez igazítanak." },
new Span { Text = "\n" },
new Span { Text = "A legtöbb szárazföldi állat, beleértve a emlősöket, hüllőket és néhány gerinctelen állatot, tüdőrendszert vagy más szakosodott szerveket használ a szükséges oxigén beszerzésére és a felesleges szén-dioxid eltávolítására. Például az emlősök alveolákkal rendelkező tüdeje mikroszkopikus szerkezetek, amelyek lehetővé teszik a gázcsere optimális kialakítását a belélegzett levegő és a keringő vér között." },
new Span { Text = "\n" },
new Span { Text = "Másrészt néhány vízi lény, mint például a halak és a rákok, kopoltyúkat használnak az oxigén kinyerésére a vízből. A kopoltyúk gyakran vékony vagy filamentális lemezekből állnak, amelyek számuk növelésével és jól kifejlett vérellátottságukkal maximális oxigénfelvételt és hatékony szén-dioxid eltávolítást tesznek lehetővé." },
new Span { Text = "\n" },
new Span { Text = "Például a madaraknak egyedi légzőrendszere van, amit keresztáramlású légáramnak nevezünk. Ez a rendszer egyirányú légáramlást biztosít a madarak tüdejében, amely optimalizálja a gázcsere folyamatát, és lehetővé teszi számukra, hogy nagy magasságokban és kimerítő repülési körülmények között is túléljenek." },
new Span { Text = "\n" },
new Span { Text = "Összességében az állatvilág lélegzési változatossága figyelemre méltó, mindegyik faj saját lélegzési mechanizmusait alkalmazkodja saját specifikus környezetéhez és anyagcserés igényeihez. Ez egy lenyűgöző példa az élet kreatív alkalmazkodására a túléléshez és a virágzásához széles körű környezetekben és körülmények között." },
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
                new Span { Text = "Дихання у світі тварин:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Дихання у світі тварин є життєво важливою функцією, необхідною для виживання кожного організму. Цей процес здійснюється різними способами, адаптованими до середовища та специфічних потреб кожного виду." },
new Span { Text = "\n" },
new Span { Text = "Більшість наземних тварин, включаючи ссавців, рептилії та деякі безхребетні, використовують систему легенів або інші спеціалізовані органи для забезпечення потреби в кисні та видалення вуглекислого газу. Наприклад, у ссавців є легені з альвеолями, мікроскопічними структурами, що полегшують обмін газів між вдиханим повітрям та кров'ю, що циркулює в їх кровоносній системі." },
new Span { Text = "\n" },
new Span { Text = "З іншого боку, деякі водні істоти, такі як риби і ракоподібні, використовують зябра для видобуття кисню з води. Зябра часто складаються з тонких чи філаментарних пластинок, що збільшуються в кількості і мають добре розвинену васкуляризацію для максимального поглинання кисню та ефективного видалення вуглекислого газу." },
new Span { Text = "\n" },
new Span { Text = "Наприклад, птахи мають унікальну систему дихання, відому як контртоковий потік. Ця система передбачає однонапрямний потік повітря в легенях птахів, що оптимізує обмін газів та дозволяє їм виживати на великих висотах і в умовах виснажливого польоту." },
new Span { Text = "\n" },
new Span { Text = "Загалом, різноманітність дихання у світі тварин є помітною, кожен вид адаптує свої механізми дихання в залежності від свого конкретного середовища та метаболічних вимог. Це є вражаючим прикладом творчої адаптації життя для виживання та процвітання в широкому спектрі середовищ і умов." },
new Span { Text = "\n" }
            }
        };
    }
}
