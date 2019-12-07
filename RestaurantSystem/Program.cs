using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = GetRestaurant();
            DeliveryControl deliveryControl = new DeliveryControl(restaurant);
            deliveryControl.ShowProductsToOrder();
        }

        private static Restaurant GetRestaurant()
        {
            Restaurant restaurant = new Restaurant();

            Product product = new Product
            {
                Name = "milk",
                Qty = 0,
                LowStockThresheld = 5
            };

            List<Product> products = new List<Product>();
            products.Add(product);

            restaurant.Products = products;

            return restaurant;
        }
    }
}
