using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16_IAnimal
{
    interface IAnimal
    {
        string Name { get; }
        void Move();
    }
}
