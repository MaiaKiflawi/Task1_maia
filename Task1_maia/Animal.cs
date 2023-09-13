using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Animal
    {
        protected string name; //שם החייה
        protected int age; //גיל החייה
        protected bool isPredator; //האם החייה טורף אל או לא
        protected double calorieAmount; //כמות קלוריות שצורך בארוחה

        public Animal(string name, int age, bool isPredator, double calorieAmount) //פעולה בונה
        {
            this.name = name;
            this.age = age;
            this.isPredator = isPredator;
            this.calorieAmount = calorieAmount;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public bool GetIsPredator()
        {
            return this.isPredator;
        }

        public double GetCalorieAmount()
        {
            return this.calorieAmount;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetIsPredator(bool isPredator)
        {
            this.isPredator = isPredator;
        }

        public void SetCaloreAmount(double calorieAmount)
        {
            this.calorieAmount = calorieAmount;
        }

        public override string ToString() //מרכזת ומחזירה את המידע הנאסף
        {
            string isP = "";
            if (this.isPredator)
            {
                isP = "is";
            }
            else
            {
                isP = "is not";
            }
            string animalDef = $"This animal's name is: {this.name}, it's age is: {this.age}, he {isP} a predator and" +
                $" eats {this.calorieAmount} calories every meal.";
            return animalDef;
        }

        public double Eat()
        {
            return this.calorieAmount * 3;
        }
    }
}
