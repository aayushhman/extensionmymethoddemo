using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmymethoddemo
{
    class TestExentisionMethod
    {
        static void Main()
        {
            Program t = new Program();
            //t.func1();
            //t.func2();
            //t.func3();
            int i = 20;
            bool result = i.isGreaterThan(10);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
