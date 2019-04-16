using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    /*
     * 委托与事件
     * 
     * 
     */
    //public delegate void DoSth(string msg);
    class Program
    {
        delegate void DoSth(string msg);
        static void Main(string[] args)
        {
            DoSth doSth = new DoSth(SayHello);
            doSth("Hello, Jimmy");
        }

        static void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
