using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_2._0
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Count the number of words in a sentence
            int result = 23.By2Less1();
            Console.WriteLine(result);

            string text = "This is a test sentence";

            Console.WriteLine("The number of words in \"{0}\" is {1}", text, text.WordCount());
        }

        public static int By2Less1(this int num)
        {
            return num * 2 - 3;
        }
        public static int Wordcount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
