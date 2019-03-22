using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask7
{
    public class Program
    {
        public static List<NumberIsOdd> GetList(int [] arr)
        {
            List<NumberIsOdd> result = new List<NumberIsOdd>();
            foreach  (var digit in arr)
            {
                NumberIsOdd obj = new NumberIsOdd(digit);
                result.Add(obj);
            }
            return result;
        }   
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7};
            var res = GetList(arr);
            foreach (var res1 in res)
            {
                Console.WriteLine(res1.Number + " " + res1.isOdd);
            }
        }
    }
}
