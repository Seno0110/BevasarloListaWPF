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
using static BevasarloListaWPF.MainWindow;

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
            betoltes();
        }
        public List<ItemModel> termekek;
        private void betoltes()
        {
            termekek = new List<ItemModel>();
            termekek.Add(new ItemModel("Tej", 5, 450, "A"));
            termekek.Add(new ItemModel("Kenyer", 10, 350, "B"));
            termekek.Add(new ItemModel("Sajt", 2, 1200, "A"));
            termekek.Add(new ItemModel("Alma", 20, 200, "C"));
            termekek.Add(new ItemModel("Narancs", 15, 300, "C"));
            termekek.Add(new ItemModel("Hús", 3, 2500, "D"));
            termekek.Add(new ItemModel("Csokoládé", 7, 900, "B"));
            termekek.Add(new ItemModel("Kenyér", 1, 450, "B"));
            termekek.Add(new ItemModel("Tej", 12, 400, "A"));
            termekek.Add(new ItemModel("Sajt", 5, 1500, "D"));
            frissites();
        }
        private void frissites()
        {
            dataGrid.ItemsSource = termekek;
        }
        private void hozzadasOldal()
        {
            
        }
        public class ItemModel
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public string Type { get; set; }
            public int Sum { get; set; }

            public ItemModel(string name, int quantity, int price, string type)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
                Type = type;
                Sum = Price * Quantity;
            }
        }
    }
}