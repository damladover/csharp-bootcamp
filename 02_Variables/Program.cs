using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            // double number;
            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("****fiyat listesi****");
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- elma fiyatı:" + applePrice+"tl");
            Console.WriteLine("---- portakal fiyatı:" + orangePrice+"tl");
            Console.WriteLine("---- çilek fiyatı:" + strawberryPrice + "tl");
            Console.WriteLine("---- patates fiyatı:" + potatoPrice + "tl");
            Console.WriteLine("---- domates fiyatı:" + tomatoPrice + "tl");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.65;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;
            Console.WriteLine();

            
            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;

            Console.WriteLine("alınan ürün:elma - " + " birimfiyat: " + applePrice + " -gramaj: " + appleGram + " toplam tutar : " + appleTotalPrice);
            Console.WriteLine("alınan ürün:portakal - " + " birimfiyat: " + orangePrice + " -gramaj: " + orangeGram + " toplam tutar : " + orangeTotalPrice);
            Console.WriteLine("alınan ürün:çilek - " + " birimfiyat: " + strawberryPrice + " -gramaj: " + strawberryGram + " toplam tutar : " + strawberryTotalPrice);
            Console.WriteLine("alınan ürün:domates - " + " birimfiyat: " + tomatoPrice + " -gramaj: " + tomatoGram + " toplam tutar : " + tomatoTotalPrice);
            Console.WriteLine("alınan ürün:patates - " + " birimfiyat: " + potatoPrice + " -gramaj: " + potatoGram + " toplam tutar : " + potatoTotalPrice);


            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine();

            Console.WriteLine("alışveriş toplam tutar :" + shoppingTotalPrice + "tl");

            #endregion

            #region Char Değişkenler
            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerCountry, passengerAge,passengerIdentityNumber;

            Console.Write("yolcu adı:");
            passengerName = Console.ReadLine();

            Console.Write("yolcu soyadı:");
            passengerSurname = Console.ReadLine();
            
            Console.Write("ilçe bilgisi:");
            passengerDistrict = Console.ReadLine();

            Console.Write("şehir bilgisi:");
            passengerCity = Console.ReadLine();

            Console.Write("yolcu yaş:");
            passengerAge = Console.ReadLine();

            Console.Write("yolcu tc no :");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

     
            


            
            Console.WriteLine();

            Console.WriteLine("----------------");
            Console.WriteLine("yolcu : "+ passengerIdentityNumber + " "+ passengerName + "" + passengerSurname + " "+ passengerDistrict+" " + passengerCity + " "  +passengerAge + " "  );







            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler





            #endregion
            Console.Read();

        }
    }
}
