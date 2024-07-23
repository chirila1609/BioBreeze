using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.NutriPages;

public partial class HPN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public HPN() : this(AudioManager.Current)
    {
    }

    public HPN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hpn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_HPN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutriHPN());
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
                new Span { FontSize = 15, Text = "Nutriția heterotrofă parazitară este un mod de nutriție întâlnit la anumite organisme care se bazează pe consumul materiei organice produse de alte organisme vii pentru a-și obține substanțele nutritive necesare. În acest mod de nutriție, organisme numite paraziți se atașează de gazdele lor și utilizează resursele acestora pentru a supraviețui și a se reproduce." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Paraziții se adaptează adesea pentru a se specializa în utilizarea anumitor organisme gazdă sau chiar a unor părți specifice ale acestora. Aceste organisme sunt adesea bine adaptate pentru a se conecta la gazdele lor și pentru a evita sistemele de apărare ale acestora. De exemplu, unele plante parazite se pot conecta la rădăcinile altor plante pentru a suge substanțele nutritive de care au nevoie." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Un aspect important al nutriției heterotrofe parazitare este capacitatea paraziților de a manipula gazdele lor pentru a-și maximiza propriul succes reproductiv. Acest lucru poate include modificări ale comportamentului gazdelor sau chiar transformări anatomice pentru a oferi un mediu mai favorabil pentru paraziți." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Deși relația parazitară poate fi dăunătoare pentru gazdele implicate, uneori paraziții și gazdele lor dezvoltă o coevoluție complexă, în care gazdele dezvoltă strategii de apărare împotriva paraziților, iar aceștia din urmă dezvoltă modalități de a depăși aceste strategii." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Exemple de organisme cu nutriție heterotrofă parazitară includ diverse specii de fungi paraziți, protozoare și insecte, precum și plante parazite precum ciupercile din genul Orobanche sau Cuscuta." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În concluzie, nutriția heterotrofă parazitară reprezintă un mod fascinant și adesea complex de supraviețuire în regnul biologic, cu implicații importante în ecologia și evoluția organismelor implicate." },
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
                new Span { Text = "Parazita heterotróf táplálkozás:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A parazita heterotróf táplálkozás olyan táplálkozási mód, amelyben egyes szervezetek más élő szervezetek által előállított szerves anyagot fogyasztják a szükséges tápanyagok megszerzéséhez. Ebben a táplálkozási módban parazitáknak nevezett szervezetek csatlakoznak gazdáikhoz, és azok erőforrásait használják fel a túléléshez és szaporodáshoz." },
new Span { Text = "\n" },
new Span { Text = "A paraziták gyakran alkalmazkodnak bizonyos gazdaszervezetek vagy akár azok meghatározott részeinek kihasználásához. Ezek a szervezetek jól alkalmazkodtak ahhoz, hogy csatlakozzanak gazdáikhoz, és elkerüljék azok védelmi rendszereit. Például egyes parazita növények csatlakozhatnak más növények gyökereihez, hogy elszívják a szükséges tápanyagokat." },
new Span { Text = "\n" },
new Span { Text = "A parazita heterotróf táplálkozás fontos aspektusa a paraziták azon képessége, hogy manipulálják gazdáikat saját szaporodási sikerük maximalizálása érdekében. Ez magában foglalhatja a gazdaszervezetek viselkedésének megváltoztatását vagy akár anatómiai átalakításokat is, hogy kedvezőbb környezetet biztosítsanak a paraziták számára." },
new Span { Text = "\n" },
new Span { Text = "Annak ellenére, hogy a parazita kapcsolat káros lehet az érintett gazdák számára, néha a paraziták és gazdáik összetett koevolúciót fejlesztenek ki, amelyben a gazdák védelmi stratégiákat alakítanak ki a paraziták ellen, míg a paraziták módszereket fejlesztenek ki ezeknek a stratégiáknak a leküzdésére." },
new Span { Text = "\n" },
new Span { Text = "A parazita heterotróf táplálkozású szervezetek példái közé tartoznak különböző parazita gombák, protozoák és rovarok, valamint parazita növények, például az Orobanche vagy Cuscuta nemzetségbe tartozó gombák." },
new Span { Text = "\n" },
new Span { Text = "Összefoglalva, a parazita heterotróf táplálkozás lenyűgöző és gyakran összetett túlélési mód a biológiai birodalomban, amely fontos következményekkel jár az érintett szervezetek ökológiájára és evolúciójára nézve." },
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
                new Span { Text = "Гетеротрофне паразитарне живлення:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Гетеротрофне паразитарне живлення - це спосіб живлення, який зустрічається у деяких організмів, що базується на споживанні органічної речовини, виробленої іншими живими організмами, для отримання необхідних поживних речовин. У цьому способі живлення організми, звані паразитами, приєднуються до своїх господарів і використовують їхні ресурси для виживання та розмноження." },
new Span { Text = "\n" },
new Span { Text = "Паразити часто пристосовуються до використання певних організмів-господарів або навіть певних частин цих організмів. Ці організми часто добре пристосовані для з'єднання з господарями та уникнення їхніх захисних систем. Наприклад, деякі паразитичні рослини можуть з'єднуватися з коренями інших рослин, щоб висмоктувати необхідні поживні речовини." },
new Span { Text = "\n" },
new Span { Text = "Важливим аспектом гетеротрофного паразитарного живлення є здатність паразитів маніпулювати своїми господарями для максимізації власного репродуктивного успіху. Це може включати зміни в поведінці господарів або навіть анатомічні перетворення для створення більш сприятливого середовища для паразитів." },
new Span { Text = "\n" },
new Span { Text = "Хоча паразитарні відносини можуть бути шкідливими для залучених господарів, іноді паразити та їхні господарі розвивають складну коеволюцію, в якій господарі розробляють стратегії захисту від паразитів, а паразити, у свою чергу, розробляють способи подолання цих стратегій." },
new Span { Text = "\n" },
new Span { Text = "Прикладами організмів з гетеротрофним паразитарним живленням є різні види паразитичних грибів, найпростіших і комах, а також паразитичні рослини, такі як гриби з роду Orobanche або Cuscuta." },
new Span { Text = "\n" },
new Span { Text = "Отже, гетеротрофне паразитарне живлення є захоплюючим і часто складним способом виживання у біологічному царстві, з важливими наслідками для екології та еволюції залучених організмів." },
new Span { Text = "\n" }
            }
        };
    }
}
