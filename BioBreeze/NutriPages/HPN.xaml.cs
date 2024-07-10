using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.NutriPages;

public partial class HPN : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public HPN() : this(AudioManager.Current)
    {
    }

    public HPN(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hpn.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_HPN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NutriHPN());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
