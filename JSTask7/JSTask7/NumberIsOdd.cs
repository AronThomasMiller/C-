using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask7
{
    public class NumberIsOdd
    {
        public int Number;
        public bool isOdd;
        public  NumberIsOdd (int Number)
        {
            this.Number = Number;
            isOdd = IsOdd(Number);
        }
        public static bool IsOdd(int Number )
        {
            return Number % 2 != 0;
        }
    }
}
