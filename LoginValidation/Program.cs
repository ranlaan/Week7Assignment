using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            Console.WriteLine("Sisesta kasutajatunnus: ");
            login = Console.ReadLine();
            Console.WriteLine("Sisesta parool: ");
            password = Console.ReadLine();
            Console.WriteLine("Sisesta PIN-kood: ");
            string PINcode = Console.ReadLine();

            int counter = 0; 
            while(counter < 3)
            {
                foreach (char character in PINcode)
                {
                    counter++;
                    if (PINcode.Length < 4 || PINcode.Length > 4)
                    {
                        Console.WriteLine("Vale PIN. Proovi uuesti.");
                        break;
                    }
                }
                if ((login == "user1") && (password == "password1") && (PINcode == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((login != "user1") && (password == "password1"))
                {
                    counter = counter + 1;
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((login == "user1") && (password != "password1"))
                {
                    counter = counter + 1;
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
            }
            
            

        }
    }
}
