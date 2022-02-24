using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //String degisken =" ";
            //byte b = 5; // 1 byte
            //sbyte s = 5; // 1 byte ve eksi deger alir

            //short sh = 5; // 2 byte
            //unshort us = 5; // 2 byte ve eksi deger almaz

            //int16 i16 = 2; // 2 byte
            //int i = 2; // 4 byte
            
            //Int64 i64 = 2; // 8 byte
            
            //uint ui = 2; //4 byte
            //long l = 4; // 8 byte
            //ulong ul = 4; // 8 byte

            // reel sayilar
            //float f = 5; // 4 byte
            //double d= 5; // 8 byte
            //decimal de = 5; // 16 byte

           // char c = '5'; // 2 byte
           // string str = "Merve"; // sinirsiz

           // bool b1 = true; 
           // bool b2 = false; 

            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            //object o1 = "x1";
            //object o2 = 4.5;

            //string str1 = string.Empty
            //str1 = "Merve";
            
            string ad = "Merve";
            string soyad = "Sahin";
            string tamisim = ad + " " + soyad;
            //Console.WriteLine(tamisim);

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            //Console.WriteLine(integer3);

            //bool bool1 = 10<2;
            //Console.WriteLine(bool1);

            string str20 ="20";
            int int20 =20;
            //string yenideger = str20 + int20.ToString();
            //Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            //Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            //Console.WriteLine(int22);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            //Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            //Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH/mm");
            //Console.WriteLine(hour);
        }
    }
}
