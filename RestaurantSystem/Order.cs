using System.Collections.Generic;

namespace RestaurantSystem
{
    internal class Order
    {
        private List<OrderLine> orderLines;

        internal List<OrderLine> OrderLines { get => orderLines; set => orderLines = value; }
    }
}