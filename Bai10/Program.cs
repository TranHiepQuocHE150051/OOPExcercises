using System;

namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.characters = "  Hello  my  name    is    Quoc        ";
            Console.WriteLine(text.ToString());
            Console.WriteLine("Number of letter a is :" + CountNumberofLetterA(text.characters));
            Console.WriteLine("Number of word  is :" + countWords(text.characters));
            text.characters = NormalizeString(text.characters);
            Console.WriteLine(text.ToString());
        }
        static string NormalizeString(string str)
        {
            while (str.IndexOf("  ") != -1) {
                str = str.Replace("  ", " ");
                }
            return str;
        }
        static int CountNumberofLetterA(string str)
        {
            int count = 0;
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            foreach (char c in chars)
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            return count;
        }
         static int countWords(String input)
        {
            input = NormalizeString(input);
            string[] words = input.Split(' ');
            return words.Length;
        }
    }
}
