namespace RestaurantSystem
{
    internal class OrderLine
    {
        private int qty;
        private Product product;

        public int Qty { get => qty; set => qty = value; }
        public Product Product { get => product; set => product = value; }
    }
}