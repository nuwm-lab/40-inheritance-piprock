using System;

namespace Lab4
{

    class LinearFunction
    {
        protected double A1 { get; set; }
        protected double A0 { get; set; }

        public void SetCoefficients(double a1, double a0)
        {
            A1 = a1;
            A0 = a0;
        }

        public void DisplayCoefficients()
        {
            Console.WriteLine($"Linear Function y = {A1}x + {A0}");
        }

        public double CalculateValue(double x)
        {
            return A1 * x + A0;
        }
    }

    class Polynomial : LinearFunction
    {
        private double A2 { get; set; }
        private double A3 { get; set; }
        private double A4 { get; set; }

        public void SetCoefficients(double a4, double a3, double a2, double a1, double a0)
        {
            A4 = a4;
            A3 = a3;
            A2 = a2;
            A1 = a1;
            A0 = a0;
        }

        public new void DisplayCoefficients()
        {
            Console.WriteLine($"Polynomial y = {A4}x^4 + {A3}x^3 + {A2}x^2 + {A1}x + {A0}");
        }

        public new double CalculateValue(double x)
        {
            return A4 * Math.Pow(x, 4) + A3 * Math.Pow(x, 3) + A2 * Math.Pow(x, 2) + A1 * x + A0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinearFunction linear = new LinearFunction();
            linear.SetCoefficients(2, 3);
            linear.DisplayCoefficients();
            Console.Write("Enter x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Linear function value: {linear.CalculateValue(x)}");

            Polynomial polynomial = new Polynomial();
            polynomial.SetCoefficients(1, -2, 3, 0, 5);
            polynomial.DisplayCoefficients();
            Console.Write("Enter x = ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Polynomial value: {polynomial.CalculateValue(x)}");
        }
    }
}
