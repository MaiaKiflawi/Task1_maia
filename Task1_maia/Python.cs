using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Python: Snake
    {
        protected string colour; //צבע הפייתון
        protected string homeland; //מוצא אותו פייתון

        public Python(string colour, string homeland, bool isVenomous, double tailLength, string name, int age, bool isPredator, double calorieAmount)
            : base(isVenomous ,tailLength, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.colour = colour;
            this.homeland = homeland;
        }

        public string GetColour()
        {
            return this.colour;
        }

        public string GetHomeland()
        {
            return this.homeland;
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }

        public void SetHomeland(string homeland)
        {
            this.homeland = homeland;
        }

        public override string ToString()
        {
            string pythonDef = $"{base.ToString()}\n THis python's colour is {this.colour} and it was found in {this.homeland}.";
            return pythonDef;
        }
    }
}
