using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            if(sprocketForm.ShowDialog() == true)
                sprockets.Add(sprocketForm.Sprocket);
            lbResults.Items.Refresh();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Confirm", "Are you sure your want to delete?", MessageBoxButton.YesNo);
            if(dialogResult == MessageBoxResult.Yes && sprockets.Count > 0)
                sprockets.RemoveAt(index);
            lbResults.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            decimal totalPrice = 0.00M;
            foreach (var sprocket in sprockets)
            {
                totalPrice += sprocket.Price;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    file.WriteLine($"{txtName.Text}: {sprockets.Count} items, Total Price: ${totalPrice.ToString("N0")}");
                    if (!chkbxLocalPickup.IsChecked.Value)
                    {
                        file.WriteLine($"Ship to:");
                        file.WriteLine(txtStreet.Text);
                        file.WriteLine($"{txtCity.Text}, {txtState.Text} {txtZipCode.Text}");
                    }
                    file.WriteLine();
                    foreach (var sprocket in sprockets)
                    {
                        file.WriteLine(sprocket.ToString());
                        file.WriteLine();
                    }
                }
            }
        }

        private void lbResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = lbResults.SelectedIndex;
        }

        private void chkbxLocalPickup_Checked(object sender, RoutedEventArgs e)
        {
            lblCity.Visibility = Visibility.Hidden;
            lblState.Visibility = Visibility.Hidden;
            lblStreet.Visibility = Visibility.Hidden;
            lblZipCode.Visibility = Visibility.Hidden;
            txtCity.Visibility = Visibility.Hidden;
            txtState.Visibility = Visibility.Hidden;
            txtStreet.Visibility = Visibility.Hidden;
            txtZipCode.Visibility = Visibility.Hidden;
        }

        private void chkbxLocalPickup_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCity.Visibility = Visibility.Visible;
            lblState.Visibility = Visibility.Visible;
            lblStreet.Visibility = Visibility.Visible;
            lblZipCode.Visibility = Visibility.Visible;
            txtCity.Visibility = Visibility.Visible;
            txtState.Visibility = Visibility.Visible;
            txtStreet.Visibility = Visibility.Visible;
            txtZipCode.Visibility = Visibility.Visible;
        }
    }
}
