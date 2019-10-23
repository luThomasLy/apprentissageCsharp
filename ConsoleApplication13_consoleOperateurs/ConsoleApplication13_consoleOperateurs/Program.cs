using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13_consoleOperateurs
{
    class Program
    {
        public static bool Test1()
        {
            Console.WriteLine("Test1");
            return false;
        }

        public static bool Test2()
        {
            Console.WriteLine("Test2");
            return true;
        }

        public static bool Test3()
        {
            Console.WriteLine("Test3");
            return true;
        }

        public static bool Test4()
        {
            Console.WriteLine("Test4");
            return false;
        }

        static void Main(string[] args)
        {
            //envoi d'argument, ne fonctionne pas, à revoir
            /*string arg1 = (args.Length <= 0) ? string.Empty : args[0];
            string arg2 = (args.Length <= 1) ? string.Empty : args[1];
            Console.WriteLine("argument 1 : {0}", arg1);
            Console.WriteLine("argument 2 : {0}", arg2);*/

            //fonctionne mais envoi la réponse rapidement
            /*string input = Console.ReadLine();
            Console.WriteLine("Vous avez écrit : \"{0}\"", input);*/

            if (Test1() & Test2())
            {
                Console.WriteLine("Opérateur utilisé : &&");
            }

            if (Test3() | Test4())
            {
                Console.WriteLine("Opérateur utilisé : ||");
            }


        }
    }
}
