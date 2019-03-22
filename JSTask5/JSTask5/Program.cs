using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mathOperations.Add(4, 5);
            mathOperations.Subtraction(4, 5);
            mathOperations.Multiply(4, 5);
            mathOperations.Divide(4, 5);
            Console.WriteLine("x+x*5-y/2 = " + mathOperations.Subtraction(mathOperations.Add(4, mathOperations.Multiply(4, 5)), mathOperations.Divide(10, 2)));
            Console.ReadKey();
        }
    }
}
