using System;

namespace MathOperationClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation op = new MathOperation();

            int result = op.OperationOne(112);
            Console.WriteLine(result);

            int result2 = op.OperationOne(15.5);
            Console.WriteLine(result2);

            int result3 = op.OperationOne("50");
            Console.WriteLine(result3);
            

            Console.ReadLine();
        }
    }

    public class MathOperation
    {
        public int OperationOne(int num1)
        {
            num1 = num1 * 10;

            return num1;
        }

        public int OperationOne(double num)
        {
            num = num + 10;
            return (int) num;
        }

        public int OperationOne(string num)
        {
            int re = 0;
            try
            {
                int int_num = Convert.ToInt32(num);
                re = 19500 / int_num;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return re;
        }
    }    
}
