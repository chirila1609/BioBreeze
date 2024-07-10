using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Limba : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Limba() : this(AudioManager.Current)
    {
    }

    public Limba(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("limba.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieLimba(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieLimba());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
