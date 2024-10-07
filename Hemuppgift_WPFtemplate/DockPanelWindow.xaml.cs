using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanel.xaml
    /// </summary>
    public partial class DockPanel : Window
    {
        public DockPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hantera knappklick
            if (sender is Button clickedButton)
            {
                MessageBox.Show($"{clickedButton.Content} klickad!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Visa bilden
            DisplayImage.Visibility = Visibility.Visible;
        }
    }
}
