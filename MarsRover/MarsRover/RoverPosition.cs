using System;
using System.Collections.Generic;

namespace MarsRover
{
    public enum Directions
    {
        N = 1, S = 2, E = 3, W = 4 //direction enums
    }

    public interface IRoverPosition
    {
        void Move(List<int> limits, string moves); //Method of the interfaceclass with 2 parameters
    }

    public class RoverPosition : IRoverPosition
    {
        public int x { get; set; } // property definition with getter and setter functions for x coordinate
        public int y { get; set; } // property definition with getter and setter functions for y coordinate
        public Directions Direction { get; set; } // property definition with getter and setter functions for x directions

        public RoverPosition() // assignment of start position of the rover
        {
            x = y = 0;
            Direction = Directions.N;
        }

        private void SpinLeft() // 90 degrees left rotation method
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void SpinRight() // 90 degrees right rotation method
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void Move() // Movement in the sama direction method
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.y += 1;
                    break;
                case Directions.S:
                    this.y -= 1;
                    break;
                case Directions.E:
                    this.x += 1;
                    break;
                case Directions.W:
                    this.x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void Action(List<int> limits, string moves) // Using methods for start the action
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.Move();
                        break;
                    case 'L':
                        this.SpinLeft();
                        break;
                    case 'R':
                        this.SpinRight();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public void Move(List<int> limits, string moves)
        {
            throw new NotImplementedException();
        }
    }
}
