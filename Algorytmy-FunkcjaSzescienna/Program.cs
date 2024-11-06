using System;

namespace Algorytmy_FunkcjaSzescienna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Podaj współczynniki a, b, c i d równania sześciennego.\n");

            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"({a})x^3 + ({b})x^2 + ({c})x + {d} = 0");

            double W = -b / (3 * a);
            double p = (3 * a * Math.Pow(W, 2) + 2 * b * W + c) / a;
            double q = (a * Math.Pow(W, 3) + b * Math.Pow(W, 2) + c * W + d) / a;
            double delta = Math.Pow(q / 2, 2) + Math.Pow(p / 3, 3);

            if (delta > 0)
            {
                Console.WriteLine("Jeden pierwiastek rzeczywisty");
                double u = Math.Cbrt(-(q / 2) + Math.Sqrt(delta));
                double v = Math.Cbrt(-(q / 2) - Math.Sqrt(delta));
                double x1 = u + v + W;
                Console.WriteLine($"x1: {x1}");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Trzy pierwiastki rzeczywiste");
                double phi = Math.Acos((3 * q) / (2 * p * Math.Sqrt(-p / 3)));
                double x1 = W + 2 * Math.Sqrt(-p / 3) * Math.Cos(phi / 3);
                double x2 = W + 2 * Math.Sqrt(-p / 3) * Math.Cos((phi / 3) + (2 * Math.PI / 3));
                double x3 = W + 2 * Math.Sqrt(-p / 3) * Math.Cos((phi / 3) + (4 * Math.PI / 3));
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
                Console.WriteLine($"x3: {x3}");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Dwa pierwiastki, z których jeden jest podwójny");
                double x1 = W - 2 * Math.Cbrt(q / 2);
                double x23 = W + Math.Cbrt(q / 2);
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2 i x3: {x23}");
            }
        }
    }
}
