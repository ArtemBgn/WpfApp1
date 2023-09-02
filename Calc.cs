using System;

namespace WpfApp1
{
    public static class Calc
    {
        public static decimal sum(double x, double y)
        {
            return (decimal)x + (decimal)y;
        }
        public static decimal sub(double x, double y)
        {
            return (decimal)x - (decimal)y;
        }
        public static decimal mult(double x, double y)
        {
            return (decimal)x * (decimal)y;
        }
        public static decimal div(double x, double y)
        {

            return (decimal)x / (decimal)y;
        }
        public static decimal remOfdiv(double x, double y)
        {
            return (decimal)x % (decimal)y;
        }
    }
}
