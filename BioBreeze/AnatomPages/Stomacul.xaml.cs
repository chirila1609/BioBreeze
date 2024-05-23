using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Stomacul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public Stomacul() : this(AudioManager.Current)
    {
    }

    public Stomacul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("stomacul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieStom(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieStomac());
    }
}
