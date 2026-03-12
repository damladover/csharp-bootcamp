using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    class Program
    {
        static void Main(string[] args)
        {

            #region alt alta 10 yıldız

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}





            #endregion

            #region yan yana 10 yıldız
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");

            //}
            #endregion

            #region dik üçgen
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region alt dik üçgen
            //for (int i = 10; i >= 1; i--)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //       Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region elmas
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 10; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region baklava dilimi 
            int n = 5;
            for(int i = 1; i <= n; i++)
            {
                for(int j = n - 1; j >= 0; j--)
                {
                    Console.Write("*");

                }
            }
            #endregion

            Console.Read();


        }


    } 
}
