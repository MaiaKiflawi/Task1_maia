using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Crocodile: Reptile
    {
        protected bool dentalCare; //עבר טיפול שיניים או לא

        public Crocodile(bool dentalCare, double tailLength, string name, int age, bool isPredator, double calorieAmount)
            : base(tailLength, name, age, isPredator, calorieAmount) //פעולה בונה
        {
            this.dentalCare = dentalCare;
        }

        public bool GetDentalCare()
        {
            return this.dentalCare;
        }

        public void SetDentalCare(bool dentalCare)
        {
            this.dentalCare = dentalCare;
        }

        public override string ToString()
        {
            string hadDC = "";
            if (this.isPredator)
            {
                hadDC = "has";
            }
            else
            {
                hadDC = "has not";
            }
            string crocDef = $"{base.ToString()}\n This crocodile {hadDC} gotten dental care.";
            return crocDef;
        }
    }
}
