using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJDÄ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WrapPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            // Skapa och öppna ett nytt fönster
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
    }
}