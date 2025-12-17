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
            dataGrid.ItemsSource = termekek;
        }
        private void frissites(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = termekek;
        }
        private void hozzadasOldal(Object sender, RoutedEventArgs e)
        {
            var ujtermek = new Hozzaadas();
            ujtermek.ShowDialog();
            if (ujtermek.DialogResult == true)
            {
                termekek.Add(ujtermek.ujtermek);
                dataGrid.ItemsSource = termekek;
                dataGrid.Items.Refresh();
            }
        }

        private void torles(Object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem == null) return;

            termekek.Remove((ItemModel)dataGrid.SelectedItem);
            dataGrid.Items.Refresh();
        }
        private void Atipus3(Object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = termekek.Where(x => x.Type == "A").OrderByDescending(x => x.Sum).Take(3);
        }
        private void top5Osszertek(Object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = termekek.OrderByDescending(x=>x.Sum).Take(5);
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