using System;
using System.Collections.Generic;
using System.Text;

namespace TheZoo
{
    public interface IAnimal
    {
        int Age { get; set; }
        string Species { get; }
        void RequestUniqueCharacteristic();

        void GetDescription();
    }
}
