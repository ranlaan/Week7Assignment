using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The c4ke 1s 4 l1e");
            string cake = Console.ReadLine();

            cake = cake.Replace('4', 'a');
            cake = cake.Replace('1', 'i');
            Console.WriteLine(cake);
        }
    }
}
