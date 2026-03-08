using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            Console.Write("şifre giriniz:");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("şifre doğru");
            }
            else
            {
                Console.WriteLine("şifre yanlış");

            }


            string capital, country;
            Console.Write("başkenti giriniz:");
            capital = Console.ReadLine();

            Console.Write("ülkeyi giriniz:");
            country = Console.ReadLine();

            if(capital=="ankara"& country == "türkiye")
            {
                Console.Write("doğru");
            }
            else
            {
                Console.Write("yanlış");
            }

            //
            Console.WriteLine();
            int exam1, exam2, exam3, average;
            string result="hata";

            Console.Write("sınav1:");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("sınav2:");
            exam2 = int.Parse(Console.ReadLine());
            
            Console.Write("sınav3:");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.Write("sınavların ortalaması:" + average);

            if (average>0 & average<50){
                result = "kötü";
            }
            if (average>50 & average < 70)
            {
                result = "orta";
            }
            if (average > 70)
            {
                result = " güzel";

            }
            Console.WriteLine();
            Console.WriteLine(result);


            #endregion else

            #region mod işlemleri
            Console.Write("lütfen 1.sayıyı giriniz:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("lütfen 2.sayıyı giriniz:");
            int number2 = int.Parse(Console.ReadLine());
            
            int re = number1 % number2;
            Console.Write("1.sayının 2. sayıya bölümünden kalan:" + re);
            Console.WriteLine();
            #endregion
            
            #region char ile değişken yapıları
            char team;
            Console.Write("lütfen takım sembolü giriniz:");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' | team == 'G'){
                Console.Write("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");

            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            #endregion
            
            
            #region örnek uygulama
            Console.WriteLine("***** restoran *****");
            Console.WriteLine();
            
            Console.WriteLine("------------");

            Console.WriteLine("1-ana yemekler");
            Console.WriteLine("2-çorbalar");
            Console.WriteLine("3-pizzalar");
            Console.WriteLine("4-içecekler");
            Console.WriteLine("tatlılar");
            
            Console.WriteLine("------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("detayını görmek için menü seçimi:");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------Ana Yemekler---------");
                Console.WriteLine();

                Console.WriteLine("1-köri soslu tavuk");
                Console.WriteLine("2-kızartma tabağı");
                Console.WriteLine("3-içecekler");

                Console.WriteLine();

            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------çorbalar---------");
                Console.WriteLine();

                Console.WriteLine("1-mercimek");
                Console.WriteLine("2-ezogelin");
                

                Console.WriteLine();

            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------içecekler---------");
                Console.WriteLine();

                Console.WriteLine("1-su");
                Console.WriteLine("2-kola");
                Console.WriteLine("3-meyve suyu");
               

                Console.WriteLine();

            }

            #endregion

            #region switch case
            
            Console.WriteLine("ay girişi yapınız: ");

            int monthnumber = int.Parse(Console.ReadLine());

            switch (monthnumber)
            {
                case 1:Console.Write("ocak");break;
                case 2: Console.Write("şubat"); break;
                case 3: Console.Write("mart"); break;
                case 4: Console.Write("nisan"); break;
                case 5: Console.Write("mayıs"); break;
                case 6: Console.Write("haziran"); break;
                case 7: Console.Write("temmuz"); break;
                case 8: Console.Write("ağustos"); break;
                case 9: Console.Write("eylül"); break;
                case 10: Console.Write("ekim"); break;
                case 11: Console.Write("kasım"); break;
                case 12: Console.Write("aralık"); break;
                default:Console.Write("hatalı veri");break;



            }


            #endregion

            Console.Read();



        }
    }
}
