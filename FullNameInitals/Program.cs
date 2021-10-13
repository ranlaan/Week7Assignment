using System;

namespace FullNameInitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi: ");
            string lastname = Console.ReadLine();
            string fullname = (firstname + lastname);

            for (int i = fullname.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(fullname[i]);
            }
        }
    }
}
