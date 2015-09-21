using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1Point3D;

namespace Problem2DistanceCalculator
{
    class MainDistanceCalculator
    {
        static void Main()
        {
            Point3D point1 = new Point3D(2, 3, 5);
            Point3D point2=Point3D.StartPoint3D;
            Console.WriteLine("Distance:{0:##.##}",(DistanceCalculator.CalculateDistance(point1,point2)));
        }
    }
}
