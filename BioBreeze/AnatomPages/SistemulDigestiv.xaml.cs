using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulDigestiv : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulDigestiv() : this(AudioManager.Current)
    {
    }

    public SistemulDigestiv(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemuldigestiv.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSD(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSD());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
