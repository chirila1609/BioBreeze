using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class SistemulRespirator : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public SistemulRespirator() : this(AudioManager.Current)
    {
    }

    public SistemulRespirator(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sistemulrespirator.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieSR(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieSR());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
