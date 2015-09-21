using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1Point3D;

namespace Problem3Paths
{
    class Paths3D
    {
        private List<Point3D> points3D=new List<Point3D>();

        public Paths3D(params Point3D[] point3D)
        {
            if (point3D.Length>0)
            {
                this.points3D.AddRange(point3D);
            }

        }

        public void AddPoint(Point3D point3D)
        {
            this.points3D.Add(point3D);
        }
        public List<Point3D> Point3Ds
        {
            get { return this.points3D; }
        }

        public override string ToString()
        {
            return string.Join(", ", this.points3D);
        }
    }
}
