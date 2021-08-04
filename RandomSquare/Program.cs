using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumList = new List<int>();
            for (var i = 0; i <= 20; i++)
            {
                randomNumList.Add(random.Next(1, 50));
            }

            Console.WriteLine("Here is the original randomNumList");
            foreach (var num in randomNumList)
            {
                Console.WriteLine(num);
            }

            var squareNumList = randomNumList.Select(num => num * num);
            Console.WriteLine("squareNumList has the following numbers");
            foreach (var num in squareNumList)
            {
                Console.WriteLine(num);
            }

            var removeOddNumber = squareNumList.Where(x => x % 2 != 0);
            Console.WriteLine("The following shows what's left after removing odd numbers from the squreNumList");
            foreach (var num in removeOddNumber)
            {
                Console.WriteLine(num);
            }


        }
    }
}
