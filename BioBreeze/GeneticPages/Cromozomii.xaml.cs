using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class Cromozomii : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; // Define player at the class level

    public Cromozomii() : this(AudioManager.Current)
    {
    }

    public Cromozomii(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("cromozomii.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenCromozomii(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenCromozomii());
    }
}
