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
            lstPaths.Items.Clear();
            Globals.validPaths.Clear();
            Globals.nodeList = Node.nodeBuilder();
            Node source = null;
            Node destination = null;
            string visited = "";
            source = Neighbor.ToNode(txtSource.Text.ToUpper());
            destination = Neighbor.ToNode(txtDest.Text.ToUpper());
            Path.Pathing(source, destination, visited);
            foreach (string p in Globals.validPaths)
            {
                lstPaths.Items.Add(p);
            }
            lblPathAnswer.Content = Globals.path + " " + Globals.shortestpath.ToString();
        }

    }
}
