using System;
using System.Collections.Generic;
using System.IO;
using Shapes3D;

namespace FinalAssignment
{
    public static class Solver
    {
        public static void ProcessFile(string filePath)
        {
            var shapes = new List<object>();
            string[] lines = File.ReadAllLines(filePath);
            double totalSum = 0;

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == "area" || parts[0] == "volume")
                {
                    int scale = int.Parse(parts[1]);
                    foreach (var shape in shapes)
                    {
                        if (shape is Cuboid cuboid)
                        {
                            totalSum += (parts[0] == "area" ? cuboid.SurfaceArea : cuboid.Volume) * scale;
                        }
                        else if (shape is Cube cube)
                        {
                            totalSum += (parts[0] == "area" ? cube.SurfaceArea : cube.Volume) * scale;
                        }
                        else if (shape is Cylinder cylinder)
                        {
                            totalSum += (parts[0] == "area" ? cylinder.SurfaceArea : cylinder.Volume) * scale;
                        }
                        else if (shape is Sphere sphere)
                        {
                            totalSum += (parts[0] == "area" ? sphere.SurfaceArea : sphere.Volume) * scale;
                        }
                        else if (shape is Prism prism)
                        {
                            totalSum += (parts[0] == "area" ? prism.SurfaceArea : prism.Volume) * scale;
                        }
                    }
                    shapes.Clear(); // Clear shapes after calculation
                }
                else
                {
                    switch (parts[0])
                    {
                        case "cube":
                            shapes.Add(new Cube(double.Parse(parts[1])));
                            break;
                        case "cuboid":
                            shapes.Add(new Cuboid(double.Parse(parts[1]), double.Parse(parts[2]), double.Parse(parts[3])));
                            break;
                        case "cylinder":
                            shapes.Add(new Cylinder(double.Parse(parts[1]), double.Parse(parts[2])));
                            break;
                        case "sphere":
                            shapes.Add(new Sphere(double.Parse(parts[1])));
                            break;
                        case "prism":
                            shapes.Add(new Prism(double.Parse(parts[1]), int.Parse(parts[2]), double.Parse(parts[3])));
                            break;
                    }
                }
            }

            // Print the total sum of measurements
            Console.WriteLine($"The sum of measurements is {totalSum:N2}.");
        }
    }
}