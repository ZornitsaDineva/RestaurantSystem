﻿using System;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = GetRestaurant();
            DeliveryControl deliveryControl = new DeliveryControl(restaurant);
            deliveryControl.showProductsToOrder();
        }

        private static Restaurant GetRestaurant()
        {
            throw new NotImplementedException();
        }
    }
}
