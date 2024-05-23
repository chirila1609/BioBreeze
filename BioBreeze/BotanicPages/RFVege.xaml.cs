using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class RFVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public RFVege() : this(AudioManager.Current)
    {
    }

    public RFVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("rfvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotRFVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotRFVege());
    }
}
