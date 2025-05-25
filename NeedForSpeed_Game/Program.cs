using System;
class NeedForSpeed
{
    static void Main()
    {
        Console.WriteLine("Welcome To Need For Speed");

        Console.WriteLine("Enter Car Model ");
        string CarModel = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter Car Color ");
        string CarColor = Console.ReadLine() ?? string.Empty;

        Car MahmoudsCar = new Car()
        {
            Car_model = CarModel,
            Car_Color = CarColor
        };
        Console.WriteLine(" Your Car Is : " + MahmoudsCar.Car_model + " and its Color is : " + MahmoudsCar.Car_Color);

        Console.WriteLine("Game Is Starting ... ");
        string userInput = "s";

        while (userInput != "x")
        {
            Console.Write(" Enter A To Accelerate , C for SlowDown and X to Exit : ");
            userInput = Console.ReadLine() ?? string.Empty;
            if (userInput == "a" || userInput == "A")
            {
                MahmoudsCar.accelerate();
            }
            else if (userInput == "c" || userInput == "C")
            {
                MahmoudsCar.Break();
            }
            else if (userInput == "x" || userInput == "X")
            {
                userInput = "x";
            }
            else
            {
                Console.WriteLine("Enter Valid Character ");
                Console.Write(" Enter A To Accelerate , C for SlowDown and X to Exit : ");
            }
        }

    }
    class Car
    {
        private int speed = 0;
        public string Car_model;
        public string Car_Color;

        public void accelerate()
        {   

            speed = speed + 10;
            Console.WriteLine("Car is Accelerated by 10");
            Console.WriteLine($"Car Speed : {speed}");

        }
        public void Break()
        {
            if (speed != 0)
            {
                speed = speed - 10;
                Console.WriteLine("Car is Slowed Down by 10");
                Console.WriteLine($"Car Speed : {speed}");
            }
            else
            {
                Console.WriteLine("Your Car Already Not Moving ");

            }


        }

    }

}