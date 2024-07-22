using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    public class Calculator
    {
        int num1;
        int num2;
        int result;

        void add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void Subtract()
        {
            result = num2 - num1;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.num1 = 69;
            obj.num2 = 100;
            obj.add();
            obj.Subtract();

            Calculator obj1 = new Calculator();
            obj1.num1 = 99;
            obj1.num2 = 250;
            obj1.add();
            obj.Subtract();


        }
    }
}
