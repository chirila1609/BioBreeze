using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.BotanicPages;

public partial class HVege : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public HVege() : this(AudioManager.Current)
    {
    }

    public HVege(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("hvege.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_BotHVege(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BotHVege());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
