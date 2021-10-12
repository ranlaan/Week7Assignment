using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string eesnimi = Console.ReadLine();

            Random rnd = new Random();
            int index = rnd.Next(0, eesnimi.Length);
            Console.WriteLine(eesnimi[index]);
        }
    }
}
