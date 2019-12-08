using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAccess dbAccess = new DBAccess();
            Restaurant restaurant = dbAccess.GetRestaurant();
            DeliveryControl deliveryControl = new DeliveryControl(restaurant);
            deliveryControl.ShowProductsToOrder();
        }
    }
}
