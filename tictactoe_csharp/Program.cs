using System;
using System.IO;
using System.Text;
using System.Threading;

namespace tictactoe_csharp
{

    class Program
    {
        static bool quit = false;

        /// <summary>
        /// The time limit for the puzzle
        /// </summary>
        const int TIME_LIMIT_SECONDS = 60;

        static void Main(string[] args)
        {

            /*
                TODO:
                1. Create game grid (3,3,3) [done]
                2. Insert `X` and `O` in the grid [done]
                3. 


            */


            // Make sure the game quits if the user hits ^C
            // Set Console.TreatControlCAsInput to true if you want to use ^C as a valid input value
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);

            Console.CursorVisible = false;

            /*** Initialize the game here! ***/

            MainLoop();





            //Console.Title = "Tic Tac Toe";
            //Console.Clear();
            //Console.SetWindowSize(65, 33);
            //Console.SetBufferSize(65, 33);

            //var utils = new Utilities();

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(utils.GetX());

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(utils.GetO());


            //Console.ResetColor();
            //Console.ReadKey(); // User must press the `Enter` key



            /*****Experiment*****/

            //Console.Clear();
            //Console.SetCursorPosition(0, 0);
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("o o        . .");
            //Console.WriteLine(" )          ) ");
            //Console.WriteLine("___        ###");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.MoveBufferArea(i + 11, i, 3, 3, i + 12, i + 1,
            //        'x', ConsoleColor.Red, ConsoleColor.White);
            //    Console.MoveBufferArea(i, i, 3, 3, i + 1, i + 1);
            //    Console.Beep((i + 10) * 100, 100);
            //}
            //Console.SetCursorPosition(0, 23);
            //Console.ResetColor();

        }

        /// <summary>
        /// Event handler for ^C key press
        /// </summary>
        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            // Unfortunately, due to a bug in .NET Framework v4.0.30319 you can't debug this 
            // because Visual Studio 2010 gives a "No Source Available" error. 
            // http://connect.microsoft.com/VisualStudio/feedback/details/524889/debugging-c-console-application-that-handles-console-cancelkeypress-is-broken-in-net-4-0
            Console.WriteLine("{0} hit, quitting...", e.SpecialKey);
            quit = true;
            e.Cancel = true; // Set this to true to keep the process from quitting immediately
        }

        /// <summary>
        /// The main gameloop
        /// </summary>
        static void MainLoop()
        {
            var elapsedMilliseconds = 0;
            int totalMilliseconds = TIME_LIMIT_SECONDS * 1000;
            const int INTERVAL = 100;

            while (elapsedMilliseconds < totalMilliseconds && !quit)
            {
                // Sleep for a short period
                Thread.Sleep(INTERVAL);
                elapsedMilliseconds += INTERVAL;

                /*** Update the screen and handle input here! ***/

            }

            Console.WriteLine("Game over!");
        }
    }
}
