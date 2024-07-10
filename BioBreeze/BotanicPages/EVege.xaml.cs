using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class EVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public EVege() : this(AudioManager.Current)
    {
    }

    public EVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("evege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotEVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotEVege());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
