using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class TAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public TAnimale() : this(AudioManager.Current)
    {
    }

    public TAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("tanimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooTAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooTAnimale());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
