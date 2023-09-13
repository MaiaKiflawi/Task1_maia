using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Reptile: Animal
    {
        protected double tailLength;//אורך הזנב

        public Reptile(double tailLength, string name, int age, bool isPredator, double calorieAmount)
            :base(name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.tailLength = tailLength;
        }

        public double GetTailLength()
        {
            return this.tailLength;
        }

        public void SetTailLength(double tailLength)
        {
            this.tailLength = tailLength;
        }

        public override string ToString()
        {
            string reptileDef = $"{base.ToString()}\n This reptile's tail is {this.tailLength} cm long.";
            return reptileDef;
        }
    }
}
