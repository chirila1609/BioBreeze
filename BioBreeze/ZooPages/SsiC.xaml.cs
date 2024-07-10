using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class SsiC : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SsiC() : this(AudioManager.Current)
    {
    }

    public SsiC(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ssic.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooSsiC(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooSsiC());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
