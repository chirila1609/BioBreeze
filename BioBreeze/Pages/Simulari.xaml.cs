namespace BioBreeze.Pages;

public partial class Simulari : ContentPage
{
	public Simulari()
	{
		InitializeComponent();
	}

    private void GoTo_nsim(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.nsim());
    }

    private void GoTo_vsim(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.vsim());
    }

    private void GoTo_mcs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.mcs());
    }

    private void GoTo_gs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.gs());
    }

    private void GoTo_cvg(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.cvg());
    }

    private void GoTo_cag(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BioBreeze.SimuPages.cag());
    }

    private void OnMenuButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    private void OnLanguageButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var languageCode = button?.CommandParameter as string;
        SetLanguage(languageCode);
    }

    private void SetLanguage(string languageCode)
    {
        switch (languageCode)
        {
            case "ro":
                NeuronSimulationButton.Text = "Simulare neuroni";
                EyeSimulationButton.Text = "Simulare ochi";
                CellMembraneSimulationButton.Text = "Simulare membrană celulară";
                GeneSimulationButton.Text = "Simulare gene";
                PlantCellGameButton.Text = "Joc celula vegetală";
                AnimalCellGameButton.Text = "Joc celula animală";
                break;

            case "hu":
                NeuronSimulationButton.Text = "Neuronok szimulációja";
                EyeSimulationButton.Text = "Szem szimuláció";
                CellMembraneSimulationButton.Text = "Sejtmembrán szimuláció";
                GeneSimulationButton.Text = "Gének szimulációja";
                PlantCellGameButton.Text = "Növényi sejt játék";
                AnimalCellGameButton.Text = "Állati sejt játék";
                break;

            case "uk":
                NeuronSimulationButton.Text = "Симуляція нейронів";
                EyeSimulationButton.Text = "Симуляція ока";
                CellMembraneSimulationButton.Text = "Симуляція клітинної мембрани";
                GeneSimulationButton.Text = "Симуляція генів";
                PlantCellGameButton.Text = "Гра рослинна клітина";
                AnimalCellGameButton.Text = "Гра тваринна клітина";
                break;

            default:
                
                SetLanguage("ro");
                break;
        }
    }
}