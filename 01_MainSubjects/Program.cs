using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region yazdırmakomutları
            // Console.WriteLine("selam");

            // Console.Write("merhaba dünya");


            Console.WriteLine("****yemek kategorileri**** ");
            Console.WriteLine();
            Console.WriteLine("1_çorbalar");
            Console.WriteLine("2_ana yemekler");
            Console.WriteLine("3_soğuk başlangıçlar");
            Console.WriteLine("4_salatalar");
            Console.WriteLine("5_tatlılar");
            Console.WriteLine("6_içecekler");
            Console.WriteLine();
            Console.WriteLine("****yemek kategorileri****");

            #endregion
            #region StringDeğişkenler 
            //string 
            //değişken_türü değişken adı;



            //string name;
            //name = "Damla";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName="Damla";
            customerSurname = "Döver";
            customerPhone = "+905555555555";
            customerEmail = "deneme@gmail.com";
            district = "iskenderun";
            city = "hatay";

            Console.WriteLine("***rezervasyon kartı****");
            Console.WriteLine();
            Console.WriteLine("müşteri: " + customerName + "" + customerSurname);
            Console.WriteLine("iletişim: " + customerPhone );
            Console.WriteLine("email adresi:" + customerEmail);
            Console.WriteLine("adres:" + district + "/" + city);
            Console.WriteLine("----------------------------");






            #endregion

            #region IntDeğişkenler
            //int
            //int number =24;
            //Console.WriteLine(number);
            
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int friesPrice = 50;

            Console.WriteLine("**** restoran menü****");
            Console.WriteLine();
            Console.WriteLine("----hamburger----:" + hamburgerPrice + "tl");
            Console.WriteLine("----coke----:" + cokePrice + "tl");
            Console.WriteLine("----friesprice----:" + friesPrice + "tl");

            Console.WriteLine();

            int hamburgercount;
            int cokecount;
            int friescount;

            int totalPrice = 0;
            hamburgercount = 3;
            cokecount = 3;
            friescount = 1;
            totalPrice = hamburgercount * hamburgerPrice + cokePrice * cokecount + friescount * friesPrice;
            Console.WriteLine(totalPrice);






            #endregion
            Console.Read();

            
        }
    }
}

//yazdırma komutları