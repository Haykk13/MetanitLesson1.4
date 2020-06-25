using System;

namespace MetanitLesson1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Make your deposit: ");
            decimal num = decimal.Parse(Console.ReadLine());

            if(num > 0 && num < 100)
            {
                num += num * 5 / 100;
            }
            else if(num >= 100 && num <= 200)
            {
                num += num * 7 / 100;
            }
            else if(num > 200)
            {
                num += num * 10 / 100;
            }
            else
            {
                throw new Exception("Wrong deposit amount!");
            }

            Console.WriteLine($"The amount after adding the percent is {num}");

            Console.ReadLine();
        }
    }
}
