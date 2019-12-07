using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystem
{
    class Coocker : Employee
    {
        private List<string> specialisations;
        private string rank;

        public List<string> Specialisations { get => specialisations; set => specialisations = value; }
        public string Rank { get => rank; set => rank = value; }
    }
}
