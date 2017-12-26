using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tictactoe_csharp
{
    class Utilities
    {
        int counter = 0;
        string line = "";
        StringBuilder output;
        string startupPath = Environment.CurrentDirectory;
        StreamReader file;

        public string GetX()
        {
            counter = 0;
            line = "";
            output = new StringBuilder();
            file = new StreamReader($"{startupPath}\\x.txt");

            while ((line = file.ReadLine()) != null)
            {
                output.AppendLine(line);
                counter++;
            }
            return output.ToString();
        }

        public string GetO()
        {
            counter = 0;
            line = "";
            output = new StringBuilder();
            file = new StreamReader($"{startupPath}\\o.txt");

            while ((line = file.ReadLine()) != null)
            {
                output.AppendLine(line);
                counter++;
            }
            return output.ToString();
        }
    }
}
