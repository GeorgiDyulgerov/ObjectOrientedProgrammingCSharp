using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1Point3D;

namespace Problem2DistanceCalculator
{
    class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint3D, Point3D secondPoint3D)
        {
            double result = Math.Sqrt(Math.Pow((secondPoint3D.X - firstPoint3D.X), 2) + Math.Pow((secondPoint3D.Y - firstPoint3D.Y), 2) + Math.Pow((secondPoint3D.Z - firstPoint3D.Z), 2));
            return result;

        }
    }
}
