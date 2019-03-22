using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSTask6
{
    class Program
    {
        public static List<WordAndCount> SearchWordInText(string text, string[] array)
        {
            List<WordAndCount> result = new List<WordAndCount>();
            var SplitedText = text.Split(' ');
            foreach (var word in array)
            {
                int count = 0;
                foreach (var WordFromSplitedText in SplitedText)
                {
                    if (WordFromSplitedText != null)
                    {
                        if (WordFromSplitedText == word)
                        {
                            count++;
                        }
                    }
                }
                WordAndCount obj = new WordAndCount(word, count);
                result.Add(obj);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string text = "hello , i am maxim, i am";
            string[] arr = new string[] { "i", "am" };
            var res = SearchWordInText(text, arr);
            foreach (var res1 in res)
            {
                Console.WriteLine(res1.Word + " " + res1.Count);
            }
        }
    }
}
