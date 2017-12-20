namespace TreehouseDefense

{
    // a template for creating path objects
    class Path
    {
        // underscore is common for private fields. 
        private readonly MapLocation[] _path;

        // constructor method
        public Path(MapLocation[] path)
        {
            _path = path;     
        }

        //a method that returns a map location
        public MapLocation GetLocationAt(int pathStep)
        {
            //Ternary if
            return (pathStep < _path.Length) ? _path[pathStep] : null;             
        }
    }
}