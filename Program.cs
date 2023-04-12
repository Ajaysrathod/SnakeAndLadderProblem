﻿namespace SnakeAndLadderProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            //Taking user input
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Position of Player\n2:Die rolled");
            int option = Convert.ToInt32(Console.ReadLine());
            //Switch case to call different methods
            switch (option)
            {
                case 1:
                    SnakeAndLadder.Position();
                    break;
                case 2:
                    SnakeAndLadder.DieRolled();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }

    }
}
