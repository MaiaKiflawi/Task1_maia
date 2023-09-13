using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Cow: Mammal
    {
        protected int litterCount; //מספר המלטות

        public Cow(int litterCount, double caloriesInMilk, int pregoMonths, string name, int age, bool isPredator, double calorieAmount)
            : base(caloriesInMilk, pregoMonths, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.litterCount = litterCount;
        }

        public int GetLitterCount()
        {
            return this.litterCount;
        }

        public void SetLitterCount(int litterCount)
        {
            this.litterCount = litterCount;
        }

        public override string ToString()
        {
            string cowDef = $"{base.ToString()}\n The cow's litter consists of {this.litterCount} calves.";
            return cowDef;
        }

        public new double Eat()
        {
            return (base.Eat()/4);
        }
    }
}
