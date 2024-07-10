using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.ZooPages;

public partial class Amfibieni : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Amfibieni() : this(AudioManager.Current)
    {
    }

    public Amfibieni(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("amfibieni.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_ZooAmfibieni(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ZooAmfibieni());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
