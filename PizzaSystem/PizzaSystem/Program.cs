namespace PizzaSystem
{
    public class Program
    {
        static void Main(string[] args)//sart of program
        {
            Butik butik = new Butik("Pizza Mamma Mia", "123 Pizza St", "12345678", 98765432);
            Console.WriteLine();
            Console.WriteLine("Welcome to the Pizza System!");
            Console.WriteLine();
            butik.Start();//method call to start the butik
            

        }
    }
}
