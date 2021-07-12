using System;
using System.Collections.Generic;
using System.Text;

namespace TheZoo
{
    class Wolf : Animal, IAnimal
    {
         string _speed;

        public void GetDescription()
        {
            Console.WriteLine($"contains a {Age}-years-old {Species} that runs {_speed}  km/h.");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)?");
            _speed = Console.ReadLine();
        }
    }
}
