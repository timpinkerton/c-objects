using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x; 
            Y = y;
        }

        // method for finding the distance between 2 points
        public int DistanceTo (int x, int y)
        {
            // int xDiff = X - x;
            // int yDiff = Y - y; 

            // int xDiffSquared = xDiff * xDiff;
            // int yDiffSquared = yDiff * yDiff; 

            // (int) will cast the results of Math.Sqrt to an integer, instead of double
            // return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            // the line below replaces the 6 lines above
            return (int)Math.Sqrt(Math.Pow((X - x), 2) + Math.Pow((Y - y), 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}