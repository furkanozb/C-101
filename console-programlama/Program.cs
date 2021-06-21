using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("İsiminizi giriniz: ");
            string name= Console.ReadLine();
            System.Console.WriteLine("Soyadınızı giriniz: ");
            string surname= Console.ReadLine();
            System.Console.WriteLine(  "Merhaba "+name+" "+surname);
        }
    }
}
