using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P5_ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            //// Use the Action<> delegate to point to DisplayMessage.
            //Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);

            //actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            //Action<string, string> UIdelegate = new Action<string, string>(UpdateUI);
            //UIdelegate.Invoke("this is a heading" , " show this message to UI ");


            Func<int, int , int> sumDel = new Func<int, int , int>(Add);

            int sum = sumDel.Invoke(2, 2);
            Console.WriteLine(" sum = {0} " , sum);
            Console.ReadLine();
        }

        // This is a target for the Action<> delegate.
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            // Restore color.
            Console.ForegroundColor = previous;
        }
        private static void UpdateUI(string Heading , string message)
        {
            Console.WriteLine(" ===== {0} ===== " , Heading);
            Console.WriteLine(message);
        }

        // Target for the Func<> delegate.
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
