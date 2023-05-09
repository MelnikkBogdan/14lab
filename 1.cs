using System;

namespace _14_lab
{
    interface IFigure
    {
        void printArea();
        double getArea();
    }

    interface ITime : IFigure
    {
        double A { get; set; }
        double B { get; set; }
    }

    public class Time : ITime, IFigure

    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Time()
        {

            A = 1;
            B = 1;
        }

        public Time(double a, double b)
        {

            A = a;
            B = b;
        }

        public double getArea()

        {
            return (A * B) / 2;

        }

        public void printArea()
        {
            Console.WriteLine(value: $"The area of the figure is {getArea()}");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            ITime[] times = new Time[]
        {
            new Time(4, 5),
            new Time(3, 6),
            new Time(2, 8)
        };

            Array.Sort(times, (d1, d2) => d1.getArea().CompareTo(d2.getArea()));

            foreach (var time in times)
            {
                time.printArea();
            }
        }
    }
}