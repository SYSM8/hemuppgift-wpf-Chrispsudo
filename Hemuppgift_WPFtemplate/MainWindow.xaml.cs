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
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Show();
        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            // Skapa och öppnar ett GridWindow
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
    }
}