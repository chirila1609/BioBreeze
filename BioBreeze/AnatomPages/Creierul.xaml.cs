using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Creierul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public Creierul() : this(AudioManager.Current)
    {
    }

    public Creierul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }
    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("creierul.mp3"));
        player.Play();
    }
    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }
    private void GoTo_AnatomieBrain(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieBrain());
    }
}