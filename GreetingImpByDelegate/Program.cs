using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingImpByDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingManager mgr = new GreetingManager();
            /*
            mgr.greetingDelegate += EnglishGreeting;
            mgr.greetingDelegate += ChineseGreeting;
            */

            mgr.greetingDelegate += (new EnglishGreeting()).GreetingPeople;
            mgr.greetingDelegate += (new ChineseGreeting()).GreetingPeople;
            mgr.MakeGreeting("frank");
            Console.ReadKey();
        }

        /*
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("你好 " + name);
        }
        */

    }
}
