using System;

namespace MethodsExample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            op.OperationOne(10, 15);

            op.OperationOne(num1: 10, num2: 15);

            Console.ReadLine();
        }
    }    
}