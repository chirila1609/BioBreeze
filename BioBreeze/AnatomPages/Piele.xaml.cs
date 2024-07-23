using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Piele : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Piele() : this(AudioManager.Current)
    {
    }

    public Piele(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("piele.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomiePiele(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomiePiele());
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
                     new Span {FontSize = 15, Text="Pielea umană, cunoscută și sub numele de tegument, este cel mai mare organ al corpului uman și îndeplinește multiple funcții vitale pentru sănătate și bunăstare. Este un strat extern protector care acoperă întregul corp și oferă o barieră fizică împotriva agenților patogeni, substanțelor chimice și radiațiilor nocive din mediul înconjurător." },
                     new Span {Text="\n" },
                     new Span {FontSize=15, Text="Structura pielii este complexă și constă din trei straturi principale: epidermul, dermul și hipodermul. Epidermul este stratul exterior al pielii și este compus în principal din celule keratinocite, care sunt responsabile pentru formarea stratului exterior protector și pentru regenerarea constantă a pielii. Acest strat conține, de asemenea, melanocite, care produc pigmentul melanină responsabil pentru culoarea pielii și pentru protejarea împotriva radiațiilor ultraviolete. Dermul este stratul intermediar al pielii și conține o rețea complexă de fibre de colagen și elastină, care oferă structură, rezistență și elasticitate pielii. Aici se găsesc și numeroase vase de sânge, nervi și glande sudoripare și sebacee. Hipodermul, sau stratul subcutanat, este stratul cel mai profund al pielii și este alcătuit în principal din țesut adipos care servește ca izolație termică și rezervă de energie, precum și ca amortizor pentru țesuturile și organele subiacente." },
                     new Span {Text="\n" },
                     new Span {FontSize= 15, Text="Pielea are multiple funcții importante în organismul uman. În primul rând, servește ca barieră fizică care protejează organismul împotriva infecțiilor, traumatismelor și pierderii de apă. De asemenea, reglează temperatura corpului prin evaporarea transpirației și dilatarea sau constricția vaselor de sânge din derm în funcție de nevoile termice ale organismului. Pielea are și un rol esențial în senzațiile tactile și în percepția senzațiilor externe, datorită prezenței numeroșilor receptori nervoși în derm. În plus, glandele sudoripare și sebacee din piele contribuie la menținerea echilibrului hidric al corpului și la eliminarea deșeurilor și toxinelor prin transpirație." },
                     new Span {Text="\n" },
                     new Span {FontSize=15, Text="În concluzie, pielea umană este un organ vital și multifuncțional, cu o structură complexă și cu numeroase roluri în menținerea sănătății și funcționării optime a organismului. Protecția împotriva agenților externi, reglarea temperaturii, senzațiile tactile și excreția sunt doar câteva dintre funcțiile esențiale ale pielii umane. Prin îngrijirea adecvată și protejarea ei împotriva factorilor nocivi, se poate asigura sănătatea și integritatea acestui organ vital." },
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
                    new Span {FontSize=15, Text="Az emberi bőr, ismert más néven tegumentum, az emberi test legnagyobb szerve, és számos fontos funkciót lát el az egészség és jólét fenntartásában. Ez egy külső védelmi réteg, amely beborítja az egész testet, és fizikai gátat képez a kórokozók, vegyi anyagok és a környezet káros sugárzása ellen." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="A bőr szerkezete bonyolult és három fő rétegből áll: az epidermiszből, a dermiszből és a hypodermiszből. Az epidermisz a bőr külső rétege, amely főként keratinocitákból áll, és felelős a külső védőréteg kialakításáért és a bőr állandó regenerációjáért. Ez a réteg tartalmaz melanocitákat is, amelyek melanint termelnek, ami a bőr színéért felelős, és védelmet nyújt az ultraibolya sugárzás ellen. A dermisz a bőr középső rétege, amely összetett hálót képez kollagén és elasztin rostokból, amelyek biztosítják a bőr szerkezetét, szilárdságát és rugalmasságát. Itt találhatók a véredények, idegek, valamint a verejték- és faggyúmirigyek is. A hypodermisz vagy a bőralatti réteg a bőr legmélyebb rétege, amely főként zsírszövetből áll, és hőszigetelésként, energiatárolóként, valamint a szövetek és a szervek alatti puha rugalmas párna funkcióját látja el." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="A bőr számos fontos funkciót lát el az emberi szervezetben. Elsősorban fizikai gátként szolgál, amely védi a szervezetet a fertőzésektől, sérülésektől és a vízveszteségtől. Emellett szabályozza a test hőmérsékletét a verejték párologtatásával, és a dermiszben lévő vérerek tágulásával vagy összehúzódásával a szervezet hőigényeinek megfelelően. A bőr fontos szerepet játszik a tapintás érzetében és az külső érzékelés észlelésében a dermiszben található számos idegvégződés miatt. Emellett a bőrben lévő verejték- és faggyúmirigyek hozzájárulnak a test vízháztartásának fenntartásához, valamint a hulladékok és méreganyagok kiválasztásához a verejtéken keresztül." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Összefoglalva: az emberi bőr fontos és sokoldalú szerv, amely bonyolult szerkezettel és számos szereppel rendelkezik az egészség és az optimális szervezeti működés fenntartásában. Az idegen anyagok elleni védelem, a testhőmérséklet szabályozása, a tapintási érzet és a kiválasztás csak néhány az emberi bőr alapvető funkciói közül. Megfelelő gondozással és védelemmel biztosítható ennek fontos szervnek az egészsége és integritása a káros tényezőkkel szemben." },
                    new Span {Text="\n" }
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span {FontSize=15, Text="Людська шкіра, відома також як тегмент, є найбільшим органом людського тіла і виконує кілька важливих функцій для здоров'я і благополуччя. Вона є зовнішнім захисним шаром, що покриває всі тіло і надає фізичний бар'єр проти патогенів, хімічних речовин і шкідливих випромінювань з навколишнього середовища." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Структура шкіри складна і складається з трьох основних шарів: епідермісу, дерми та гіподермісу. Епідерміс є зовнішнім шаром шкіри і складається в основному з кератиноцитів, які відповідають за формування захисного зовнішнього шару і постійну регенерацію шкіри. Цей шар також містить меланоцити, які виробляють пігмент меланін, відповідальний за колір шкіри і захист від ультрафіолетових променів. Дерма є середнім шаром шкіри і містить складну мережу колагенових і еластинових волокон, які забезпечують структуру, міцність і еластичність шкіри. Тут також знаходяться численні кровоносні судини, нерви та потові і сальні залози. Гіподерміс, або підшкірний шар, є найглибшим шаром шкіри і складається в основному з жирової тканини, яка служить термічною ізоляцією і запасом енергії, а також амортизатором для підлеглих тканин і органів." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Шкіра виконує кілька важливих функцій в організмі людини. Вона служить фізичним бар'єром, що захищає організм від інфекцій, травм і втрати води. Крім того, вона регулює температуру тіла за рахунок випаровування поту і розширення або стискання кровоносних судин дерми в залежності від теплових потреб організму. Шкіра також відіграє важливу роль у відчуттях дотику і у сприйнятті зовнішніх відчуттів завдяки наявності численних нервових рецепторів у дермі. Крім того, потові і сальні залози у шкірі сприяють підтримці водного балансу організму і видаленню відходів та токсинів через пот." },
                    new Span {Text="\n" },
                    new Span {FontSize=15, Text="Висновок: людська шкіра є важливим і багатофункціональним органом з складною структурою та численними функціями для підтримки здоров'я і оптимального функціонування організму. Захист від зовнішніх впливів, регулювання температури, відчуття дотику та виділення продуктів є лише деякі з ключових функцій людської шкіри. З правильного догляду і захисту від шкідливих факторів можна забезпечити здоров'я та цілісність цього важливого органа." },
                    new Span {Text="\n" }
                }
        };
    }
}
