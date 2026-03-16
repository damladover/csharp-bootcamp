using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul " };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);

            //}

            //int[] numbers = { 45, 78, 635, 41, 1000 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}

            //int[] numbers = { 45, 78, 635, 41, 1000 };
            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);

            //    }
            //}



            //int[] numbers = { 45, 78, 635, 41, 1000 };

            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;

            //}Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}


            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);

            //}




            #endregion

            #region örnek sınav uygulaması 
            Console.Write("***sınav uygulaması***");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------");

            Console.Write("sınıfınızda kaç öğrenci var :");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("");


            string[] studentsNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i =0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentsNames[i] = Console.ReadLine();
                double totalExamResult = 0;


                //her öğrenci için 3 sınav notu girişi 
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;



                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;


            }
            //sınav ortalamaları
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentsNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");


                //öğrencilerin geçip kalma durumları 
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsNames[i]} adlı öğrenci dersi geçti");

                }
                else
                {
                    Console.WriteLine($"{studentsNames[i]} adlı öğrenci dersten kaldı ");

                }
            }

            #endregion
        }
    }
}
