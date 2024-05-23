using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.NutriPages;

public partial class MN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public MN() : this(AudioManager.Current)
    {
    }

    public MN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("mn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_MN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutriMN());
    }
}