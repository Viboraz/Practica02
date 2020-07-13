using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public static class MathematicalFormulas
    {
        public static double Rectangle(string rectangleLength, string rectangBreadth)
        {
            double length_1 = Double.Parse(rectangleLength);
            double breadth_1 = Double.Parse(rectangBreadth);
            double area_r = length_1 * breadth_1;
            return area_r;
        }

        public static double Triangle(string rectangTbreadth, string rectangHieght)
        {
            double tbreadth_1 = Double.Parse(rectangTbreadth);
            double hieght_1 = Double.Parse(rectangHieght);
            double area_t = (tbreadth_1 * hieght_1) / 2;
            return area_t;
        }
    }

    class Areas
    {
        static void Main()
        {
            double length, breadth, hieght, breadthfortriangle;

            Console.WriteLine("Enter the Length for Rectangle");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breadth for Rectangle");
            breadth = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is :{0}", length * breadth);

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Enter the Breadth for Triangle ");
            breadthfortriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hieght for Triangle ");
            hieght = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle is:{0}", (breadthfortriangle * hieght) / 2);

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Please select the geometric figure:");
            Console.WriteLine("1. Rectangle.");
            Console.WriteLine("2. Triangle.");
            Console.WriteLine("3. Exit.");
            Console.Write(":");

            string selection = Console.ReadLine();
            double R, T = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please the Length and the breadth for Rectangle: ");
                    R = MathematicalFormulas.Rectangle(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("The area of ​​the rectangle is: {0:F2}", R);
                    break;

                case "2":
                    Console.Write("Please enter the Breadth and Hieght for Triangle: ");
                    T = MathematicalFormulas.Triangle(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("The area of ​​the triangle is: {0:F2}", T);
                    break;

                case "3":
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please select a geometric figure or exit.");
                    break;
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}