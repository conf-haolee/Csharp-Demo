using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace BasicElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);

            long y = 10000000000L;
            Console.WriteLine(y);

            float z = 3.14F;
            Console.WriteLine(z);

            char c = 'A';
            Console.WriteLine(c);

            String str = "Hello, World!";
            Console.WriteLine(str);

            bool isTrue = true;
            Console.WriteLine(isTrue);

            // var is a type auto acquired variable
            var w = 3;
            Console.WriteLine(w.GetType().Name);

            //Form f = new Form();
            ////Form f = null;
            //f.ShowDialog();

            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "Now I'm a string!"; 
            Console.WriteLine(myVar); 

        }
    }
}
