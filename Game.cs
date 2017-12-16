using System; 

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            // this creates a new variable "map" that is of type Map and assigns it a new Map() object 
            Map map = new Map(8, 5); 

            // this creates a new point 
            Point point = new Point(4, 2);

            Console.WriteLine(point.DistanceTo(5, 5)); 
        }
    }
}