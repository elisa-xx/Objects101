using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ObjectExercises
{
    class Employee
    {
        public string name;
        public decimal payRate;

        public Employee(string n, decimal p) 
        {
            name = n;
            payRate = p;
        }

        public decimal GetPay()
        {
            return payRate * 40;
        }
    }
    class Rectangle
    {
        public int width;
        public int height;

        public Rectangle (int w, int h)
        {
            width = w;
            height = h;
        }

        public int GetArea()
        {
            return width * height;
        }

        public int GetPerimeter()
        {
            return width * 2 + height * 2;
        }
    }

    class Circle
    {
        private double radius;
        public double GetRadius() {
            return radius;
        }
        public Circle (double radius)
        {
            this.radius = radius;

        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestTaskFour();
        }


        static void TestTaskOne()
        {
            Employee a, b, c;
            string str;

            a = new Employee("Adam Smith", 10.00m);
            b = new Employee("Fred Flintstone", 11.50m);
            c = new Employee("Mary Brown", 20.00m);

            str = a.name + "\t" + a.payRate + "\t\t" + a.GetPay();
            Console.WriteLine(str);

            str = b.name + "\t" + b.payRate + "\t\t" + b.GetPay();
            Console.WriteLine(str);

            str = c.name + "\t" + c.payRate + "\t\t" + c.GetPay();
            Console.WriteLine(str);
        }



        static void TestTaskTwo()
        {
            Console.WriteLine("Rectangles");
            ShowRectangle(2, 5);
            ShowRectangle(3, 7);
            ShowRectangle(14, 2);
            ShowRectangle(9, 6);
            ShowRectangle(5, 15);
        }

        static void ShowRectangle(int x, int y)
        {
            Rectangle rect = new Rectangle(x, y);
            string str = rect.width + " by " + rect.height + "\t"
                + "Area: " + rect.GetArea() + "\t"
                + "Perimeter: " + rect.GetPerimeter();
            Console.WriteLine(str);
        }


        static void TestTaskThree()
        {
            Console.WriteLine("Circles");
            ShowCircle(1.5);
            ShowCircle(2);
            ShowCircle(5.7);
            ShowCircle(7);
            ShowCircle(25);
        }

        static void ShowCircle(double r)
        {
            Circle c = new Circle(r);
            string str = "Radius: " + c.GetRadius() + "\t"
                + "Area: " + c.GetArea() + "\t"
                + "Circumference: " + c.GetCircumference();
            Console.WriteLine(str);
        }

        static void TestTaskFour()
        {
      

            for(int radius = 1; radius <=50; radius++)
            {
                Circle c = new Circle(radius);
                Console.WriteLine($"Area of circle with radius {radius} is {c.GetArea()}");
            }
        }
    }
}
