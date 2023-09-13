using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Bird: Animal, IBird
    {
        protected int flightAlt; //גובה תעופה
        protected int wingspanLen; //אורך מוטת הכנף

        public Bird(int flightAlt, int wingspanLen, string name, int age, bool isPredator, double calorieAmount)
            :base(name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.flightAlt = flightAlt;
            this.wingspanLen = wingspanLen;
        }

        public int GetFlightAlt()
        {
            return this.flightAlt;
        }

        public int GetWingspanLen()
        {
            return this.wingspanLen;
        }

        public void SetFlightAlt(int flightAlt)
        {
            this.flightAlt = flightAlt;
        }

        public void SetWingspanLen(int wingspanLen)
        {
            this.wingspanLen = wingspanLen;
        }

        public override string ToString()
        {
            string birdDef = $"{base.ToString()}\n This bird's flight altitude is {this.flightAlt} meters high and " +
                $"it's wingspan is {this.wingspanLen} cm long.";
            return birdDef;
        }

        public string Sing()
        {
            return "🎼🎵🎵🎵🔊";
        }

        public string Dance()
        {
             return "And a 1 2 3 4 - dance!🐦";
        }

        public string TakeOff()
        {
            return "Bird is taking off";
        }

        public string Land()
        {
            return "Bird is landing";
        }

        public string Soaring()
        {
            return "Bird is soaring";
        }
    }
}
