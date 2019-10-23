using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6_fonction
{   
    class Program
    {
        static void Main(string[] args)
        {
            //instanciation et utilisation de la fonction concat
            string a = "hello";
            string b = "bonjour";
            testsFonctions tf = new testsFonctions();
            string c = tf.concat(a, b);
            Console.WriteLine(c);
            //appel fonction multi
            int f = 10;
            int g = 2;
            int h = tf.multi(f, g);
            Console.WriteLine(h);
            //appel fonction sayHello
            tf.sayHello(a);

        }
    }
}
