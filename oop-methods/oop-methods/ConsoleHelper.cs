using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_methods
{
    public static class ConsoleHelper
    {
        public static void PrintMessage(string message)
        {
            PrintMessage(message, null, 1);
        }

        public static void PrintMessage(string label,string message)
        {
            PrintMessage(message, label, 1);
        }

        public static void PrintMessage(string message, uint count)
        {
            PrintMessage(message, null, count);
            
        }


        public static void PrintMessage(string message, string label, uint count)
        {

            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine($"{label}: ");
            }

            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(message);
            }

        }
    }
}
