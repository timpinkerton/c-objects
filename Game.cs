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
                MapLocation maplocation = new MapLocation(9, 9, map);
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
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }

        }
    }
}