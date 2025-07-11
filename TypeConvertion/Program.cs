namespace TypeConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 105;
            double myDouble = myInt; // Implicit conversion from int to double
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble); // Output: 105.0

            double myDouble2 = 105.5;
            int i =(int)myDouble2; // Explicit conversion from double to int
            Console.WriteLine(i);

            string str = "123";
            int num = Convert.ToInt32(str); // Convert string to int
            Console.WriteLine(num); // Output: 123

            string str2 = "567";
            int num2 = int.Parse(str2); // Parse string to int
            Console.WriteLine(num2); // Output: 567
        }
    }
}
