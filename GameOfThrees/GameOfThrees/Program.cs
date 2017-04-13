/*
    First, you mash in a random large number to start with. Then, repeatedly do the following:

    If the number is divisible by 3, divide it by 3.
    If it's not, either add 1 or subtract 1 (to make it divisible by 3), then divide it by 3.

    The game stops when you reach "1". 

    The input is a single number: the number at which the game starts.

    100

    Output Description

    The output is a list of valid steps that must be taken to play the game. Each step is represented by the number you start at, followed by either -1 or 1 (if you are adding/subtracting 1 before dividing), or 0 (if you are just dividing). The last line should simply be 1.

    100 -1
    33 0
    11 1
    4 -1
    1

    Challenge Input
    31337357

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to start: ");
            double initNum;
            while (!Double.TryParse(Console.ReadLine(), out initNum))
            {
                Console.WriteLine("Please enter a number!");
                Console.Write("Enter a number to start: ");
            }

            double number = initNum;

            while (initNum > 1)
            {
                //If divisible by 3 then just divide
                if (number % 3 == 0)
                {
                    number = number / 3;
                    Console.WriteLine(initNum + " / 3 = " + number);
                }
                   
                //else figure out if it needs to be add/subtract by 1
                //done by getting remainder
                else
                {
                    //Remainder has to 1 or 2
                    //If 1, subtract to make divisible by 3
                    //Otherwise its 2, so you need to add 1
                    int remain = (int) (number % 3);
                    string math;

                    if (remain == 1)
                    {
                        math = "- 1";
                        number -= 1;
                    }
                    else
                    {
                        math = "+ 1";
                        number += 1;
                    }

                    Console.WriteLine(initNum + " " + math + " = " + number);
                }

                //Set initNum to the new number
                initNum = number;
            }

            //Print last number
            Console.WriteLine(initNum);

            Console.ReadKey();
        }
    }
}
