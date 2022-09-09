using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace fdsfsd
{
    class Program

    {


        static double fy2(int i, double xt, double[] x, double[] y)
        {
            double A, B, C;
            A = y[i - 1];
            B = (y[i] - A) / (x[i] - x[i - 1]);
            C = (y[i + 1] - A - B * (x[i + 1] - x[i - 1])) / ((x[i + 1] - x[i - 1]) * (x[i + 1] - x[i]));
            return A + B * (xt - x[i - 1]) + C * (xt - x[i]) * (xt - x[i - 1]);
        }
        static double fy3(int i, double xt, double[] x, double[] y)
        {
            //Кубическая интерполяция
            double A, B, C, D;
            A = y[i - 1];
            B = (y[i] - A) / (x[i] - x[i - 1]);
            C = (B - ((y[i - 1] - A) / x[i - 1])) / (x[i] - x[i - 1]);
            D = (((y[i] + A) / x[i]) - B - C * (x[i] - x[i - 1])) / ((x[i] - x[i - 1]) * (x[i] - x[i - 1]));
            return A + B * (xt - x[i - 1]) + C * (xt - x[i]) * (xt - x[i - 1]) + D * (xt - x[i - 1]) * (xt - x[i - 1]) * (xt - x[i]);

        }


        static void Main()
        {
            double g;
            double yt = 0;
            double[] x = new double[] { 927, 1077, 1227, 1377, 1527, 1677, 1827, 1977, 2120, 2125, 2127 };
            double[] y = new double[] { 75, 69, 63, 41, 20, 14, 8, 6, 4.2, 4, 4 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("x = {0,3}      y={1,2} ", x[i], y[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите значение х ");
                g = double.Parse(Console.ReadLine());
                double xt = g;
                Console.WriteLine();
                if (xt <= ((x[1] + x[2]) / 2))
                {
                    yt = fy2(2, xt, x, y);
                }
                else
                {
                    for (int j = 2; j < 10; j++)
                    {
                        if ((xt >= (x[j - 1] + x[j]) / 2) & xt <= ((x[j] + x[j + 1]) / 2))
                        {
                            yt = fy2(j, xt, x, y);
                            break;
                        }
                    }
                }
                Console.WriteLine("Квадратичная интерполяция");
                Console.Write("В точке x={0:f1}", xt);
                Console.WriteLine("  значение y={0:f1}", yt);
                Console.WriteLine();
                if (xt <= ((x[1] + x[2]) / 2))
                {
                    yt = fy3(2, xt, x, y);
                }
                else
                {
                    for (int j = 2; j < 10; j++)
                    {
                        if ((xt >= (x[j - 1] + x[j]) / 2) & xt <= ((x[j] + x[j + 1]) / 2))
                        {
                            yt = fy3(j, xt, x, y);
                            break;
                        }
                    }
                }
                Console.WriteLine("Кубическая интерполяция");
                Console.Write("В точке x={0:f1}", xt);
                Console.WriteLine("  значение y={0:f1}", yt);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
