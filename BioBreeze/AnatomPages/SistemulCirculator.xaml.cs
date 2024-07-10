using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulCirculator : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulCirculator() : this(AudioManager.Current)
    {
    }

    public SistemulCirculator(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulcirculator.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSC());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
