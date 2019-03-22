using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask1
{
    public class Program
    {
        public static  int chooseBigger (int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(chooseBigger (1 , 2).ToString());
        }
    }
}
