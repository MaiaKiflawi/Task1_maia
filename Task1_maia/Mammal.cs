using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Mammal: Animal
    {
        protected double caloriesInMilk; //כמות קלוריות בחלב
        protected int pregoMonths; //מספר חודשי הריון

        public Mammal (double caloriesInMilk, int pregoMonths, string name, int age, bool isPredator, double calorieAmount)
            :base(name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.caloriesInMilk = caloriesInMilk;
            this.pregoMonths = pregoMonths;
        }

        public double GetCaloriesInMilk()
        {
            return this.caloriesInMilk;
        }

        public int GetpregoMonths()
        {
            return this.pregoMonths;
        }

        public void SetCaloriesInMilk(double caloriesInMilk)
        {
            this.caloriesInMilk = caloriesInMilk;
        }

        public void SetPregoMonths(int pregoMonths)
        {
            this.pregoMonths = pregoMonths;
        }

        public override string ToString() //מרכזת ומחזירה את המידע הנאספת
        {
            string mammalDef = $"{base.ToString()}\n This mammal's pregnancy lasts for {this.pregoMonths} months and " +
                $"the milk it produces has {this.caloriesInMilk} calories.";
            return mammalDef;
        }

        public new double Eat()
        {
            return (base.Eat() + this.caloriesInMilk);
        }
    }
}
