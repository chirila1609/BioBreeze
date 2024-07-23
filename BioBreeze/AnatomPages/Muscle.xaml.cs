using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Muscle : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Muscle() : this(AudioManager.Current)
    {
    }

    public Muscle(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("muschii.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieMuscle(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieMuscle());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void OnRomanianClicked(object sender, EventArgs e)
    {
        SetRomanianContent();
    }

    private void OnHungarianClicked(object sender, EventArgs e)
    {
        SetHungarianContent();
    }

    private void OnUkrainianClicked(object sender, EventArgs e)
    {
        SetUkrainianContent();
    }

    private void SetRomanianContent()
    {
        IntroLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Introducere: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii sunt unul dintre cele mai importante sisteme din corpul nostru. Ei ne ajută să ne mișcăm și să ne menținem poziția corectă. Fără mușchi, nu am putea să facem lucruri simple precum să ne ridicăm sau să ne întindem mâinile." },
                }
        };

        FaceMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Feței: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii feței sunt responsabili pentru exprimarea noastră facială. Acești mușchi ne permit să zâmbim, să clipim și să ne arătăm emoțiile. De asemenea, ne ajută să mâncăm și să vorbim corect." },
                }
        };

        NeckMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Gâtului: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii gâtului sunt responsabili pentru mișcările capului. Acești mușchi ne permit să ne întoarcem capul în diferite direcții și să ne menținem capul drept." },
                }
        };

        BackMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Spate: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii spatelui sunt esențiali pentru menținerea posturii corecte a corpului și pentru sprijinirea coloanei vertebrale. Ei ne permit să ne aplecăm, să ne întindem și să ne ridicăm fără să ne accidentăm." },
                }
        };

        ShoulderMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Umerilor: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii umărului sunt importanți pentru mișcarea și stabilizarea umărului. Acești mușchi sunt implicați în ridicarea și coborârea brațelor și în mișcările de rotație ale umărului." },
                }
        };

        ArmMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Brațului: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii brațului sunt responsabili pentru mișcarea și controlul brațelor noastre. Ei ne permit să ne ridicăm brațele, să prindem obiecte și să facem mișcări precise." },
                }
        };

        WristMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Încheieturii: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii încheieturii sunt importanți pentru controlul mișcărilor mâinilor și degetelor. Acești mușchi ne permit să prindem obiecte, să scriem și să facem gesturi precise." },
                }
        };

        HandMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Mâinii: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii mâinii sunt esențiali pentru mișcările fine și controlul degetelor. Acești mușchi ne permit să prindem obiecte mici, să facem gesturi și să executăm activități precum să scriem sau să desenăm." },
                }
        };

        AbdomenMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Abdomenului: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Mușchii abdomenului sunt responsabili pentru menținerea stabilității trunchiului și a posturii corecte a corpului. Ei ne permit să ne mișcăm înainte și înapoi și să ne rotim trunchiul." },
                }
        };

        LegMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Mușchii Piciorului: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Picioarele noastre sunt susținute de o rețea complexă de mușchi care ne permit să ne mișcăm și să ne menținem echilibrul. Mușchii coapsei, cei mai mari și mai puternici mușchi din picioare, sunt responsabili pentru ridicarea și mișcarea în diverse direcții. Mușchii gambei, situați în partea inferioară a piciorului, sunt implicați în flexia și extensia piciorului, precum și în menținerea echilibrului. Mușchii fesieri, localizați în zona feselor, sunt responsabili pentru mișcarea șoldurilor și pentru menținerea unei posturi corecte." },
                }
        };
    }

    private void SetHungarianContent()
    {
        IntroLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Bevezetés: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az izmok az egyik legfontosabb rendszerünk a testünkben. Segítenek nekünk mozogni és megőrizni a helyes testtartást. Izom nélkül nem tudnánk egyszerű dolgokat csinálni, mint például felállni vagy kinyújtani a karjainkat." },
                }
        };

        FaceMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Arci Izmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Az arci izmok felelősek az arckifejezéseinkért. Ezek az izmok lehetővé teszik, hogy mosolyogjunk, pislogjunk és kifejezzük érzelmeinket. Ezen kívül segítenek nekünk helyesen enni és beszélni." },
                }
        };

        NeckMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Nyakizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A nyakizmok felelősek a fej mozgásaiért. Ezek az izmok lehetővé teszik, hogy különböző irányokba fordítsuk a fejünket, és tartsuk egyenesen." },
                }
        };

        BackMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Hátizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A hátizmok létfontosságúak a helyes testtartás fenntartásában és a gerinc támogatásában. Ezek az izmok lehetővé teszik, hogy meghajoljunk, nyújtsunk és emeljünk anélkül, hogy megsérülnénk." },
                }
        };

        ShoulderMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Vállizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A vállizmok fontosak a váll mozgásának és stabilizálásának szempontjából. Ezek az izmok részt vesznek a karok emelésében és leengedésében, valamint a váll forgó mozgásaiban." },
                }
        };

        ArmMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Karizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A karizmok felelősek a karok mozgásáért és irányításáért. Ezek az izmok lehetővé teszik, hogy felemeljük karjainkat, tárgyakat fogjunk meg és pontos mozdulatokat tegyünk." },
                }
        };

        WristMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Csuklóizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A csuklóizmok fontosak a kezek és ujjak mozgásának irányításában. Ezek az izmok lehetővé teszik, hogy tárgyakat fogjunk meg, írjunk és pontos mozdulatokat tegyünk." },
                }
        };

        HandMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Kézizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A kézizmok létfontosságúak a finom mozdulatokhoz és az ujjak irányításához. Ezek az izmok lehetővé teszik, hogy apró tárgyakat fogjunk meg, gesztusokat tegyünk és olyan tevékenységeket végezzünk, mint az írás vagy rajzolás." },
                }
        };

        AbdomenMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Hasizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A hasizmok felelősek a törzs stabilitásának fenntartásáért és a helyes testtartásért. Ezek az izmok lehetővé teszik, hogy előre és hátra mozogjunk és forgassuk a törzsünket." },
                }
        };

        LegMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Lábizmok: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "A lábunkat egy összetett izomzat hálózata támogatja, amely lehetővé teszi, hogy mozogjunk és egyensúlyban maradjunk. A combizmok, a lábak legnagyobb és legerősebb izmai, felelősek a felemelésért és a különböző irányokba történő mozgásért. A lábszár izmai, amelyek az alsó lábszárban találhatók, részt vesznek a láb flexiójában és extensiójában, valamint az egyensúly fenntartásában. A gluteális izmok, amelyek a fenék területén találhatók, felelősek a csípő mozgásáért és a helyes testtartás fenntartásáért." },
                }
        };
    }

    private void SetUkrainianContent()
    {
        IntroLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "Вступ: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи є однією з найважливіших систем у нашому тілі. Вони допомагають нам рухатися і підтримувати правильну поставу. Без м'язів ми не могли б робити такі прості речі, як стояти або простягати руки." },
                }
        };

        FaceMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Обличчя: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи обличчя відповідають за наші вирази обличчя. Ці м'язи дозволяють нам посміхатися, моргати і показувати свої емоції. Також вони допомагають нам правильно їсти та говорити." },
                }
        };

        NeckMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Шиї: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи шиї відповідають за рухи голови. Ці м'язи дозволяють нам повертати голову в різні напрямки і тримати голову прямо." },
                }
        };

        BackMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Спини: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи спини життєво важливі для підтримки правильної постави та підтримки хребта. Вони дозволяють нам нахилятися, розтягуватися та піднімати без травм." },
                }
        };

        ShoulderMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Плечей: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи плечей важливі для руху та стабілізації плеча. Ці м'язи беруть участь у підніманні та опусканні рук та у рухах обертання плеча." },
                }
        };

        ArmMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Руки: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи руки відповідають за рух та контроль наших рук. Вони дозволяють нам піднімати руки, захоплювати предмети та робити точні рухи." },
                }
        };

        WristMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Зап'ястя: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи зап'ястя важливі для контролю рухів рук та пальців. Ці м'язи дозволяють нам захоплювати предмети, писати та робити точні жести." },
                }
        };

        HandMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Кисті: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи кисті є життєво важливими для тонких рухів і контролю пальців. Ці м'язи дозволяють нам захоплювати маленькі предмети, робити жести та виконувати такі дії, як письмо чи малювання." },
                }
        };

        AbdomenMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Черевного Преса: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "М'язи черевного преса відповідають за підтримання стабільності тулуба та правильної постави тіла. Вони дозволяють нам рухатися вперед і назад та обертати тулуб." },
                }
        };

        LegMusclesLabel.FormattedText = new FormattedString
        {
            Spans =
                {
                    new Span { FontAttributes = FontAttributes.Bold, Text = "М'язи Ноги: " },
                    new Span { Text = "\n" },
                    new Span { FontSize = 15, Text = "Наші ноги підтримуються складною мережею м'язів, яка дозволяє нам рухатися та підтримувати рівновагу. М'язи стегна, найбільші та найсильніші м'язи ніг, відповідають за підйом та рух у різні напрямки. М'язи литок, розташовані у нижній частині ноги, беруть участь у згинанні та розгинанні стопи, а також у підтримці рівноваги. Сідничні м'язи, розташовані в області сідниць, відповідають за рухи стегон та підтримку правильної постави." },
                }
        };

    }
    }
