using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            welcomeStatement();
            int a, b, c;

            Console.WriteLine();
            Console.WriteLine("Enter Two Numbers To be Multiplied");

            a = findArea();
            b = findArea();

            multiplyNumbers(a, b);

            Console.WriteLine();
            c = secretNumber();

            Console.ReadKey();
        }//closes Main

        static void welcomeStatement()
        {
            Console.WriteLine("Welcome to My Method Examples");
        }

        static int findArea()
        {
            int x;

            Console.WriteLine("Please Enter Number:");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static int secretNumber()
        {
            int y;

            Console.WriteLine("Please enter your secret number:");
            y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
        static void multiplyNumbers(int num1, int num2)
        {
            int total = num1 * num2;
            Console.WriteLine("Your Total is {0}", total);
        }
    }

}
