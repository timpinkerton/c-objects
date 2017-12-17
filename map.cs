namespace TreehouseDefense
{
    // a template for creating map objects
    class Map
    {
        // Width and Height are "instance" variables.  They exist as long as the object exists
        // readonly keyword prevents Width and Height from changing after they are created. 
        public readonly int Width;
        public readonly int Height; 
        // objects instantiated from the Map class can store width and height

        // a constructor method
        // user must provide parameters in order for the object to be constructed
        // width and height are "method level" variables. Only exist inside this method. 
        public Map(int width, int height)
        {
            // initializing the fields
            // "Width" in the class above equals "width" provided by the user
            Width = width;
            Height = height; 
        }

        // OnMap method
        // parameters is point of type Point
        // return value is of type bool (will return true of false)
        public bool OnMap(Point point)
        {
            // since it's using &&, if everything thing is true, it will return true
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y < Height;   
        }
    }
}