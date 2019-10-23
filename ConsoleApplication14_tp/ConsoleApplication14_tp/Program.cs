using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14_tp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 100;
            bool over = false;

            Random rand = new Random();
            int nbtire = rand.Next(maxValue);
            Console.WriteLine(nbtire);
            
            while (!over)
            {
                Console.WriteLine("entrer un chiffre entre 0 et 100");
                int nbjoueur = (int.Parse(Console.ReadLine()));

                if (nbjoueur < nbtire)
                {
                    Console.WriteLine("plus plus");
                }
                else if (nbjoueur > nbtire)
                {
                    Console.WriteLine("moins moins");
                }
                else if (nbjoueur == nbtire)
                {
                    Console.WriteLine("vous avez trouvé, le nb mystère est {0}", nbtire);
                    over = true;
                }
            }
        }
    }
}
