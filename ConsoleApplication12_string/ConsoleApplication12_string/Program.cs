using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //opérateur +, pour concat de string
            string firstSt = "mochi mochi";
            string secSt = "allo allo";

            string fullSt = firstSt + " " + secSt;
            Console.WriteLine(fullSt);

            //méthode concat de classe string
            string phrase = string.Concat("mochi", "allo");
            Console.WriteLine(phrase);

            //méthode format de la classe string
            string s = String.Format("{{0}} est remplacé par {0} et {{1}} par {1}", 
                "para2 L", 
                "para3 T");
            Console.WriteLine(s);

            //classe StringBuilder
            string name = "Mitch";
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append(name);
            sb.Append(",how are you ?");
            string salutPhrase = sb.ToString();
            Console.WriteLine(salutPhrase);

            //en mode concat
            string nom = "Tim";
            string superPhrase = "Hello," + nom + ", how are you ?";
            Console.WriteLine(superPhrase);

            //for avec StringBuilder
            for(int i = 0; i < 10; i++)
            {
                sb.AppendLine(nom);
            }
            string fullS = sb.ToString();
            Console.WriteLine(fullS);
        }
    }
}
