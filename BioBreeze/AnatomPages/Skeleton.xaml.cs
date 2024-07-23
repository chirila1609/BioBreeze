using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Skeleton : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Skeleton() : this(AudioManager.Current)
    {
    }

    public Skeleton(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("skeleton.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSchele(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSchele());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnRomanianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Gândește-te la scheletul tău ca la o capodoperă arhitecturală a corpului tău, proiectată în mod intricat pentru a oferi suport, protecție și mobilitate. Fiecare os are forma și scopul său unic, lucrând împreună ca o echipă perfect sincronizată." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Craniul: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Să începem de sus, cu craniul, fortăreața corpului tău pentru creier. Știai că nu este doar un os mare? De fapt, este alcătuit din 22 de oase care se potrivesc perfect împreună, formând un coif protector în jurul celui mai vital organ al tău." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Coloana vertebrală: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Urmează coloana vertebrală, sau coloana vertebrală. Este ca scheletul corpului tău (literalmente!). Formată din 33 de vertebre așezate una peste alta, coloana vertebrală oferă stabilitate și flexibilitate, permițându-ți să stai drept, să te apleci și să te rotești în toate direcțiile posibile." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel4.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Coaste: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Trecând la zona pieptului, găsim coastele, formând o structură în formă de cușcă în jurul inimii și plămânilor tăi. Există în total 12 perechi de coaste, dintre care primele 7 sunt atașate direct de stern (osul pieptului) și celelalte 5 perechi se mișcă liber. Ele se dilată și se contractă la fiecare respirație, ajutându-te să respiri adânc și protejând organele prețioase." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel5.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Brațe și Picioare: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Hai să vorbim acum despre membrele tale, mișcătorii și agitatorii corpului tău! Brațele tale sunt dotate cu humerusul în partea superioară a brațului, conectat la radius și ulna în antebraț, și un aranjament complex de oase carpale, metacarpiene și falange în mână. La fel și picioarele tale se laudă cu femurul în coapsă, urmat de tibia și fibula în partea inferioară a piciorului, și oasele tarsale, metatarsale și falangele în picior. Aceste oase lucrează împreună pentru a susține greutatea corpului, pentru a facilita mișcarea și pentru a permite activități precum scrisul, practicarea sporturilor și dansul." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel6.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Mâini și Talpă: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "În final, hai să ne concentrăm asupra extremităților tale, instrumentele tale de încredere pentru interacțiunea cu lumea. Mâinile tale sunt echipate cu aranjamente intricate de oase, permițând mișcări precise, abilități motorii fine și capacitatea de a manipula obiecte cu ușurință. De asemenea, picioarele tale sunt minuni de inginerie, oferind stabilitate, echilibru și propulsie în timp ce navighezi prin diverse terenuri și medii." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel7.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Vă mulțumesc că ați citit această prezentare despre sistemul scheletic. Sper că acum aveți o apreciere mai profundă pentru complexitatea și funcționalitatea uimitoare a scheletului nostru. Rămâneți curioși și continuați să explorați fascinanta lume a biologiei umane!" }
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Képzeld el a tested csontvázát, mint a tested építészeti mesterművét, bonyolultan tervezve, hogy támogatást, védelmet és mozgékonyságot nyújtson. Minden csontnak megvan a saját formája és egyedi célja, együtt dolgozva, mint egy tökéletesen szinkronizált csapat." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Koponya: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Kezdjük fentről, a koponyával, amely a tested legfontosabb része a központi idegrendszer számára. Tudtad, hogy ez nem csak egy nagy csont? Valójában 22 csontból áll, amelyek tökéletesen illeszkednek egymáshoz, egy védősisakot alkotva a legfontosabb szerv körül." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Háti gerinc: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Következő a háti gerinc, vagy másnéven gerincoszlop. Ez a tested váza (szó szerint!). Összesen 33 egymásra rakott csigolyából áll, amely stabilitást és rugalmasságot biztosít, lehetővé téve számodra, hogy egyenesen állj, hajolj és forogj minden lehetséges irányban." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel4.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Karok és lábak: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Gyerekek, most beszéljünk a végtagjaidról, a tested mozgatóiról! A karjaidat a felkar csontja, a könyökcsont és a sugárcsont alkotja az alkarban, valamint bonyolult csukló-, kéz- és ujjcsont-rendszerrel. Ugyanez vonatkozik a lábaidra is, ahol a combcsont, a sípcsont és a vádlicsont alkotják az alsó lábszárat, valamint a bonyolult láb- és lábujjcsontok." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel5.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Kezek és láb talpa: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Végül, koncentráljunk a végtagjaidra, a világgal való interakció megbízható eszközeire. A kezed bonyolult csontrendszerekkel van felszerelve, amelyek pontos mozgásokat, finom motoros készségeket és a tárgyak könnyű manipulálásának képességét teszik lehetővé. A lábad is mérnöki csoda, stabilizációt, egyensúlyt és hajtást nyújtva, amikor különböző terepeken és környezetekben navigálsz." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel6.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Köszönöm, hogy elolvastad ezt az ismertetőt a csontvázzal kapcsolatban. Remélem, most már mélyebb megértésed van a csontvázunk bonyolultságáról és lenyűgöző funkcióiról. Maradj kíváncsi és folytasd az emberi biológia lenyűgöző világának felfedezését!" }
                }
        };

        ContentLabel7.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Köszönöm, hogy elolvastad ezt az ismertetőt a csontvázzal kapcsolatban. Remélem, most már mélyebb megértésed van a csontvázunk bonyolultságáról és lenyűgöző funkcióiról. Maradj kíváncsi és folytasd az emberi biológia lenyűgöző világának felfedezését!" }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel1.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Уявіть свій скелет як архітектурний шедевр вашого тіла, який інтрикатно спроектований для надання підтримки, захисту та мобільності. Кожна кістка має свою унікальну форму та призначення, працюючи разом як чудово синхронізована команда." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel2.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Череп: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Почнемо зверху, з черепом, фортецею вашого тіла для мозку. Чи знали ви, що це не просто велика кістка? Фактично, він складається з 22 кісток, які ідеально взаємодіють, утворюючи захисний шолом навколо вашого найважливішого органа." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel3.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Хребет: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Далі йде хребет, або спинний стовп. Це як скелет вашого тіла (буквально!). Складається з 33 хребців, розташованих один на одному, хребет забезпечує стабільність та гнучкість, дозволяючи вам стояти прямо, нахилятися та обертатися у всі можливі напрямки." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel4.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Руки та ноги: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "Діти, зараз поговоримо про ваши кінцівки, рухомі механізми вашого тіла! Ваші руки оснащені верхів’ям плеча, що з’єднується з лучною кісткою та плечовою кісткою в передпліччі, а також складною системою кісток зап’ястка, метакарпальних кісток і фаланг у руці. Те ж саме стосується вашого нижнього кінця, де стегнова кістка, кості гомілки і лежащої кістки створюють нижню частину ноги, а також складну систему кісток тарзальних, метатарзальних і фаланг у нозі." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel5.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Руки та ноги підошви: " , FontAttributes = FontAttributes.Bold},
                    new Span { FontSize = 15, Text = "На завершення давайте зосередимося на ваших кінцівках, надійному інструменті взаємодії зі світом. Ваші руки оснащені складними системами кісток, що забезпечують точні рухи, дрібні моторні навички і здатність легко маніпулювати предметами. Ваші ноги також є інженерним чудом, забезпечуючи стабільність, рівновагу і привід, коли ви навігуєте по різних місцевостях та середовищах." },
                    new Span { Text = "\n" }
                }
        };

        ContentLabel6.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Дякуємо, що прочитали цей огляд скелетної системи. Сподіваюся, тепер ви маєте глибше розуміння складності та вражаючих функцій нашого скелета. Залишайтеся допитливими і продовжуйте досліджувати захоплюючий світ людської біології!" }
                }
        };

        ContentLabel7.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Дякуємо, що прочитали цей огляд скелетної системи. Сподіваюся, тепер ви маєте глибше розуміння складності та вражаючих функцій нашого скелета. Залишайтеся допитливими і продовжуйте досліджувати захоплюючий світ людської біології!" }
                }
        };
    }
}
