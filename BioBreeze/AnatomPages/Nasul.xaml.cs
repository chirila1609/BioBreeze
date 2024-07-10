using BioBreeze.Teste;
using Plugin.Maui.Audio;

namespace BioBreeze.AnatomPages;

public partial class Nasul : ContentPage
{
    private IAudioManager audioManager;
    private IAudioPlayer player; 

    public Nasul() : this(AudioManager.Current)
    {
    }

    public Nasul(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void Asculta(object sender, EventArgs e)
    {
        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("nasul.mp3"));
        player.Play();
    }

    private void Opreste(object sender, EventArgs e)
    {
        if (player != null)
        {
            player.Dispose();
        }
    }

    private void GoTo_AnatomieNasul(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AnatomieNasul());
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}
