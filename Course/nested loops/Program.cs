using System;

namespace nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rows?: "); 
            int rows= Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol?: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i+=1)
            {
                for (int j = 0; j < columns; j += 1)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
