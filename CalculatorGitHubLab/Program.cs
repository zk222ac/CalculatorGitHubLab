using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGitHubLab
{
   public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Sub(5, 2));
            Console.WriteLine(Mul(1, 2));
            Console.WriteLine(Div(23, 4));
           
            Console.ReadKey();

           
        }

        static int Add(int a , int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }

        public void ScientificFunctionality()
        {
            Console.WriteLine(" Scientific Calculator");
        }
    }
}
