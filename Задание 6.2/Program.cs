using System;

namespace Задание_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            char[] newstr = str.ToCharArray();

            Array.Reverse(newstr);

            string str2 = new string(newstr);

            if (str.Equals(str2))
                Console.WriteLine("палиндром");
            else Console.WriteLine("не палиндром");

            Console.ReadLine();
        }
    }
    
}
