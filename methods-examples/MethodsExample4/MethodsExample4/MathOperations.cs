using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample4
{
    public class MathOperations
    {
        public void DivideByTwo(int num, out int result_num)
        {
            result_num = num / 2;
        }

        public void MethodWithoutParams()
        {

        }

        public void MethodWithoutParams(int overloaded)
        {

        }
        public void MethodWithoutParams(int overloaded, string anotheroverload)
        {

        }
    }
}
