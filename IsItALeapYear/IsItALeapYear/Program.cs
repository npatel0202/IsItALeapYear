using System;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsItALeapYear(int Year)
        {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) return true;
            else return false;
        }
    }
}
