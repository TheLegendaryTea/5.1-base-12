using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y2");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите x3");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y3");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите x4");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y4");
            int y4 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите x5");
            int x5 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y5");
            int y5 = int.Parse(Console.ReadLine());
            double s1 = S1(x1, x2, x3, y1, y2, y3);
            double s2 = S2(x1, x3, x4, y1, y3, y4);
            double s3 = S3(x1, x4, x5, y1, y4, y5);
            double sum = s1 + s2 + s3;
            Console.WriteLine("S="+sum);
        }
        static double S1(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            double S = Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1))/2;
            return S;
        }
        static double S2(int x1, int x3, int x4, int y1, int y3, int y4)
        {
            double S = Math.Abs((x3 - x1) * (y4 - y1) - (x4 - x1) * (y3 - y1))/2;
            return S;
        }
        static double S3(int x1,int x4,int x5,int y1,int y4, int y5)
        {
            double S = Math.Abs((x4 - x1) * (y5 - y1) - (x5 - x1) * (y4 - y1))/2;
            return S;
        }
    }
}
