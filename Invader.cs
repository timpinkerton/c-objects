namespace TreehouseDefense

{
    // a template for creating invader objects
    class Invader
    {
        private readonly Path _path; 

        // field to initialze the _pathStep to 0
        private int _pathStep = 0; 

        // computed property
        public MapLocation Location => _path.GetLocationAt(_pathStep); 

        public int Health { get; private set; } = 2; 

        // below line reads, the invader has scored (true) if the _pathStep is gte the _path.Length
        public bool HasScored { get  { return _pathStep >= _path.Length; } }

        // if Health is lte 0, IsNuetralized returns true
        public bool IsNuetralized => Health <= 0; 

        public bool IsActive => !(IsNuetralized || HasScored);

        //constructor method
        public Invader(Path path)
        {
            _path = path; 
        }

        // Move method to advance tell the invader to move
        // when Move is called it will advance the invader one step down the path
        public void Move() => _pathStep += 1; 

        // to track the health of an invader
        
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }



    }
}