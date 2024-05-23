using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.NutriPages;

public partial class HSN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public HSN() : this(AudioManager.Current)
    {
    }

    public HSN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hsn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_HSN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutriHSN());
    }
}
