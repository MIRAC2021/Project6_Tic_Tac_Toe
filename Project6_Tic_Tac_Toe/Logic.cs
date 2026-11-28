using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Project6_Tic_Tac_Toe
{
    public static class Logic
    {
        public static void GeneratorGrid(int gridSize) //is there a way to ask/change data type for generating different grids
        {
            char[,] Grid = new char [gridSize, gridSize];
        }

        public static void DisplayGrid(int gridSize, char[,] grid)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write(grid[i, j] + " ");
                    if ( j == gridSize - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine("----------");
            }
        }

        public static void GetPlacementInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Up arrow pressed");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down arrow pressed");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Left arrow pressed");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Right arrow pressed");
                    break;
                case ConsoleKey.Escape:
                    return;
            }

        }

        public static bool IsLine(int gridSize, char[,] grid)
        {
            int counter = 0;
            
            // Middle
            int middle = gridSize / 2;
            for (int i = 0; i < gridSize - 1; i++)
            {
                if (grid[middle, i] == grid[middle, i + 1])
                {
                    counter++;
                }
                if (grid[i, middle] == grid[i + 1, middle])
                {
                    counter++;
                }

            }
            if (counter == 2 * (gridSize - 1))
            {
                Console.WriteLine("You won on the middle lines!");
                return true;
            }
            //else
            //{
            //    Console.WriteLine("You lost on the middle line.");
            //    return false;
            //}
           
            // Horizontal
            int horizontal_win_count = 0;
            for (int i = 0; i < gridSize - 1; i++)
            {
                counter = 0;
                for (int j = 0; j < gridSize - 1; j++)
                {
                    if (grid[i, j] == grid[i, j + 1])
                    {
                        counter++;
                    }
                }
                if (counter == (gridSize - 1))
                {
                    horizontal_win_count++;
                }
            }

            if (horizontal_win_count > 0)
            {
                Console.WriteLine("You won on horizontal line !");
                return true;
            }
            //else
            //{
            //    Console.WriteLine("You lost on horizontal line.");
            //    balance -= bet;
            //}
           
            // Vertical
            int vertical_win_count = 0;
            for (int j = 0; j < gridSize - 1; j++)
            {
                counter = 0;
                for (int i = 0; i < gridSize - 1; i++)
                {
                    if (grid[i, j] == grid[i + 1, j])
                    {
                        counter++;
                    }
                }
                if (counter == (gridSize - 1))
                {
                    vertical_win_count++;
                }

            }
            if (vertical_win_count > 0)
            {
                Console.WriteLine("You won on vertical line!");
                return true;
            }
            //else
            //{
            //    Console.WriteLine("You lost on vertical line.");
            //    balance -= bet;
            //}
           
            // Diagonal 1
            for (int i = 0; i < (gridSize - 1); i++)
            {
                if (grid[i, i] == grid[i + 1, i + 1])
                {
                    counter++;
                }
            }
            if (counter == (gridSize - 1))
            {
                Console.WriteLine("You won on diagonal 1!");
                return true;
            }
            //else
            //{
            //    Console.WriteLine("You lost on diagonal 1.");
            //    balance -= bet;
            //}

            //Diagonal 2
            counter = 0;
            for (int i = 0; i < (gridSize - 1); i++)
            {
                for (int j = (gridSize - 1); j > 0; j--)
                {
                    if (grid[i, j] == grid[i + 1, j - 1])
                    {
                        counter++;
                    }
                }
            }

            if (counter == (gridSize + 1))
            {
                Console.WriteLine("You won on diagonal 2!");
                return true;
            }
            else
            {
                Console.WriteLine("You lost on diagonal 2.");
                return false;
            }

        }

        public static void PlayTicTacToe()
        {
            throw new NotImplementedException();
        }

    }


}
