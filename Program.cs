using System;

namespace dotnet
{
    class Degiskenler
    {
        public static void Main(String[] args)
        {
            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;
            
            uint ui = 2;
            long l= 4;

            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = '2';
            string str = "mustafa";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "adana";
            object o2 = 'm';
            object o3 = 44;
            object o4 = 44.4;

            string str1 = string.Empty; 
            str1 = "Mustafa Özer";
            string ad ="mustafa";
            string soyad = "Özer";
            string tamad = ad + " " + soyad;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;


            bool bool1 = 10>2;

            string str2 = "20";
            int int2 = 20;
            string yenideger = str2 + int2.ToString();
            Console.WriteLine(yenideger);

            int int3 = int2 + Convert.ToInt32(str2); 
            Console.WriteLine(int3);
            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);
            string hour = DateTime.Now.ToString("HH:m");
            Console.WriteLine(hour);
        }
    }
}