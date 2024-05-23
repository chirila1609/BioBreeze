using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class CAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public CAnimale() : this(AudioManager.Current)
    {
    }

    public CAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("canimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooCAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooCAnimale());
    }
}