using System;

namespace Excersise_Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
                //problem 1 Start
                Console.WriteLine("Please enter a number between 1 and 10:\n");
                int userInput = Convert.ToInt32(Console.ReadLine());

                Methods.oneToTen(userInput);
                //Problem 1 End

                //Problem 2 Start
                Console.WriteLine("Please enter any number:\n");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number:\n");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Methods.maxNum(num1, num2);
                //Problem 2 End

                //Problem 3 Start
                Console.WriteLine("Please enter your current speed in km\\h:\n");
                int num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please the speed limit in km\\h:\n");
                int num4 = Convert.ToInt32(Console.ReadLine());
                Methods.speedCamera(num3, num4);
                //Problem 3 End
        }
    }
}

            