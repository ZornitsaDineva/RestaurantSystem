using System.Collections.Generic;

namespace RestaurantSystem
{
    internal class Restaurant
    {
        private List<Product> products;
        private List<Employee> employees;
        private List<Order> orders;
        private string address;

        public List<Product> Products { get => products; set => products = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public List<Order> Orders { get => orders; set => orders = value; }
        public string Address { get => address; set => address = value; }
    }
}