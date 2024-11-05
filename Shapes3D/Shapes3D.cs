using System;

namespace Shapes3D
{
    public class Cuboid
    {
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }

        public Cuboid(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public double SurfaceArea => 2 * (Width * Height + Width * Depth + Height * Depth);
        public double Volume => Width * Height * Depth;
    }

    public class Cube : Cuboid
    {
        public Cube(double sideLength) : base(sideLength, sideLength, sideLength) { }
    }

    public class Cylinder
    {
        public double Radius { get; }
        public double Height { get; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double SurfaceArea => 2 * Math.PI * Radius * (Radius + Height);
        public double Volume => Math.PI * Radius * Radius * Height;
    }

    public class Sphere
    {
        public double Radius { get; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double SurfaceArea => 4 * Math.PI * Radius * Radius;
        public double Volume => (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
    }

    public class Prism
    {
        public double SideLength { get; }
        public int Faces { get; }
        public double Height { get; }

        public Prism(double sideLength, int faces, double height)
        {
            SideLength = sideLength;
            Faces = faces;
            Height = height;
        }

        public double SurfaceArea => Faces * SideLength * Height; // Simplified for demonstration
        public double Volume => (1.0 / 2.0) * Faces * SideLength * Height; // Simplified for demonstration
    }
}