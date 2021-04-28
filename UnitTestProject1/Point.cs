using System;

namespace UnitTestProject1
{
    public class Point
    {
        public int x;
        public int y;

        protected bool Equals(Point other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x * 397) ^ y;
            }
        }

        public static bool operator ==(Point left, Point right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !Equals(left, right);
        }

        public string GetGridHash()
        {
            return $"x: {Math.Floor((double)x / 10)}, y: {Math.Floor((double)y / 10)}";
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}