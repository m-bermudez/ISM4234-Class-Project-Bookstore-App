using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    internal class bullsBookstore
    {
        private string name;
        private string campus;
        private double deliveryfee;

        public string Name { get; set; } 
        public string Campus { get; set; }
        public double DeliveryFee
        {
            get
            {
                return deliveryfee;
            }
            set
            {
                if (value >= 0)
                {
                    deliveryfee = value;
                }
                else
                {
                    deliveryfee = 0;
                }
            }
        }
        public bullsBookstore (string name, string campus, double deliveryfee)
        {
            Name = name;
            Campus = campus;
            DeliveryFee = deliveryfee;
        }

        public void CreateReceipt()
        {
            double subtotal = 0;
            string price_str = "0";
            double price_num = 0;
            double taxRate = 0;
            double taxAmount = 0;
            double grandTotal = 0;

            while (price_str != "Done")
            {
                try
                {
                    price_num = Convert.ToDouble(price_str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Value entered was not a number, please try again");
                    price_num = 0;
                }
                subtotal = subtotal + price_num;
                Console.WriteLine("Enter price of textbooks or other bookstore item (Enter \"Done\" to quit)");
                price_str = Console.ReadLine();
            }
            switch (Campus)
            {
                case "Tampa":
                    Console.WriteLine("\nTampa tax rate is 8%");
                    taxRate = .08;
                    break;
                case "Sarasota":
                    Console.WriteLine("\nSarasota tax rate is 6%");
                    taxRate = .06;
                    break;
                case "St. Petersburg":
                    Console.WriteLine("\nSt. Petersburg tax rate is 7%");
                    taxRate = .07;
                    break;
                default:
                    Console.WriteLine("\nUnknown campus, default tax rate applied at 10%");
                    taxRate = .10;
                    break;
            }

            taxAmount = subtotal * taxRate;

            if (subtotal >= 300)
            {
                subtotal = subtotal - 20;
            }
            else if (subtotal >= 200)
            {
                subtotal = subtotal - 10;
            }
            else if (subtotal >= 100)
            {
                subtotal = subtotal - 5;
            }

            grandTotal = subtotal + taxAmount + deliveryfee;

            Console.WriteLine("Subtotal: {0:C}" +
                  "\nDelivery fee: {1:C}" +
                  "\n{2:P} tax: {3:C}" +
                  "\nGrand total: {4:C}",
                  subtotal, DeliveryFee, taxRate, taxAmount, grandTotal);
        }
    }
}
