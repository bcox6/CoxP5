using Microsoft.Win32;
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

namespace CoxP5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Sprocket> sprockets = new List<Sprocket>();
        private int index;
        public MainWindow()
        {
            InitializeComponent();
            lbResults.ItemsSource = sprockets;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SprocketForm sprocketForm = new SprocketForm();
            sprocketForm.ShowDialog();
            if(sprocketForm.Sprocket != null)
                sprockets.Add(sprocketForm.Sprocket);
            lbResults.Items.Refresh();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            sprockets.RemoveAt(index);
            lbResults.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == true)
            {

            }
        }

        private void lbResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = lbResults.SelectedIndex;
        }
    }
}
