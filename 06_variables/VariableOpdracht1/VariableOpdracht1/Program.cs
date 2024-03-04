using System;

namespace VariableOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //maak hier 3 local variables aan:
            string name = "Bob";
            int hp = 100;
            int str = 45;


            //nu zou de statement hieronder moeten werken
            Console.WriteLine($"{name} {hp} {str}");
        }
    }

}