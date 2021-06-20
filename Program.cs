using System;

namespace patika_degisken_pratigi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; // 1byte
            byte c = 5; // 1byte

            short s = 5; // 2byte
            ushort us = 5; // 2byte

            Int16 i16 = 2; // 2byte
            int i = 2; // 4byte
            Int32 i32 = 2; // 8byte
            Int64 i64 = 2; // 8byte

            uint ui = 2; // 4byte
            long l = 4; // 8byte
            ulong ul = 4; // 8byte

            // Reel sayilar
            float f = 5; // 4byte
            double d = 5; // 8byte
            decimal dec = 5; // 16byte

            char ch = '2'; // 2byte
            string str = "Cemil"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Cemil Gökalp ÇAKAR";
            string ad = "Cemil Gökalp";
            string soyad = "ÇAKAR";
            string tamisim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10>2;

            // değişken dönüşümleri

            string str2 = "2";
            int int2 = 2;

            string yenideger = str2 + int2.ToString(); // Çıktısı 22

            Console.WriteLine(yenideger);

            int yeniinteger = int2 + Convert.ToInt32(str2); // Çıktısı 4
            Console.WriteLine(yeniinteger); 

            int int3 = int2 + int.Parse(str2); // Çıktısı 4

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            
            string datetime3 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime3);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
