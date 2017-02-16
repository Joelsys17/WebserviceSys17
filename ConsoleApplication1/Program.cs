using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 obj = new localhost.WebService1();
            Console.WriteLine("What file should be read? ");
            string UserInput = Console.ReadLine();
            Console.WriteLine("You have entered: " + UserInput);            
            obj.txtFile(UserInput);
            Console.WriteLine("File contains:" + UserInput);
        }


    }
}


