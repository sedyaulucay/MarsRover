using System;
using System.Linq;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            var limits = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList(); //Getting maksimum values from user
            var firstPositions = Console.ReadLine().Trim().Split(' '); //Getting first values (input positions) from user
            RoverPosition position = new RoverPosition();

            if (firstPositions.Count() == 3)
            {
                position.x = Convert.ToInt32(firstPositions[0]); // assign first value to x 
                position.y = Convert.ToInt32(firstPositions[1]); // assign second value to y 
                position.Direction = (Directions)Enum.Parse(typeof(Directions), firstPositions[2]); // assign third value as position (get from enum from Directions class)
            }

            var moves = Console.ReadLine().ToUpper(); // use the user value as upper case with ToUpper function

            try
            {
                position.Action(limits, moves);
                Console.WriteLine($"{position.x} {position.y} {position.Direction.ToString()}"); // Write values to console according to action method
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
