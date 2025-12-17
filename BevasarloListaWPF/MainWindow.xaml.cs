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

namespace BevasarloListaWPF
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
        public List<termek> termekLista;
        private string url = "bevasarlosLista";
        private void betoltes(string url)
        {
            
        }
        public class termek
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public char Type { get; set; }

            public termek(string name, int quantity, int price, char type)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
                Type = type;
            }
        }
    }
}