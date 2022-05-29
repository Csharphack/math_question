using System;
using System.Collections.Generic;
using System.Text;

namespace list
{
    class triangle
    {
        public double a;
        public double b;
        public double c;

        public void tri_perimeter()
        {
            Console.WriteLine(@"|\              ");
            Console.WriteLine(@"| \             ");
            Console.WriteLine(@"|  \            ");
            Console.WriteLine(@"|a  \c           ");
            Console.WriteLine(@"|    \          ");
            Console.WriteLine(@"|     \         ");
            Console.WriteLine(@"|___b__\        ");

            Console.WriteLine("Work out the perimeter");

            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b");
            b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("C:" + c);

            double total_perimeter = a + b + c;

            Console.WriteLine("Total perimeter:" + total_perimeter);
        }
        public void tri_area()
        {
            Console.WriteLine(@"|\              ");
            Console.WriteLine(@"| \             ");
            Console.WriteLine(@"|  \            ");
            Console.WriteLine(@"|a  \c           ");
            Console.WriteLine(@"|    \          ");
            Console.WriteLine(@"|     \         ");
            Console.WriteLine(@"|___b__\        ");

            Console.WriteLine("Work out the Area");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());

            double total_area = 0.5 * a * b;

            Console.WriteLine("Total area:" + total_area);
        }
    }
}
