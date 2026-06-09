using System.Collections.ObjectModel;
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
using WpfCafeKiosk.Models;

namespace WpfCafeKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<OrderItem> orders;

        public MainWindow()
        {
            InitializeComponent();
        }

        // 윈도우 로드이벤트 핸들러
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            orders = new ObservableCollection<OrderItem>();
            LstOrder.ItemsSource = orders;
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
            // result가 true일때 주문담기
            if (result == true)
            {
                // OrderItem item = win.SelectOrder;
                //MessageBox.Show($"{item.MenuName} {item.Count}개 담기! {item.TotalPrice}원 입니다");
                orders.Add(win.SelectOrder);
                RefreshOrderSummary();
            }
        }

        // F12 클릭시 자동 생성
        private void BtnRemoveOrder_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;  // wpf,winforms에서 중요한 개념, 이벤트를 발생시킨 주체
            OrderItem item = btn.Tag as OrderItem;

            if (item != null)
            {
                orders.Remove(item);
                RefreshOrderSummary();
            }
        }
        private void RefreshOrderSummary()
        {
            int count = orders.Sum(x=> x.Count);
            int total = orders.Sum(x=> x.TotalPrice);

            TxtOrderCount.Text = $"{count}잔";
            TxtTotalPrice.Text = $"{total}원";
        }

        private void BtnClearAll_Click(object sender, RoutedEventArgs e)
        {
            if (orders.Count == 0)
            {
                RootDialog.IsOpen = true;
                return;
            }
            orders.Clear();
            RefreshOrderSummary();
        }
    }
}