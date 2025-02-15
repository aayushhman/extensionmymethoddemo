using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmymethoddemo
{
     static class MyStaticClass
    {
        public static void func3(this Program t)
        {
            Console.WriteLine("This is Third function..");

        }
    }
}
