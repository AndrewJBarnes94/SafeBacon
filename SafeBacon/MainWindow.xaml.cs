using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SafeBacon;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Add 8 rows and 8 columns
        for (int i = 0; i < 8; i++)
        {
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.ColumnDefinitions.Add(new ColumnDefinition());
        }
    }

    

}