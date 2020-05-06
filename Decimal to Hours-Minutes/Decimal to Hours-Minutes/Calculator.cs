using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Hours_Minutes
{
    class Calculator
    {
        //vars
        static double userNumber, answer;
        static int userRepeat;

        //Program Logic
        public void ProgramLogic()
        {

            do
            {
                userNumber = UserInput();
                DoMath();

                Console.WriteLine("Press any key to continue to enter another decimal and Esc to exit program.");
                Console.ReadKey();
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                //exit the program
                {

                    System.Environment.Exit(0);

                }

            } while (true);

        }


        //MATH
        private void DoMath()
        {

            var tsResult = TimeSpan.FromHours(userNumber); //Takes the decimal and converts to hours and minutes
            Console.WriteLine("{0:D2} hour {1:D2} minutes", (int)tsResult.TotalHours, tsResult.Minutes); //Displayed the hours and minutes; Total hours is used to show only hour and not days.
            Console.WriteLine("or \n{0:D2}:{1:D2}", (int)tsResult.TotalHours, tsResult.Minutes);

        }

        //Inquire the user to enter in a #'s
        public static double UserInput()
        {

            Console.WriteLine("Insert Decimal.");
            String value = Console.ReadLine();
            double.TryParse(value, out double result);
            return result;

        }

    }
}
