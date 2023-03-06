using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = GetNumberOfData();

            Console.Clear();

            // Display Data

            double[] data = new double[n];
            data = GetData(n);

            foreach (double i in data)
            {
                Console.WriteLine($"Data: {i.ToString("F2")}");
            }

            // Get Mean

            double mean = GetMean(data, n);
            Console.WriteLine($"Mean is: {mean}");

            // Get Second Row

            GetSecondData(data, mean, n);

            double[] secondRow = new double[n];
            secondRow = GetSecondData(data, mean, n);

            // Display Second row

            foreach (double secondData in secondRow)
            {
                Console.WriteLine($"Second Row: {secondData.ToString("F2")}");
            }

            // Get Third Row

            double[] thirdRow = new double[n];
            thirdRow = GetThirdData(data, mean, n);

            // Display Third row

            foreach (double thirdData in thirdRow)
            {
                Console.WriteLine($"Third Row: {thirdData.ToString("F2")}");
            }

            // Get Variance 
            double variance = GetVariance(thirdRow, n);
            Console.WriteLine($"Variance is: {variance.ToString("F2")}");

            // Get Standard Deviation
            double standardDev = Math.Sqrt(variance);
            Console.WriteLine($"Standard Deviation: {standardDev.ToString("F2")}");

            Console.ReadKey();
        }

        public static int GetNumberOfData()
        {
            Console.Write("Enter number of data: ");
            int n = int.Parse(Console.ReadLine());

            return n;
        }

        public static double[] GetData(int n)
        {
            double[] data = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter data: ");
                data[i] = int.Parse(Console.ReadLine());
            }
            return data;
        }

        public static double GetMean(double[] data, int n)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += data[i];
            }

            sum /= n;

            return sum;
        }

        public static double[] GetSecondData(double[] data, double mean, int n)
        {
            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = data[i] - mean;
            }

            return result;
        }

        public static double[] GetThirdData(double[] data, double mean, int n)
        {
            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = data[i] - mean;
                result[i] *= result[i];
            }

            return result;
        }

        public static double GetVariance(double[] data, int n)
        {
            double variance = 0;

            for (int i = 0; i < n; i++)
            {
                variance += data[i];
            }

            variance /= (n-1);

            return variance;
        }
    }
}
