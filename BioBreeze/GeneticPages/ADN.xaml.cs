using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class ADN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public ADN() : this(AudioManager.Current)
    {
    }

    public ADN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("adn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenADN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenADN());
    }
}
