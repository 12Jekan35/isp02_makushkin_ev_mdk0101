using System;

namespace ConsoleApp1
{
    class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double VectorLength
        {
            get => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double ScalarProduct(Vector3D guestVector)
        {
            return ScalarProduct(guestVector.X, guestVector.Y, guestVector.Z);
        }

        public double ScalarProduct(double xGuest, double yGuest, double zGuest)
        {
            return X * xGuest + Y * yGuest + Z * zGuest;
        }

        public Vector3D VectorProduct(Vector3D guestVector)
        {
            return VectorProduct(guestVector.X, guestVector.Y, guestVector.Z);
        }

        public Vector3D VectorProduct(double xGuest, double yGuest, double zGuest)
        {
            Vector3D result = new Vector3D();
            result.X = Y * zGuest - Z - yGuest;
            result.Y = Z * xGuest - X * zGuest;
            result.Z = X * yGuest - Y * xGuest;
            return result;
        }

        public override string ToString()
        {
            return $"vec (x: {X}; y: {Y}; z: {Z})";
        }

        public Vector3D(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
