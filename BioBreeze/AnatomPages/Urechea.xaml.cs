using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Urechea : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Urechea() : this(AudioManager.Current)
    {
    }

    public Urechea(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("urechea.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieUreche(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieUreche());
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
                    new Span {FontSize=15, Text="Urechea umană este un organ complex și esențial al sistemului auditiv, responsabil pentru percepția sunetelor din mediul înconjurător. Este formată din trei părți distincte: urechea externă, urechea medie și urechea internă." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Urechea externă cuprinde pavilionul urechii și canalul auditiv extern. Pavilionul urechii colectează și direcționează sunetele către canalul auditiv, care se încheie la membrana timpanului, o structură subțire și flexibilă care vibrează în funcție de intensitatea sunetelor." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Urechea medie este alcătuită dintr-o serie de oase mici numite osicule auditive: ciocanul, nicovala și scară. Aceste osicule amplifică și transmit vibrațiile membranei timpanului către urechea internă. De asemenea, urechea medie este conectată la trompa lui Eustachio, care ajută la egalizarea presiunii aerului între urechea medie și exterior." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Urechea internă, sau labirintul, este situată în osul temporal și este responsabilă pentru convertirea vibrațiilor sonore în semnale nervoase pe care creierul le poate interpreta. Labirintul este compus dintr-o serie de canale și structuri delicate, inclusiv cochilia și vestibulul. Cochilia conține celule senzoriale specializate numite celule ciliare, care transformă vibrațiile în semnale electrice trimise apoi către creier prin nervul auditiv. Vestibulul reglează echilibrul și poziția corpului." },
                    new Span {Text="\n" },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Împreună, aceste trei componente ale urechii umane lucrează armonios pentru a permite percepția și interpretarea sunetelor din mediul înconjurător, jucând un rol vital în comunicare și orientare în lumea înconjurătoare." },
                    new Span {Text="\n" },
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Fül: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Az emberi fül egy bonyolult és lényeges szerv a hallórendszerben, amely felelős a környezetből érkező hangok érzékeléséért. Három különböző részből áll: külső fül, középső fül és belső fül.", FontSize = 16 },
new Span { Text = "A külső fül magában foglalja a füllebet és a külső hallójáratot. A fülleb összegyűjti és irányítja a hangokat a külső hallójárat felé, amely a dobhártyával végződik, egy vékony és rugalmas szerkezettel, amely rezgéseket hoz létre a hangok intenzitásától függően.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A középső fül a hallócsontok nevű kis csontok sorozatából áll: kalapács, üllő és kengyel. Ezek a csontok megnövelik és átadják a dobhártya rezgéseit a belső fül felé. Emellett a középső fül kapcsolódik az Eustach-kürtbe, amely segít a légnyomás kiegyenlítésében a középső fül és a külvilág között.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "A belső fül, vagyis a labirintus, a halántéki csontban található, és felelős a hangrezgések átalakításáért olyan idegi jelekké, amelyeket az agy értelmezni tud. A labirintus egy sor csatornából és finom struktúrákból áll, beleértve a csigát és az egyensúlyozót. A csiga olyan speciális érzékszervi sejteket tartalmaz, amelyek elektromos jelekké alakítják át a rezgéseket, majd az auditív idegen keresztül továbbítják az agy felé. Az egyensúlyozó szabályozza az egyensúlyt és a test pozícióját.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Ezen három komponens együttesen harmonikusan működik az emberi fülben, lehetővé téve a környezetből érkező hangok észlelését és értelmezését, kulcsfontosságú szerepet játszva a kommunikációban és az orientációban a környező világban.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { Text = "Вухо: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Людське вухо є складним і важливим органом слухової системи, відповідальним за сприйняття звуків навколишнього середовища. Воно складається з трьох відмінних частин: зовнішнього вуха, середнього вуха та внутрішнього вуха.", FontSize = 16 },
new Span { Text = "Зовнішнє вухо включає вухові раковину та зовнішній слуховий канал. Вухова раковина збирає і направляє звуки в зовнішній слуховий канал, який закінчується барабанною перетинкою, тонкою і гнучкою структурою, що вібрує в залежності від інтенсивності звуків.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Середнє вухо складається з ряду малих кісточок, які називаються слуховими кісточками: молоточок, наковальня та кінцівка. Ці кісточки підсилюють і передають коливання барабанної перетинки внутрішньому вусі. Крім того, середнє вухо з'єднане з трубкою Євстахія, яка допомагає вирівняти тиск повітря між середнім вухом та зовнішнім середовищем.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Внутрішнє вухо, або лабіринт, розташоване в скроневій кістці і відповідає за перетворення звукових коливань в нервові сигнали, які мозок може інтерпретувати. Лабіринт складається з ряду каналів та витончених структур, включаючи оболонку та вестибул. Оболонка містить спеціалізовані вібросенсорні клітини, які перетворюють коливання в електричні сигнали, які потім направляються в мозок через слуховий нерв. Вестибул регулює рівновагу та положення тіла.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Разом ці три компоненти вуха працюють гармонійно для сприйняття та інтерпретації звуків навколишнього середовища, виконуючи важливу роль у комунікації та орієнтації у світі навколишнього середовища.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
                }
        };
    }
}
