using System;
using System.Collections.Generic;

namespace TheZoo
{
    class Program
    {
        static void Main(string[] args)
        {

            string animalName;
            int cage = 1;

            List<IAnimal> list = new List<IAnimal>();
            while (true)
            {
                if (list.Count == 3)
                {
                    Console.WriteLine("\n Our Zoo is full. Come back later. \n");
                    break;
                }
                Console.Write($"\nCage{cage}\n" + $"What is the animal species?");
                animalName = Console.ReadLine().ToLower();
                cage++;


                switch (animalName) {
                    case "lion":
                        Lion lion = new Lion();
                        lion.SetAge();
                        lion.RequestUniqueCharacteristic();
                        list.Add(lion); break;

                    case "wolf":
                        Wolf wolf = new Wolf();
                        wolf.SetAge();
                        wolf.RequestUniqueCharacteristic();
                        list.Add(wolf); break;

                    case "bear":
                        Bear bear = new Bear();
                        bear.SetAge();
                        bear.RequestUniqueCharacteristic();
                        list.Add(bear); break;

                }




            }
        
        
            Console.WriteLine("============================");

            foreach (var animal in list)
            {
                Console.Write("Cage " + (list.IndexOf(animal) + 1) + " ");
                animal.GetDescription();
                
            }
           
        }
    }
}
