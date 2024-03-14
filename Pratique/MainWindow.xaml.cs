using System.Windows;

namespace Pratique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTerrainSansServiceClick(object sender, RoutedEventArgs e)
        {
            var terrainSauvage = new TerrainSauvage();
            TbTerrainSansService.Text = terrainSauvage.CalculerCout().ToString("0.00$");
        }

        public void OnTerrainAvecServicesClick(object sender, RoutedEventArgs e)
        {
            Service[] services = [
                new Service(10, CbAvec20A.IsChecked.Value, "Electricité 20 ampères"),
                new Service(15, CbAvecEgouts.IsChecked.Value, "Egouts")
            ];
            var terrainAvecServices = new TerrainAvecServices(services);
            TbTerrainAvecServices.Text = terrainAvecServices.CalculerCout().ToString("0.00$");
        }
    }
}