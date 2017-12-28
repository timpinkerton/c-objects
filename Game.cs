using System; 

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            // this creates a new variable "map" that is of type Map and assigns it a new Map() object 
            Map map = new Map(8, 5); 

            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                    }
                ); 

                Invader[] invaders = 
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                };

                Tower[] towers = 
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map)),
                };

                Level level = new Level(invaders)
                {
                    Towers = towers 
                };            

                bool playerWon = level.Play(); 

                Console.WriteLine("Player " + (playerWon? "won" : "lost"));  

            }
            // declaring a variable for the exception "ex"
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }

        }
    }
}