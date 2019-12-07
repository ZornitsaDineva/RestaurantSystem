namespace RestaurantSystem
{
    internal abstract class Employee
    {
        private int id;
        private string name;
        private decimal salary;
        private bool fired;
        private bool sick;
        private bool careful;
            

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public bool Fired { get => fired; set => fired = value; }
        public bool Sick { get => sick; set => sick = value; }
        public bool Careful { get => careful; set => careful = value; }

        bool IsAvailable()
        {
            return !Fired && !Sick;
        }
    }
}