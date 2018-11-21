using System;

namespace MathOperationClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation op = new MathOperation();
            op.OperationOne(10, 15);

            op.OperationOne(num1: 10, num2: 15);


            Console.ReadLine();
        }
    }

    public class MathOperation
    {
        public void OperationOne(int num1, int num2)
        {
            num1 = num1 + 10;

            Console.WriteLine(num2);
        }
    }    
}
