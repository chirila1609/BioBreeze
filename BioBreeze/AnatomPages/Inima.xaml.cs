using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Inima : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

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
}
