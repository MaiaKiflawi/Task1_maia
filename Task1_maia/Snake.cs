using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Snake : Reptile
    {
        protected bool isVenomous; //האם הנחש ערסי או לא

        public Snake(bool isVenomous, double tailLength, string name, int age, bool isPredator, double calorieAmount)
            : base(tailLength, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.isVenomous = isVenomous;
        }

        public bool GetIsVenomous()
        {
            return this.isVenomous;
        }

        public void SetIsVenomous(bool isVenomous)
        {
            this.isVenomous = isVenomous;
        }

        public override string ToString()
        {
            string isV = "";
            if (this.isPredator)
            {
                isV = "is";
            }
            else
            {
                isV = "is not";
            }
            string snakeDef = $"{base.ToString()}\n This snake {isV} venomous.";
            return snakeDef;
        }

        public string Dance()
        {
            return "Come on everybody! do the SNAKE! 🐍";
        }
    }
}
