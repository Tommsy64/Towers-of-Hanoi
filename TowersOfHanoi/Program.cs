using System;

namespace TowersOfHanoi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;
            bool readKey = args.Length > 1;
            if (args.Length < 1)
            {
                Console.Write("Enter the No. of Disks: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                n = Convert.ToInt32(args[0]);
                Console.WriteLine("Number of disks: {0}", n);
            }
            for (int x = 1; x < (1 << n); x++)
            {
                Console.WriteLine("Move from Peg {0} to Peg {1}", (x & x - 1) % 3 + 1, ((x | x - 1) + 1) % 3 + 1);
                if (readKey)
                    Console.ReadKey();
            }
        }
    }
}