using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookstoreTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bullsBookstore myOrder = new bullsBookstore("Maui", "Ocala", 12);
            Console.WriteLine("Hello {0}! Place your Bulls Bookstore order for the {1} campus.", myOrder.Name, myOrder.Campus);
            myOrder.CreateReceipt();
        }
    }
}
