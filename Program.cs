using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            int i=2;  //4 byte
            Int16 i16=2; //2 byte
            Int32 i32=2; //4byte
            Int64 i64=2; //8 byte    
  
            //Reel sayılar
            float f=5; //4 byte
            double d=5; //8 byte
            decimal dc=5;  //16 byte

            char c='2'; //2 byte
            string str = "Yunus"; //sınırsız byte

            bool b1= true;
            bool b2= false;

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);
            //şimdiki zamanın tarih ve saat karşılığını getirir.

            object o1='x';
            object o2='y';
            object o3= 4;
            object o4= 4.3;

            // string ifadeler

            string str1 = string.Empty; // boş string (str1) oluşturur.
            str1 = "Yunus Başak"; // str1'e değer atar.
            string ad = "Yunus";
            string soyad = "Başak";
            string tamIsim = ad + " " + soyad; // tamIsim adında değişken oluşturarak ayrı yazılan string ifadeleri bir arada aralarında boşluk olacak şekilde yazdırır.

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2; // integer3 değişkeni ile diğer iki değişkenin çapımını aldık.

            //boolean

            bool bool1 = 10>2; //true değeri dönecek.
            bool bool2 = 10<2; //false değeri dönecek
             
            // değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // çıktısı 2020 - str20 değişkenine int20 değişkenini string ifade olarak yazdırır. ilk ifade string ("")olduğu için yanına gelecek şekilde olur.
            
            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21); // çıktısı 40- int20 değişkenine str20 değişkenini sayısal ifade olarak yazdırır. ilk ifade sayısal ifade (Int32) olduğu için toplamı olacak şekilde olur.

            int int22 = int20 + int.Parse(str20); // Çıktısı 40 olur.

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // Bugünün tarihini verir.
            System.Console.WriteLine(datetime);
            
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine( datetime2);

            // saat

            string hour = DateTime.Now.ToString("HH.mm");
            System.Console.WriteLine(hour); //Şimdiki zamanı saat olarak gösterir.
            

        }
    }
}
