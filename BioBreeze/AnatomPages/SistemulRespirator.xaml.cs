using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulRespirator : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulRespirator() : this(AudioManager.Current)
    {
    }

    public SistemulRespirator(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulrespirator.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSR(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSR());
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
                    new Span {FontSize=15, Text="Sistemul respirator este esențial pentru supraviețuirea organismelor vii, furnizând oxigen în organism și eliminând dioxidul de carbon, un produs deșeu al metabolismului celular. Acest sistem complex este alcătuit dintr-o serie de structuri și organe care lucrează împreună pentru a asigura schimbul adecvat de gaze între organism și mediul înconjurător." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="La nivelul sistemului respirator uman, acesta include căile respiratorii superioare, cum ar fi nasul, faringele și laringele, precum și căile respiratorii inferioare, cum ar fi traheea, bronhiile și plămânii. Procesul începe cu inhalarea aerului prin nas sau gură, care apoi călătorește prin căile respiratorii către plămâni. În plămâni, aerul este distribuit prin bronhiole către alveolele pulmonare, unde are loc schimbul de gaze între aerul inhalat și sângele circulant." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="La nivelul alveolelor, oxigenul este preluat de hemoglobina din sânge și transportat către celulele corpului, în timp ce dioxidul de carbon este eliminat din sânge și expirat în atmosferă. Acest proces, cunoscut sub numele de respirație celulară, este esențial pentru generarea energiei necesare pentru funcționarea optimă a organismului." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="În plus față de schimbul de gaze, sistemul respirator are și rolul de a filtra, încălzi și umidifica aerul inhalat, protejând astfel plămânii împotriva agenților patogeni și a substanțelor iritante din mediu." }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "A légzőrendszer alapvető fontosságú az élő szervezetek számára, oxigént szállít a szervezetbe és eltávolítja a szén-dioxidot, ami a sejtek anyagcseréjének mellékterméke. Ez a bonyolult rendszer számos struktúrából és szervből áll, amelyek együttműködve biztosítják a megfelelő gázcsere folyamatot az élőlény és környezete között.", FontSize = 16 },
new Span { Text = "Az emberi légzőrendszer magában foglalja a felső légutakat, mint az orr, garat és gége, valamint az alsó légutakat, mint a légcső, hörgők és tüdők. A folyamat az orron vagy szájon át történő levegő belégzésével kezdődik, amely ezután az légutakon keresztül a tüdőbe jut. A tüdőben a levegő a hörgőkön keresztül eljut az alveolusokba, ahol létrejön a gázcsere a belélegzett levegő és a keringő vér között.", FontSize = 16 },
new Span { Text = "Az alveolusok szintjén az oxigén a vérben lévő hemoglobinhoz kötődik és szállítódik a test sejtjeihez, míg a szén-dioxid eltávolítása a vérkeringésből és kifújása a légkörbe. Ezt a folyamatot, amelyet sejtes légzésnek nevezünk, az szervezet optimális működéséhez szükséges energia előállításához használják.", FontSize = 16 },
new Span { Text = "A gázcsere mellett a légzőrendszer szűréséért, melegítéséért és párásításáért is felelős, így védi a tüdőt a környezeti kórokozóktól és irritáló anyagoktól.", FontSize = 16 }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Дихальна система є ключовою для виживання живих організмів, постачаючи кисень в організм і видаляючи вуглекислий газ, продукт обміну речовин у клітинах. Ця складна система складається з численних структур і органів, які спільно забезпечують належну обмін газів між організмом і навколишнім середовищем.", FontSize = 16 },
new Span { Text = "На рівні людської дихальної системи вона включає верхні дихальні шляхи, такі як ніс, горло та гортань, а також нижні дихальні шляхи, такі як трахея, бронхії та легені. Процес починається з вдихання повітря через ніс або рот, яке потім подорожує по дихальних шляхах до легенів. У легенях повітря розподіляється через бронхіоли до альвеол, де відбувається обмін газів між вдихнутим повітрям та кров'ю, що циркулює.", FontSize = 16 },
new Span { Text = "На рівні альвеол кисень забирається гемоглобіном з крові та транспортується до клітин організму, тоді як вуглекислий газ видаляється з крові та видихається в атмосферу. Цей процес, відомий як клітинне дихання, є необхідним для вироблення енергії, необхідної для оптимального функціонування організму.", FontSize = 16 },
new Span { Text = "Окрім обміну газів, дихальна система також відповідає за фільтрацію, нагрівання і зволоження вдиханого повітря, захищаючи тим самим легені від патогенів та подразнювальних речовин.", FontSize = 16 }
                }
        };
    }
}
