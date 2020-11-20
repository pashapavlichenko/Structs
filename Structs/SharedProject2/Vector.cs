using System;

namespace Structtt
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector3 = new Vector3(1, 1, 1);
            var vector33 = new Vector3(2, 2, 2);
            Console.WriteLine(vector3.GetLength());
        }
    }
}