using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16_IAnimal
{
    class Dog : IAnimal
    {
        private string m_name;

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public Dog(string name)
        {
            m_name = name;
        }

        public void Move()
        {
            Console.WriteLine("{0} bouge et cours vers la balle.", m_name);
        }
    }
}
