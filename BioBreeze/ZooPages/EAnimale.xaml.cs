using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class EAnimale : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EAnimale() : this(AudioManager.Current)
    {
    }

    public EAnimale(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("eanimale.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooEAnimale(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooEAnimale());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
