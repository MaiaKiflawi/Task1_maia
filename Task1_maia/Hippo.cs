using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Hippo: Mammal
    {
        protected int fatPercent; //אחוזי שומן

        public Hippo(int fatPercent, double caloriesInMilk, int pregoMonths, string name, int age, bool isPredator, double calorieAmount)
            : base(caloriesInMilk, pregoMonths, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.fatPercent = fatPercent;
        }

        public int GetFatPercent()
        {
            return this.fatPercent;
        }

        public void SetFatPercent(int fatPercent)
        {
            this.fatPercent = fatPercent;
        }

        public override string ToString()
        {
            string hippoDef = $"{base.ToString()}\n The hippo's fat percentage is {this.fatPercent}%.";
            return hippoDef;
        }
    }
}
