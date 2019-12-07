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
    }
}
