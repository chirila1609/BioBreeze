using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class RVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public RVege() : this(AudioManager.Current)
    {
    }

    public RVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("rvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotRVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotRVege());
    }
}
