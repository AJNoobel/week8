using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta Oma Nimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta Oma Vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            SayHello(userName, userAge);
        }



        private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Hi There! {someName}");
            Console.WriteLine($"Oled Sündinud aastal {2021 - someNumber}.");
        }
    }
}
