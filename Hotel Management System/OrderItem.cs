using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class OrderItem
    {
        public Menu Menu { get; set;}
        public int Quantity { get; set; }

        public OrderItem(Menu menu,int quantity)
        {
            Menu=menu;
            Quantity=quantity;
        }

        public double GetTotalPrice()
        {
            return Menu.price*Quantity;

        }
        public override string ToString()
        {
            return $"{Menu}:{Quantity}=${GetTotalPrice()}";
        }
    }
}
