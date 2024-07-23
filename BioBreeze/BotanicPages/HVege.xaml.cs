using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class HVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public HVege() : this(AudioManager.Current)
    {
    }

    public HVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotHVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotHVege());
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
                new Span {FontSize=15, Text="Hrănirea plantelor reprezintă un aspect esențial al îngrijirii lor și este crucială pentru obținerea unei creșteri sănătoase și bogate în recoltă. Procesul de hrănire a plantelor implică furnizarea acestora a substanțelor nutritive de care au nevoie pentru a-și susține metabolismul, dezvoltarea și reproducerea." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {Text="Substanțele Nutritive Esențiale", FontAttributes=FontAttributes.Bold, FontSize=20 },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Plantele necesită o gamă variată de substanțe nutritive pentru a-și menține sănătatea și vitalitatea. Cele trei macronutrienți principali de care au nevoie sunt azotul (N), fosforul (P) și potasiul (K), cunoscuți sub numele de elemente NPK. Acești nutrienți esențiali sunt utilizați în diferite procese metabolice ale plantelor: azotul pentru creșterea frunzelor verzi și producerea proteinelor, fosforul pentru dezvoltarea sistemului radicular și a florilor, iar potasiul pentru rezistența la stres și sinteza carbohidraților." },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Pe lângă acești macronutrienți, plantele mai necesită și alte elemente esențiale, cunoscute sub numele de micronutrienți, cum ar fi fierul, magneziul, calciul, cuprul, zincul și molibdenul. Deși acestea sunt necesare în cantități mai mici decât macronutrienții, ele joacă un rol vital în funcționarea optimă a plantelor." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {Text="Surse de Nutriție", FontAttributes=FontAttributes.Bold, FontSize=20 },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Plantele pot obține substanțele nutritive de care au nevoie din mai multe surse, inclusiv din sol, apă și aer. Solul este o sursă fundamentală de nutrienți pentru plante, deoarece majoritatea substanțelor nutritive sunt prezente sub formă de săruri minerale dizolvate în soluție. Îngrășămintele organice și anorganice pot fi aplicate în sol pentru a suplimenta și îmbunătăți nivelul de nutrienți disponibili." },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="În plus față de sol, plantele pot primi nutrienți și din apă. În natură, plantele acvatice absorb direct nutrienții din mediul lor înconjurător. În cazul plantelor cultivate în ghivece sau în sistemul hidroponic, soluții nutritive speciale pot fi adăugate în apă pentru a asigura necesarul de nutrienți." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {Text="Dozarea Corectă a Nutrienților", FontAttributes=FontAttributes.Bold, FontSize=20 },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Este esențial ca hrănirea plantelor să fie făcută în mod corect și echilibrat. Supradozarea sau subdozarea nutrienților poate avea efecte negative asupra sănătății plantelor și poate duce la probleme precum arsuri ale frunzelor, deficiențe nutriționale sau inhibarea creșterii. De aceea, este recomandabil să se folosească îngrășăminte specifice, adaptate nevoilor specifice ale plantelor și să se respecte instrucțiunile de dozare." },
                new Span {Text="\n" },
                new Span {Text="\n" },
                new Span {Text="Concluzie", FontAttributes=FontAttributes.Bold, FontSize=20 },
                new Span {Text="\n" },
                new Span {FontSize=15, Text="Hrănirea plantelor este un proces esențial pentru obținerea unei creșteri sănătoase și abundente. Asigurarea unei oferte adecvate de nutrienți, echilibrată și bine dozată, este cheia pentru ca plantele să prospere și să ofere recolte bogate și de calitate." },
            }
        };
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Növények táplálása: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények táplálása létfontosságú szempontja gondozásuknak és alapvető a egészséges és gazdag termés eléréséhez. A növények táplálásának folyamata magában foglalja a számukra szükséges tápanyagok biztosítását, hogy támogassák anyagcseréjüket, fejlődésüket és szaporodásukat.", FontSize = 16 },
new Span { Text = "Elengedhetetlen tápanyagok: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények számos tápanyagra van szükségük egészségük és vitalitásuk fenntartásához. Az általuk leginkább igényelt három fő makroelem az azot (N), foszfor (P) és kálium (K), ismertek NPK elemekként. Ezeket az alapvető tápanyagokat különböző anyagcsere-folyamatokban használják a növények: az azot a zöld levelek növekedéséhez és fehérjék termeléséhez, a foszfor a gyökérrendszer és a virágok fejlődéséhez, míg a kálium a stresszrezisztencia és a szénhidrátok szintéziséhez szükséges.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Ezek mellett a makroelemek mellett a növényeknek más, mikrotápanyagoknak nevezett alapvető elemekre is szükségük van, mint például a vas, magnézium, kalcium, réz, cink és molibdén. Ezek bár kisebb mennyiségben szükségesek, vitális szerepet játszanak a növények optimális működésében.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Táplálékforrások: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények számos forrásból szerezhetik meg szükséges tápanyagaikat, beleértve a talajt, vizet és levegőt. A talaj alapvető tápanyagforrás a növények számára, mivel a legtöbb tápanyag oldott ásványi sók formájában van jelen a talajoldatban. Szerves és szervetlen trágyák alkalmazhatók a talajba, hogy kiegészítsék és javítsák az elérhető tápanyagszintet.", FontSize = 16 },
new Span { Text = "Emellett a talajon kívül a növények tápanyagokat is kaphatnak vízből. A természetben a vízi növények közvetlenül elnyelik tápanyagaikat környezetükből. A konténeres növények vagy hidroponikus rendszerben termesztett növények esetében speciális tápoldatokat adhatnak hozzá a vízhez, hogy biztosítsák a szükséges tápanyagmennyiséget.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Tápanyagok megfelelő adagolása: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények táplálása szempontjából kulcsfontosságú, hogy azt helyesen és kiegyensúlyozottan végezzék el. A tápanyagok túladagolása vagy aluladagolása negatív hatással lehet a növények egészségére, például levélsérülésekhez, tápanyaghiányhoz vagy a növekedés gátlásához vezethet. Ezért ajánlott specifikus, a növények konkrét igényeihez igazított trágyák használata, és betartani a adagolási utasításokat.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Következtetés: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "A növények táplálása alapvető folyamat a egészséges és gazdag növekedés eléréséhez. A megfelelő, kiegyensúlyozott és jól adagolt tápanyagellátás biztosítása kulcsfontosságú ahhoz, hogy a növények jól fejlődjenek és gazdag, minőségi termést nyújtsanak.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
            }
        };
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        ContentLabel.FormattedText = new FormattedString
        {
            Spans =
            {
                new Span { Text = "Живлення рослин: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Живлення рослин є важливим аспектом їх догляду і критичним для здобуття здорового та багатого урожаю. Процес живлення рослин полягає в забезпеченні їм необхідних поживних речовин, щоб підтримувати їх обмін речовин, розвиток та розмноження.", FontSize = 16 },
new Span { Text = "Необхідні поживні речовини: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Рослини потребують різноманітних поживних речовин для збереження свого здоров'я та життєздатності. Три основні макроелементи, необхідні для них, - це азот (N), фосфор (P) і калій (K), відомі як NPK-елементи. Ці необхідні поживні речовини використовуються в різних метаболічних процесах рослин: азот для зростання зелених листків і синтезу білків, фосфор для розвитку кореневої системи і квітів, калій для стресостійкості і синтезу вуглеводів.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Крім цих макроелементів, рослини також потребують інших необхідних елементів, відомих як мікроелементи, таких як залізо, магній, кальцій, мідь, цинк і молібден. Вони, хоч і потрібні в менших кількостях, відіграють важливу роль у оптимальному функціонуванні рослин.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Джерела живлення: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Рослини можуть отримувати необхідні поживні речовини з різних джерел, включаючи ґрунт, воду та повітря. Ґрунт є основним джерелом поживних речовин для рослин, оскільки більшість поживних речовин присутні у вигляді мінеральних солей, розчинених у ґрунтовому розчині. Органічні та неорганічні добрива можуть застосовуватися у ґрунт для підвищення та покращення рівня доступних поживних речовин.", FontSize = 16 },
new Span { Text = "Окрім ґрунту, рослини можуть отримувати поживні речовини також з води. У природі водні рослини напряму поглинають поживні речовини з оточуючого середовища. Для культурних рослин, вирощуваних у контейнерах або гідропонних системах, до води можуть додаватися спеціальні поживні розчини для забезпечення необхідних поживних речовин.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Правильна дозування поживних речовин: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Важливо, щоб живлення рослин відбувалося правильно і збалансовано. Перевищення або недостаток поживних речовин може мати негативний вплив на здоров'я рослин, наприклад, до листяних опіків, дефіциту поживних речовин або гальмування росту. Тому рекомендується використовувати спеціальні добрива, що відповідають конкретним потребам рослин, і дотримуватися інструкцій з дозування.", FontAttributes = FontAttributes.Bold, FontSize = 16 },
new Span { Text = "Висновок: ", FontAttributes = FontAttributes.Bold, FontSize = 20 },
new Span { Text = "Живлення рослин є ключовим процесом для досягнення здорового та багатого росту. Забезпечення належного, збалансованого і правильно дозованого живлення є важливим для того, щоб рослини належним чином розвивалися і надавали багатий та якісний врожай.", FontAttributes = FontAttributes.Bold, FontSize = 16 }
            }
        };
    }
}
