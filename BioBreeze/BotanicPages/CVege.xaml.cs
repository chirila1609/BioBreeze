using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class CVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public CVege() : this(AudioManager.Current)
    {
    }

    public CVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("cvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotCVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotCVege());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
