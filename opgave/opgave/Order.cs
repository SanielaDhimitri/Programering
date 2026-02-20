using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    public class Order
    {
        public int OrderID { get; set; }
        public Burger Burger { get; set; }
        public Costumers Costumers { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderID, Burger burger, Costumers costumers, DateTime orderDate)
        {
            OrderID = orderID;
            Burger = burger;
            Costumers = costumers;
            OrderDate = DateTime.Now;
        }
        public override string ToString()
        {
            return $"OrderID: {OrderID}\n" +
                   $" BURGER:{"".PadRight(113)}BurgerID: {Burger.BurgerID}\n" +//PadRight() shton hapësira (spaces) në fund të një teksti, derisa ai të arrijë një gjatësi të caktuar.
                   $" Name: {Burger.Name}\n" +
                   $" Price: {Burger.Price}\n" +
                   $" Description: {Burger.Description}\n" +
                   $" COSTUMER:{"".PadRight(111)}Name: {Costumers.Name}\n" +
                   $" Address: {Costumers.Address}\n" +
                   $" Phone Number: {Costumers.PhoneNumber}";
        }
    }

    }
//OrderID: 1
// BURGER:
// BurgerID: 123
// Name: Cheeseburger
// Price: 5,99
// Description: store
// COSTUMER:                                                                                                               Name: John Doe
// Address: 123 Main St
// Phone Number: 555 - 1234

