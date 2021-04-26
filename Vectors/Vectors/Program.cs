using System;
using System.Collections.Generic;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> d1 = new List<double> { 3, 5 };
            List<double> d2 = new List<double> { 5, -6 };
            Vector v1 = new Vector(d1);
            Vector v2 = new Vector(d2);
            Vector v3 = v1.Add(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v1.AlgDotProduct(v2));
            Console.WriteLine(v1.GeoDotProduct(v2));
        }
    }
}
