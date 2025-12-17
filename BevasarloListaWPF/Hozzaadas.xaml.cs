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

namespace BevasarloListaWPF
{
    /// <summary>
    /// Interaction logic for Hozzaadas.xaml
    /// </summary>
    public partial class Hozzaadas : Window
    {
        
        public Hozzaadas()
        {
            InitializeComponent();
        }
        public MainWindow.ItemModel ujtermek;
        public string name;
        public int quantity;
        public int price;
        public string type;
        public void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) &&
                int.TryParse(Quantity.Text, out quantity) &&
                int.TryParse(Price.Text, out price) &&
                Type_.SelectedItem != null)
            {
                name = Name.Text;
                type = Type_.Text;
                ujtermek = new MainWindow.ItemModel(name, quantity, price, type);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Hibás adatok!","Hiba",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        private void No_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
