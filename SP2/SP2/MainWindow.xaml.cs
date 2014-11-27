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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SP2
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

        private void btnPath_Click(object sender, RoutedEventArgs e)
        {
            //string[][] neighbors = new string[19][];
            //neighbors = Nodes.Storage();
            string source = "";
            string destination = "";
            string visited = "";
            source = txtSource.Text.ToUpper();
            destination = txtDest.Text.ToUpper();
            Path.Pathing(source, destination, visited);
            //Nodes.Search(neighbors, source, destination, "");
            //lstPaths.Items.Add(validPath);
        }

    }
}
