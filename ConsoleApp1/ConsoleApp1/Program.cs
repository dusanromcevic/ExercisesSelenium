using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{


    class Program
    {

       
        static void Main(string[] args)
        {

            var customer = new Customer(1, "Ja");

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
