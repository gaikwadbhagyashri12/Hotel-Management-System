using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class Program
    {

        static void Main(string[] args)
        { 
            Restaurant restaurant = new Restaurant();
            int option;
            do
            {


                Console.WriteLine("*******************************************************************************************");
                Console.WriteLine("* * * Welcome To Sahyadri Restaurant * * *");
                Console.WriteLine("      1.Display Menu...");
                Console.WriteLine("      2.Place Order...");
                Console.WriteLine("      3.View Order...");
                Console.WriteLine("      4.Bill...");
                Console.WriteLine("      5.Exit");
                Console.WriteLine("********************************************************************************************");
                Console.WriteLine("Enter your choice");

                if(!int.TryParse(Console.ReadLine(),out option))
                {
                    Console.WriteLine("Invalid input.Please enter a valid number");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        restaurant.DisplayMenu();
                        Console.WriteLine("**************************************************************************************");
                        break;

                    case 2:
                        restaurant.PlaceOrder();
                        Console.WriteLine("***************************************************************************************");
                        break;

                    case 3:
                        restaurant.ViewOrder();
                        Console.WriteLine("****************************************************************************************");
                        break;

                    case 4:

                        restaurant.CheckOut();
                        Console.WriteLine("****************************************************************************************");
                        break;

                    case 5:
                        Console.WriteLine("Exit");

                        Console.WriteLine("*******************************************************************************************");
                        break;

                    default:
                        Console.WriteLine("*********************************************************************************************");
                        
                        Console.WriteLine("Please Enter the valid Option");
                        break;
                }
            } while (option!=5);

        }
    }
}



