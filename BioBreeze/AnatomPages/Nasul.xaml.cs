using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Nasul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Nasul() : this(AudioManager.Current)
    {
    }

    public Nasul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("nasul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieNasul(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieNasul());
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
                    new Span { FontSize = 15, Text = "Nasul uman este un organ complex și esențial al sistemului respirator, având multiple funcții, printre care respirația, detectarea mirosurilor și filtrarea particulelor din aerul inhalat. Situat în partea superioară a feței, nasul servește ca un canal de aer și ca un receptor de informații olfactive." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Structura nasului este formată din mai multe componente, inclusiv cavitatea nazală, septul nazal, cornetele nazale și sinusurile paranazale. Cavitatea nazală este spațiul interior al nasului, care este tapetat cu mucoasă și în care aerul este încălzit, umidificat și curățat înainte de a ajunge în plămâni. Septul nazal este o perete subțire de țesut care separă cavitatea nazală în două părți simetrice. Cornetele nazale sunt proeminențe osoase acoperite de mucoasă care ajută la direcționarea și filtrarea aerului în timpul respirației. Sinusurile paranazale sunt cavități umplute cu aer care se găsesc în oasele din jurul nasului și servesc la reducerea greutății capului și la producerea de mucus." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Una dintre cele mai importante funcții ale nasului este detectarea mirosurilor. Membrana olfactivă situată în partea superioară a cavității nazale conține receptorii olfactivi care sunt sensibili la substanțele chimice din aer. Aceste receptorii transmit informații către creier, permițând individului să perceapă și să identifice mirosurile din mediul înconjurător." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Pe lângă funcția sa de detectare a mirosurilor, nasul uman joacă și un rol important în filtrarea particulelor din aerul inhalat. Firele de păr și mucoasa din cavitatea nazală capturează particulele străine și microorganismele din aer, împiedicându-le să ajungă în plămâni și protejând astfel sistemul respirator împotriva infecțiilor și alergiilor." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "În concluzie, nasul uman este un organ esențial pentru respirație, olfacție și protecție împotriva particulelor străine din aer. Structura și funcționarea sa complexe îl fac un element indispensabil al corpului uman și ilustrează interconectarea dintre funcțiile de bază ale organismului și capacitatea sa de a interacționa cu mediul înconjurător." },
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
                    new Span { FontSize = 15, Text = "Ніс людини - це складний і важливий орган дихальної системи, який виконує кілька функцій, включаючи дихання, виявлення запахів та фільтрацію частинок з вдиханого повітря." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Структура носа складається з декількох компонентів, включаючи назальну порожнину, назальний септ, назальні раковини та параназальні синуси." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Однією з найважливіших функцій носа є виявлення запахів, а також фільтрація частинок з вдиханого повітря." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Висновок: ніс людини - це необхідний орган для дихання, відчуття запахів та захисту від іноземних частинок повітря." },
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
                    new Span { FontSize = 15, Text = "Az emberi orr egy bonyolult és fontos légzőrendszeri szerv, amely több funkciót is ellát, beleértve a légzést, a szagok érzékelését és a belélegzett levegő részecskéinek szűrését." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az orr szerkezete több összetevőből áll, ideértve az orrüreget, az orrsövényt, az orrjáratokat és a melléküregeket." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Az orr egyik legfontosabb funkciója a szagok érzékelése és a belélegzett levegő részecskéinek szűrése." },
                    new Span { Text = "\n\n" },
                    new Span { FontSize = 15, Text = "Összegzés: Az emberi orr lélegzési, szaglási és védelmi szervként szolgál a levegőbe belépő idegen részecskék ellen." },
                    new Span { Text = "\n" }
                }
        };
    }
}
