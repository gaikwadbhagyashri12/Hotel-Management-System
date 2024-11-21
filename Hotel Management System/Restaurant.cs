﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Restaurant
    {
        private List<Menu> menu = new List<Menu>();
        private List<OrderItem> orderItems = new List<OrderItem>();

       
        
       
        public void ListOfItems()

       
    
     
    
        {
            Console.WriteLine("************************************************************************************");
            menu.Add(new Menu(1, "Akkha Masur",150));
            menu.Add(new Menu(2, "Chicken",250));
            menu.Add(new Menu(3, "Kaleja fry",120));
            menu.Add(new Menu(4, "roti",20));
            menu.Add(new Menu(5, "Mutton",350));
            menu.Add(new Menu(6, "Jeera Rice",70));
            menu.Add(new Menu(7, "Paneer Masala",200));
            menu.Add(new Menu(8, "Kaju kari",250));
            menu.Add(new Menu(9, "Bhakari",20));
            menu.Add(new Menu(10, "Masala Papad",40));

        }
        public void DisplayMenu()
        {
            try
            {
                ListOfItems();
                foreach(var item in menu)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+"Error Occuring the display Menu");
            }
        }

        public void PlaceOrder()
        {
            try
            {
                Console.WriteLine("Enter the Item no. you want to order");
                if(int.TryParse(Console.ReadLine(),out int itemId))
                {
                    Menu selectItem = menu.Find(m => m.id==itemId);
                    if(selectItem!=null)
                    {
                        Console.WriteLine("Enter the Quantity");
                        if(int.TryParse(Console.ReadLine(),out int quantity))
                        {
                            orderItems.Add(new OrderItem(selectItem, quantity));
                            Console.WriteLine($"{ selectItem.name} is added to your order");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString()+"Error Occurng to add order");
            }
        }

        public void ViewOrder()
        {
            try
            {
                if(orderItems.Count >0)
                {
                    Console.WriteLine("Your Order.........");
                    foreach(var item in orderItems)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Order Not yet placed.........");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occuring for view the order..."+ex.Message);
            }
        }
        public void CheckOut()
        {
            try
            {
                if(orderItems.Count>0)
                {
                    double total = 0;
                    Console.WriteLine("Your order Details...");
                    foreach (var item in orderItems) 
                    {
                        Console.WriteLine(item);
                        total=total+item.GetTotalPrice();
                    }
                    Console.WriteLine($"Total Amount:"+total);
                    Console.WriteLine("Thank you for your order,Please Proceed........");
                    menu.Clear();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error Occuring during"+ex.Message);

            }
        }
    }
}
