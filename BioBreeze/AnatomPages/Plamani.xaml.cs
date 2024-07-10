using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Plamani : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Plamani() : this(AudioManager.Current)
    {
    }

    public Plamani(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("plamani.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomiePL(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomiePL());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
