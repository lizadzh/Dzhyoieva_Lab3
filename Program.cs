using System;
using System.Collections.Generic;

namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> coefficients1 = new List<double> { 1.0, 5, 3, 9 };
            List<double> coefficients2 = new List<double> { 2.0, 8, 4, 7 };

            //вивести поліноми
            Console.Write(string.Format("{0}", coefficients1[0]));
            for (int i = 1; i < coefficients1.Count; i++)
            Console.Write(string.Format(" + {0}*x^{1}", coefficients1[i], i));
            Console.WriteLine("\n*");
            Console.Write(string.Format("{0}", coefficients2[0]));
            for (int i = 1; i < coefficients2.Count; i++)
            Console.Write(string.Format(" + {0}*x^{1}", coefficients2[i], i));
            Console.WriteLine("\n=");
             
            //множення
            List<double> result = new List<double>(new double[coefficients1.Count + coefficients2.Count - 1]);
            for (int i = 0; i < coefficients1.Count; i++) for (int j = 0; j < coefficients2.Count; j++)result[i + j] += coefficients1[i] * coefficients2[j];

            //вивести результат
            Console.Write(string.Format("{0}", result[0]));
            for (int i = 1; i < result.Count; i++)
                Console.Write(string.Format(" + {0}*x^{1}", result[i], i));
            Console.WriteLine("");
        }
    }
}
