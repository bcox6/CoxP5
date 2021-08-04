using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoxP5
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        public Sprocket Sprocket { get; set; }
        public SprocketForm()
        {
            InitializeComponent();
        }

        public void GetSprocketInformation()
        {
            
            
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (cmbxItemType.Text.Equals("Aluminum", StringComparison.OrdinalIgnoreCase))
            {
                int itemId = int.Parse(txtItemId.Text);
                int numTeeth = int.Parse(txtNumOfTeeth.Text);
                int numItems = int.Parse(txtNumOfItems.Text);
                Sprocket = new AluminumSprocket(itemId, numTeeth, numItems);
            }
            else if (cmbxItemType.Text.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                int itemId = int.Parse(txtItemId.Text);
                int numTeeth = int.Parse(txtNumOfTeeth.Text);
                int numItems = int.Parse(txtNumOfItems.Text);
                Sprocket = new SteelSprocket(itemId, numTeeth, numItems);
            }
            else if (cmbxItemType.Text.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
            {
                int itemId = int.Parse(txtItemId.Text);
                int numTeeth = int.Parse(txtNumOfTeeth.Text);
                int numItems = int.Parse(txtNumOfItems.Text);
                Sprocket = new PlasticSprocket(itemId, numTeeth, numItems);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
