using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise_Mosh
{
    public class Methods
    {
        public static void oneToTen(int userInput)
        {
            bool userChoice = false;
            //Problem 1 Start
            while (userChoice == false)
            {

                if (userInput >= 1 && userInput <= 10)
                {
                    Console.WriteLine($"Your number is {userInput}");
                    userChoice = true;
                }

                else if (userInput <= 0 || userInput >= 11)
                {
                    Console.WriteLine("Please select a number between 1 and 10");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                //Problem 1 End
            }
        }

        //Problem 2 Start
            public static void maxNum(int num1, int num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine($"{num1} is the maximum of the inputs");
            }
            else if( num1 < num2)
            {
                Console.WriteLine($"{num2} is the max of the numbers");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both inputs are equal");
            }
            else
            {
                Console.WriteLine("No numbers found");
            }
        }
        //Problem 2 End


        //Problem 3 Start

        public static void speedCamera(int speed, int limit)
        {
            int license = 0;
            
            if (speed <= limit)
            {
                Console.WriteLine("Have a nice day :)");
            }

            else if (speed > limit && speed <= limit + 4)
            {
                license = license + 2;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit\nThat's {license} points on your license");
            }
            else if (speed >= (limit+5) && speed <= (limit + 9))
            {
                license = license + 4;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit\nThat's {license} points on your license");
            }
            else if (speed >= (limit + 10) && speed <= (limit + 14))
            {
                license = license + 6;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit\nThat's {license} points on your license");
            }
            else if (speed >= (limit + 15) && speed <= (limit + 19))
            {
                license = license + 8;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit\nThat's {license} points on your license");
            }
            else if (speed >= (limit + 20) && speed <= (limit + 24))
            {
                license = license + 10;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit\nThat's {license} points on your license");
            }
            else if (speed >= (limit + 25))
            {
                license = license + 12;
                Console.WriteLine($"You are speeding at {speed - limit}km\\h over the limit" +
                    $"\nThat's {license} points on your license" +
                    $"\nWhich is an automatic ban\n" +
                    $"Your license has been suspended");
            }
            //Problem 3 End

        }

    }
}

       
