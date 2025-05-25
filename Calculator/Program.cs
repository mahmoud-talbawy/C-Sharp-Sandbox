using System;
class Clculator
{
    static void Main()
    {
        bool lastinput = true;
        while (lastinput)
        {
            Console.WriteLine(" Welcome To Our Small Caluclator ");
            Console.Write(" Enter Your First Number : ");
            int firstNumber = 0;
            firstNumber = whileFunction(firstNumber);
            Console.Write(" Enter Your  Sign Like { + , - , * } : ");
            string sign = Console.ReadLine() ?? string.Empty;

            Console.Write(" Enter Your Second Number : ");
            int secondNumber = 0;
            secondNumber = whileFunction(secondNumber);


            switch (sign)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Undefined Operation");
                    }
                    else
                    {
                        Console.WriteLine(firstNumber / secondNumber);
                    }
                    break;
                default:
                    Console.WriteLine("You Entered a Wrong Sign ");

                    break;
            }
            Console.Write("Do You Want To Calculate Another One (yes , No) : ");
            string run = Console.ReadLine() ?? string.Empty;
            if (run == "no" || run == "n" || run == "NO" || run == "false" || run == "N")
            {
                Console.WriteLine("Hopping a nice Time for you ❤️ ");
                Console.WriteLine("Waiting For Your Comeback");
                lastinput = false;
            }
        }



        int whileFunction(int number)
        {
            while (!int.TryParse(Console.ReadLine() ?? string.Empty, out number))
            {
                Console.Write("Enter Correct Number : ");
            }
            return number;

        }

    }
}
