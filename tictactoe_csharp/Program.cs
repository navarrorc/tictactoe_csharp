using System;

namespace tictactoe_csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            /*
                TODO:
                1. Create game grid (3,3,3) [done]
                2. Insert `X` and `O` in the grid [done]
                3. 


            */

            Console.WriteLine(@"
                |   |
             {0}|{1}|{2}
             ---|---|---
             {3}|{4}|{5}
             ---|---|---
             {6}|{7}|{8}
                |   |
            ", " X ", "   ", "   ", " O ", "   ", "   ", "   ", "   ", "   ");

            Console.ReadKey(); // User must press the `Enter` key


        }
    }
}
