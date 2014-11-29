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
            List<Node> nodeList = new List<Node>();
            nodeList = Node.nodeBuilder();
            Node source = null;
            Node destination = null;
            source = nodeList.FirstOrDefault(x => x.Name == txtSource.Text.ToUpper());
            destination = nodeList.FirstOrDefault(y => y.Name == txtDest.Text.ToUpper());
            string visited = source.Name;
            Path.Pathing(source, destination, visited, nodeList);
            foreach(string p in Globals.validPaths)
            {
                lstPaths.Items.Add(p);
            }
        }

    }
}
