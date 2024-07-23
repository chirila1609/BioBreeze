using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class Cromozomii : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player;

    public Cromozomii() : this(AudioManager.Current)
    {
    }

    public Cromozomii(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("cromozomii.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenCromozomii(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenCromozomii());
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
                new Span { FontSize = 15, Text = "Cromozomii sunt structuri esențiale ale celulelor care conțin materialul genetic și care joacă un rol crucial în transmiterea informației genetice de la o generație la alta în cadrul organismelor vii. Acestea sunt prezente în nucleul celular și sunt vizibile în timpul diviziunii celulare, în special în timpul diviziunii celulare sexuale (meioză) și a diviziunii celulare asexuate (mitoză)." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Fiecare specie are un număr specific de cromozomi, care este caracteristic pentru acea specie. Cromozomii sunt formați dintr-o moleculă lungă de acid dezoxiribonucleic (ADN), care este împachetată strâns în jurul unor proteine numite histone. Structura compactă a cromozomilor permite organizarea și păstrarea informației genetice într-un mod eficient." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Principalele funcții ale cromozomilor sunt:" },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { Text = "1. Transmiterea ereditară a informației genetice: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Cromozomii sunt responsabili pentru transmiterea caracteristicilor ereditare de la părinți la descendenți. Această transmitere are loc prin intermediul gametelor (spermă și ovule) în timpul reproducției sexuate." },
new Span { Text = "\n" },
new Span { Text = "2. Controlul proceselor celulare: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Cromozomii conțin gene care codifică proteine esențiale pentru funcționarea celulei. Aceste gene controlează procesele celulare, cum ar fi metabolismul, diviziunea celulară și răspunsurile la mediu." },
new Span { Text = "\n" },
new Span { Text = "3. Variabilitatea genetică: ", FontAttributes = FontAttributes.Bold },
new Span { FontSize = 15, Text = "Cromozomii sunt sursa principală a variabilității genetice în cadrul unei populații. Fenomene precum recombinarea genetică și mutațiile contribuie la diversitatea genetică a indivizilor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "În funcție de structura și numărul lor, cromozomii pot fi împărțiți în două tipuri principale: autosomi și cromozomi sexuali. Autosomii sunt cromozomii care nu determină sexul organismului și sunt prezentați în perechi omoloage în celulele somatice. Cromozomii sexuali determină sexul și pot varia în funcție de specie." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Studiul cromozomilor este esențial în înțelegerea eredității și a diversității genetice a vieții pe Pământ. Tehnici precum cariotiparea și hibridizarea in situ sunt utilizate pentru analiza structurii și funcției cromozomilor în diferite organisme." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Prin urmare, cromozomii sunt componente fundamentale ale celulelor și sunt esențiali pentru diversitatea și perpetuarea vieții pe Terra." },
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
                new Span { Text = "A kromoszómák:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A kromoszómák a sejtek alapvető struktúrái, amelyek genetikai anyagot tartalmaznak, és kulcsfontosságú szerepet játszanak a genetikai információ egyik generációról a másikra történő átadásában az élő szervezetekben. Ezek a sejtmagban vannak jelen, és sejtosztódás során láthatóak, különösen a szexuális sejtosztódás (meiózis) és az ivartalan sejtosztódás (mitózis) során." },
new Span { Text = "\n" },
new Span { Text = "Minden fajnak megvan a maga specifikus kromoszómaszáma, amely jellemző az adott fajra. A kromoszómák egy hosszú dezoxiribonukleinsav (DNS) molekulából állnak, amely szorosan van csomagolva a hiszton nevű fehérjék köré. A kromoszómák kompakt szerkezete lehetővé teszi a genetikai információ hatékony szervezését és megőrzését." },
new Span { Text = "\n" },
new Span { Text = "A kromoszómák fő funkciói a következők:" },
new Span { Text = "\n" },
new Span { Text = "1. Genetikai információ örökítése:", FontAttributes = FontAttributes.Bold },
new Span { Text = " A kromoszómák felelősek az öröklődő tulajdonságok átadásáért a szülőktől az utódokig. Ez az átadás a gaméták (sperma és petesejt) révén történik a szexuális szaporodás során." },
new Span { Text = "\n" },
new Span { Text = "2. Sejtfolyamatok szabályozása:", FontAttributes = FontAttributes.Bold },
new Span { Text = " A kromoszómák olyan géneket tartalmaznak, amelyek a sejtműködéshez szükséges fehérjéket kódolják. Ezek a gének szabályozzák a sejtfunkciókat, mint például az anyagcserét, a sejtosztódást és a környezeti válaszokat." },
new Span { Text = "\n" },
new Span { Text = "3. Genetikai változatosság:", FontAttributes = FontAttributes.Bold },
new Span { Text = " A kromoszómák a genetikai változatosság fő forrásai egy populációban. A genetikai rekombináció és mutációk hozzájárulnak az egyének genetikai sokféleségéhez." },
new Span { Text = "\n" },
new Span { Text = "A kromoszómák szerkezetük és számuk alapján két fő típusba sorolhatók: autoszómák és ivari kromoszómák. Az autoszómák azok a kromoszómák, amelyek nem határozzák meg a szervezet nemét, és homológ párokban vannak jelen a szomatikus sejtekben. Az ivari kromoszómák határozzák meg a nemet, és fajonként változhatnak." },
new Span { Text = "\n" },
new Span { Text = "A kromoszómák tanulmányozása elengedhetetlen az öröklődés és az élet genetikai sokféleségének megértéséhez. Olyan technikákat, mint a kariotipizálás és az in situ hibridizáció, használják a kromoszómák szerkezetének és funkciójának elemzésére különböző szervezetekben." },
new Span { Text = "\n" },
new Span { Text = "Ennek megfelelően a kromoszómák a sejtek alapvető alkotóelemei, és létfontosságúak az élet sokféleségének és fennmaradásának szempontjából a Földön." },
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
                new Span { Text = "Хромосоми:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Хромосоми - це основні структури клітин, що містять генетичний матеріал і відіграють вирішальну роль у передачі генетичної інформації від одного покоління до іншого в живих організмах. Вони присутні в ядрі клітини і помітні під час клітинного поділу, особливо під час статевого поділу (мейоз) і безстатевого поділу (мітоз)." },
new Span { Text = "\n" },
new Span { Text = "Кожен вид має специфічну кількість хромосом, характерну для цього виду. Хромосоми складаються з довгої молекули дезоксирибонуклеїнової кислоти (ДНК), яка щільно упакована навколо білків, званих гістонів. Компактна структура хромосом дозволяє ефективно організувати і зберігати генетичну інформацію." },
new Span { Text = "\n" },
new Span { Text = "Основні функції хромосом:" },
new Span { Text = "\n" },
new Span { Text = "1. Передача спадкової інформації:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Хромосоми відповідають за передачу спадкових ознак від батьків до нащадків. Ця передача відбувається через гамети (сперматозоїди і яйцеклітини) під час статевого розмноження." },
new Span { Text = "\n" },
new Span { Text = "2. Контроль клітинних процесів:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Хромосоми містять гени, які кодують білки, необхідні для функціонування клітини. Ці гени контролюють клітинні процеси, такі як метаболізм, поділ клітин і реакції на навколишнє середовище." },
new Span { Text = "\n" },
new Span { Text = "3. Генетична варіабельність:", FontAttributes = FontAttributes.Bold },
new Span { Text = " Хромосоми є основним джерелом генетичної варіабельності в популяції. Такі явища, як генетична рекомбінація і мутації, сприяють генетичній різноманітності особин." },
new Span { Text = "\n" },
new Span { Text = "Залежно від структури і кількості, хромосоми можна розділити на два основні типи: аутосоми і статеві хромосоми. Аутосоми - це хромосоми, які не визначають стать організму і присутні в парних гомологічних клітинах. Статеві хромосоми визначають стать і можуть відрізнятися залежно від виду." },
new Span { Text = "\n" },
new Span { Text = "Вивчення хромосом є важливим для розуміння спадковості і генетичної різноманітності життя на Землі. Такі методи, як каріотипування і гібридизація in situ, використовуються для аналізу структури і функції хромосом у різних організмах." },
new Span { Text = "\n" },
new Span { Text = "Таким чином, хромосоми є основними компонентами клітин і необхідні для різноманітності і збереження життя на Землі." },
new Span { Text = "\n" }

            }
        };
    }
}
