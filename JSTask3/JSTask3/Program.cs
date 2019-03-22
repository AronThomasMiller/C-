using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask3
{
    public class Program
    {
        public static List<int> filterArray(int[] array, int minVal, int maxVal)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < maxVal && minVal < array[i])
                {
                    result.Add(array[i]);
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            var resultEnd = filterArray(arr, 1, 4);
            foreach (var res in resultEnd)
            {
                Console.WriteLine(res);
            }
        }
    }
}
