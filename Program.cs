using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            options();
            
        }
        static void options()
        {
            triangle tri_question = new triangle();
            circle small_circle = new circle();

            Console.WriteLine("1) Work our Perimeter");
            Console.WriteLine("2) Work out Area");
            Console.WriteLine("3) Circle Math problem");
            Console.WriteLine("4) Exit                      ");

            Console.WriteLine("--------------------------");

            while (true)
            {
                wrong_option:
                Console.WriteLine("Enter Choice");
                int choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice >= 5)
                {
                    Console.WriteLine("invalid Input");
                    goto wrong_option;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("work out Perimeter");
                    tri_question.tri_perimeter();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You want to work out the area of triangle.");
                    tri_question.tri_area();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Solve Circle problems");
                    small_circle.circle_question();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exit the program");
                    break;
                }
            }
        }
    }
}