using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            byte b = 5;  //
            sbyte c = 4;  //1 byte yer kaplar -128/+128
            short s = 5; //2 byte yer kaplar 
            ushort us = 5;

            Int16 i16 = 2;    //2 byte
            int i = 2;        //4 byte
            Int32 i32 = 2;    //4 byte
            Int64 i64 = 2;    //8 byte

            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            float f = 5;     //4 byte
            double d = 5;    //8 byte

            decimal de = 5; //16 byte


            char ch = '2';   //2byte
            string str = "ff"; //sınırsız

            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler
            string strl = String.Empty;
            string ad = "ff";
            string soyad = "ozb";
            string tamIsim = ad + " " + soyad;


            //integer tanımlama sekilleri
            int intdeger1 = 5;
            int intdeger2 = 3;
            int intdeger3 = intdeger1 + intdeger2;


            //boolean
            bool bool1 = 10 > 2;

            //degisken donusumleri

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            System.Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);


            int int22 = int20 + int.Parse(str20);

            //datetime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(dateTime);

        }
    }
}
