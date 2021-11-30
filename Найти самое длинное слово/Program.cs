using System;

namespace Найти_самое_длинное_слово
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "мама мыла пилораму";
            string wordWithMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = words[i];
            Console.WriteLine(wordWithMaxLength);
        }

    }
    }

