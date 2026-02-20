namespace opgave
{ 
public class Program
{
    public static void Main()
    {
        Costumers costumer1 = new Costumers("John Doe", "123 Main St", "555-1234");
           
            Burger burger1 = new Burger(123, "Cheeseburger", 5.99, "store");
             
            Order order1 = new Order (1, burger1, costumer1, DateTime.Now);

            Console.WriteLine( order1.ToString() );


        }
}
}
//OrderID: 1
// BURGER: 
//BurgerID: 123
// Name: Cheeseburger
// Price: 5,99
// Description: store
// COSTUMER:                                                                                                               Name: John Doe
// Address: 123 Main St
// Phone Number: 555 - 1234