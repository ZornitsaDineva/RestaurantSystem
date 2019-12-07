using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystem
{
    class Manager : Employee
    {
        private decimal financialGoal;
        private List<string> missions;

        public decimal FinancialGoal { get => financialGoal; set => financialGoal = value; }
        public List<string> Missions { get => missions; set => missions = value; }
    }
}
