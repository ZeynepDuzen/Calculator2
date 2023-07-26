using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Calculator ***

            //The user should enter  two numbers, and than
            //the user should enter  addition,subtraction,multiplication or division
            //finally, the user should be able to do whatever mathematical operation he/she want

            double number1;
            double number2;
            string operation;

            Console.WriteLine("Please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter operation sign < + , - , * , / >");
            operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = number1 + number2;
                Console.WriteLine("result : " + result);
            }
            if (operation == "-")
            {
                result = number1 - number2;
                Console.WriteLine("result : " + result);
            }
            if (operation == "*")
            {
                result = number1 * number2;
                Console.WriteLine("result : " + result);
            }
            else
            {
                result = number1 / number2;
                Console.WriteLine("result : " + result);
            }
            
        


            Console.Read();
        }
    }
}
