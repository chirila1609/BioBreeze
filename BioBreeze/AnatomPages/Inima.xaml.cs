using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Inima : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Inima() : this(AudioManager.Current)
    {
    }

    public Inima(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("inima.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieHeart(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieHearth());
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
                    new Span { FontSize = 15, Text = "Inima umană este un organ remarcabil care servește ca element central al sistemului circulator, pom-pând sânge în întregul corp pentru a livra oxigen și substanțe nutritive celulelor și țesuturilor, eliminând în același timp produsele de degradare." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Plasată puțin în partea stângă a pieptului, inima are aproximativ dimensiunea unui pumn și este formată dintr-un țesut muscular specializat numit mușchi cardiac. Este împărțită în patru camere: două atrii (camere superioare) și două ventricule (camere inferioare). Partea dreaptă a inimii primește sânge dezoxigenat din corp și îl pompează către plămâni pentru oxigenare, în timp ce partea stângă primește sânge oxigenat din plămâni și îl pompează către restul corpului." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Acțiunea de pompare a inimii este controlată de impulsuri electrice generate de o mică grupare de celule numită nodul sinusal (SA), adesea numită pace-makerul natural al inimii. Aceste impulsuri determină mușchiul inimii să se contracte în mod coordonat, creând bătăile ritmice ale inimii." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Inima este susținută și protejată de o membrană dublă numită pericard. Sângele este furnizat mușchiului inimii însuși printr-o rețea de vase de sânge cunoscută sub numele de artere coronariene. Aceste artere se desprind de la aorta, cea mai mare arteră a corpului, și încercuiesc inima, asigurându-se că primește oxigenul și substanțele nutritive de care are nevoie pentru a funcționa corect." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Diferiți factori pot afecta sănătatea inimii, inclusiv dieta, exercițiul fizic, genetica și alegerile de stil de viață. Afecțiuni precum boala coronariană, insuficiența cardiacă și aritmiile pot afecta capacitatea inimii de a pompa sânge eficient, ducând la complicații grave." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Menținerea unui stil de viață sănătos, inclusiv adoptarea unei diete echilibrate, exercițiul regulat, gestionarea stresului, evitarea tutunului și limitarea consumului de alcool, poate ajuta la reducerea riscului de boli de inimă și la promovarea sănătății generale a inimii." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Consultările regulate cu un furnizor de servicii medicale, inclusiv monitorizarea tensiunii arteriale, a nivelurilor de colesterol și a altor factori de risc cardiovascular, sunt esențiale pentru detectarea și gestionarea timpurie a problemelor legate de inimă." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Inima umană nu este doar un organ vital pentru menținerea vieții, ci și un simbol al iubirii, curajului și rezilienței, inspirând uimire și admirație de-a lungul istoriei și în diferite culturi. Înțelegerea structurii și funcționării sale este crucială pentru menținerea sănătății și stării de bine cardiovasculară." },
                    new Span { Text = "\n" },
                }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Az emberi szív egy rendkívüli szerv, amely a keringési rendszer központi eleme, vérrel látja el az egész testet, hogy oxigént és tápanyagokat szállítson a sejteknek és szöveteknek, miközben ugyanakkor eltávolítja a bomlástermékeket." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A szív kissé balra helyezkedik el a mellkas közepétől, és körülbelül ököl nagyságú. A szív különleges izomszövetből, ún. szívizomból áll. Négy kamrára oszlik: két pitvarra (felső kamrák) és két kamrára (alsó kamrák). A szív jobb oldala oxigénhiányos vért kap a testből, és a tüdőbe pumpálja oxigenizálás céljából, míg a bal oldal oxigéndús vért kap a tüdőből, és azt a test többi részébe pumpálja." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A szív pumpáló működését kis csoportokban lévő sejtek, ún. sinus csomó (SA) által generált elektromos impulzusok szabályozzák, gyakran nevezik a szív természetes pacemakerének is. Ezek az impulzusok koordináltan összehúzzák a szív izomzatát, így létrehozva a szív ritmikus összehúzódásait." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A szívet egy dupla membrán, a szívburok védi és támogatja. A vér közvetlenül a szívizomzatba egy vérerek hálózatán keresztül jut el, amit koszorúereknek nevezünk. Ezek az erek az aortából, a test legnagyobb artériájából származnak, és körülveszik a szívet, biztosítva annak számára a szükséges oxigént és tápanyagokat a megfelelő működéshez." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Különböző tényezők befolyásolhatják a szív egészségét, ideértve az étrendet, a fizikai aktivitást, a genetikát és az életmódot. Betegségek, mint például a koszorúér-betegség, a szívelégtelenség és az aritmia, csökkenthetik a szív hatékonyságát a vér pumpálásában, súlyos szövődményekhez vezetve." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Egészséges életmód fenntartása, ideértve a kiegyensúlyozott étrendet, rendszeres testmozgást, stresszkezelést, dohányzás kerülését és az alkoholfogyasztás korlátozását, hozzájárulhat a szívbetegségek kockázatának csökkentéséhez és a szív általános egészségének támogatásához." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Rendszeres konzultációk orvosi szakemberekkel, ideértve az artériás vérnyomás, a koleszterinszint és egyéb szív- és érrendszeri kockázati tényezők monitorozását, elengedhetetlenek a szívproblémák korai felismeréséhez és kezeléséhez." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az emberi szív nemcsak az életfenntartás fontos szerve, hanem a szeretet, bátorság és ellenállóképesség szimbóluma is, csodálatot és elismerést keltve a történelem során és különböző kultúrákban egyaránt. A szerkezetének és működésének megértése kulcsfontosságú az egészséges szív és keringési rendszer fenntartásában." },
                    new Span { Text = "\n" },
                }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontSize = 15, Text = "Людське серце - це вражаючий орган, який служить центральним елементом кровообігової системи, що перекачує кров по всьому тілу для постачання кисню і поживних речовин клітинам і тканинам, в той же час видаляючи продукти розпаду." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Розташоване трохи ліворуч від середини грудної клітки, серце має приблизно розмір кулака і складається з особливої м'язової тканини, що називається серцевим м'язом. Воно розділене на чотири камери: дві передсердя (верхні камери) і дві шлуночки (нижні камери). Права частина серця отримує відсоткований кров із тіла і перекачує його до легенів для оксигенізації, тоді як ліва частина отримує оксигеновану кров із легенів і перекачує її до решти тіла." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Дія перекачування серця контролюється електричними імпульсами, що генеруються малою групою клітин, яку називають синусний вузол (SA), часто називаючи природнім пейсмейкером серця. Ці імпульси змушують м'яз серця координовано скорочуватися, створюючи ритмічні пульсації серця." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Серце підтримується і захищається подвійною оболонкою, яку називають серцевою оболонкою. Кров постачається самому м'язу серця через мережу кровоносних судин, відомих як коронарні артерії. Ці артерії відходять від аорти, найбільшої артерії тіла, і обходять серце, забезпечуючи йому необхідний кисень і поживні речовини для правильної роботи." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Різні фактори можуть впливати на здоров'я серця, включаючи діету, фізичну активність, генетику та життєвий стиль. Захворювання, такі як коронарна хвороба, серцева недостатність та аритмії, можуть впливати на здатність серця ефективно перекачувати кров, що призводить до серйозних ускладнень." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Підтримання здорового способу життя, включаючи прийом збалансованої дієти, регулярні фізичні вправи, управління стресом, уникання тютюну і обмеження споживання алкоголю, може допомогти знизити ризик захворювань серця та підтримати загальне здоров'я серця." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Регулярні консультації з медичними працівниками, включаючи контроль артеріального тиску, рівні холестерину та інші фактори серцево-судинного ризику, є важливими для виявлення та раннього управління серцевими проблемами." },
                    new Span { Text = "\n" },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Людське серце - це не лише життєвоважливий орган, але й символ кохання, мужності і стійкості, що викликає захоплення та захват упродовж історії та в різних культурах. Розуміння його структури та функціонування є важливим для підтримання здоров'я та благополуччя серця." },
                    new Span { Text = "\n" },
                }
        };
    }
}
