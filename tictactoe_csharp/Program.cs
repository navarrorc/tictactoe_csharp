using System;

namespace tictactoe_csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"
                |   |
                |   |{1}
             ---|---|---
                |{0}|
             ---|---|---
                |   |
                |   |
            ", " X ", " O ");

            Console.ReadKey(); // User must press the `Enter` key

            Console.WriteLine(@"
                |   |
                |   |{1}
             ---|---|---
                |{0}|
             ---|---|---
                |   |
                |   |
            ", " O ", " X ");
        }
    }
}
