namespace RestaurantSystem
{
    internal class Product
    {
        private int id;
        private string name;
        private decimal price;
        private int qty;
        private int lowStockThresheld;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
        public int LowStockThresheld { get => lowStockThresheld; set => lowStockThresheld = value; }

        public bool IsInLowStock()
        {
            return qty < lowStockThresheld;
        }

        public bool IsOutOfStock()
        {
            return qty == 0;
        }

    }
}