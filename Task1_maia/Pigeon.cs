using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Pigeon: Bird
    {
        protected string colour; //צבע היונה
        protected int chiksNum; //כמות הגוזלים שיש ליונה

        public Pigeon(string colour, int chicksNum, int flightAlt, int wingspanLen, string name, int age, bool isPredator, double calorieAmount)
            : base(wingspanLen ,flightAlt, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.colour = colour;
            this.chiksNum = chicksNum;
        }

        public string GetColour()
        {
            return this.colour;
        }

        public int GetChiksNum()
        {
            return this.chiksNum;
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }

        public void SetChiksNum(int chiksNum)
        {
            this.chiksNum = chiksNum;
        }

        public override string ToString()
        {
            string pigeonDef = $"{base.ToString()}\n This pigeon is {this.colour} and it has {this.chiksNum} chiks.";
            return pigeonDef;
        }
    }
}
