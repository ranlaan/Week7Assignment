using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();

            if (firstname.Length < 5)
            {
                for (int i = firstname.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(firstname[i]);
                }
            }
            else
            {
                Console.WriteLine(firstname);
            }

           
        }
    }
}
