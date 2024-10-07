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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RowInput.Text, out int row) && int.TryParse(ColumnInput.Text, out int column))
            {
                if (row >= 0 && row < 4 && column >= 0 && column < 4)
                {
                    // Skapa en ny knapp
                    Button newButton = new Button
                    {
                        Background = Brushes.LightGreen,
                        Content = $"Row {row}, Col {column}",
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Stretch,
                    };

                    // Lägg till knappen i rätt cell
                    Grid.SetRow(newButton, row);
                    Grid.SetColumn(newButton, column);
                    MainGrid.Children.Add(newButton);
                }
                else
                {
                    MessageBox.Show("Rad och kolumn mellan 0 och 3.");
                }
            }
            else
            {
                MessageBox.Show("Vänligen ange mellan 0 och 3 för rad och kolumn.");
            }
        }
    }
}
