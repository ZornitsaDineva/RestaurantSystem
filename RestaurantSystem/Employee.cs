namespace RestaurantSystem
{
    internal class Employee
    {
        private int id;
        private string name;
        private decimal salary;
        private bool fired;
        private bool sick;
        private bool carfeful;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public bool Fired { get => fired; set => fired = value; }
        public bool Sick { get => sick; set => sick = value; }
        public bool Carfeful { get => carfeful; set => carfeful = value; }

        bool IsAvailable()
        {
            return !Fired && !Sick;
        }


    }
}