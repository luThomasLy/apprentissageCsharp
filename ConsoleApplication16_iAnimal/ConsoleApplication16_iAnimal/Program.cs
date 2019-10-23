using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16_IAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal milmil = new Dog("milmil");
            milmil.Move();
        }
    }
}
