using System;

namespace Console_Programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminiz nedir?");
            string name=Console.ReadLine();
            Console.WriteLine("Soyisminiz nedir?");
            string surname=" "+Console.ReadLine();
            Console.WriteLine("Merhaba " + name + surname);
        }
    }
}
