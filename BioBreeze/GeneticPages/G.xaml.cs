using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class G : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public G() : this(AudioManager.Current)
    {
    }

    public G(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("g.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenG(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenG());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
