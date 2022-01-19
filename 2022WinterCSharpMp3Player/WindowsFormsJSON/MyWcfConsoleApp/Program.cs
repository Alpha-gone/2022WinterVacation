using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWcfConsoleApp.MyServiceReference;

namespace MyWcfConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1Client service = new Service1Client();

            Console.WriteLine(service.GetData(10));
            Console.ReadLine();
            
        }
    }
}
