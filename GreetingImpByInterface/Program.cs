using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingManager mgr = new GreetingManager();
            mgr.MakeGreeting("Frank", new EnglishGreeting());
            mgr.MakeGreeting("Frank", new ChineseGreeting());
            Console.ReadKey();
        }
    }
}
