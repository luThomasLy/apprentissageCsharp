using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entrez un nombre : ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    "100/nombre = {0}",
                    100 / n);
            }
            catch (DivideByZeroException dbzEx)
            {
                Console.WriteLine("Erreur : division par zéro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Une autre exception a eu lieu : {0}.",
                    ex.Message);
            }
            finally
            {
                Console.WriteLine("Quel que soit le résultat, ceci est affiché.");
            }
        }
    }
}
