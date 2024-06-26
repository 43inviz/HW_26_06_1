using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{
    internal class Program
    {

        
        static void Main(string[] args)
        {


            //MessageOutput messOut = new MessageOutput();

            //MessageMethods messMeth = Show;
            //messMeth += SaveMess;

            //messOut.DelegateON("abs", messMeth);

            //Console.ReadLine();
            //========================================================

            //MATH
            //MathOperation mathOperation = new MathOperation();

            //MathMethods mathMethods = Sum;
            //mathMethods += Mult;
            //mathMethods += Subtraction;

            //mathOperation.MethodsON(5, 5, mathMethods);

            //Console.ReadLine();

            //======================================================

            ArithmeticOperation arithmeticOperation = new ArithmeticOperation();
            Predicate<int> predicate = IsEasy;
            predicate += IsOdd;
            predicate += IsEasy;
            predicate += IsFibonacci;


            arithmeticOperation.ArithmStart(2, predicate);

            Console.ReadLine();


        }


        public static bool IsEven(int x){return x % 2 == 0;}
        public static bool IsOdd(int x) { return x % 2 !=0 ;}

        public static bool IsEasy(int x) { 
            if(x > 1)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        public static bool IsPerfectSquare(int x )
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }
        public static bool IsFibonacci(int x)
        {
            if (x < 0) return false;

            

            int test1 = 5 * x * x + 4;
            int test2 = 5 * x * x - 4;

            return IsPerfectSquare(test1) || IsPerfectSquare(test2);
        }

        ///////
        public static void Sum(int a,int b) {Console.WriteLine($" Sum: {a + b} ");}
        public static void Mult(int a, int b) { Console.WriteLine($" Mult: {a * b} "); }
        public static void Subtraction (int  a, int b) { Console.WriteLine($" Sub: {a - b} "); }
        
        /////
        public static void Show(string mess)
        {
            Console.WriteLine(mess);
        }

        public static void SaveMess(string mess)
        {
            Console.WriteLine("Mess is save");
        }
    }
}
