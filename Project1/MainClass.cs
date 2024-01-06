using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class MainClass
    {
        public static void Main(string []  args)
        {
            TestClass01 obj = new TestClass01("Hi");

            string msg = obj.getMessage(string.Empty);

            string msg1 = obj.getMessage("Hello");

            Console.WriteLine(msg);
            Console.WriteLine(msg1);

        }

    }
}
