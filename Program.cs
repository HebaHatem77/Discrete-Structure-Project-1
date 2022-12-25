using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     The prime numbers from the first number to the last number");
            Console.WriteLine("______________________________________________________________________");
            int f, l;
            Console.WriteLine("Enter the first number:"); //The lower limit number.
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last number:"); //The upper limit number.
            l = int.Parse(Console.ReadLine());

            for (int x = f; x <= l; x++)  //The outer loop to check all numbers.
            {
                int z = 0;
                for (int d = 2; d < x; d++)  // The inner loop to check number by number.
                {
                    if (x % d == 0)   //* if it true, it is not prime number.*//
                    z++;                 //*As the prime number is only divisible by 1 and itself. *//


                }
                if (z == 0 && x > 1)  //if it true,it is a prime number.
                    Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
