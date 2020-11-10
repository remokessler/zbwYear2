using System;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var vector1 = new Vector(1, 2, 3);
            var vector2 = new Vector(4, 5, 6);

            var vector3 = vector1 + vector2;
            var vector4 = vector3 - vector1;
            var vector5 = vector3 * 2d;
            var vector6 = vector1 * vector2;

            var absolute = (double)vector1;

            var result1 = vector4 == vector1;
            var result2 = vector1 != vector2;

            Console.WriteLine(vector3.ToString());
            Console.WriteLine(vector4.ToString());
            Console.WriteLine(vector5.ToString());
            Console.WriteLine(vector6.ToString());
            Console.WriteLine(absolute);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
    public struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double this[int pos]
        {
            get
            {
                if (pos == 1) return X;
                if (pos == 2) return Y;
                if (pos == 3) return Z;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (pos == 1) X = value;
                if (pos == 2) Y = value;
                if (pos == 3) Z = value;
                throw new IndexOutOfRangeException();
            }
        }

        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector operator *(Vector v, double d) => new Vector(v.X * d, v.Y * d, v.Z * d);

        public static Vector operator *(Vector a, Vector b) => new Vector((a.Y * b.Z - a.Z * b.Y), (a.Z * b.X - a.X * b.Z), (a.X * b.Y - a.Y * b.X));

        public static bool operator ==(Vector a, Vector b) => a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        public static bool operator !=(Vector a, Vector b) => a.X != b.X || a.Y != b.Y || a.Z != b.Z;

        public static implicit operator double(Vector v) => Math.Sqrt(Math.Abs(Math.Pow(v.X, 2) * Math.Pow(v.Y, 2) * Math.Pow(v.Z, 2)));
        public static implicit operator Vector(double d) => new Vector(d, 0, 0);

        public override string ToString()
        {
            return 
                $@"/ {X} \" + Environment.NewLine +
                $@"| {Y} |" + Environment.NewLine +
                $@"\ {Z} /";
        }

        public override bool Equals(object obj)
        {
            return this == ((Vector)obj);
        }
    }
}
