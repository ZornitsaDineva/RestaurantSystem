using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystem
{
    class DeliveryControl
    {
        private readonly Restaurant restaurant;
        internal Restaurant Restaurant => restaurant;

        public DeliveryControl(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }

        internal void ShowProductsToOrder()
        {
            Console.WriteLine("Products to order report:");

            foreach (Product product in Restaurant.Products)
            {
                if (product.IsOutOfStock())
                {
                    Console.WriteLine("Product " + product.Name + " is out of stock");
                } else if (product.IsInLowStock())
                {
                    Console.WriteLine("Product " + product.Name + " is in low stock");
                }                
            }
        }
    }
}

