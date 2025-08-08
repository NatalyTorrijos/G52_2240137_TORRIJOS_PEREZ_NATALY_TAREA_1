using UnityEngine;
using System;

namespace PackagePunto2D
{
    [Serializable]
    public class Punto2D
    {
        public double X;
        public double Y;


        public Punto2D()
        {
        }

        public Punto2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X1 { get => X; set => X = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}
