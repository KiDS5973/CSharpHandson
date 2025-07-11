namespace ControleStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Arif Mahmud";

            if (Name == "Arif Mahmud")
            {
                Console.WriteLine("Hello Arif Mahmud");
            }
            else
            {
                Console.WriteLine("Hello Unknown User");
            }


            Console.Write("Enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            // Using if-else-if ladder
            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");

            int j = 10;

            if (j == 10)
            {

                // nested - if statement
                // will only be executed if statement
                // above it is true
                if (j < 12)
                    Console.WriteLine("j is smaller than 12 too");
                else
                    Console.WriteLine("j is greater than 12");
            }

            // Ask for user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask for a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Print welcome message
            Console.WriteLine($"\nHello {name}, you entered {number}.");

            // Using Switch case 
            switch (number)
            {
                case 10:
                    Console.WriteLine("This is case 10");
                    break;
                case 20:
                    Console.WriteLine("This is case 20");
                    break;
                case 30:
                    Console.WriteLine("This is case 30");
                    break;
                default:
                    Console.WriteLine("None of the cases match your number.");
                    break;
            }
        }
    }
}
