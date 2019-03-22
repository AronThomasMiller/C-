using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask2
{
    public class Program
    {
        public static int findMax(int [] array)
        {
            return array.Max();
       
        }
        public static int findMin(int [] array)
        {
            return array.Min();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(findMax(arr));
            Console.WriteLine(findMin(arr));
        }
    }
}
