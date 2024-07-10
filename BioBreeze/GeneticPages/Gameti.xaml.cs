using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class Gameti : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Gameti() : this(AudioManager.Current)
    {
    }

    public Gameti(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("gameti.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenGameti(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenGameti());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
