using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void Action1_12N_LMLMLMLMM()
        {
            RoverPosition position = new RoverPosition() //Creating new object from RoverPosition class for firdt action
            {
                //Assignment of first positions and direction of rover
                x = 1,
                y = 2,
                Direction = Directions.N
            };

            var limits = new List<int>() { 5, 5 }; //Assign maksimum values
            var moves = "LMLMLMLMM"; //input directions

            position.Action(limits, moves);

            var inputs = $"{position.x} {position.y} {position.Direction.ToString()}";
            var outputs = "1 3 N";

            Assert.AreEqual(inputs, outputs);
        }

        [TestMethod]
        public void Action2_33E_MRRMMRMRRM()  //Creating new object from RoverPosition class for second action
        {
            RoverPosition position = new RoverPosition()
            {
                //Assignment of first positions and direction of rover
                x = 3,
                y = 3,
                Direction = Directions.E
            };

            var limits = new List<int>() { 5, 5 }; //Assign maksimum values
            var moves = "MRRMMRMRRM"; //input directions

            position.Action(limits, moves);

            var inputs = $"{position.x} {position.y} {position.Direction.ToString()}";
            var outputs = "2 3 S";

            Assert.AreEqual(inputs, outputs);
        }
    }
}
