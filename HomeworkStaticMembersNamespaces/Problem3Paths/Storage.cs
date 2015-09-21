using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.IO;
using System.Text.RegularExpressions;
using Problem1Point3D;
using Problem3Paths;

static class Storage
{
    public static void SavePathInFile(string fileName, Paths3D path)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(path);
        }
    }

    public static Paths3D LoadPathFromFile(string fileName)
    {
        Paths3D path = new Paths3D();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string input = input = reader.ReadToEnd();
            string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

            Regex regex = new Regex(pattern);

            var matchs = regex.Matches(input);

            foreach (Match match in matchs)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);

                Point3D point = new Point3D(x, y, z);
                path.AddPoint(point);
            }

            return path;
        }
    }
}
