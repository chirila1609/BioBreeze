using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.GeneticPages;

public partial class EV : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EV() : this(AudioManager.Current)
    {
    }

    public EV(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ev.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_GenEV(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenEV());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
