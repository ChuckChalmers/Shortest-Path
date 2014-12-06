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
            lblPathAnswer.Content = "";
            lstPaths.Items.Clear();
            Globals.Initialize();
            Node source = null;
            Node destination = null;
            string visited = "";
            source = Neighbor.ToNode(txtSource.Text.ToUpper());
            destination = Neighbor.ToNode(txtDest.Text.ToUpper());
            if (Globals.nodeList.Contains(source))
            {
                if (Globals.nodeList.Contains(destination))
                {
                    Path.Pathing(source, destination, visited);
                    foreach (string p in Globals.validPaths)
                    {
                        lstPaths.Items.Add(p);
                    }
                    lblPathAnswer.Content = Globals.path + " " + Globals.shortestpath.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Destination", "Error");
                    txtDest.Clear();
                    txtDest.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Source", "Error");
                txtSource.Clear();
                txtSource.Focus();
            }
            
        }

    }
}
