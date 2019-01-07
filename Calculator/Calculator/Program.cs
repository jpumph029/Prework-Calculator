using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int opperationSwitch = 0;
            double result = 0;

            Console.WriteLine("Type your first number: ");
            string strFirstNum = Console.ReadLine();
            double firstNum = Convert.ToDouble(strFirstNum);

            Console.WriteLine("Please choose your opperation + (add), - (subtract), * (multiplication), / (division)");
            string strOperation = Console.ReadLine();

            if (strOperation == "+" || strOperation == "add" || strOperation == "addition")
            {
                opperationSwitch = 1;
            }
            else if (strOperation == "-" || strOperation == "subtract" || strOperation == "subtraction")
            {
                opperationSwitch = 2;
            }
            else if (strOperation == "*" || strOperation == "multiplication" || strOperation == "times" || strOperation == "x")
            {
                opperationSwitch = 3;
            }
            else if (strOperation == "/" || strOperation == "division" || strOperation == "divide" || strOperation == "%")
            {
                opperationSwitch = 4;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }

            Console.WriteLine("Type your Second number: ");
            string strSecondNum = Console.ReadLine();
            double secondNum = Convert.ToDouble(strSecondNum);

            switch (opperationSwitch)
            {
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum * secondNum;
                    break;
                case 4:
                    result = firstNum / secondNum;
                    break;
            }
            
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }

        
    }
}
