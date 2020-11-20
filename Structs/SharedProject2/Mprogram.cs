using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structtt
{
    public record Vector3;
    
        //Init variables
        public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    //Constructor
    public Vector3(double X, double Y, double Z) => (x, y, z) = (X, Y, Z);

    //Output in CW
    public override string ToString() => $"({x}, {y}, {z})";

    //Vectors3 Addition
    public static Vector3 operator +(Vector3 a, Vector3 b)
        => new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);

    //Vectors3 Subtraction
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    //Multiply vector3 by vector3
    public static Vector3 operator *(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
    }

    //Multiply vector3 by a number
    public static Vector3 operator *(Vector3 a, int k)
    {
        return new Vector3(a.x * k, a.y * k, a.z * k);
    }

    //Division vector3 by number
    public static Vector3 operator /(Vector3 a, int k)
    {
        return new Vector3(a.x / k, a.y / k, a.z / k);
    }

    //Vector3 normalization
    public Vector3 Normalize()
    {
        double q = Math.Sqrt(x * x + y * y + z * z);
        return new Vector3(x / q, y / q, z / q);
    }

    //Length of vector3
    public double GetLength()
    {
        double l = Math.Sqrt(x * x + y * y + z * z);
        return l;
    }
}
