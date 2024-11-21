using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Menu
    {
     public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public Menu(int id,string name,int price)
        {
            this.id=id;
            this.name=name;
            this.price=price;
        }
        public override string ToString()
        {
            return $"ID:{id},Name:{name}:Price:${price}";
        }



    }
}
