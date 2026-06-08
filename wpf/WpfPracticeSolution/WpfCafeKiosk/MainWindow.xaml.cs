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

namespace WpfCafeKiosk
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

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            string[] tag = btn.Tag.ToString().Split("|");

            String menuName = tag[0];
            int price = int.Parse(tag[1]);
            string imagePath = tag[2];

            // MessageBox.Show($"{name}는 {price}원 입니다.");
            MenuOptionWindow win = new MenuOptionWindow(menuName, price,imagePath);

            win.Owner = this;
            bool? result = win.ShowDialog();

        }
    }
}