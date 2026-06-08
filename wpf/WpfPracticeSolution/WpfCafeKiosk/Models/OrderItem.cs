namespace WpfCafeKiosk.Models
{
    internal class OrderItem
    {
        public int MenueId { get; set; }
        public string MenuName { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalPrice { 
            get{
                return Price * Count;
            } 
        }
    }
}
