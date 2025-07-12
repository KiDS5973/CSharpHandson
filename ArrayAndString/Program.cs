using Microsoft.Win32.SafeHandles;

namespace ArrayAndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one dimentional array 
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Number {i + 1} is: {arr[i]}");
            }

            foreach (int number in arr)
            {
                Console.WriteLine($"Number is : {number}");
            }

            // Multi dimentional array

            int[,] muarr = new int[3,3];
            Console.WriteLine("Enter 9 numbers for a 3x3 matrix:");
            for (int i = 0; i < muarr.GetLength(0); i++)
            {
                for (int j = 0; j < muarr.GetLength(1); j++)
                {
                    muarr[i,j] =Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < muarr.GetLength(0); i++)
            {
                for (int j = 0; j < muarr.GetLength(1); j++)
                {
                    Console.Write($"{muarr[i, j]} ");
                }
                Console.WriteLine();
            }

            // Jagged array

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            // Declare the jagged array with the given number of rows
            int[][] jarr = new int[rows][];

            // Input for each row
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter number of elements in row {i + 1}: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                jarr[i] = new int[cols]; // Initialize the row

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    jarr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Output the array
            Console.WriteLine("\nJagged Array Elements:");
            for (int i = 0; i < jarr.Length; i++)
            {
                Console.Write($"Elements[{i}] Array: ");
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
