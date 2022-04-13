using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir reqem daxil edin");
            string s = Console.ReadLine();
            int i = 0;
            int count = s.Length;
            int sum = 0;
            while (i < count)
            {
                if (char.IsDigit(s[i]))
                    sum += s[i++] - 48;
            }
            Console.WriteLine(sum);

        }
    }
}
