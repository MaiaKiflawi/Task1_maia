using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_maia
{
    internal class Park
    {
        private Animal[] animalArr;
        private int animalNum;

        public Park(int animalNum)
        {
            this.animalArr = new Animal[1000];
            this.animalNum = animalNum;
        }

        public void AddAnimal(Animal animal)
        {
            if (this.animalNum < this.animalArr.Length)
            {
                for (int i = 0; i < this.animalArr.Length; i++)
                {
                    if (this.animalArr[i] == null)
                    {
                        this.animalArr[i] = animal;
                    }
                }
            }
        }

        public List<Animal> PredatorOverTen() //הפעולה מחזירה רשימה של כל החיות שהם טורפי על ומעל גיל 10
        {
            List<Animal> list = new List<Animal>();
            for (int i = 0; i < this.animalArr.Length; i++)
            {
                if (this.animalArr[i].GetIsPredator() && this.animalArr[i].GetAge() >= 10)
                {
                    list.Add(this.animalArr[i]);
                }
            }
            return list;
        }

        public int BirdAndReptilePredator()
        {
            int num = 0;
            for (int i = 0; i < this.animalArr.Length; i++)
            {
                if (this.animalArr[i] is Bird && this.animalArr[i].GetIsPredator())
                    num++;
                if (this.animalArr[i] is Reptile && this.animalArr[i].GetIsPredator())
                    num++;
            }
            return num;
        }
    }
}
