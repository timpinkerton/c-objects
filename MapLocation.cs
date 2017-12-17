namespace TreehouseDefense
{
    //" : Point" makes MapLocation a subclass of the Point class
    class MapLocation : Point
    {
        // a constructor method of the MapLocation class.  It takes the same parameters as the constructor of the Point class
        // ": base" calls the Point class constructor
        // Map map gives the constructor an instance of the Map object
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            // "this" refers to the current object (the object that's being constructed)
            if (!map.OnMap(this))
            {
                // Create a new exception instance and "throw" it. 
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundaries of the map."); 
            }
        }
    }
}