using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmymethoddemo
{
    class Program
    {
        public void func1()
        {
            Console.WriteLine("This is First function..");
        }
        public void func2()
        {
            Console.WriteLine("This is Second function..");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.func1();
            p.func2();
            Console.ReadLine();
        }
    }
}
