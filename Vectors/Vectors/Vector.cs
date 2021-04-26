using System;
using System.Collections.Generic;
using System.Text;

namespace Vectors
{
    class Vector
    {
        List<double> _components;
        string _type;
        Dictionary<int, double> _pairs;
        double _magnitude;
        const double pi = 3.14159;
        public Vector(List<double> components)
        {
            _components = components;
        }
        public List<double> Components { get => _components; set => _components = value; }
        public string Type 
        { 
            get
            {
                _type = Components.Count + "-vector";
                return _type;
            } 
        }
        Dictionary<int, double> Pairs
        {
            get
            {
                for(int i = 0; i < Components.Count; i++)
                {
                    _pairs.Add(i, Components[i]);
                }
                return _pairs;
            }
            set => _pairs = value;
        }
        public double Magnitude
        {
            get
            {
                double x = 0;
                List<double> squared = new List<double>();
                for(int i = 0; i < Components.Count; i++)
                {
                    squared.Add(Components[i] * Components[i]);
                }
                foreach(double d in squared)
                {
                    x += d;
                }
                _magnitude = (int)Math.Sqrt(x);
                return _magnitude;
            }
            set => _magnitude = value;
        }
        public Vector Add(Vector v)
        {
            List<double> d = new List<double>();
            for(int i = 0; i < Components.Count; i++)
            {
                d.Add(Components[i] + v.Components[i]);
            }
            Vector result = new Vector(d);
            return result;
        }
        public Vector Multiply(double n)
        {
            List<double> d = new List<double>();
            for(int i = 0; i < Components.Count; i++)
            {
                d.Add(Components[i] * n);
            }
            Vector result = new Vector(d);
            return result;
        }
        public double AlgDotProduct(Vector v)
        {
            List<double> result = new List<double>();
            double x = 0;
            for(int i = 0; i < Components.Count; i++)
            {
                x += (Components[i] * v.Components[i]);
            }
            return x;
        }
        public double GeoDotProduct(Vector v)
        {
            double theta = ToDegrees(Math.Cos(Magnitude / v.Magnitude));
            return theta * Magnitude * v.Magnitude;
        }
        // i know why this does not work 
        public double ToDegrees(double radians)
        {
            double degrees = (180 * pi) * radians;
            return degrees;
        }
        public override string ToString()
        {
            string s = null;
            for(int i = 0; i < _components.Count; i++)
            {
                if(i == 0)
                {
                    s += _components[i];
                }
                else
                {
                    s += "," +_components[i];
                }
            }
            return s;
        }
    }
}
