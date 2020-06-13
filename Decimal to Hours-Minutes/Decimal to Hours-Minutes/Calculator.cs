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
        static double userNumber;

        //Program Logic
        public void ProgramLogic()
        {
            do
            {
                try
                {
                    userNumber = UserInput();
                    DoMath();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                                

                Console.WriteLine("Press any key to continue or Esc to exit program.");
                Console.ReadKey();
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                //exit the program
                {
                    System.Environment.Exit(0);
                }

                //Writes a new line as to not have the user's input run into the Insert Decimal text
                Console.WriteLine("");

            } while (true);
        }


        //MATH
        private void DoMath()
        {
            //Takes the decimal and converts to hours and minutes
            var tsResult = TimeSpan.FromHours(userNumber);
            //Displayed the hours and minutes; Total hours is used to show only hour and not days.
            Console.WriteLine("{0:D2} hour {1:D2} minutes", (int)tsResult.TotalHours, tsResult.Minutes); 
            Console.WriteLine("or \n{0:D2}:{1:D2}", (int)tsResult.TotalHours, tsResult.Minutes);
        }

        //Inquire the user to enter in a #'s
        public static double UserInput()
        {
            Console.WriteLine("Insert Decimal.");
            String userinput = Console.ReadLine();
            try
            {
                return Convert.ToDouble(userinput);
            }
            catch
            {
                //Catches bugs or issues. 
                //In this case it would detect non number data.
                throw new Exception("Please input numbers only.");
            }
        }
    }
}
