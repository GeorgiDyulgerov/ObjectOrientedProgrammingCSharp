using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1Point3D;

namespace Problem3Paths
{
    class MainPaths
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(2, 3, 5);
            Point3D point2=new Point3D(6.66, 7.32,9.69);
            Point3D point3 = Point3D.StartPoint3D;

            Paths3D path = new Paths3D(point1, point2, point3);

            Console.WriteLine("Saved path to file: {0}", path);

            Storage.SavePathInFile("path.txt", path);   

        }
    }
}
