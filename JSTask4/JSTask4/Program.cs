using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask4
{
    public class Program
    {
        public static int wordsCounter(string text)
        {
            int result = 0;
            string[] words = text.Split(new char[] { ' ' });
            List<string> arr = new List<string>();
            foreach (var element in words)
            {
                if (element.Length > 0)
                {
                    arr.Add(element);
                }
            }
            result = arr.Count;
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(wordsCounter("Hello,  from  . Automaton team")); 
        }
    }
}
