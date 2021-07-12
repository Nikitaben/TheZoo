using System;
using System.Collections.Generic;
using System.Text;

namespace TheZoo
{
    class Bear : Animal, IAnimal
    {
        private bool _isGrizzly;

        public void GetDescription()
        {
            string non = _isGrizzly ? "" : "non";
            Console.WriteLine($"contains a {Age}-year-old {Species.ToLower()} {non} grizzly bear.");
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it  grizlly bear (true/false)? ");
 
            _isGrizzly = bool.Parse(Console.ReadLine());
        }
    }
}
