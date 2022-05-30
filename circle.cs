using System;
using System.Collections.Generic;
using System.Text;

namespace list
{
    class circle
    {
        public double r;
        public double d;

        public void circle_circumpherence()
        {
            Console.WriteLine("Work out the circumpherence");

            Console.WriteLine("----------------------");

            Console.WriteLine("Enter X");
            r = double.Parse(Console.ReadLine());

            d = r + r;

            double circle_circumpherence = Math.PI * d;

            Console.WriteLine("Circumpherence of the circle is:" + circle_circumpherence);

        }
        public void circle_area()
        {
            Console.WriteLine("Work out the area of circle.");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Enter X");
            r = double.Parse(Console.ReadLine());

            double circle_area = Math.PI * (r * r);

            Console.WriteLine("Tre area of circle is:" + circle_area);
        }

        static void circle_options()
        {
            circle small_circle = new circle();

            while (true)
            {
                Console.WriteLine("Chose option");

                Console.WriteLine("---------------------");

                check_options:
                Console.WriteLine("1) Work out circumpherence of a circle");
                Console.WriteLine("2) Work out Area of a circle");
                Console.WriteLine("3) Exit");

                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());

                if (choice <= 0 || choice >= 4)
                {
                    Console.WriteLine("Invalid, Try again");
                    goto check_options;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Work out the circumpherence of the circle");
                    small_circle.circle_circumpherence();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Work out the area of circle");
                    small_circle.circle_area();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exit the program");
                    break;
                }
            }
        }
        public void circle_question()
        {
            circle_options();
        }
    }
}
