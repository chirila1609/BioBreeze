using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class RFVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public RFVege() : this(AudioManager.Current)
    {
    }

    public RFVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("rfvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotRFVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotRFVege());
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
                new Span { FontSize = 15, Text = "Reproducerea la plantele cu flori, cunoscută și sub denumirea de angiosperme, este un proces complex și fascinant ce constă în transmiterea materialului genetic de la o generație la alta și în dezvoltarea unor noi indivizi. Acest proces esențial este esențial pentru menținerea biodiversității și pentru asigurarea continuității speciilor." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Angiospermele sunt plante vasculare care produc flori, structuri reproductive specializate în care are loc fertilizarea. Reproducerea la plantele cu flori implică două etape majore: polenizarea și fertilizarea." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Polenizarea este primul pas în reproducerea plantelor cu flori și implică transferul polenului de la staminele (partea masculină a florii) către pistil (partea feminină a florii) sau către alte flori. Acest proces poate fi realizat fie de vânt (polenizare anemofilă), fie de polenizatori, cum ar fi insectele, păsările sau alte animale (polenizare zoofilă). Adaptările florilor, cum ar fi culorile vibrante, mirosul și nectarul, sunt adesea evoluate pentru a atrage acești polenizatori și a facilita polenizarea." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Fertilizarea are loc atunci când un tub polinic transportă polenul de la stamină până la ovarul din pistil. Aici, un spermă masculin fertilizează un ovul, formând un zigot, care este prima etapă a dezvoltării unui embrion. Odată fertilizat, ovul se transformă într-un sămânță, iar ovarul se dezvoltă în fruct. Sămânța conține materialul genetic al plantei și este înconjurată de un strat protector numit tegument." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "După fertilizare, fructul și sămânța rezultată își continuă dezvoltarea. Fructul protejează și susține sămânța în timp ce se formează și maturizează. Odată ce fructul ajunge la maturitate, poate fi dispersat de diferite mecanisme, cum ar fi vântul, apa sau animalele. Sămânța poate ajunge într-un nou mediu, unde poate germina și începe un nou ciclu de viață." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Reproducerea la plantele cu flori este un proces complex și diversificat, adaptat la o varietate de medii și condiții de viață. Această adaptabilitate și diversitate sunt esențiale pentru succesul și supraviețuirea speciilor de plante în ecosistemele lor naturale." },
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
                new Span { Text = "Virágos növények szaporodása:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A virágos növények szaporodása, más néven angioszperma szaporodás, bonyolult és lenyűgöző folyamat, amely során genetikai anyagukat generációról generációra továbbítják, és új egyedeket fejlesztenek ki. Ez a folyamat alapvető fontosságú a biodiverzitás fenntartásában és a fajok folytonosságának biztosításában.", FontSize = 16 },
new Span { Text = "Angioszperma:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Angioszperma egy vazkális növény, amely virágokat hoz létre, különleges reproduktív struktúrák, ahol a megtermékenyítés történik. A virágos növények szaporodása két fő lépésből áll: a porzózásból és a megtermékenyítésből.", FontSize = 16 },
new Span { Text = "Porzózás:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A porzózás az első lépés a virágos növények szaporodásában, amely során a pollen átvitelre kerül a virág porzó (hím része) és a termő (női része) között, vagy más virágok között. Ez a folyamat lehet szél által (szélbeporzás), vagy beporzók, mint például rovarok, madarak vagy más állatok (állatbeporzás) által. A virágok adaptációi, mint a vibráló színek, illatok és nektár, gyakran azért fejlődtek ki, hogy vonzzák ezeket a beporzókat és elősegítsék a porzódást.", FontSize = 16 },
new Span { Text = "Megtermékenyítés:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A megtermékenyítés akkor következik be, amikor a pollen tüsző a pollent szállítja a porzóból a termővel. Itt egy hím spermium megtermékenyíti a petesejtet, és zigóta alakul ki, ami az új egyed fejlődésének első lépése. Miután megtermékenyült, a petesejt kifejlődik egy magvában, míg a termő hüvely gyümölcsé válik. A magva tartalmazza a növény genetikai anyagát, és egy védelmező réteg, a tegumentum, veszi körül.", FontSize = 16 },
new Span { Text = "Frissítés:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A megtermékenyítést követően a gyümölcs és az abból származó mag folytatja fejlődését. A gyümölcs védi és támogatja a magot, amíg kialakul és érik. Miután a gyümölcs éretté válik, különböző mechanizmusok, például a szél, víz vagy állatok, segítségével elterjedhet. A mag eljuthat egy új környezetbe, ahol kikelhet és elindíthat egy új életciklust.", FontSize = 16 },
new Span { Text = "Virágos növények szaporodása:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A virágos növények szaporodása bonyolult és változatos folyamat, amely számos környezeti és életkörülményre adaptálódik. Ez az alkalmazkodóképesség és sokféleség alapvető fontosságú a növényfajok sikeréhez és túléléséhez természetes ökoszisztémáikban.", FontSize = 16 }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Розмноження квіткових рослин:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Розмноження квіткових рослин, також відоме як ангіосперми, є складним і захоплюючим процесом, який включає передачу генетичного матеріалу від одного покоління до іншого і розвиток нових індивідів. Цей процес є ключовим для збереження біорізноманіття та забезпечення стійкості видів.", FontSize = 16 },
new Span { Text = "Ангіосперми:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Ангіосперми - це судинні рослини, що утворюють квіти, спеціалізовані репродуктивні структури, де відбувається запліднення. Розмноження квіткових рослин включає дві основні стадії: запилення та запліднення.", FontSize = 16 },
new Span { Text = "Запилення:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Запилення - перший крок у розмноженні квіткових рослин, що передбачає передачу пилку з тичинок (чоловіча частина квітки) до зав'язі (жіноча частина квітки) або до інших квіток. Цей процес може здійснюватися вітром (анемофільне запилення) або запилювачами, такими як комахи, птахи або інші тварини (зоофільне запилення). Адаптації квіток, такі як яскраві кольори, аромати та нектар, часто розвивалися для приваблення цих запилювачів та полегшення запилення.", FontSize = 16 },
new Span { Text = "Запліднення:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Запліднення відбувається тоді, коли пилкова трубка переносить пилок з тичинки до зав'язі. Тут чоловічий сперматозоїд запліднює яйцеклітину, утворюючи зиготу, яка є першим етапом розвитку нового індивіда. Після запліднення яйцеклітина перетворюється в насінину, а зав'язь розвивається в плід. Насіння містить генетичний матеріал рослини і оточене захисним шаром, який називається оболонкою.", FontSize = 16 },
new Span { Text = "Розвиток:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Після запліднення плід та утворене насіння продовжують свій розвиток. Плід захищає та підтримує насіння під час його формування і дозрівання. Після того, як плід дозріває, він може бути поширений за допомогою різних механізмів, таких як вітер, вода або тварини. Насіння може потрапити в нове середовище, де воно може витоптати та почати новий життєвий цикл.", FontSize = 16 },
new Span { Text = "Заключення:", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Розмноження квіткових рослин є складним і різноманітним процесом, адаптованим до різних середовищ та умов життя. Ця адаптивність та різноманітність є ключовими для успіху та виживання рослинних видів у їх природних екосистемах.", FontSize = 16 }
            }
        };
    }
}
