using ConsoleApplication1.ServiceReference3;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService2SoapClient service = new WebService2SoapClient();
            Console.WriteLine("What file should be read? ");
            string UserInput = Console.ReadLine();
            Console.WriteLine("You have entered: " + UserInput);
            service.GetWebsiteHtml(UserInput);
            Console.WriteLine("File contains: " + service.GetWebsiteHtml(UserInput));
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.WriteLine("Here is objects in database:");
            foreach (string s in service.objects2())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.ReadKey();


        }

       
    }
}


