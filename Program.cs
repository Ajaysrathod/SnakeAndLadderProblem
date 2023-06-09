﻿namespace SnakeAndLadderProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            //Taking user input
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Position of Player\n2:Die rolled\n3:Check For Position\n4:Player win condition\n5:Exact win position of player\n6:Count of winning position");
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
                case 3:
                    SnakeAndLadder.CheckForPosition();
                    break;
                case 4:
                    SnakeAndLadder.PlayerWinCondition();
                    break;
                case 5:
                    SnakeAndLadder.PlayerWinCondition();
                    break;
                case 6:
                    SnakeAndLadder.PlayerWinCondition();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }

    }
}
