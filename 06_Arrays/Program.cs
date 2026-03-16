using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri 
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);



            //string[] cities = new string[5];

            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[4]);



            //string[] cities = { "prag", "roma", "atina", "ankara" };
            //Console.WriteLine(cities[2]);


            #endregion


            #region elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "turuncu" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 55, 67, 78, 99, 87, 17, 12, 43 };
            //for (int i =0; i < numbers.Length; i++)
            //{ if (numbers[i] % 3 == 0) {


            //        Console.WriteLine(numbers[i]);

            //    } }

            //char[] symbols = { 'a', 'b', 'c', 'd', '*', '+' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion



            #region en büyük eleman 

            //int[] myArray = { 47, 85, 100, 325, 11, 96 };
            //int maxNumber = myArray[0];
            //for(int i = 0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"lütfen {i + 1}.şehri giriniz:");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}
            #endregion



        }
    }
}
