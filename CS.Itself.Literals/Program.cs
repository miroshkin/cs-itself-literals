using System;

namespace CS.Itself.Literals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("\a\a\a"); //beep beep beep

            string a = "asdf";
            string b = "asdf";

            Console.WriteLine("string a equals b : " + a == b + "\n\v");

            
            object c = "asdf";
            object d = "asdf";

            Console.WriteLine("object c equals d : " + a == b + "\n\v");

            string e = @"Excellent work!";
            Console.Write($"\'{e}\'");
        }
    }
}
