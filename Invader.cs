namespace TreehouseDefense

{
    // a template for creating invader objects
    class Invader
    {
        private readonly Path _path; 

        // field to initialze the _pathStep to 0
        private int _pathStep = 0; 

        // auto property automatically implements a getter and setter
        public MapLocation GetLocation{ get; private set; }

        //constructor method
        public Invader(Path path)
        {
            _path = path; 
            location = _path.GetLocation(_pathStep);
        }

        // Move method to advance tell the invader to move
        public void Move()
        {
            // when Move is called it will advance the invader one step down the path 
            _pathStep += 1; 
            location = _path.GetLocationAt(_pathStep);
        }

    }
}