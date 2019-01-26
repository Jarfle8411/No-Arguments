using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method_returning_a_value
{
    class simplemethodreturningvalue
    {
        static void Main(string[] args)
        {
            double num1 = 10.0, num2 = 20.0, myAnswer;
            //call the method and assign the return value to varible myAnswer
            myAnswer = ans(num1, num2);
            Console.WriteLine("The value returned is " + myAnswer);
        }
        public static double ans(double x, double y)
        {
            double answer = x + y;
            return answer;
        }

    }
}