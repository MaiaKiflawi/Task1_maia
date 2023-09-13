using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] arrMammal =
            {
                new Mammal(caloriesInMilk: 50, pregoMonths: 9, name: "m1", age: 11, isPredator: false, calorieAmount: 1020.7),
                new Cow(caloriesInMilk: 78, pregoMonths: 11, name: "m2", age: 3, isPredator: true, calorieAmount: 1500.5, litterCount: 2),
                new Cow(caloriesInMilk: 20.7, pregoMonths: 7, name: "m3", age: 8, isPredator: false, calorieAmount: 570, litterCount : 4),
                new Hippo(caloriesInMilk: 100.1, pregoMonths: 9, name: "m4", age: 1, isPredator: false, calorieAmount: 1150, fatPercent: 67),
                new Hippo(caloriesInMilk: 56.4, pregoMonths: 9, name: "m5", age: 5, isPredator: true, calorieAmount: 1075, fatPercent: 30),
            };
            foreach (Mammal m in arrMammal)
            {
                Console.WriteLine(m);
            }
            Reptile[] arrReptile =
            {
                new Reptile(tailLength: 12, name: "r1", age: 2, isPredator: true, calorieAmount: 18.7),
                new Snake(tailLength: 58.4, name: "r2", age: 6, isPredator: true, calorieAmount: 1100, isVenomous: true),
                new Python(tailLength: 45, name: "r3", age: 4, isPredator: false, calorieAmount: 506.7, isVenomous: false, colour: "green", homeland: "Sydney"),
                new Reptile(tailLength: 3.1, name: "r4", age: 7, isPredator: false, calorieAmount: 21.4),
                new Python(tailLength: 27.6, name: "r5", age: 1, isPredator: false, calorieAmount: 78.9, isVenomous: false, colour: "brown", homeland: "Florida"),
            };
            foreach (Reptile r in arrReptile)
            {
                Console.WriteLine(r);
            }
            Animal[] arrAnimal =
            {
                new Animal(name: "a1", age: 1, isPredator: true, calorieAmount: 784),
                new Pigeon(name: "a2", age: 8, isPredator: false, calorieAmount: 450, flightAlt: 15, wingspanLen: 15, colour: "white", chicksNum: 6),
                new Pigeon(name: "a3", age: 2, isPredator: false, calorieAmount: 250, flightAlt: 20, wingspanLen: 20, colour: "grey", chicksNum: 4),
                new Snake(name: "a4", age: 3, isPredator: true, calorieAmount: 800.6, isVenomous: true, tailLength: 56),
                new Crocodile(name: "a5", age: 10, isPredator: false, calorieAmount: 157.2, tailLength: 150, dentalCare: true),
                new Crocodile(name: "a6", age: 18, isPredator: false, calorieAmount: 45.6, tailLength: 176, dentalCare: false),
                new Hippo(name: "a7", age: 5, isPredator: true, calorieAmount: 70.4, caloriesInMilk: 200, pregoMonths: 9, fatPercent: 68),
                new Mammal(name: "a8", age: 12, isPredator: false, calorieAmount: 387.6, caloriesInMilk: 270, pregoMonths:8),
            };
            foreach (Animal a in arrAnimal)
            {
                Console.WriteLine(a);
            }
        }

        public static double SumDailyCalories (Animal[] arrAnimal) //מחזיר את סכום הקלוריות שצרכו כל החיות ביום
        {
            double sumC = 0; //סכום קלוריות
            foreach (Animal a in arrAnimal)
            {
                sumC += a.Eat();
            }
            return sumC;
        }

        public static int CountMammal(Animal[] arrAnimal) //מחזיר את מספר היונקים במחלקת החיות
        {
            int countM = 0; //מספר יונקים
            foreach (Animal a in arrAnimal)
            {
                if (a is Mammal)
                {
                    countM++;
                }
            }
            return countM;
        }

        public static void MakeDance(Animal[] arrAnimal) //פעולה שמפעילה את פעולת הריקוד אצל כל הציפורים ונחשים ממערך החיות
        {
            foreach (Animal a in arrAnimal)
            {
                if (a is Bird)
                    (a as Bird).Dance();
                else if (a is Snake)
                    (a as Snake).Dance();
            }
        }

        public static string FattestHippo(Animal[] arrAnimal) //הפעולה מחזירה את שם ההיפופוטם עם אחוזי השומן הגדולים ביותר
        {
            int maxF = 0;
            string hName = "";
            foreach (Animal a in arrAnimal)
            {
                if (a is Hippo)
                {
                    if ((a as Hippo).GetFatPercent() > maxF)
                    {
                        maxF = (a as Hippo).GetFatPercent();
                        hName = (a as Hippo).GetName();
                    }
                        
                }
            }
            return hName;
        }
    }
}
