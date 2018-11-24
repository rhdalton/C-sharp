using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType valueType = new ValueType();
            valueType.Amount = 99;
            ValueType valueType2 = valueType;
            valueType2.Amount = 11;

            /* valueType.Amount remains 99 */
            Console.WriteLine(valueType.Amount);

            ReferenceType refType = new ReferenceType();
            refType.Amount = 99;
            ReferenceType refType2 = refType;
            refType2.Amount = 11;

            /* refType.Amount changes to 11 */
            Console.WriteLine(refType.Amount);

            Console.ReadLine();
        }
    }

    public struct ValueType
    {
        public decimal Amount { get; set; }
    }

    public class ReferenceType
    {
        public decimal Amount { get; set; }
    }   
}
