using System;
using System.Collections.Generic;
using System.Text;

namespace TheZoo
{
    class Lion : Animal, IAnimal
    {
        private string _color;



        public void GetDescription()
        {

            Console.WriteLine($" contains a { Age }-years-old { Species.ToLower()} with a {_color } mane.");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What color is its mane?");
            _color = Console.ReadLine();
        }
    }
}
