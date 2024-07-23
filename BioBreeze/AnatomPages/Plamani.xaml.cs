using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Plamani : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Plamani() : this(AudioManager.Current)
    {
    }

    public Plamani(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("plamani.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomiePL(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomiePL());
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
                        new Span {Text="Structura plămânilor: ", FontAttributes=FontAttributes.Bold, FontSize=20 },
                        new Span {Text="\n" },
                        new Span {Text="1. Bronhiile și bronhiile terminale: ", FontAttributes=FontAttributes.Bold, FontSize=15 },
                        new Span {FontSize=15, Text="Plămânii sunt alcătuiți dintr-un sistem complex de tuburi numite bronhii și bronhiole, care se ramifică pentru a ajunge în toate zonele plămânilor." },
                        new Span {Text="\n" },
                        new Span {Text="2. Alveolele: ", FontAttributes=FontAttributes.Bold, FontSize=15 },
                        new Span {FontSize=15, Text="Aceste mici saci de aer sunt situate la capătul bronhiilor și bronhiiolelor și reprezintă locul principal de schimb de gaze. Aici, oxigenul este preluat din aer și dioxidul de carbon este eliminat." },
                        new Span {Text="\n" },
                        new Span {Text="3. Capilarele sanguine: ", FontAttributes=FontAttributes.Bold, FontSize=15 },
                        new Span {FontSize=15, Text="Alveolele sunt înconjurate de o rețea densă de capilare sanguine, ceea ce facilitează schimbul rapid de gaze între aerul respirat și sânge." },
                        new Span {Text="\n" },
                        new Span {Text="\n" },
                        new Span {Text="Funcția plămânilor: ", FontAttributes=FontAttributes.Bold, FontSize=20 },
                        new Span {Text="\n" },
                        new Span {Text="1. Respirația: ", FontAttributes=FontAttributes.Bold },
                        new Span {FontSize=15, Text="Plămânii permit procesul de respirație, în care oxigenul este preluat din aer și introdus în sânge, în timp ce dioxidul de carbon este eliminat din sânge și excretat în aerul expirat." },
                        new Span {Text="\n" },
                        new Span {Text="2. Reglarea pH-ului:", FontAttributes=FontAttributes.Bold },
                        new Span {FontSize=15, Text="Plămânii joacă un rol important în menținerea echilibrului acido-bazic în organism prin eliminarea dioxidului de carbon, un produs de excreție care poate afecta pH-ul sanguin." },
                        new Span {Text="\n" },
                        new Span {Text="3. Protecția împotriva infecțiilor: ", FontAttributes=FontAttributes.Bold },
                        new Span {FontSize=15, Text="Plămânii sunt, de asemenea, echipați cu mecanisme de apărare, cum ar fi mucoasa și sistemul imunitar local, care îi protejează împotriva agenților patogeni și particulelor străine inhalate." },
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                new Span { Text = "A tüdők szerkezete: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "1. Hörghurkok és terminális hörghurkok: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A tüdők bonyolult csövekből álló rendszert alkotnak, amelyeket hörghurkoknak és hörghurkák neveznek, és elágaznak az összes tüdőterület eléréséhez.", FontSize = 16 },
new Span { Text = "2. Alveolusok: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Ezek a kis levegőzacskók a hörghurkok és hörghurkák végén helyezkednek el, és a gázcsere fő helyszínei. Itt az oxigén levegőből történő felvétele és a széndioxid eltávolítása történik.", FontSize = 16 },
new Span { Text = "3. Véredények: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Az alveolusokat sűrű vérerek hálózzák be, amelyek lehetővé teszik a gyors gázcsere lehetőségét a belélegzett levegő és a vér között.", FontSize = 16 },
new Span { Text = "A tüdők funkciója: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "1. Lélegzés: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A tüdők lehetővé teszik a légzés folyamatát, amely során az oxigén a levegőből bekerül a vérbe, míg a széndioxid eltávolításra kerül a vérkeringésből és kiválasztódik a kilélegzett levegőben.", FontSize = 16 },
new Span { Text = "2. pH szabályozás: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A tüdők fontos szerepet játszanak a szervezet sav-bázis egyensúlyának fenntartásában a szén-dioxid eltávolításával, ami a kiválasztás terméke, és befolyásolhatja a vér pH-ját.", FontSize = 16 },
new Span { Text = "3. Védettség fertőzésekkel szemben: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A tüdők védelmi mechanizmusokkal vannak ellátva, mint például a nyálkahártya és a helyi immunrendszer, amelyek védelmet nyújtanak a belélegzett patogének és idegen részecskék ellen.", FontSize = 16 }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                new Span { Text = "Структура легенів: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "1. Бронхії та термінальні бронхіоли: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Легені складаються зі складної системи трубок, що називаються бронхії та бронхіоли, які розгалужуються для досягнення всіх зон легенів.", FontSize = 16 },
new Span { Text = "2. Альвеоли: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Ці малі повітряні мішки розташовані в кінці бронхій та бронхіол, і є основним місцем обміну газів. Тут кисень забирається з повітря, а вуглекислий газ виводиться.", FontSize = 16 },
new Span { Text = "3. Капіляри кровоносні: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Альвеоли оточені густою мережею кровоносних капілярів, що сприяє швидкому обміну газів між вдиханим повітрям і кров'ю.", FontSize = 16 },
new Span { Text = "Функція легенів: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "1. Дихання: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Легені дозволяють процес дихання, під час якого кисень забирається з повітря і вводиться в кров, а вуглекислий газ видаляється з крові і виділяється у видиханому повітрі.", FontSize = 16 },
new Span { Text = "2. Регулювання рН: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Легені грають важливу роль у підтримці кислотно-лужного балансу в організмі, видаляючи вуглекислий газ, що є продуктом виведення, який може впливати на кислотно-лужний баланс крові.", FontSize = 16 },
new Span { Text = "3. Захист від інфекцій: ", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Легені також обладнані захисними механізмами, такими як слизова оболонка і місцева імунна система, які захищають їх від патогенів та чужорідних частинок, що надходять разом з вдиханим повітрям.", FontSize = 16 }
                }
        };
    }
}
