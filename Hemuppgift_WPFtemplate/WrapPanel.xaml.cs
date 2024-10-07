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
    /// Interaction logic for WrapPanel.xaml
    /// </summary>
    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }

        private void WrapPanelWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Ställ in initial orientering
            EllipsePanel.Orientation = Orientation.Horizontal;
        }

        private void OrientationChanged(object sender, RoutedEventArgs e)
        {
            if (EllipsePanel != null) // Kontrollera att EllipsePanel inte är null
            {
                if (HorizontalButton.IsChecked == true)
                {
                    EllipsePanel.Orientation = Orientation.Horizontal;
                }
                else if (VerticalButton.IsChecked == true)
                {
                    EllipsePanel.Orientation = Orientation.Vertical;
                }
            }
        }
    }
}
