using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateTest test = new DelegateTest("test", client);
            test.start();
            Console.ReadKey();
        }

        static void client(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
