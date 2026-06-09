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
using WpfCafeKiosk.Models;  // 네임스페이스가 다르면 using문으로 import해야함

namespace WpfCafeKiosk
{
    /// <summary>
    /// MenuOptionWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuOptionWindow : Window
    {
        private int price;
        private string menuName;
        private string imagePath;
        private int qty = 1;
        public MenuOptionWindow()
        {
            InitializeComponent();
        }

        public OrderItem SelectOrder { get; set; }

        public MenuOptionWindow(string menuName, int price,string imagePath)
        {
            InitializeComponent();

            this.menuName = menuName;
            this.price = price;
            this.imagePath = imagePath;

            TxtMenuName.Text = menuName;
            TxtPrice.Text = $"{price:N0}원";
            
            ImgMenu.Source = new BitmapImage(new Uri(imagePath,UriKind.RelativeOrAbsolute));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (qty <= 1) return;
            qty--;
            TxtQty.Text = qty.ToString();
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            qty++;
            TxtQty.Text = qty.ToString();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            SelectOrder = new OrderItem
            {
                MenuName = menuName,
                Count = qty,
                Price = price,
                TotalPrice = price * qty
            };
            DialogResult = true;
            Close();

        }
    }
}
