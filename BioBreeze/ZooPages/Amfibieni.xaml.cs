using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Amfibieni : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Amfibieni() : this(AudioManager.Current)
    {
    }

    public Amfibieni(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("amfibieni.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooAmfibieni(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooAmfibieni());
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
                new Span { FontSize = 15, Text = "Amfibienii reprezintă o clasă fascinantă de animale vertebrate care includ broaște, salamandre și tritoni. Aceste creaturi sunt cunoscute pentru capacitatea lor de a trăi atât pe uscat, cât și în apă, fiind adaptate la o varietate de medii acvatice și terestre." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "O caracteristică distinctivă a amfibienilor este ciclul lor de viață, care începe de obicei în apă. Majoritatea amfibienilor se reproduc prin ouă, care eclozează în larve, cunoscute sub numele de lăcustele. Aceste larve se dezvoltă apoi într-o formă intermediară, numită tânărul de metamorfoză, înainte de a deveni adulți." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "Pielea amfibienilor este deosebit de importantă pentru ei, deoarece le permite să respire. Multe specii de amfibieni absorb oxigenul direct prin piele, pe lângă respirația pulmonară. Această piele delicată necesită o umiditate constantă, motiv pentru care majoritatea amfibienilor sunt întâlniți în apropierea surselor de apă." },
new Span { Text = "\n" },
new Span { Text = "\n" },
new Span { FontSize = 15, Text = "De-a lungul evoluției, amfibienii s-au adaptat la o varietate de habitate, de la păduri tropicale umede la deșerturi aride și zone montane reci. Cu toate acestea, multe specii de amfibieni se confruntă cu amenințări semnificative, inclusiv pierderea habitatului, poluarea și schimbările climatice. Ca urmare, conservarea acestor creaturi delicate este esențială pentru menținerea echilibrului ecologic al ecosistemelor lor și pentru protejarea diversității biologice a planetei noastre." },
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
                new Span { Text = "Kétéltűek:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "A kétéltűek lenyűgöző gerinces állatok osztályát képviselik, beleértve a békákat, szalamandrát és tritont. Ezek a lények ismertek képességükről, hogy mind a szárazföldön, mind a vízben képesek élni, alkalmazkodva a különböző vízi és szárazföldi környezetekhez." },
new Span { Text = "\n" },
new Span { Text = "A kétéltűek jellegzetes tulajdonsága az életciklusuk, amely általában vízben kezdődik. A legtöbb kétéltű tojásokkal szaporodik, amelyek lárváként, úgynevezett lárva néven kelnek ki. Ezek a lárvák aztán egy átalakulási állapotban fejlődnek ki, mielőtt felnőtté válnának." },
new Span { Text = "\n" },
new Span { Text = "A kétéltűek bőre különösen fontos számukra, mert lehetővé teszi számukra a légzést. Sok kétéltű faj közvetlenül oxigént szív fel a bőrén keresztül, a tüdő légzésén kívül. Ez az érzékeny bőr állandó nedvességet igényel, ezért a legtöbb kétéltű a vízforrások közelében él." },
new Span { Text = "\n" },
new Span { Text = "Az evolúció során a kétéltűek alkalmazkodtak a különböző élőhelyekhez, a nedves trópusi erdőktől kezdve az aszályos sivatagokig és a hideg hegyvidéki területekig. Azonban sok kétéltű faj szembesül jelentős fenyegetésekkel, beleértve az élőhelyvesztést, a szennyezést és a klímaváltozásokat. Ezért ezeknek a sebezhető lényeknek a megőrzése nélkülözhetetlen az ökoszisztémáik egyensúlyának fenntartásához és a Föld biológiai sokféleségének védelméhez." },
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
                new Span { Text = "Амфібії:", FontAttributes = FontAttributes.Bold },
new Span { Text = "\n" },
new Span { Text = "Амфібії - це захоплюючий клас хребетних тварин, до якого входять жаби, саламандри та тритони. Ці створіння відомі своєю здатністю жити як на суші, так і у воді, адаптовані до різноманітних водних та суходільних середовищ." },
new Span { Text = "\n" },
new Span { Text = "Однією з характерних рис амфібій є їхній життєвий цикл, який, як правило, починається у воді. Більшість амфібій розмножуються яйцями, які вилуплюються у личинки, відомі як готи. Ці личинки потім розвиваються в проміжну форму, відому як лялька метаморфози, перед тим як стати дорослими." },
new Span { Text = "\n" },
new Span { Text = "Шкіра амфібій має особливе значення для них, оскільки дозволяє їм дихати. Багато видів амфібій поглинають кисень безпосередньо через шкіру, на додачу до легеневого дихання. Ця чутлива шкіра потребує постійної вологості, тому більшість амфібій зустрічаються неподалік від джерел води." },
new Span { Text = "\n" },
new Span { Text = "Протягом еволюції амфібії адаптувалися до різноманітних місць мешкання, від вологих тропічних лісів до сухих пустель та холодних гірських регіонів. Однак багато видів амфібій стикаються з серйозними загрозами, включаючи втрату середовища, забруднення та зміни клімату. Отже, збереження цих вразливих створінь є невід'ємною частиною збереження екологічного балансу їхніх екосистем та захисту біологічного різноманіття нашої планети." },
new Span { Text = "\n" }
            }
        };
    }
}
